using System.Collections.Concurrent;
using System.Net.WebSockets;
using System.Text;
using System.Text.Json;
using CloudNimble.ChromeEssentials.Protocol;

namespace CloudNimble.ChromeEssentials;

/// <summary>
/// A lightweight, AOT-compatible Chrome DevTools Protocol (CDP) WebSocket client.
/// Provides methods to send CDP commands, subscribe to events, and manage the WebSocket lifecycle.
/// Uses source-generated JSON serialization for full Native AOT compatibility.
/// </summary>
/// <remarks>
/// Usage:
/// <code>
/// using var client = new CdpClient();
/// await client.ConnectAsync("ws://127.0.0.1:9222/devtools/browser/...");
/// var result = await client.SendAsync("Page.navigate", params);
/// </code>
/// </remarks>
public sealed class CdpClient : IDisposable
{
    /// <summary>
    /// The default timeout in milliseconds for CDP commands and event waits.
    /// </summary>
    private const int DefaultTimeout = 15_000;

    private ClientWebSocket? _ws;
    private int _nextId;
    private readonly ConcurrentDictionary<int, TaskCompletionSource<JsonElement>> _pending = new();
    private readonly ConcurrentDictionary<string, List<Action<JsonElement>>> _eventHandlers = new();
    private readonly ConcurrentDictionary<string, List<Action<JsonElement>>> _sessionEventHandlers = new();
    private readonly List<Action> _closeHandlers = [];
    private CancellationTokenSource _cts = new();
    private Task? _receiveLoop;
    private bool _disposed;

    /// <summary>
    /// Connects to a Chrome DevTools Protocol WebSocket endpoint and starts the receive loop.
    /// </summary>
    /// <param name="wsUrl">
    /// The WebSocket URL to connect to, typically obtained from <see cref="BrowserDiscovery.GetWsUrl"/>
    /// or from the browser's <c>/json/version</c> HTTP endpoint.
    /// </param>
    /// <exception cref="WebSocketException">Thrown when the connection cannot be established.</exception>
    public async Task ConnectAsync(string wsUrl)
    {
        _ws = new ClientWebSocket();
        _cts = new CancellationTokenSource();
        await _ws.ConnectAsync(new Uri(wsUrl), CancellationToken.None);
        _receiveLoop = Task.Run(ReceiveLoopAsync);
    }

    /// <summary>
    /// Background loop that reads messages from the WebSocket and dispatches them
    /// to pending command responses or event handlers.
    /// </summary>
    private async Task ReceiveLoopAsync()
    {
        var buffer = new byte[1024 * 256];
        var sb = new StringBuilder();

        try
        {
            while (_ws?.State == WebSocketState.Open && !_cts.IsCancellationRequested)
            {
                WebSocketReceiveResult result;
                sb.Clear();
                do
                {
                    result = await _ws.ReceiveAsync(buffer, _cts.Token);
                    sb.Append(Encoding.UTF8.GetString(buffer, 0, result.Count));
                } while (!result.EndOfMessage);

                if (result.MessageType == WebSocketMessageType.Close)
                    break;

                var msg = JsonSerializer.Deserialize(sb.ToString(), ChromeEssentialsJsonContext.Default.CdpResponse);
                if (msg is null) continue;

                if (msg.Id > 0 && _pending.TryRemove(msg.Id, out var tcs))
                {
                    if (msg.Error is not null)
                        tcs.TrySetException(new CdpException(msg.Error.Message));
                    else
                        tcs.TrySetResult(msg.Result);
                }
                else if (msg.Method is not null)
                {
                    // Dispatch to session-scoped handlers first
                    if (msg.SessionId is not null)
                    {
                        var sessionKey = $"{msg.SessionId}:{msg.Method}";
                        if (_sessionEventHandlers.TryGetValue(sessionKey, out var sessionHandlers))
                        {
                            List<Action<JsonElement>> snapshot;
                            lock (sessionHandlers) { snapshot = [.. sessionHandlers]; }
                            foreach (var h in snapshot)
                                h(msg.Params);
                        }
                    }

                    // Always dispatch to global handlers (regardless of session)
                    if (_eventHandlers.TryGetValue(msg.Method, out var handlers))
                    {
                        List<Action<JsonElement>> snapshot;
                        lock (handlers) { snapshot = [.. handlers]; }
                        foreach (var h in snapshot)
                            h(msg.Params);
                    }
                }
            }
        }
        catch (OperationCanceledException) { }
        catch (WebSocketException) { }
        finally
        {
            foreach (var h in _closeHandlers)
                h();

            foreach (var kvp in _pending)
                kvp.Value.TrySetCanceled();
            _pending.Clear();
        }
    }

    /// <summary>
    /// Sends a CDP command and waits for the response.
    /// </summary>
    /// <param name="method">The CDP method name (e.g., <c>"Page.navigate"</c>, <c>"Runtime.evaluate"</c>).</param>
    /// <param name="parameters">Optional JSON parameters for the command. Pass <c>null</c> for commands that take no parameters.</param>
    /// <param name="sessionId">Optional session ID for target-scoped commands. Required when communicating with a specific tab or target.</param>
    /// <param name="timeout">Optional timeout in milliseconds. Defaults to 15,000ms. Use longer timeouts for operations like <c>Page.printToPDF</c>.</param>
    /// <param name="cancellationToken">Optional cancellation token to cancel the operation.</param>
    /// <returns>The result of the CDP command as a <see cref="JsonElement"/>.</returns>
    /// <exception cref="CdpException">Thrown when the WebSocket is not connected, the command returns an error, or the command times out.</exception>
    /// <exception cref="OperationCanceledException">Thrown when the <paramref name="cancellationToken"/> is cancelled.</exception>
    public async Task<JsonElement> SendAsync(
        string method,
        JsonElement? parameters = null,
        string? sessionId = null,
        int timeout = DefaultTimeout,
        CancellationToken cancellationToken = default)
    {
        if (_ws is null || _ws.State != WebSocketState.Open)
            throw new CdpException("WebSocket not connected");

        var id = Interlocked.Increment(ref _nextId);
        var request = new CdpRequest
        {
            Id = id,
            Method = method,
            Params = parameters,
            SessionId = sessionId,
        };

        var tcs = new TaskCompletionSource<JsonElement>(TaskCreationOptions.RunContinuationsAsynchronously);
        _pending[id] = tcs;

        var json = JsonSerializer.Serialize(request, ChromeEssentialsJsonContext.Default.CdpRequest);
        var bytes = Encoding.UTF8.GetBytes(json);
        await _ws.SendAsync(bytes, WebSocketMessageType.Text, true, cancellationToken);

        using var timeoutCts = new CancellationTokenSource(timeout);
        using var linkedCts = CancellationTokenSource.CreateLinkedTokenSource(timeoutCts.Token, cancellationToken);
        linkedCts.Token.Register(() =>
        {
            if (_pending.TryRemove(id, out var t))
            {
                if (cancellationToken.IsCancellationRequested)
                    t.TrySetCanceled(cancellationToken);
                else
                    t.TrySetException(new CdpException($"Timeout: {method}"));
            }
        });

        return await tcs.Task;
    }

    /// <summary>
    /// Registers a handler for a CDP event. The handler will be called each time the specified event is received,
    /// regardless of which session the event originates from.
    /// </summary>
    /// <param name="method">The CDP event name (e.g., <c>"Page.loadEventFired"</c>, <c>"Network.responseReceived"</c>).</param>
    /// <param name="handler">The callback to invoke when the event is received. The <see cref="JsonElement"/> contains the event parameters.</param>
    /// <returns>An <see cref="Action"/> that, when called, unregisters the handler.</returns>
    public Action OnEvent(string method, Action<JsonElement> handler)
    {
        var handlers = _eventHandlers.GetOrAdd(method, _ => []);
        lock (handlers) { handlers.Add(handler); }
        return () =>
        {
            lock (handlers) { handlers.Remove(handler); }
        };
    }

    /// <summary>
    /// Registers a handler for a CDP event scoped to a specific session.
    /// Only events from the specified session will trigger this handler.
    /// </summary>
    /// <param name="sessionId">The session ID to filter events for.</param>
    /// <param name="method">The CDP event name (e.g., <c>"Page.loadEventFired"</c>).</param>
    /// <param name="handler">The callback to invoke when the event is received from the specified session.</param>
    /// <returns>An <see cref="Action"/> that, when called, unregisters the handler.</returns>
    public Action OnSessionEvent(string sessionId, string method, Action<JsonElement> handler)
    {
        var key = $"{sessionId}:{method}";
        var handlers = _sessionEventHandlers.GetOrAdd(key, _ => []);
        lock (handlers) { handlers.Add(handler); }
        return () =>
        {
            lock (handlers) { handlers.Remove(handler); }
        };
    }

    /// <summary>
    /// Waits for a single occurrence of a CDP event, returning a task that completes when the event fires.
    /// </summary>
    /// <param name="method">The CDP event name to wait for (e.g., <c>"Page.loadEventFired"</c>).</param>
    /// <param name="timeout">The timeout in milliseconds. Defaults to <see cref="DefaultTimeout"/>.</param>
    /// <returns>
    /// A tuple containing:
    /// <list type="bullet">
    /// <item><description><c>Promise</c> — a <see cref="Task{JsonElement}"/> that resolves with the event parameters.</description></item>
    /// <item><description><c>Cancel</c> — an <see cref="Action"/> to cancel the wait.</description></item>
    /// </list>
    /// </returns>
    /// <exception cref="CdpException">Thrown if the event does not fire within the timeout period.</exception>
    public (Task<JsonElement> Promise, Action Cancel) WaitForEvent(string method, int timeout = DefaultTimeout)
    {
        var tcs = new TaskCompletionSource<JsonElement>(TaskCreationOptions.RunContinuationsAsynchronously);
        var settled = 0;
        Action? off = null;
        Timer? timer = null;

        off = OnEvent(method, p =>
        {
            if (Interlocked.CompareExchange(ref settled, 1, 0) != 0) return;
            timer?.Dispose();
            off?.Invoke();
            tcs.TrySetResult(p);
        });

        timer = new Timer(_ =>
        {
            if (Interlocked.CompareExchange(ref settled, 1, 0) != 0) return;
            off?.Invoke();
            tcs.TrySetException(new CdpException($"Timeout waiting for event: {method}"));
        }, null, timeout, Timeout.Infinite);

        void Cancel()
        {
            if (Interlocked.CompareExchange(ref settled, 1, 0) != 0) return;
            timer?.Dispose();
            off?.Invoke();
            tcs.TrySetCanceled();
        }

        return (tcs.Task, Cancel);
    }

    /// <summary>
    /// Waits for a single occurrence of a CDP event scoped to a specific session.
    /// </summary>
    /// <param name="sessionId">The session ID to filter events for.</param>
    /// <param name="method">The CDP event name to wait for.</param>
    /// <param name="timeout">The timeout in milliseconds. Defaults to <see cref="DefaultTimeout"/>.</param>
    /// <returns>
    /// A tuple containing:
    /// <list type="bullet">
    /// <item><description><c>Promise</c> — a <see cref="Task{JsonElement}"/> that resolves with the event parameters.</description></item>
    /// <item><description><c>Cancel</c> — an <see cref="Action"/> to cancel the wait.</description></item>
    /// </list>
    /// </returns>
    /// <exception cref="CdpException">Thrown if the event does not fire within the timeout period.</exception>
    public (Task<JsonElement> Promise, Action Cancel) WaitForSessionEvent(string sessionId, string method, int timeout = DefaultTimeout)
    {
        var tcs = new TaskCompletionSource<JsonElement>(TaskCreationOptions.RunContinuationsAsynchronously);
        var settled = 0;
        Action? off = null;
        Timer? timer = null;

        off = OnSessionEvent(sessionId, method, p =>
        {
            if (Interlocked.CompareExchange(ref settled, 1, 0) != 0) return;
            timer?.Dispose();
            off?.Invoke();
            tcs.TrySetResult(p);
        });

        timer = new Timer(_ =>
        {
            if (Interlocked.CompareExchange(ref settled, 1, 0) != 0) return;
            off?.Invoke();
            tcs.TrySetException(new CdpException($"Timeout waiting for event: {method}"));
        }, null, timeout, Timeout.Infinite);

        void Cancel()
        {
            if (Interlocked.CompareExchange(ref settled, 1, 0) != 0) return;
            timer?.Dispose();
            off?.Invoke();
            tcs.TrySetCanceled();
        }

        return (tcs.Task, Cancel);
    }

    /// <summary>
    /// Registers a handler to be called when the WebSocket connection closes, either normally or due to an error.
    /// </summary>
    /// <param name="handler">The callback to invoke on connection close.</param>
    public void OnClose(Action handler) => _closeHandlers.Add(handler);

    /// <summary>
    /// Asynchronously closes the WebSocket connection, sending a normal closure frame to the browser.
    /// </summary>
    /// <param name="cancellationToken">Optional cancellation token.</param>
    public async Task CloseAsync(CancellationToken cancellationToken = default)
    {
        if (_disposed) return;
        _cts.Cancel();
        if (_ws is not null)
        {
            try
            {
                using var closeCts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
                closeCts.CancelAfter(2000);
                await _ws.CloseAsync(WebSocketCloseStatus.NormalClosure, "", closeCts.Token);
            }
            catch { }
            _ws.Dispose();
        }
    }

    /// <summary>
    /// Closes the WebSocket connection gracefully, sending a normal closure frame to the browser.
    /// </summary>
    public void Close()
    {
        if (_disposed) return;
        _cts.Cancel();
        try { _ws?.CloseAsync(WebSocketCloseStatus.NormalClosure, "", CancellationToken.None).Wait(2000); } catch { }
        _ws?.Dispose();
    }

    /// <summary>
    /// Disposes of the client, closing the WebSocket connection and releasing all resources.
    /// </summary>
    public void Dispose()
    {
        if (_disposed) return;
        _disposed = true;
        Close();
        _cts.Dispose();
    }
}

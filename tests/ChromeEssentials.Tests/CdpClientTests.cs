namespace CloudNimble.ChromeEssentials.Tests;

/// <summary>
/// Unit tests for the <see cref="CdpClient"/> class.
/// These tests verify client behavior without requiring a live browser connection.
/// </summary>
[TestClass]
public sealed class CdpClientTests
{
    /// <summary>
    /// Verifies that SendAsync throws when the client is not connected.
    /// </summary>
    [TestMethod]
    public async Task SendAsync_ThrowsCdpException_WhenNotConnected()
    {
        using var client = new CdpClient();
        var ex = await Assert.ThrowsExactlyAsync<CdpException>(
            () => client.SendAsync("Page.navigate"));
        Assert.AreEqual("WebSocket not connected", ex.Message);
    }

    /// <summary>
    /// Verifies that OnEvent returns an unsubscribe action that works correctly.
    /// </summary>
    [TestMethod]
    public void OnEvent_ReturnsUnsubscribeAction()
    {
        using var client = new CdpClient();
        var callCount = 0;
        var unsub = client.OnEvent("Test.event", _ => callCount++);

        Assert.IsNotNull(unsub);
        // Calling unsub should not throw
        unsub();
    }

    /// <summary>
    /// Verifies that WaitForEvent returns a cancellable task.
    /// </summary>
    [TestMethod]
    public async Task WaitForEvent_Cancel_CancelsTask()
    {
        using var client = new CdpClient();
        var (promise, cancel) = client.WaitForEvent("Test.event", timeout: 60_000);

        cancel();

        await Assert.ThrowsExactlyAsync<TaskCanceledException>(() => promise);
    }

    /// <summary>
    /// Verifies that Dispose can be called multiple times without error.
    /// </summary>
    [TestMethod]
    public void Dispose_CanBeCalledMultipleTimes()
    {
        var client = new CdpClient();
        client.Dispose();
        client.Dispose(); // Should not throw
    }

    /// <summary>
    /// Verifies that OnClose registers a handler without error.
    /// </summary>
    [TestMethod]
    public void OnClose_RegistersHandler_WithoutError()
    {
        using var client = new CdpClient();
        client.OnClose(() => { });
    }

    /// <summary>
    /// Verifies that ConnectAsync throws for an invalid WebSocket URL.
    /// </summary>
    [TestMethod]
    public async Task ConnectAsync_ThrowsForInvalidUrl()
    {
        using var client = new CdpClient();
        await Assert.ThrowsExactlyAsync<UriFormatException>(
            () => client.ConnectAsync("not-a-valid-url"));
    }
}

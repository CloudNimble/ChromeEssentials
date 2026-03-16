using System.Text.Json;
using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Represents a CDP WebSocket response envelope received from the browser.
/// May contain either a command result (matching a request <see cref="Id"/>)
/// or an event notification (with a <see cref="Method"/> name).
/// </summary>
public sealed class CdpResponse
{
    /// <summary>
    /// Gets or sets the request identifier this response corresponds to. Zero for event notifications.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the result of the CDP command as a raw <see cref="JsonElement"/>.
    /// </summary>
    [JsonPropertyName("result")]
    public JsonElement Result { get; set; }

    /// <summary>
    /// Gets or sets the error information if the CDP command failed, or <c>null</c> on success.
    /// </summary>
    [JsonPropertyName("error")]
    public CdpError? Error { get; set; }

    /// <summary>
    /// Gets or sets the event method name (e.g., <c>"Page.loadEventFired"</c>). Null for command responses.
    /// </summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>
    /// Gets or sets the event parameters as a raw <see cref="JsonElement"/>.
    /// </summary>
    [JsonPropertyName("params")]
    public JsonElement Params { get; set; }

    /// <summary>
    /// Gets or sets the session ID for session-scoped events and responses in flattened mode.
    /// When using <c>Target.attachToTarget</c> with <c>flatten: true</c>, events from specific
    /// targets include this field to identify which session they belong to.
    /// </summary>
    [JsonPropertyName("sessionId")]
    public string? SessionId { get; set; }
}

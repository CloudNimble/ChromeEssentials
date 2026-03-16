using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Parameters for the <c>Target.detachedFromTarget</c> CDP event.
/// Emitted when the debugger is detached from a target.
/// </summary>
public sealed class DetachedParams
{
    /// <summary>
    /// Gets or sets the session ID of the detached session.
    /// </summary>
    [JsonPropertyName("sessionId")]
    public string SessionId { get; set; } = "";
}

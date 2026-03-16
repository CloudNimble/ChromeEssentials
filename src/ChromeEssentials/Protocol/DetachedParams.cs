using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Parameters for the <c>Target.detachedFromTarget</c> CDP event.
/// Issued when detached from target for any reason (including <c>detachFromTarget</c> command).
/// </summary>
public sealed class DetachedParams
{
    /// <summary>
    /// Gets or sets the detached session identifier.
    /// </summary>
    [JsonPropertyName("sessionId")]
    public string SessionId { get; set; } = "";
}

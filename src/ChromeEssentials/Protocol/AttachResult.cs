using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Represents the result of the <c>Target.attachToTarget</c> CDP command.
/// </summary>
public sealed class AttachResult
{
    /// <summary>
    /// Gets or sets the session ID for the attached target, used for sending subsequent commands to this target.
    /// </summary>
    [JsonPropertyName("sessionId")]
    public string SessionId { get; set; } = "";
}

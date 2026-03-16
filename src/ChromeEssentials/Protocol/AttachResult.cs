using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Represents the result of the <c>Target.attachToTarget</c> CDP command.
/// Attaches to the target with given id.
/// </summary>
public sealed class AttachResult
{
    /// <summary>
    /// Gets or sets the id assigned to the session.
    /// </summary>
    [JsonPropertyName("sessionId")]
    public string SessionId { get; set; } = "";
}

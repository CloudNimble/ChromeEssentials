using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Parameters for the <c>Target.attachToTarget</c> CDP command.
/// Attaches to the target with given id.
/// </summary>
public sealed class AttachParams
{
    /// <summary>
    /// Gets or sets the target ID to attach to.
    /// </summary>
    [JsonPropertyName("targetId")]
    public string TargetId { get; set; } = "";

    /// <summary>
    /// Gets or sets a value indicating whether to enable "flat" access to the session via specifying sessionId attribute in the commands.
    /// </summary>
    [JsonPropertyName("flatten")]
    public bool Flatten { get; set; }
}

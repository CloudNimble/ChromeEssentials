using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Represents the result of the <c>Target.createTarget</c> CDP command.
/// </summary>
public sealed class CreateTargetResult
{
    /// <summary>
    /// Gets or sets the target ID of the newly created target.
    /// </summary>
    [JsonPropertyName("targetId")]
    public string TargetId { get; set; } = "";
}

using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Parameters for the <c>Target.targetDestroyed</c> CDP event.
/// Emitted when a target is destroyed (e.g., a tab is closed).
/// </summary>
public sealed class TargetDestroyedParams
{
    /// <summary>
    /// Gets or sets the target ID of the destroyed target.
    /// </summary>
    [JsonPropertyName("targetId")]
    public string TargetId { get; set; } = "";
}

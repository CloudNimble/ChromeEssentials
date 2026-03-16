using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Parameters for the <c>Target.targetDestroyed</c> CDP event.
/// Issued when a target is destroyed.
/// </summary>
public sealed class TargetDestroyedParams
{
    /// <summary>
    /// Gets or sets the target ID of the destroyed target.
    /// </summary>
    [JsonPropertyName("targetId")]
    public string TargetId { get; set; } = "";
}

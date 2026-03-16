using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Represents the result of the <c>Target.getTargets</c> CDP command.
/// Contains an array of all available browser targets.
/// </summary>
public sealed class GetTargetsResult
{
    /// <summary>
    /// Gets or sets the array of target information objects.
    /// </summary>
    [JsonPropertyName("targetInfos")]
    public TargetInfo[] TargetInfos { get; set; } = [];
}

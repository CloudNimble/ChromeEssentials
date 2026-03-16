using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Represents a media feature for emulation.
/// </summary>
public sealed class MediaFeature
{
    /// <summary>
    /// Gets or sets the media feature name.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = "";

    /// <summary>
    /// Gets or sets the media feature value.
    /// </summary>
    [JsonPropertyName("value")]
    public string Value { get; set; } = "";
}

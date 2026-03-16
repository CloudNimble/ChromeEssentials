using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Represents a CSS media feature override for emulation (e.g., <c>prefers-color-scheme: dark</c>).
/// </summary>
public sealed class MediaFeature
{
    /// <summary>
    /// Gets or sets the media feature name (e.g., <c>"prefers-color-scheme"</c>, <c>"prefers-reduced-motion"</c>).
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = "";

    /// <summary>
    /// Gets or sets the media feature value (e.g., <c>"dark"</c>, <c>"light"</c>, <c>"reduce"</c>).
    /// </summary>
    [JsonPropertyName("value")]
    public string Value { get; set; } = "";
}

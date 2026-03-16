using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Parameters for the <c>Emulation.setEmulatedMedia</c> CDP command.
/// Emulates the given media type or media feature for CSS media queries.
/// </summary>
public sealed class SetEmulatedMediaParams
{
    /// <summary>
    /// Gets or sets the media type to emulate. Empty string disables the override.
    /// </summary>
    [JsonPropertyName("media")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Media { get; set; }

    /// <summary>
    /// Gets or sets the media features to emulate.
    /// </summary>
    [JsonPropertyName("features")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public MediaFeature[]? Features { get; set; }
}

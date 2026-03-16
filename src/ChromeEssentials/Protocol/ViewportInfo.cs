using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Represents VisualViewport information returned by layout metrics.
/// </summary>
public sealed class ViewportInfo
{
    /// <summary>
    /// Gets or sets the width (CSS pixels), excludes scrollbar if present.
    /// </summary>
    [JsonPropertyName("clientWidth")]
    public double ClientWidth { get; set; }

    /// <summary>
    /// Gets or sets the height (CSS pixels), excludes scrollbar if present.
    /// </summary>
    [JsonPropertyName("clientHeight")]
    public double ClientHeight { get; set; }

    /// <summary>
    /// Gets or sets the horizontal offset relative to the document (CSS pixels).
    /// </summary>
    [JsonPropertyName("pageX")]
    public double PageX { get; set; }

    /// <summary>
    /// Gets or sets the vertical offset relative to the document (CSS pixels).
    /// </summary>
    [JsonPropertyName("pageY")]
    public double PageY { get; set; }

    /// <summary>
    /// Gets or sets the scale relative to the ideal viewport (size at width=device-width).
    /// </summary>
    [JsonPropertyName("scale")]
    public double Scale { get; set; }
}

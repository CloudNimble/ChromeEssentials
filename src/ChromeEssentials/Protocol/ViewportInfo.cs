using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Represents viewport dimension information returned by layout metrics.
/// </summary>
public sealed class ViewportInfo
{
    /// <summary>
    /// Gets or sets the width of the viewport's client area in CSS pixels.
    /// </summary>
    [JsonPropertyName("clientWidth")]
    public double ClientWidth { get; set; }

    /// <summary>
    /// Gets or sets the height of the viewport's client area in CSS pixels.
    /// </summary>
    [JsonPropertyName("clientHeight")]
    public double ClientHeight { get; set; }

    /// <summary>
    /// Gets or sets the horizontal scroll offset in CSS pixels.
    /// </summary>
    [JsonPropertyName("pageX")]
    public double PageX { get; set; }

    /// <summary>
    /// Gets or sets the vertical scroll offset in CSS pixels.
    /// </summary>
    [JsonPropertyName("pageY")]
    public double PageY { get; set; }

    /// <summary>
    /// Gets or sets the page scale factor.
    /// </summary>
    [JsonPropertyName("scale")]
    public double Scale { get; set; }
}

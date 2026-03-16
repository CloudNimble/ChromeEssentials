using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Represents the result of the <c>Page.getLayoutMetrics</c> CDP command.
/// Returns metrics relating to the layouting of the page, such as viewport bounds/scale.
/// </summary>
public sealed class LayoutMetrics
{
    /// <summary>
    /// Gets or sets the deprecated metrics relating to the visual viewport.
    /// </summary>
    [JsonPropertyName("visualViewport")]
    public ViewportInfo? VisualViewport { get; set; }

    /// <summary>
    /// Gets or sets the metrics relating to the visual viewport in CSS pixels.
    /// </summary>
    [JsonPropertyName("cssVisualViewport")]
    public ViewportInfo? CssVisualViewport { get; set; }
}

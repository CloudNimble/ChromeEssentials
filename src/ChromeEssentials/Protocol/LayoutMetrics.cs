using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Represents the result of the <c>Page.getLayoutMetrics</c> CDP command.
/// Provides information about the page's layout viewport dimensions.
/// </summary>
public sealed class LayoutMetrics
{
    /// <summary>
    /// Gets or sets the visual viewport metrics.
    /// </summary>
    [JsonPropertyName("visualViewport")]
    public ViewportInfo? VisualViewport { get; set; }

    /// <summary>
    /// Gets or sets the CSS visual viewport metrics.
    /// </summary>
    [JsonPropertyName("cssVisualViewport")]
    public ViewportInfo? CssVisualViewport { get; set; }
}

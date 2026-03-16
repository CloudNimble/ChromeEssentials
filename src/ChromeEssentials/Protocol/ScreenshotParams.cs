using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Parameters for the <c>Page.captureScreenshot</c> CDP command.
/// </summary>
public sealed class ScreenshotParams
{
    /// <summary>
    /// Gets or sets the image format for the screenshot. Supported values: <c>"png"</c>, <c>"jpeg"</c>, <c>"webp"</c>.
    /// Defaults to <c>"png"</c>.
    /// </summary>
    [JsonPropertyName("format")]
    public string Format { get; set; } = "png";

    /// <summary>
    /// Gets or sets the compression quality (0-100) for JPEG and WebP formats. Not applicable for PNG.
    /// </summary>
    [JsonPropertyName("quality")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? Quality { get; set; }

    /// <summary>
    /// Gets or sets the clip region for capturing a specific area of the page.
    /// If not specified, the entire visible viewport is captured.
    /// </summary>
    [JsonPropertyName("clip")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public ViewportClip? Clip { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to capture the screenshot from the surface rather than the view.
    /// Defaults to <c>true</c>.
    /// </summary>
    [JsonPropertyName("fromSurface")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? FromSurface { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to capture the full page, beyond the visible viewport.
    /// </summary>
    [JsonPropertyName("captureBeyondViewport")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? CaptureBeyondViewport { get; set; }
}

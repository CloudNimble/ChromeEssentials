using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Parameters for the <c>Page.captureScreenshot</c> CDP command.
/// Capture page screenshot.
/// </summary>
public sealed class ScreenshotParams
{
    /// <summary>
    /// Gets or sets the image compression format (defaults to png).
    /// </summary>
    [JsonPropertyName("format")]
    public string Format { get; set; } = "png";

    /// <summary>
    /// Gets or sets the compression quality from range [0..100] (jpeg only).
    /// </summary>
    [JsonPropertyName("quality")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? Quality { get; set; }

    /// <summary>
    /// Gets or sets the capture the screenshot of a given region only.
    /// </summary>
    [JsonPropertyName("clip")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public ViewportClip? Clip { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to capture the screenshot from the surface, rather than the view.
    /// </summary>
    [JsonPropertyName("fromSurface")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? FromSurface { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to capture the screenshot beyond the viewport.
    /// </summary>
    [JsonPropertyName("captureBeyondViewport")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? CaptureBeyondViewport { get; set; }
}

using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Represents a rectangular clip region for screenshot capture, defining the area of the page to capture.
/// </summary>
public sealed class ViewportClip
{
    /// <summary>
    /// Gets or sets the X offset in device independent pixels (dip).
    /// </summary>
    [JsonPropertyName("x")]
    public double X { get; set; }

    /// <summary>
    /// Gets or sets the Y offset in device independent pixels (dip).
    /// </summary>
    [JsonPropertyName("y")]
    public double Y { get; set; }

    /// <summary>
    /// Gets or sets the clip width in device independent pixels (dip).
    /// </summary>
    [JsonPropertyName("width")]
    public double Width { get; set; }

    /// <summary>
    /// Gets or sets the clip height in device independent pixels (dip).
    /// </summary>
    [JsonPropertyName("height")]
    public double Height { get; set; }

    /// <summary>
    /// Gets or sets the page scale factor. Defaults to 1.
    /// </summary>
    [JsonPropertyName("scale")]
    public double Scale { get; set; } = 1;
}

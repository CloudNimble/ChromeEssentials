using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Represents the result of the <c>Page.captureScreenshot</c> CDP command.
/// Capture page screenshot.
/// </summary>
public sealed class CaptureScreenshotResult
{
    /// <summary>
    /// Gets or sets the Base64-encoded image data.
    /// </summary>
    [JsonPropertyName("data")]
    public string Data { get; set; } = "";
}

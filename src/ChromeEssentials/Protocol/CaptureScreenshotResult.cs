using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Represents the result of the <c>Page.captureScreenshot</c> CDP command.
/// </summary>
public sealed class CaptureScreenshotResult
{
    /// <summary>
    /// Gets or sets the Base64-encoded image data of the captured screenshot.
    /// </summary>
    [JsonPropertyName("data")]
    public string Data { get; set; } = "";
}

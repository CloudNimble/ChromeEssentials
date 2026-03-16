using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Represents the result of the <c>Page.navigate</c> CDP command.
/// </summary>
public sealed class NavigateResult
{
    /// <summary>
    /// Gets or sets the frame ID of the navigated frame.
    /// </summary>
    [JsonPropertyName("frameId")]
    public string? FrameId { get; set; }

    /// <summary>
    /// Gets or sets the error text if navigation failed, or <c>null</c> on success.
    /// </summary>
    [JsonPropertyName("errorText")]
    public string? ErrorText { get; set; }

    /// <summary>
    /// Gets or sets the loader identifier for the navigation.
    /// </summary>
    [JsonPropertyName("loaderId")]
    public string? LoaderId { get; set; }
}

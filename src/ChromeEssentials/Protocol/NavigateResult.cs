using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Represents the result of the <c>Page.navigate</c> CDP command.
/// </summary>
public sealed class NavigateResult
{
    /// <summary>
    /// Gets or sets the frame id that has navigated (or failed to navigate).
    /// </summary>
    [JsonPropertyName("frameId")]
    public string? FrameId { get; set; }

    /// <summary>
    /// Gets or sets the user friendly error message, present if and only if navigation has failed.
    /// </summary>
    [JsonPropertyName("errorText")]
    public string? ErrorText { get; set; }

    /// <summary>
    /// Gets or sets the loader identifier.
    /// </summary>
    [JsonPropertyName("loaderId")]
    public string? LoaderId { get; set; }
}

using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Parameters for the <c>Page.navigate</c> CDP command.
/// Navigates current page to the given URL.
/// </summary>
public sealed class NavigateParams
{
    /// <summary>
    /// Gets or sets the URL to navigate the page to.
    /// </summary>
    [JsonPropertyName("url")]
    public string Url { get; set; } = "";

    /// <summary>
    /// Gets or sets the referrer URL.
    /// </summary>
    [JsonPropertyName("referrer")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Referrer { get; set; }

    /// <summary>
    /// Gets or sets the frame id to navigate, if not specified navigates the top frame.
    /// </summary>
    [JsonPropertyName("frameId")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FrameId { get; set; }
}

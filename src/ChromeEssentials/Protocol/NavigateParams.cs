using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Parameters for the <c>Page.navigate</c> CDP command.
/// </summary>
public sealed class NavigateParams
{
    /// <summary>
    /// Gets or sets the URL to navigate to.
    /// </summary>
    [JsonPropertyName("url")]
    public string Url { get; set; } = "";

    /// <summary>
    /// Gets or sets the referrer URL. Optional.
    /// </summary>
    [JsonPropertyName("referrer")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Referrer { get; set; }

    /// <summary>
    /// Gets or sets the frame ID to navigate. If not specified, navigates the top-level frame.
    /// </summary>
    [JsonPropertyName("frameId")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FrameId { get; set; }
}

using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Parameters for the <c>Page.setDocumentContent</c> CDP command.
/// Sets given markup as the document's HTML.
/// </summary>
public sealed class SetDocumentContentParams
{
    /// <summary>
    /// Gets or sets the frame id to set HTML for.
    /// </summary>
    [JsonPropertyName("frameId")]
    public string FrameId { get; set; } = "";

    /// <summary>
    /// Gets or sets the HTML content to set.
    /// </summary>
    [JsonPropertyName("html")]
    public string Html { get; set; } = "";
}

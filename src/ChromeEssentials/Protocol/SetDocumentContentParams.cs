using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Parameters for the <c>Page.setDocumentContent</c> CDP command.
/// Sets the HTML content of the specified frame.
/// </summary>
public sealed class SetDocumentContentParams
{
    /// <summary>
    /// Gets or sets the frame ID whose content should be set.
    /// </summary>
    [JsonPropertyName("frameId")]
    public string FrameId { get; set; } = "";

    /// <summary>
    /// Gets or sets the HTML content to set.
    /// </summary>
    [JsonPropertyName("html")]
    public string Html { get; set; } = "";
}

using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Represents information about a frame in the page.
/// </summary>
public sealed class FrameInfo
{
    /// <summary>
    /// Gets or sets the unique frame identifier.
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; } = "";

    /// <summary>
    /// Gets or sets the parent frame identifier, or <c>null</c> for the main frame.
    /// </summary>
    [JsonPropertyName("parentId")]
    public string? ParentId { get; set; }

    /// <summary>
    /// Gets or sets the frame's URL.
    /// </summary>
    [JsonPropertyName("url")]
    public string Url { get; set; } = "";

    /// <summary>
    /// Gets or sets the frame's security origin.
    /// </summary>
    [JsonPropertyName("securityOrigin")]
    public string SecurityOrigin { get; set; } = "";

    /// <summary>
    /// Gets or sets the frame's MIME type as determined by the browser.
    /// </summary>
    [JsonPropertyName("mimeType")]
    public string MimeType { get; set; } = "";

    /// <summary>
    /// Gets or sets the frame's name as specified in the tag.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

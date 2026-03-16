using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Represents a Frame type in the CDP protocol.
/// </summary>
public sealed class FrameInfo
{
    /// <summary>
    /// Gets or sets the frame unique identifier.
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; } = "";

    /// <summary>
    /// Gets or sets the parent frame identifier.
    /// </summary>
    [JsonPropertyName("parentId")]
    public string? ParentId { get; set; }

    /// <summary>
    /// Gets or sets the frame document's URL without fragment.
    /// </summary>
    [JsonPropertyName("url")]
    public string Url { get; set; } = "";

    /// <summary>
    /// Gets or sets the frame document's security origin.
    /// </summary>
    [JsonPropertyName("securityOrigin")]
    public string SecurityOrigin { get; set; } = "";

    /// <summary>
    /// Gets or sets the frame document's mimeType as determined by the browser.
    /// </summary>
    [JsonPropertyName("mimeType")]
    public string MimeType { get; set; } = "";

    /// <summary>
    /// Gets or sets the frame's name as specified in the tag.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

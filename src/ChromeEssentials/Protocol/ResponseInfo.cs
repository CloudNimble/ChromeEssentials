using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Represents HTTP response information.
/// </summary>
public sealed class ResponseInfo
{
    /// <summary>
    /// Gets or sets the response URL. This URL can be different from <c>CachedResource.url</c> in case of redirect.
    /// </summary>
    [JsonPropertyName("url")]
    public string Url { get; set; } = "";

    /// <summary>
    /// Gets or sets the HTTP response status code.
    /// </summary>
    [JsonPropertyName("status")]
    public int Status { get; set; }

    /// <summary>
    /// Gets or sets the HTTP response status text.
    /// </summary>
    [JsonPropertyName("statusText")]
    public string StatusText { get; set; } = "";

    /// <summary>
    /// Gets or sets the HTTP response headers.
    /// </summary>
    [JsonPropertyName("headers")]
    public Dictionary<string, string> Headers { get; set; } = new();

    /// <summary>
    /// Gets or sets the resource mimeType as determined by the browser.
    /// </summary>
    [JsonPropertyName("mimeType")]
    public string MimeType { get; set; } = "";
}

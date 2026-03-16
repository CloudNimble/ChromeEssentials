using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Represents HTTP response information.
/// </summary>
public sealed class ResponseInfo
{
    /// <summary>
    /// Gets or sets the response URL (may differ from request URL due to redirects).
    /// </summary>
    [JsonPropertyName("url")]
    public string Url { get; set; } = "";

    /// <summary>
    /// Gets or sets the HTTP status code.
    /// </summary>
    [JsonPropertyName("status")]
    public int Status { get; set; }

    /// <summary>
    /// Gets or sets the HTTP status text.
    /// </summary>
    [JsonPropertyName("statusText")]
    public string StatusText { get; set; } = "";

    /// <summary>
    /// Gets or sets the response headers as key-value pairs.
    /// </summary>
    [JsonPropertyName("headers")]
    public Dictionary<string, string> Headers { get; set; } = new();

    /// <summary>
    /// Gets or sets the MIME type of the response.
    /// </summary>
    [JsonPropertyName("mimeType")]
    public string MimeType { get; set; } = "";
}

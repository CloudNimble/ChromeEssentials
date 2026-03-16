using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Represents HTTP request information.
/// </summary>
public sealed class RequestInfo
{
    /// <summary>
    /// Gets or sets the request URL.
    /// </summary>
    [JsonPropertyName("url")]
    public string Url { get; set; } = "";

    /// <summary>
    /// Gets or sets the HTTP method (e.g., <c>"GET"</c>, <c>"POST"</c>).
    /// </summary>
    [JsonPropertyName("method")]
    public string Method { get; set; } = "";

    /// <summary>
    /// Gets or sets the request headers as key-value pairs.
    /// </summary>
    [JsonPropertyName("headers")]
    public Dictionary<string, string> Headers { get; set; } = new();

    /// <summary>
    /// Gets or sets the POST data, if any.
    /// </summary>
    [JsonPropertyName("postData")]
    public string? PostData { get; set; }
}

using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Represents HTTP request information.
/// </summary>
public sealed class RequestInfo
{
    /// <summary>
    /// Gets or sets the request URL (without fragment).
    /// </summary>
    [JsonPropertyName("url")]
    public string Url { get; set; } = "";

    /// <summary>
    /// Gets or sets the HTTP request method.
    /// </summary>
    [JsonPropertyName("method")]
    public string Method { get; set; } = "";

    /// <summary>
    /// Gets or sets the HTTP request headers.
    /// </summary>
    [JsonPropertyName("headers")]
    public Dictionary<string, string> Headers { get; set; } = new();

    /// <summary>
    /// Gets or sets the HTTP POST request data. Use <c>postDataEntries</c> instead.
    /// </summary>
    [JsonPropertyName("postData")]
    public string? PostData { get; set; }
}

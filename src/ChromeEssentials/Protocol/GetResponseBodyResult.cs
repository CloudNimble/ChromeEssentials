using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Result of the <c>Network.getResponseBody</c> CDP command.
/// </summary>
public sealed class GetResponseBodyResult
{
    /// <summary>
    /// Gets or sets the response body content. If <see cref="Base64Encoded"/> is true, this is Base64-encoded.
    /// </summary>
    [JsonPropertyName("body")]
    public string Body { get; set; } = "";

    /// <summary>
    /// Gets or sets a value indicating whether the body content is Base64-encoded.
    /// </summary>
    [JsonPropertyName("base64Encoded")]
    public bool Base64Encoded { get; set; }
}

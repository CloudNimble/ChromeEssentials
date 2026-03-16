using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Result of the <c>Network.getResponseBody</c> CDP command.
/// </summary>
public sealed class GetResponseBodyResult
{
    /// <summary>
    /// Gets or sets the response body.
    /// </summary>
    [JsonPropertyName("body")]
    public string Body { get; set; } = "";

    /// <summary>
    /// Gets or sets a value indicating whether the content was sent as base64.
    /// </summary>
    [JsonPropertyName("base64Encoded")]
    public bool Base64Encoded { get; set; }
}

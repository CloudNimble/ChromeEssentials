using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Parameters for the <c>Network.getResponseBody</c> CDP command.
/// </summary>
public sealed class GetResponseBodyParams
{
    /// <summary>
    /// Gets or sets the network request ID for which to get the response body.
    /// </summary>
    [JsonPropertyName("requestId")]
    public string RequestId { get; set; } = "";
}

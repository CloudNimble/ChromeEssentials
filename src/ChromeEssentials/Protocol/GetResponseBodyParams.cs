using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Parameters for the <c>Network.getResponseBody</c> CDP command.
/// Returns content served for the given request.
/// </summary>
public sealed class GetResponseBodyParams
{
    /// <summary>
    /// Gets or sets the identifier of the network request to get content for.
    /// </summary>
    [JsonPropertyName("requestId")]
    public string RequestId { get; set; } = "";
}

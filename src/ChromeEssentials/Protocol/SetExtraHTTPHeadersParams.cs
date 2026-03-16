using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Parameters for the <c>Network.setExtraHTTPHeaders</c> CDP command.
/// Specifies additional headers to send with every HTTP request.
/// </summary>
public sealed class SetExtraHTTPHeadersParams
{
    /// <summary>
    /// Gets or sets the headers as key-value pairs.
    /// </summary>
    [JsonPropertyName("headers")]
    public Dictionary<string, string> Headers { get; set; } = new();
}

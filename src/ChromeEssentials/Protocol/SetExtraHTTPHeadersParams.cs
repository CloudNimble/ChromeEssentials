using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Parameters for the <c>Network.setExtraHTTPHeaders</c> CDP command.
/// Specifies whether to always send extra HTTP headers with the requests from this page.
/// </summary>
public sealed class SetExtraHTTPHeadersParams
{
    /// <summary>
    /// Gets or sets the map with extra HTTP headers.
    /// </summary>
    [JsonPropertyName("headers")]
    public Dictionary<string, string> Headers { get; set; } = new();
}

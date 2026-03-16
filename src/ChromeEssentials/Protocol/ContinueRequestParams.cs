using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Parameters for the <c>Fetch.continueRequest</c> CDP command.
/// Continues the request, optionally modifying some of its parameters.
/// </summary>
public sealed class ContinueRequestParams
{
    /// <summary>
    /// Gets or sets an id the client received in requestPaused event.
    /// </summary>
    [JsonPropertyName("requestId")]
    public string RequestId { get; set; } = "";

    /// <summary>
    /// Gets or sets the request url. If set, the request url will be modified in a way that's not observable by page.
    /// </summary>
    [JsonPropertyName("url")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Url { get; set; }

    /// <summary>
    /// Gets or sets the request method override.
    /// </summary>
    [JsonPropertyName("method")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Method { get; set; }

    /// <summary>
    /// Gets or sets the post data override. If set, overrides the post data in the request.
    /// (Encoded as a base64 string when passed over JSON).
    /// </summary>
    [JsonPropertyName("postData")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? PostData { get; set; }

    /// <summary>
    /// Gets or sets the request headers override. Note that the overrides do not
    /// extend to subsequent redirect hops, if a redirect happens.
    /// </summary>
    [JsonPropertyName("headers")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public HeaderEntry[]? Headers { get; set; }
}

using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Parameters for the <c>Fetch.fulfillRequest</c> CDP command.
/// Provides response to the request.
/// </summary>
public sealed class FulfillRequestParams
{
    /// <summary>
    /// Gets or sets an id the client received in requestPaused event.
    /// </summary>
    [JsonPropertyName("requestId")]
    public string RequestId { get; set; } = "";

    /// <summary>
    /// Gets or sets an HTTP response code.
    /// </summary>
    [JsonPropertyName("responseCode")]
    public int ResponseCode { get; set; }

    /// <summary>
    /// Gets or sets response headers.
    /// </summary>
    [JsonPropertyName("responseHeaders")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public HeaderEntry[]? ResponseHeaders { get; set; }

    /// <summary>
    /// Gets or sets a response body. If absent, original response body will be used if the request
    /// is intercepted at the response stage and empty body will be used if the request is intercepted
    /// at the request stage.
    /// </summary>
    [JsonPropertyName("body")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Body { get; set; }

    /// <summary>
    /// Gets or sets a textual representation of responseCode.
    /// If absent, a standard phrase matching responseCode is used.
    /// </summary>
    [JsonPropertyName("responsePhrase")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? ResponsePhrase { get; set; }
}

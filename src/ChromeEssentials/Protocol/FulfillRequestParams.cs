using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Parameters for the <c>Fetch.fulfillRequest</c> CDP command.
/// Provides a synthetic response to a paused request.
/// </summary>
public sealed class FulfillRequestParams
{
    /// <summary>
    /// Gets or sets the request interception ID.
    /// </summary>
    [JsonPropertyName("requestId")]
    public string RequestId { get; set; } = "";

    /// <summary>
    /// Gets or sets the HTTP response code to use.
    /// </summary>
    [JsonPropertyName("responseCode")]
    public int ResponseCode { get; set; }

    /// <summary>
    /// Gets or sets the response headers.
    /// </summary>
    [JsonPropertyName("responseHeaders")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public HeaderEntry[]? ResponseHeaders { get; set; }

    /// <summary>
    /// Gets or sets the Base64-encoded response body.
    /// </summary>
    [JsonPropertyName("body")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Body { get; set; }

    /// <summary>
    /// Gets or sets the response phrase (e.g., <c>"OK"</c>).
    /// </summary>
    [JsonPropertyName("responsePhrase")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? ResponsePhrase { get; set; }
}

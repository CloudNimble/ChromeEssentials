using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Event parameters for the <c>Fetch.requestPaused</c> event.
/// Issued when the domain is enabled and the request URL matches the specified filter.
/// The request is paused until the client responds with one of continueRequest, failRequest
/// or fulfillRequest. The stage of the request can be determined by presence of
/// responseErrorReason and responseStatusCode.
/// </summary>
public sealed class RequestPausedParams
{
    /// <summary>
    /// Gets or sets the unique identifier for this request. Each request the page makes will have a unique id.
    /// </summary>
    [JsonPropertyName("requestId")]
    public string RequestId { get; set; } = "";

    /// <summary>
    /// Gets or sets the details of the request.
    /// </summary>
    [JsonPropertyName("request")]
    public RequestInfo Request { get; set; } = new();

    /// <summary>
    /// Gets or sets the id of the frame that initiated the request.
    /// </summary>
    [JsonPropertyName("frameId")]
    public string FrameId { get; set; } = "";

    /// <summary>
    /// Gets or sets how the requested resource will be used.
    /// </summary>
    [JsonPropertyName("resourceType")]
    public string ResourceType { get; set; } = "";

    /// <summary>
    /// Gets or sets the response code if intercepted at response stage.
    /// </summary>
    [JsonPropertyName("responseStatusCode")]
    public int? ResponseStatusCode { get; set; }
}

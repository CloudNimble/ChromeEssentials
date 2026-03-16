using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Event parameters for the <c>Fetch.requestPaused</c> event.
/// Fired when a request is intercepted and paused.
/// </summary>
public sealed class RequestPausedParams
{
    /// <summary>
    /// Gets or sets the unique identifier for this interception.
    /// </summary>
    [JsonPropertyName("requestId")]
    public string RequestId { get; set; } = "";

    /// <summary>
    /// Gets or sets the intercepted request details.
    /// </summary>
    [JsonPropertyName("request")]
    public RequestInfo Request { get; set; } = new();

    /// <summary>
    /// Gets or sets the frame ID that initiated the request.
    /// </summary>
    [JsonPropertyName("frameId")]
    public string FrameId { get; set; } = "";

    /// <summary>
    /// Gets or sets the resource type.
    /// </summary>
    [JsonPropertyName("resourceType")]
    public string ResourceType { get; set; } = "";

    /// <summary>
    /// Gets or sets the HTTP response status code if intercepted at response stage.
    /// </summary>
    [JsonPropertyName("responseStatusCode")]
    public int? ResponseStatusCode { get; set; }
}

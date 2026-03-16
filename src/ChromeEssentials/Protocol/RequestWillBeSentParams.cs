using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Event parameters for the <c>Network.requestWillBeSent</c> event.
/// Fired when a network request is about to be sent.
/// </summary>
public sealed class RequestWillBeSentParams
{
    /// <summary>
    /// Gets or sets the unique request identifier.
    /// </summary>
    [JsonPropertyName("requestId")]
    public string RequestId { get; set; } = "";

    /// <summary>
    /// Gets or sets the loader identifier (correlates with page navigation).
    /// </summary>
    [JsonPropertyName("loaderId")]
    public string LoaderId { get; set; } = "";

    /// <summary>
    /// Gets or sets the URL of the document this request is loaded for.
    /// </summary>
    [JsonPropertyName("documentURL")]
    public string DocumentURL { get; set; } = "";

    /// <summary>
    /// Gets or sets the request details.
    /// </summary>
    [JsonPropertyName("request")]
    public RequestInfo Request { get; set; } = new();

    /// <summary>
    /// Gets or sets the timestamp of the request.
    /// </summary>
    [JsonPropertyName("timestamp")]
    public double Timestamp { get; set; }

    /// <summary>
    /// Gets or sets the wall time of the request.
    /// </summary>
    [JsonPropertyName("wallTime")]
    public double WallTime { get; set; }

    /// <summary>
    /// Gets or sets the resource type (e.g., <c>"Document"</c>, <c>"Script"</c>, <c>"Stylesheet"</c>).
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

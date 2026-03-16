using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Event parameters for the <c>Network.requestWillBeSent</c> event.
/// Fired when page is about to send HTTP request.
/// </summary>
public sealed class RequestWillBeSentParams
{
    /// <summary>
    /// Gets or sets the request identifier.
    /// </summary>
    [JsonPropertyName("requestId")]
    public string RequestId { get; set; } = "";

    /// <summary>
    /// Gets or sets the loader identifier. Empty string if the request is fetched from worker.
    /// </summary>
    [JsonPropertyName("loaderId")]
    public string LoaderId { get; set; } = "";

    /// <summary>
    /// Gets or sets the URL of the document this request is loaded for.
    /// </summary>
    [JsonPropertyName("documentURL")]
    public string DocumentURL { get; set; } = "";

    /// <summary>
    /// Gets or sets the request data.
    /// </summary>
    [JsonPropertyName("request")]
    public RequestInfo Request { get; set; } = new();

    /// <summary>
    /// Gets or sets the monotonically increasing time in seconds since an arbitrary point in the past.
    /// </summary>
    [JsonPropertyName("timestamp")]
    public double Timestamp { get; set; }

    /// <summary>
    /// Gets or sets the UTC time in seconds, measured as the number of seconds since January 1, 1970.
    /// </summary>
    [JsonPropertyName("wallTime")]
    public double WallTime { get; set; }

    /// <summary>
    /// Gets or sets the type of this resource.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

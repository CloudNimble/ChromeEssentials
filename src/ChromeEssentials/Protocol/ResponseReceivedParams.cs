using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Event parameters for the <c>Network.responseReceived</c> event.
/// Fired when HTTP response is available.
/// </summary>
public sealed class ResponseReceivedParams
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
    /// Gets or sets the monotonically increasing time in seconds since an arbitrary point in the past.
    /// </summary>
    [JsonPropertyName("timestamp")]
    public double Timestamp { get; set; }

    /// <summary>
    /// Gets or sets the resource type.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "";

    /// <summary>
    /// Gets or sets the response data.
    /// </summary>
    [JsonPropertyName("response")]
    public ResponseInfo Response { get; set; } = new();
}

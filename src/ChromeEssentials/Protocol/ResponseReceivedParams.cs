using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Event parameters for the <c>Network.responseReceived</c> event.
/// Fired when an HTTP response is received.
/// </summary>
public sealed class ResponseReceivedParams
{
    /// <summary>
    /// Gets or sets the request identifier.
    /// </summary>
    [JsonPropertyName("requestId")]
    public string RequestId { get; set; } = "";

    /// <summary>
    /// Gets or sets the loader identifier.
    /// </summary>
    [JsonPropertyName("loaderId")]
    public string LoaderId { get; set; } = "";

    /// <summary>
    /// Gets or sets the timestamp.
    /// </summary>
    [JsonPropertyName("timestamp")]
    public double Timestamp { get; set; }

    /// <summary>
    /// Gets or sets the resource type.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "";

    /// <summary>
    /// Gets or sets the response details.
    /// </summary>
    [JsonPropertyName("response")]
    public ResponseInfo Response { get; set; } = new();
}

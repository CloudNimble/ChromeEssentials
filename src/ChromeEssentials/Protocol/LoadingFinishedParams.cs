using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Event parameters for the <c>Network.loadingFinished</c> event.
/// Fired when HTTP request has finished loading.
/// </summary>
public sealed class LoadingFinishedParams
{
    /// <summary>
    /// Gets or sets the request identifier.
    /// </summary>
    [JsonPropertyName("requestId")]
    public string RequestId { get; set; } = "";

    /// <summary>
    /// Gets or sets the monotonically increasing time in seconds since an arbitrary point in the past.
    /// </summary>
    [JsonPropertyName("timestamp")]
    public double Timestamp { get; set; }

    /// <summary>
    /// Gets or sets the total number of bytes received for this request.
    /// </summary>
    [JsonPropertyName("encodedDataLength")]
    public double EncodedDataLength { get; set; }
}

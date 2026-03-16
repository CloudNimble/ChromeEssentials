using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Event parameters for the <c>Network.loadingFailed</c> event.
/// Fired when HTTP request has failed to load.
/// </summary>
public sealed class LoadingFailedParams
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
    /// Gets or sets the resource type.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "";

    /// <summary>
    /// Gets or sets the user friendly error message.
    /// </summary>
    [JsonPropertyName("errorText")]
    public string ErrorText { get; set; } = "";

    /// <summary>
    /// Gets or sets a value indicating whether loading was canceled.
    /// </summary>
    [JsonPropertyName("canceled")]
    public bool Canceled { get; set; }
}

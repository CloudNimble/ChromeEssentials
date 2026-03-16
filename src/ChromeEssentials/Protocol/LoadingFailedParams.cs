using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Event parameters for the <c>Network.loadingFailed</c> event.
/// </summary>
public sealed class LoadingFailedParams
{
    /// <summary>
    /// Gets or sets the request identifier.
    /// </summary>
    [JsonPropertyName("requestId")]
    public string RequestId { get; set; } = "";

    /// <summary>
    /// Gets or sets the timestamp when loading failed.
    /// </summary>
    [JsonPropertyName("timestamp")]
    public double Timestamp { get; set; }

    /// <summary>
    /// Gets or sets the resource type.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "";

    /// <summary>
    /// Gets or sets the error message describing the failure.
    /// </summary>
    [JsonPropertyName("errorText")]
    public string ErrorText { get; set; } = "";

    /// <summary>
    /// Gets or sets a value indicating whether the request was canceled.
    /// </summary>
    [JsonPropertyName("canceled")]
    public bool Canceled { get; set; }
}

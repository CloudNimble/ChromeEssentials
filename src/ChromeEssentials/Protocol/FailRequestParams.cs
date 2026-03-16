using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Parameters for the <c>Fetch.failRequest</c> CDP command.
/// Causes the request to fail with specified reason.
/// </summary>
public sealed class FailRequestParams
{
    /// <summary>
    /// Gets or sets an id the client received in requestPaused event.
    /// </summary>
    [JsonPropertyName("requestId")]
    public string RequestId { get; set; } = "";

    /// <summary>
    /// Gets or sets the reason the request should fail. Causes the request to fail with the given reason.
    /// </summary>
    [JsonPropertyName("reason")]
    public string Reason { get; set; } = "";
}

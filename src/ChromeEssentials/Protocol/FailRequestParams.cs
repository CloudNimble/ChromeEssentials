using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Parameters for the <c>Fetch.failRequest</c> CDP command.
/// Causes a paused request to fail with the specified error reason.
/// </summary>
public sealed class FailRequestParams
{
    /// <summary>
    /// Gets or sets the request interception ID.
    /// </summary>
    [JsonPropertyName("requestId")]
    public string RequestId { get; set; } = "";

    /// <summary>
    /// Gets or sets the reason the request failed (e.g., <c>"Failed"</c>, <c>"Aborted"</c>,
    /// <c>"TimedOut"</c>, <c>"AccessDenied"</c>, <c>"ConnectionClosed"</c>, <c>"ConnectionReset"</c>,
    /// <c>"ConnectionRefused"</c>, <c>"ConnectionAborted"</c>, <c>"ConnectionFailed"</c>,
    /// <c>"NameNotResolved"</c>, <c>"InternetDisconnected"</c>, <c>"AddressUnreachable"</c>,
    /// <c>"BlockedByClient"</c>, <c>"BlockedByResponse"</c>).
    /// </summary>
    [JsonPropertyName("reason")]
    public string Reason { get; set; } = "";
}

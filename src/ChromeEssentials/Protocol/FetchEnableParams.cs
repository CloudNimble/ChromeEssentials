using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Parameters for the <c>Fetch.enable</c> CDP command.
/// Enables issuing of requestPaused events. A request will be paused until client
/// calls one of failRequest, fulfillRequest or continueRequest/continueWithAuth.
/// </summary>
public sealed class FetchEnableParams
{
    /// <summary>
    /// Gets or sets the request patterns to intercept. If specified, only requests matching
    /// any of these patterns will produce fetchRequested event and will be paused until clients response.
    /// </summary>
    [JsonPropertyName("patterns")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public RequestPattern[]? Patterns { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether authRequired events will be issued and
    /// requests will be paused expecting a call to continueWithAuth.
    /// </summary>
    [JsonPropertyName("handleAuthRequests")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public bool HandleAuthRequests { get; set; }
}

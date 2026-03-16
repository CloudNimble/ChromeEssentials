using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Parameters for the <c>Fetch.enable</c> CDP command.
/// Enables the Fetch domain for intercepting network requests.
/// </summary>
public sealed class FetchEnableParams
{
    /// <summary>
    /// Gets or sets the request patterns to intercept. If empty, all requests are intercepted.
    /// </summary>
    [JsonPropertyName("patterns")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public RequestPattern[]? Patterns { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to handle auth requests.
    /// </summary>
    [JsonPropertyName("handleAuthRequests")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public bool HandleAuthRequests { get; set; }
}

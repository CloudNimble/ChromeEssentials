using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Result of the <c>Network.setCookie</c> CDP command.
/// </summary>
public sealed class SetCookieResult
{
    /// <summary>
    /// Always set to true. If an error occurs, the response itself will have HTTP status 500.
    /// </summary>
    [JsonPropertyName("success")]
    public bool Success { get; set; }
}

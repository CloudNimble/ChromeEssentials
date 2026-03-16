using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Result of the <c>Network.setCookie</c> CDP command.
/// </summary>
public sealed class SetCookieResult
{
    /// <summary>
    /// Gets or sets a value indicating whether the cookie was successfully set.
    /// </summary>
    [JsonPropertyName("success")]
    public bool Success { get; set; }
}

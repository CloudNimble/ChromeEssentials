using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Result of the <c>Network.getCookies</c> CDP command.
/// </summary>
public sealed class GetCookiesResult
{
    /// <summary>
    /// Gets or sets the array of cookies.
    /// </summary>
    [JsonPropertyName("cookies")]
    public CookieInfo[] Cookies { get; set; } = [];
}

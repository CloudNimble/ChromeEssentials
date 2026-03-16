using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Parameters for the <c>Network.getCookies</c> CDP command.
/// </summary>
public sealed class GetCookiesParams
{
    /// <summary>
    /// Gets or sets the list of URLs for which cookies are requested. If not specified,
    /// cookies for the current page URL are returned.
    /// </summary>
    [JsonPropertyName("urls")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string[]? Urls { get; set; }
}

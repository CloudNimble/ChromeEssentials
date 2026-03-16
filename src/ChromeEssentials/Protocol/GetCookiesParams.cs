using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Parameters for the <c>Network.getCookies</c> CDP command.
/// Returns all browser cookies for the current URL. Depending on the backend support, will return
/// detailed cookie information in the <c>cookies</c> field.
/// </summary>
public sealed class GetCookiesParams
{
    /// <summary>
    /// Gets or sets the list of URLs for which applicable cookies will be fetched. If not specified,
    /// it's assumed to be set to the list of URLs of the current page.
    /// </summary>
    [JsonPropertyName("urls")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string[]? Urls { get; set; }
}

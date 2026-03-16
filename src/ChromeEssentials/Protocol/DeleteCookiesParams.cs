using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Parameters for the <c>Network.deleteCookies</c> CDP command.
/// Deletes browser cookies with matching name and url or domain/path/partitionKey pair.
/// </summary>
public sealed class DeleteCookiesParams
{
    /// <summary>
    /// Gets or sets the name of the cookies to remove.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = "";

    /// <summary>
    /// Gets or sets the URL. If specified, deletes all the cookies with the given name where domain and path match provided URL.
    /// </summary>
    [JsonPropertyName("url")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Url { get; set; }

    /// <summary>
    /// Gets or sets the domain. If specified, deletes only cookies with the exact domain.
    /// </summary>
    [JsonPropertyName("domain")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Domain { get; set; }

    /// <summary>
    /// Gets or sets the path. If specified, deletes only cookies with the exact path.
    /// </summary>
    [JsonPropertyName("path")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Path { get; set; }
}

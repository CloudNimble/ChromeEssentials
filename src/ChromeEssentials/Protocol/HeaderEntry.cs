using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Represents an HTTP header as a name-value pair, used by the Fetch domain.
/// </summary>
public sealed class HeaderEntry
{
    /// <summary>
    /// Gets or sets the header name.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = "";

    /// <summary>
    /// Gets or sets the header value.
    /// </summary>
    [JsonPropertyName("value")]
    public string Value { get; set; } = "";
}

using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Parameters for the <c>Emulation.setUserAgentOverride</c> CDP command.
/// Allows overriding user agent with the given string. <c>userAgentMetadata</c> must be set
/// for Client Hint headers to be sent.
/// </summary>
public sealed class SetUserAgentOverrideParams
{
    /// <summary>
    /// Gets or sets the user agent to use.
    /// </summary>
    [JsonPropertyName("userAgent")]
    public string UserAgent { get; set; } = "";

    /// <summary>
    /// Gets or sets the browser language to emulate.
    /// </summary>
    [JsonPropertyName("acceptLanguage")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? AcceptLanguage { get; set; }

    /// <summary>
    /// Gets or sets the platform navigator.platform should return.
    /// </summary>
    [JsonPropertyName("acceptLanguage")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? AcceptLanguage { get; set; }

    /// <summary>
    /// Gets or sets the platform string to use (e.g., <c>"Win32"</c>, <c>"Linux x86_64"</c>).
    /// </summary>
    [JsonPropertyName("platform")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Platform { get; set; }
}

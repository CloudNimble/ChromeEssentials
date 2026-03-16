using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Represents the result of the <c>Browser.getVersion</c> CDP command.
/// Contains version information about the connected browser.
/// </summary>
public sealed class BrowserVersionResult
{
    /// <summary>
    /// Gets or sets the protocol version (e.g., <c>"1.3"</c>).
    /// </summary>
    [JsonPropertyName("protocolVersion")]
    public string ProtocolVersion { get; set; } = "";

    /// <summary>
    /// Gets or sets the browser product name and version (e.g., <c>"Chrome/120.0.6099.109"</c>).
    /// </summary>
    [JsonPropertyName("product")]
    public string Product { get; set; } = "";

    /// <summary>
    /// Gets or sets the V8 JavaScript engine version.
    /// </summary>
    [JsonPropertyName("jsVersion")]
    public string JsVersion { get; set; } = "";

    /// <summary>
    /// Gets or sets the user agent string.
    /// </summary>
    [JsonPropertyName("userAgent")]
    public string UserAgent { get; set; } = "";

    /// <summary>
    /// Gets or sets the WebKit revision.
    /// </summary>
    [JsonPropertyName("revision")]
    public string Revision { get; set; } = "";
}

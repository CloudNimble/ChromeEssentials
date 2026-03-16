using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Returns version information.
/// </summary>
public sealed class BrowserVersionResult
{
    /// <summary>
    /// Protocol version.
    /// </summary>
    [JsonPropertyName("protocolVersion")]
    public string ProtocolVersion { get; set; } = "";

    /// <summary>
    /// Product name.
    /// </summary>
    [JsonPropertyName("product")]
    public string Product { get; set; } = "";

    /// <summary>
    /// V8 version.
    /// </summary>
    [JsonPropertyName("jsVersion")]
    public string JsVersion { get; set; } = "";

    /// <summary>
    /// User-Agent.
    /// </summary>
    [JsonPropertyName("userAgent")]
    public string UserAgent { get; set; } = "";

    /// <summary>
    /// Product revision.
    /// </summary>
    [JsonPropertyName("revision")]
    public string Revision { get; set; } = "";
}

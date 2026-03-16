using System.Text.Json;
using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Represents a CDP WebSocket request envelope sent to the browser.
/// Each request has a unique <see cref="Id"/> that correlates with the response.
/// </summary>
public sealed class CdpRequest
{
    /// <summary>
    /// Gets or sets the unique request identifier. Used to match responses to their corresponding requests.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the CDP method name (e.g., <c>"Page.navigate"</c>, <c>"Runtime.evaluate"</c>).
    /// </summary>
    [JsonPropertyName("method")]
    public string Method { get; set; } = "";

    /// <summary>
    /// Gets or sets the optional parameters for the CDP command, serialized as a <see cref="JsonElement"/>.
    /// </summary>
    [JsonPropertyName("params")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public JsonElement? Params { get; set; }

    /// <summary>
    /// Gets or sets the optional session ID for sending commands to a specific target (e.g., a tab or worker).
    /// </summary>
    [JsonPropertyName("sessionId")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? SessionId { get; set; }
}

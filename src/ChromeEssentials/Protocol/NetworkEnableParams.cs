using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Parameters for the <c>Network.enable</c> CDP command.
/// Enables network tracking, network events will now be delivered to the client.
/// </summary>
public sealed class NetworkEnableParams
{
    /// <summary>
    /// Gets or sets the buffer size in bytes to use when preserving network payloads (XHRs, etc.).
    /// </summary>
    [JsonPropertyName("maxTotalBufferSize")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public int MaxTotalBufferSize { get; set; }

    /// <summary>
    /// Gets or sets the per-resource buffer size in bytes to use when preserving network payloads.
    /// </summary>
    [JsonPropertyName("maxResourceBufferSize")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public int MaxResourceBufferSize { get; set; }

    /// <summary>
    /// Gets or sets the longest post body size (in bytes) that would be included in <c>requestWillBeSent</c> notification.
    /// </summary>
    [JsonPropertyName("maxPostDataSize")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public int MaxPostDataSize { get; set; }
}

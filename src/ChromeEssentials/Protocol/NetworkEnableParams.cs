using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Parameters for the <c>Network.enable</c> CDP command.
/// Enables network tracking and causes network events to be sent to the client.
/// </summary>
public sealed class NetworkEnableParams
{
    /// <summary>
    /// Gets or sets the maximum total buffer size in bytes for resource content to be buffered.
    /// </summary>
    [JsonPropertyName("maxTotalBufferSize")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public int MaxTotalBufferSize { get; set; }

    /// <summary>
    /// Gets or sets the maximum per-resource buffer size in bytes.
    /// </summary>
    [JsonPropertyName("maxResourceBufferSize")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public int MaxResourceBufferSize { get; set; }

    /// <summary>
    /// Gets or sets the maximum post data size in bytes to include in <c>requestWillBeSent</c> events.
    /// </summary>
    [JsonPropertyName("maxPostDataSize")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public int MaxPostDataSize { get; set; }
}

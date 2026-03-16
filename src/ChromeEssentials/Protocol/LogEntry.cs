using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Log entry.
/// </summary>
public sealed class LogEntry
{
    /// <summary>
    /// Log entry source.
    /// </summary>
    [JsonPropertyName("source")]
    public string Source { get; set; } = "";

    /// <summary>
    /// Log entry severity.
    /// </summary>
    [JsonPropertyName("level")]
    public string Level { get; set; } = "";

    /// <summary>
    /// Logged text.
    /// </summary>
    [JsonPropertyName("text")]
    public string Text { get; set; } = "";

    /// <summary>
    /// Timestamp when this entry was added.
    /// </summary>
    [JsonPropertyName("timestamp")]
    public double Timestamp { get; set; }

    /// <summary>
    /// URL of the resource if known.
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

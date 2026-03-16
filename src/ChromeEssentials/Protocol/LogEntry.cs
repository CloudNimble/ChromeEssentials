using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Represents a browser-level log entry from the Log domain.
/// </summary>
public sealed class LogEntry
{
    /// <summary>
    /// Gets or sets the log entry source (e.g., <c>"network"</c>, <c>"security"</c>, <c>"deprecation"</c>, <c>"other"</c>).
    /// </summary>
    [JsonPropertyName("source")]
    public string Source { get; set; } = "";

    /// <summary>
    /// Gets or sets the log severity level (<c>"verbose"</c>, <c>"info"</c>, <c>"warning"</c>, or <c>"error"</c>).
    /// </summary>
    [JsonPropertyName("level")]
    public string Level { get; set; } = "";

    /// <summary>
    /// Gets or sets the logged text.
    /// </summary>
    [JsonPropertyName("text")]
    public string Text { get; set; } = "";

    /// <summary>
    /// Gets or sets the timestamp of the log entry.
    /// </summary>
    [JsonPropertyName("timestamp")]
    public double Timestamp { get; set; }

    /// <summary>
    /// Gets or sets the URL associated with the log entry, if any.
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

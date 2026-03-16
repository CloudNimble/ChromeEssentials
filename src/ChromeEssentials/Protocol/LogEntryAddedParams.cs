using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Issued when new message was logged.
/// </summary>
public sealed class LogEntryAddedParams
{
    /// <summary>
    /// The entry.
    /// </summary>
    [JsonPropertyName("entry")]
    public LogEntry Entry { get; set; } = new();
}

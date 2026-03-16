using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Event parameters for the <c>Log.entryAdded</c> event.
/// Fired when a browser-level log entry is added.
/// </summary>
public sealed class LogEntryAddedParams
{
    /// <summary>
    /// Gets or sets the log entry.
    /// </summary>
    [JsonPropertyName("entry")]
    public LogEntry Entry { get; set; } = new();
}

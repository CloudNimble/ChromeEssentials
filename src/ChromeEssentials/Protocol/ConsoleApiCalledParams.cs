using System.Text.Json;
using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Event parameters for the <c>Runtime.consoleAPICalled</c> event.
/// Fired when a console API method is called (e.g., console.log, console.error).
/// </summary>
public sealed class ConsoleApiCalledParams
{
    /// <summary>
    /// Gets or sets the type of console call (e.g., <c>"log"</c>, <c>"error"</c>, <c>"warning"</c>, <c>"info"</c>).
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "";

    /// <summary>
    /// Gets or sets the call arguments as an array of remote objects.
    /// </summary>
    [JsonPropertyName("args")]
    public RemoteObject[] Args { get; set; } = [];

    /// <summary>
    /// Gets or sets the execution context ID where the call was made.
    /// </summary>
    [JsonPropertyName("executionContextId")]
    public int ExecutionContextId { get; set; }

    /// <summary>
    /// Gets or sets the call timestamp.
    /// </summary>
    [JsonPropertyName("timestamp")]
    public double Timestamp { get; set; }
}

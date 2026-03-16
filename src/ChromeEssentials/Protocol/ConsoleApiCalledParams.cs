using System.Text.Json;
using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Event parameters for the <c>Runtime.consoleAPICalled</c> event.
/// Issued when console API was called.
/// </summary>
public sealed class ConsoleApiCalledParams
{
    /// <summary>
    /// Type of the call. Allowed values: <c>log</c>, <c>debug</c>, <c>info</c>, <c>error</c>, <c>warning</c>,
    /// <c>dir</c>, <c>dirxml</c>, <c>table</c>, <c>trace</c>, <c>clear</c>, <c>startGroup</c>,
    /// <c>startGroupCollapsed</c>, <c>endGroup</c>, <c>assert</c>, <c>profile</c>, <c>profileEnd</c>,
    /// <c>count</c>, <c>timeEnd</c>.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "";

    /// <summary>
    /// Call arguments.
    /// </summary>
    [JsonPropertyName("args")]
    public RemoteObject[] Args { get; set; } = [];

    /// <summary>
    /// Identifier of the context where the call was made.
    /// </summary>
    [JsonPropertyName("executionContextId")]
    public int ExecutionContextId { get; set; }

    /// <summary>
    /// Call timestamp.
    /// </summary>
    [JsonPropertyName("timestamp")]
    public double Timestamp { get; set; }
}

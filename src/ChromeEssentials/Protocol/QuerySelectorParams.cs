using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Parameters for the <c>DOM.querySelector</c> CDP command.
/// Executes <c>querySelector</c> on a given node.
/// </summary>
public sealed class QuerySelectorParams
{
    /// <summary>
    /// Gets or sets the ID of node to query upon.
    /// </summary>
    [JsonPropertyName("nodeId")]
    public int NodeId { get; set; }

    /// <summary>
    /// Gets or sets the selector string.
    /// </summary>
    [JsonPropertyName("selector")]
    public string Selector { get; set; } = "";
}

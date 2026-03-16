using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Parameters for the <c>DOM.querySelector</c> CDP command.
/// Executes a CSS selector query on the specified node.
/// </summary>
public sealed class QuerySelectorParams
{
    /// <summary>
    /// Gets or sets the node ID to query within.
    /// </summary>
    [JsonPropertyName("nodeId")]
    public int NodeId { get; set; }

    /// <summary>
    /// Gets or sets the CSS selector string.
    /// </summary>
    [JsonPropertyName("selector")]
    public string Selector { get; set; } = "";
}

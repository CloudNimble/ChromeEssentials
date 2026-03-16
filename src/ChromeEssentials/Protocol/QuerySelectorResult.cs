using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Represents the result of the <c>DOM.querySelector</c> CDP command.
/// </summary>
public sealed class QuerySelectorResult
{
    /// <summary>
    /// Gets or sets the node ID of the matching element, or 0 if no match was found.
    /// </summary>
    [JsonPropertyName("nodeId")]
    public int NodeId { get; set; }
}

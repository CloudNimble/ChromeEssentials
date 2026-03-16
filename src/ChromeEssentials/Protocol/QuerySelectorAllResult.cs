using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Represents the result of the <c>DOM.querySelectorAll</c> CDP command.
/// </summary>
public sealed class QuerySelectorAllResult
{
    /// <summary>
    /// Gets or sets the node IDs of all matching elements.
    /// </summary>
    [JsonPropertyName("nodeIds")]
    public int[] NodeIds { get; set; } = [];
}

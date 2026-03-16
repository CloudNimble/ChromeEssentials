using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Represents the result of the <c>DOM.querySelectorAll</c> CDP command.
/// Executes <c>querySelectorAll</c> on a given node.
/// </summary>
public sealed class QuerySelectorAllResult
{
    /// <summary>
    /// Gets or sets the query selector results.
    /// </summary>
    [JsonPropertyName("nodeIds")]
    public int[] NodeIds { get; set; } = [];
}

using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Parameters for the <c>DOM.getOuterHTML</c> CDP command.
/// Returns node's HTML markup.
/// </summary>
public sealed class GetOuterHTMLParams
{
    /// <summary>
    /// Gets or sets the node identifier.
    /// </summary>
    [JsonPropertyName("nodeId")]
    public int NodeId { get; set; }
}

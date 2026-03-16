using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Parameters for the <c>DOM.getOuterHTML</c> CDP command.
/// </summary>
public sealed class GetOuterHTMLParams
{
    /// <summary>
    /// Gets or sets the node ID of the element whose outer HTML is requested.
    /// </summary>
    [JsonPropertyName("nodeId")]
    public int NodeId { get; set; }
}

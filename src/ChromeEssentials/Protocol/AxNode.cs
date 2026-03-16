using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Represents a single node in the browser's accessibility tree.
/// Each node corresponds to an accessible element on the page.
/// </summary>
public sealed class AxNode
{
    /// <summary>
    /// Gets or sets the unique identifier for this accessibility node.
    /// </summary>
    [JsonPropertyName("nodeId")]
    public string NodeId { get; set; } = "";

    /// <summary>
    /// Gets or sets the node ID of this node's parent, or <c>null</c> for the root node.
    /// </summary>
    [JsonPropertyName("parentId")]
    public string? ParentId { get; set; }

    /// <summary>
    /// Gets or sets the node IDs of this node's children.
    /// </summary>
    [JsonPropertyName("childIds")]
    public string[]? ChildIds { get; set; }

    /// <summary>
    /// Gets or sets the ARIA role of this node (e.g., <c>"button"</c>, <c>"heading"</c>, <c>"link"</c>).
    /// </summary>
    [JsonPropertyName("role")]
    public AxValue? Role { get; set; }

    /// <summary>
    /// Gets or sets the accessible name of this node, typically derived from labels, text content, or ARIA attributes.
    /// </summary>
    [JsonPropertyName("name")]
    public AxValue? Name { get; set; }

    /// <summary>
    /// Gets or sets the accessible value of this node (e.g., the current value of a slider or text input).
    /// </summary>
    [JsonPropertyName("value")]
    public AxValue? Value { get; set; }
}

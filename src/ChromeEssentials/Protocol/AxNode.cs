using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// A node in the accessibility tree.
/// </summary>
public sealed class AxNode
{
    /// <summary>
    /// Gets or sets the unique identifier for this node.
    /// </summary>
    [JsonPropertyName("nodeId")]
    public string NodeId { get; set; } = "";

    /// <summary>
    /// Gets or sets the ID of this node's parent.
    /// </summary>
    [JsonPropertyName("parentId")]
    public string? ParentId { get; set; }

    /// <summary>
    /// Gets or sets the IDs of this node's child nodes.
    /// </summary>
    [JsonPropertyName("childIds")]
    public string[]? ChildIds { get; set; }

    /// <summary>
    /// Gets or sets this node's role, whether explicit or implicit.
    /// </summary>
    [JsonPropertyName("role")]
    public AxValue? Role { get; set; }

    /// <summary>
    /// Gets or sets the accessible name for this node.
    /// </summary>
    [JsonPropertyName("name")]
    public AxValue? Name { get; set; }

    /// <summary>
    /// Gets or sets the current value for this node.
    /// </summary>
    [JsonPropertyName("value")]
    public AxValue? Value { get; set; }
}

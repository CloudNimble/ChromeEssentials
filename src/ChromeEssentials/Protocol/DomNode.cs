using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// DOM interaction is implemented in terms of mirror objects that represent the actual DOM nodes.
/// DOMNode is a base node mirror type.
/// </summary>
public sealed class DomNode
{
    /// <summary>
    /// Gets or sets the node identifier that is passed into the rest of the DOM messages as the <c>nodeId</c>.
    /// Backend will only push node with given <c>id</c> once. It is aware of all requested nodes and will
    /// only fire DOM events for nodes known to the client.
    /// </summary>
    [JsonPropertyName("nodeId")]
    public int NodeId { get; set; }

    /// <summary>
    /// Gets or sets the BackendNodeId for this node.
    /// </summary>
    [JsonPropertyName("backendNodeId")]
    public int BackendNodeId { get; set; }

    /// <summary>
    /// Gets or sets the <c>Node</c>'s nodeType.
    /// </summary>
    [JsonPropertyName("nodeType")]
    public int NodeType { get; set; }

    /// <summary>
    /// Gets or sets the <c>Node</c>'s nodeName.
    /// </summary>
    [JsonPropertyName("nodeName")]
    public string NodeName { get; set; } = "";

    /// <summary>
    /// Gets or sets the <c>Node</c>'s localName.
    /// </summary>
    [JsonPropertyName("localName")]
    public string LocalName { get; set; } = "";

    /// <summary>
    /// Gets or sets the <c>Node</c>'s nodeValue.
    /// </summary>
    [JsonPropertyName("nodeValue")]
    public string NodeValue { get; set; } = "";

    /// <summary>
    /// Gets or sets the child count for <c>Container</c> nodes.
    /// </summary>
    [JsonPropertyName("childNodeCount")]
    public int? ChildNodeCount { get; set; }

    /// <summary>
    /// Gets or sets the child nodes of this node when requested with children.
    /// </summary>
    [JsonPropertyName("children")]
    public DomNode[]? Children { get; set; }

    /// <summary>
    /// Gets or sets the node's attributes as a flat array of [name, value, name, value, ...].
    /// </summary>
    [JsonPropertyName("attributes")]
    public string[]? Attributes { get; set; }

    /// <summary>
    /// Gets or sets the document URL (only for document nodes).
    /// </summary>
    [JsonPropertyName("documentURL")]
    public string? DocumentURL { get; set; }

    /// <summary>
    /// Gets or sets the frame ID for frame owner elements.
    /// </summary>
    [JsonPropertyName("frameId")]
    public string? FrameId { get; set; }
}

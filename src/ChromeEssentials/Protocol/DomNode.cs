using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Represents a DOM node in the Chrome DevTools Protocol.
/// </summary>
public sealed class DomNode
{
    /// <summary>
    /// Gets or sets the node identifier used to reference this node in subsequent CDP calls.
    /// </summary>
    [JsonPropertyName("nodeId")]
    public int NodeId { get; set; }

    /// <summary>
    /// Gets or sets the backend node identifier (unique across all frames).
    /// </summary>
    [JsonPropertyName("backendNodeId")]
    public int BackendNodeId { get; set; }

    /// <summary>
    /// Gets or sets the node type (1=Element, 3=Text, 9=Document, etc., per DOM spec).
    /// </summary>
    [JsonPropertyName("nodeType")]
    public int NodeType { get; set; }

    /// <summary>
    /// Gets or sets the node name (e.g., <c>"DIV"</c>, <c>"#text"</c>, <c>"#document"</c>).
    /// </summary>
    [JsonPropertyName("nodeName")]
    public string NodeName { get; set; } = "";

    /// <summary>
    /// Gets or sets the node's local name (tag name without namespace prefix).
    /// </summary>
    [JsonPropertyName("localName")]
    public string LocalName { get; set; } = "";

    /// <summary>
    /// Gets or sets the node's text value (for text nodes and comment nodes).
    /// </summary>
    [JsonPropertyName("nodeValue")]
    public string NodeValue { get; set; } = "";

    /// <summary>
    /// Gets or sets the number of child nodes.
    /// </summary>
    [JsonPropertyName("childNodeCount")]
    public int? ChildNodeCount { get; set; }

    /// <summary>
    /// Gets or sets the child nodes (only present when requested with depth > 0).
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

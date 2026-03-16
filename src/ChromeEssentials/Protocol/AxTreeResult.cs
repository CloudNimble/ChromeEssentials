using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Represents the result of the <c>Accessibility.getFullAXTree</c> CDP command.
/// Contains the complete accessibility tree for the current page.
/// </summary>
public sealed class AxTreeResult
{
    /// <summary>
    /// Gets or sets the array of accessibility nodes that make up the tree.
    /// </summary>
    [JsonPropertyName("nodes")]
    public AxNode[] Nodes { get; set; } = [];
}

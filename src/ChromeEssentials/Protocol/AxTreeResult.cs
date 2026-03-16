using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Represents the result of an Accessibility domain command that returns an array of <see cref="AxNode"/> objects,
/// such as <c>Accessibility.getFullAXTree</c>, <c>Accessibility.getPartialAXTree</c>,
/// <c>Accessibility.getChildAXNodes</c>, <c>Accessibility.getAXNodeAndAncestors</c>,
/// or <c>Accessibility.queryAXTree</c>.
/// </summary>
public sealed class AxTreeResult
{
    /// <summary>
    /// Gets or sets the array of <see cref="AxNode"/> objects representing nodes in the accessibility tree.
    /// </summary>
    [JsonPropertyName("nodes")]
    public AxNode[] Nodes { get; set; } = [];
}

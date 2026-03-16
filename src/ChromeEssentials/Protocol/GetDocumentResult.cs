using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Represents the result of the <c>DOM.getDocument</c> CDP command.
/// Returns the root DOM node (and optionally the subtree) to the caller.
/// Implicitly enables the DOM domain events for the current target.
/// </summary>
public sealed class GetDocumentResult
{
    /// <summary>
    /// Gets or sets the resulting node.
    /// </summary>
    [JsonPropertyName("root")]
    public DomNode Root { get; set; } = new();
}

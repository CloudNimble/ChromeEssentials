using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Represents the result of the <c>DOM.getDocument</c> CDP command.
/// Returns the root DOM node of the page.
/// </summary>
public sealed class GetDocumentResult
{
    /// <summary>
    /// Gets or sets the root DOM node.
    /// </summary>
    [JsonPropertyName("root")]
    public DomNode Root { get; set; } = new();
}

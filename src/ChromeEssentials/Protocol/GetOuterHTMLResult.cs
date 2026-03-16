using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Represents the result of the <c>DOM.getOuterHTML</c> CDP command.
/// </summary>
public sealed class GetOuterHTMLResult
{
    /// <summary>
    /// Gets or sets the outer HTML markup.
    /// </summary>
    [JsonPropertyName("outerHTML")]
    public string OuterHTML { get; set; } = "";
}

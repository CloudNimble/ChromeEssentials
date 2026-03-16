using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Represents the result of the <c>Page.addScriptToEvaluateOnNewDocument</c> CDP command.
/// </summary>
public sealed class AddScriptToEvaluateOnNewDocumentResult
{
    /// <summary>
    /// Gets or sets the identifier of the added script.
    /// </summary>
    [JsonPropertyName("identifier")]
    public string Identifier { get; set; } = "";
}

using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Parameters for the <c>Page.addScriptToEvaluateOnNewDocument</c> CDP command.
/// Injects a script that will be evaluated on every new document creation (including subframes).
/// </summary>
public sealed class AddScriptToEvaluateOnNewDocumentParams
{
    /// <summary>
    /// Gets or sets the JavaScript source code to inject.
    /// </summary>
    [JsonPropertyName("source")]
    public string Source { get; set; } = "";

    /// <summary>
    /// Gets or sets an optional world name for isolated world execution.
    /// </summary>
    [JsonPropertyName("worldName")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? WorldName { get; set; }
}

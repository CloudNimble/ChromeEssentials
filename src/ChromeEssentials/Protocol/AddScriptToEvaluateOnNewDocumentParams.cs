using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Parameters for the <c>Page.addScriptToEvaluateOnNewDocument</c> CDP command.
/// Evaluates given script in every frame upon creation (before loading frame's scripts).
/// </summary>
public sealed class AddScriptToEvaluateOnNewDocumentParams
{
    /// <summary>
    /// Gets or sets the script source code.
    /// </summary>
    [JsonPropertyName("source")]
    public string Source { get; set; } = "";

    /// <summary>
    /// Gets or sets the world name. If specified, creates an isolated world with the given name and evaluates given script in it.
    /// </summary>
    [JsonPropertyName("worldName")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? WorldName { get; set; }
}

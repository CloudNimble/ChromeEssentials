using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Parameters for the <c>Input.insertText</c> CDP command.
/// Inserts text as if it were typed by the user.
/// </summary>
public sealed class InsertTextParams
{
    /// <summary>
    /// Gets or sets the text string to insert into the focused element.
    /// </summary>
    [JsonPropertyName("text")]
    public string Text { get; set; } = "";
}

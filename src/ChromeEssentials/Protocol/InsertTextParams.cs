using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Parameters for the <c>Input.insertText</c> CDP command.
/// This method emulates inserting text that doesn't come from a key press,
/// for example an emoji keyboard or an IME.
/// </summary>
public sealed class InsertTextParams
{
    /// <summary>
    /// Gets or sets the text to insert.
    /// </summary>
    [JsonPropertyName("text")]
    public string Text { get; set; } = "";
}

using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Parameters for the <c>Page.handleJavaScriptDialog</c> CDP command.
/// Accepts or dismisses a JavaScript-initiated dialog.
/// </summary>
public sealed class HandleJavaScriptDialogParams
{
    /// <summary>
    /// Gets or sets a value indicating whether to accept (<c>true</c>) or dismiss (<c>false</c>) the dialog.
    /// </summary>
    [JsonPropertyName("accept")]
    public bool Accept { get; set; }

    /// <summary>
    /// Gets or sets the text to enter in a prompt dialog. Only used for prompt dialogs.
    /// </summary>
    [JsonPropertyName("promptText")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? PromptText { get; set; }
}

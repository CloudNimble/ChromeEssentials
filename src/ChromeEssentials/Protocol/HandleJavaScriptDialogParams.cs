using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Parameters for the <c>Page.handleJavaScriptDialog</c> CDP command.
/// Accepts or dismisses a JavaScript initiated dialog (alert, confirm, prompt, or onbeforeunload).
/// </summary>
public sealed class HandleJavaScriptDialogParams
{
    /// <summary>
    /// Gets or sets a value indicating whether to accept or dismiss the dialog.
    /// </summary>
    [JsonPropertyName("accept")]
    public bool Accept { get; set; }

    /// <summary>
    /// Gets or sets the text to enter into the dialog prompt before accepting. Used only if this is a prompt dialog.
    /// </summary>
    [JsonPropertyName("promptText")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? PromptText { get; set; }
}

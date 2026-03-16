using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Event parameters for the <c>Page.javascriptDialogOpening</c> event.
/// Fired when a JavaScript-initiated dialog (alert, confirm, prompt, or beforeunload) is about to open.
/// </summary>
public sealed class JavaScriptDialogOpeningParams
{
    /// <summary>
    /// Gets or sets the URL of the frame that initiated the dialog.
    /// </summary>
    [JsonPropertyName("url")]
    public string Url { get; set; } = "";

    /// <summary>
    /// Gets or sets the dialog message text.
    /// </summary>
    [JsonPropertyName("message")]
    public string Message { get; set; } = "";

    /// <summary>
    /// Gets or sets the dialog type (<c>"alert"</c>, <c>"confirm"</c>, <c>"prompt"</c>, or <c>"beforeunload"</c>).
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "";

    /// <summary>
    /// Gets or sets a value indicating whether the dialog has a user gesture.
    /// </summary>
    [JsonPropertyName("hasBrowserHandler")]
    public bool HasBrowserHandler { get; set; }

    /// <summary>
    /// Gets or sets the default prompt value for prompt dialogs.
    /// </summary>
    [JsonPropertyName("defaultPrompt")]
    public string? DefaultPrompt { get; set; }
}

using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Event parameters for the <c>Page.javascriptDialogOpening</c> event.
/// </summary>
public sealed class JavaScriptDialogOpeningParams
{
    /// <summary>
    /// Gets or sets the frame url.
    /// </summary>
    [JsonPropertyName("url")]
    public string Url { get; set; } = "";

    /// <summary>
    /// Gets or sets the message that will be displayed by the dialog.
    /// </summary>
    [JsonPropertyName("message")]
    public string Message { get; set; } = "";

    /// <summary>
    /// Gets or sets the dialog type.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "";

    /// <summary>
    /// Gets or sets a value indicating whether browser is capable showing or acting on the given dialog. When browser has no dialog handler for given target, calling handleJavaScriptDialog will stall.
    /// </summary>
    [JsonPropertyName("hasBrowserHandler")]
    public bool HasBrowserHandler { get; set; }

    /// <summary>
    /// Gets or sets the default dialog prompt.
    /// </summary>
    [JsonPropertyName("defaultPrompt")]
    public string? DefaultPrompt { get; set; }
}

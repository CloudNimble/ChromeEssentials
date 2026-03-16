using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Represents the result of a click operation, typically returned from evaluated JavaScript
/// that clicks an element and reports the outcome.
/// </summary>
public sealed class ClickResult
{
    /// <summary>
    /// Gets or sets a value indicating whether the click operation succeeded.
    /// </summary>
    [JsonPropertyName("ok")]
    public bool Ok { get; set; }

    /// <summary>
    /// Gets or sets the error message if the click failed, or <c>null</c> on success.
    /// </summary>
    [JsonPropertyName("error")]
    public string? Error { get; set; }

    /// <summary>
    /// Gets or sets the HTML tag name of the clicked element (e.g., <c>"BUTTON"</c>, <c>"A"</c>).
    /// </summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>
    /// Gets or sets the text content of the clicked element.
    /// </summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

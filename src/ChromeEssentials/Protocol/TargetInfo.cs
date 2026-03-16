using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Represents information about a browser target (tab, service worker, shared worker, etc.).
/// Returned by the <c>Target.getTargets</c> CDP command.
/// </summary>
public sealed class TargetInfo
{
    /// <summary>
    /// Gets or sets the unique identifier for this target.
    /// </summary>
    [JsonPropertyName("targetId")]
    public string TargetId { get; set; } = "";

    /// <summary>
    /// Gets or sets the type of the target (e.g., <c>"page"</c>, <c>"background_page"</c>, <c>"service_worker"</c>).
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "";

    /// <summary>
    /// Gets or sets the title of the target (typically the page title for page targets).
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; set; } = "";

    /// <summary>
    /// Gets or sets the URL of the target.
    /// </summary>
    [JsonPropertyName("url")]
    public string Url { get; set; } = "";
}

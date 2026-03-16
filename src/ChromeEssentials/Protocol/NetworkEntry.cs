using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Represents a network resource timing entry from the browser's Performance API.
/// Used to analyze page load performance and resource fetching behavior.
/// </summary>
public sealed class NetworkEntry
{
    /// <summary>
    /// Gets or sets the URL of the network resource.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = "";

    /// <summary>
    /// Gets or sets the resource type (e.g., <c>"script"</c>, <c>"stylesheet"</c>, <c>"fetch"</c>).
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "";

    /// <summary>
    /// Gets or sets the total duration of the resource fetch in milliseconds.
    /// </summary>
    [JsonPropertyName("duration")]
    public int Duration { get; set; }

    /// <summary>
    /// Gets or sets the size of the resource in bytes, or <c>null</c> if the size is unavailable.
    /// </summary>
    [JsonPropertyName("size")]
    public long? Size { get; set; }
}

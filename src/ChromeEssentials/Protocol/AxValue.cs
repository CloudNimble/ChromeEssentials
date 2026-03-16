using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// A single computed AX property.
/// </summary>
public sealed class AxValue
{
    /// <summary>
    /// Gets or sets the computed value of this property.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Represents a named value in the accessibility tree, wrapping a string value with its type.
/// </summary>
public sealed class AxValue
{
    /// <summary>
    /// Gets or sets the string representation of the accessibility value.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

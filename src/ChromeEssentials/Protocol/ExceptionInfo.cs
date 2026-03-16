using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Represents detailed information about a JavaScript exception.
/// </summary>
public sealed class ExceptionInfo
{
    /// <summary>
    /// String representation of the object.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }
}

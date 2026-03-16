using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Represents detailed information about a JavaScript exception.
/// </summary>
public sealed class ExceptionInfo
{
    /// <summary>
    /// Gets or sets the full description of the exception, including the stack trace.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }
}

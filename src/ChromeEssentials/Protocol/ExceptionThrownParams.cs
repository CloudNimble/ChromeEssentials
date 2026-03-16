using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Event parameters for the <c>Runtime.exceptionThrown</c> event.
/// Issued when exception was thrown and unhandled.
/// </summary>
public sealed class ExceptionThrownParams
{
    /// <summary>
    /// Timestamp of the exception.
    /// </summary>
    [JsonPropertyName("timestamp")]
    public double Timestamp { get; set; }

    /// <summary>
    /// Exception details.
    /// </summary>
    [JsonPropertyName("exceptionDetails")]
    public ExceptionDetails ExceptionDetails { get; set; } = new();
}

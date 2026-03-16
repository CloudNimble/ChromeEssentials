using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Event parameters for the <c>Runtime.exceptionThrown</c> event.
/// Fired when an unhandled JavaScript exception occurs.
/// </summary>
public sealed class ExceptionThrownParams
{
    /// <summary>
    /// Gets or sets the timestamp of the exception.
    /// </summary>
    [JsonPropertyName("timestamp")]
    public double Timestamp { get; set; }

    /// <summary>
    /// Gets or sets the exception details.
    /// </summary>
    [JsonPropertyName("exceptionDetails")]
    public ExceptionDetails ExceptionDetails { get; set; } = new();
}

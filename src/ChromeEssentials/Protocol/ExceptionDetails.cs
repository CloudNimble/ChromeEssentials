using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Represents exception details from a failed <c>Runtime.evaluate</c> call.
/// </summary>
public sealed class ExceptionDetails
{
    /// <summary>
    /// Exception text, which should be used together with exception object when available.
    /// </summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }

    /// <summary>
    /// Exception object if available.
    /// </summary>
    [JsonPropertyName("exception")]
    public ExceptionInfo? Exception { get; set; }
}

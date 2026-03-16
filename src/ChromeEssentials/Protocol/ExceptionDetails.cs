using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Represents exception details from a failed <c>Runtime.evaluate</c> call.
/// </summary>
public sealed class ExceptionDetails
{
    /// <summary>
    /// Gets or sets the exception text (a short description of the error).
    /// </summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }

    /// <summary>
    /// Gets or sets the exception object containing detailed information about the error.
    /// </summary>
    [JsonPropertyName("exception")]
    public ExceptionInfo? Exception { get; set; }
}

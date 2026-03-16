using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Represents the result of a <c>Runtime.evaluate</c> CDP command.
/// </summary>
public sealed class EvalResult
{
    /// <summary>
    /// Gets or sets the evaluation result value.
    /// </summary>
    [JsonPropertyName("result")]
    public EvalResultValue Result { get; set; } = new();

    /// <summary>
    /// Gets or sets exception details if the evaluation threw an error, or <c>null</c> on success.
    /// </summary>
    [JsonPropertyName("exceptionDetails")]
    public ExceptionDetails? ExceptionDetails { get; set; }
}

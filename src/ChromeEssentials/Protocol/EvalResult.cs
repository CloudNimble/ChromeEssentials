using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Represents the result of a <c>Runtime.evaluate</c> CDP command.
/// </summary>
public sealed class EvalResult
{
    /// <summary>
    /// Evaluation result.
    /// </summary>
    [JsonPropertyName("result")]
    public EvalResultValue Result { get; set; } = new();

    /// <summary>
    /// Exception details.
    /// </summary>
    [JsonPropertyName("exceptionDetails")]
    public ExceptionDetails? ExceptionDetails { get; set; }
}

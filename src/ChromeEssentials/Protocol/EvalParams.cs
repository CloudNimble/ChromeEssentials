using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Parameters for the <c>Runtime.evaluate</c> CDP command.
/// Evaluates expression on global object.
/// </summary>
public sealed class EvalParams
{
    /// <summary>
    /// Expression to evaluate.
    /// </summary>
    [JsonPropertyName("expression")]
    public string Expression { get; set; } = "";

    /// <summary>
    /// Whether the result is expected to be a JSON object that should be sent by value.
    /// </summary>
    [JsonPropertyName("returnByValue")]
    public bool ReturnByValue { get; set; }

    /// <summary>
    /// Whether execution should await for resulting value and return once awaited promise is resolved.
    /// </summary>
    [JsonPropertyName("awaitPromise")]
    public bool AwaitPromise { get; set; }

    /// <summary>
    /// Specifies in which execution context to perform evaluation. If the parameter is omitted the
    /// evaluation will be performed in the context of the inspected page.
    /// </summary>
    [JsonPropertyName("contextId")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? ContextId { get; set; }

    /// <summary>
    /// Whether execution should be treated as initiated by user in the UI.
    /// </summary>
    [JsonPropertyName("userGesture")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public bool UserGesture { get; set; }
}

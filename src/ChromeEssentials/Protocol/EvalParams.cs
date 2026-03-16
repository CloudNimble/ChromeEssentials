using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Parameters for the <c>Runtime.evaluate</c> CDP command.
/// Evaluates a JavaScript expression in the context of the inspected page.
/// </summary>
public sealed class EvalParams
{
    /// <summary>
    /// Gets or sets the JavaScript expression to evaluate.
    /// </summary>
    [JsonPropertyName("expression")]
    public string Expression { get; set; } = "";

    /// <summary>
    /// Gets or sets a value indicating whether the result should be returned by value (serialized).
    /// When <c>true</c>, the result is returned as a JSON-compatible value rather than a remote object reference.
    /// </summary>
    [JsonPropertyName("returnByValue")]
    public bool ReturnByValue { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether execution should wait for the expression's promise to resolve.
    /// When <c>true</c> and the expression returns a <c>Promise</c>, the result will be the resolved value.
    /// </summary>
    [JsonPropertyName("awaitPromise")]
    public bool AwaitPromise { get; set; }

    /// <summary>
    /// Gets or sets the execution context ID to evaluate the expression in. If omitted, uses the default context.
    /// Required for evaluating in specific frames or isolated worlds.
    /// </summary>
    [JsonPropertyName("contextId")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? ContextId { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the evaluation should be treated as initiated by a user gesture.
    /// </summary>
    [JsonPropertyName("userGesture")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public bool UserGesture { get; set; }
}

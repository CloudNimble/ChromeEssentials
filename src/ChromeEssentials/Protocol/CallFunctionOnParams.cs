using System.Text.Json;
using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Parameters for the <c>Runtime.callFunctionOn</c> CDP command.
/// Calls function with given declaration on the given object. Object group of the result is inherited from the target object.
/// </summary>
public sealed class CallFunctionOnParams
{
    /// <summary>
    /// Declaration of the function to call.
    /// </summary>
    [JsonPropertyName("functionDeclaration")]
    public string FunctionDeclaration { get; set; } = "";

    /// <summary>
    /// Identifier of the object to call function on.
    /// </summary>
    [JsonPropertyName("objectId")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? ObjectId { get; set; }

    /// <summary>
    /// Call arguments. All call arguments must belong to the same JavaScript world as the target object.
    /// </summary>
    [JsonPropertyName("arguments")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public CallArgument[]? Arguments { get; set; }

    /// <summary>
    /// Whether the result is expected to be a JSON object which should be sent by value.
    /// </summary>
    [JsonPropertyName("returnByValue")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public bool ReturnByValue { get; set; }

    /// <summary>
    /// Whether execution should await for resulting value and return once awaited promise is resolved.
    /// </summary>
    [JsonPropertyName("awaitPromise")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public bool AwaitPromise { get; set; }

    /// <summary>
    /// Specifies execution context which global object will be used to call function on.
    /// </summary>
    [JsonPropertyName("executionContextId")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? ExecutionContextId { get; set; }
}

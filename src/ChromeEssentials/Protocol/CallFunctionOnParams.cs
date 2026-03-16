using System.Text.Json;
using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Parameters for the <c>Runtime.callFunctionOn</c> CDP command.
/// Calls a function with a given declaration on the specified remote object.
/// </summary>
public sealed class CallFunctionOnParams
{
    /// <summary>
    /// Gets or sets the declaration of the function to call (e.g., <c>"function() { return this.value; }"</c>).
    /// </summary>
    [JsonPropertyName("functionDeclaration")]
    public string FunctionDeclaration { get; set; } = "";

    /// <summary>
    /// Gets or sets the identifier of the object to call the function on.
    /// </summary>
    [JsonPropertyName("objectId")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? ObjectId { get; set; }

    /// <summary>
    /// Gets or sets the call arguments to pass to the function.
    /// </summary>
    [JsonPropertyName("arguments")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public CallArgument[]? Arguments { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the result should be returned by value.
    /// </summary>
    [JsonPropertyName("returnByValue")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public bool ReturnByValue { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the execution should await the resulting promise.
    /// </summary>
    [JsonPropertyName("awaitPromise")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public bool AwaitPromise { get; set; }

    /// <summary>
    /// Gets or sets the execution context ID. If omitted, the global context of the default page is used.
    /// </summary>
    [JsonPropertyName("executionContextId")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? ExecutionContextId { get; set; }
}

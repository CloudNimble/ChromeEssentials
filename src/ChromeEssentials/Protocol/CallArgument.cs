using System.Text.Json;
using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Represents a call argument for <c>Runtime.callFunctionOn</c>.
/// </summary>
public sealed class CallArgument
{
    /// <summary>
    /// Gets or sets the primitive value of the argument.
    /// </summary>
    [JsonPropertyName("value")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public JsonElement? Value { get; set; }

    /// <summary>
    /// Gets or sets the remote object handle to pass as the argument.
    /// </summary>
    [JsonPropertyName("objectId")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? ObjectId { get; set; }
}

using System.Text.Json;
using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Represents a call argument for <c>Runtime.callFunctionOn</c>.
/// </summary>
public sealed class CallArgument
{
    /// <summary>
    /// Primitive value or serializable javascript object.
    /// </summary>
    [JsonPropertyName("value")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public JsonElement? Value { get; set; }

    /// <summary>
    /// Remote object handle.
    /// </summary>
    [JsonPropertyName("objectId")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? ObjectId { get; set; }
}

using System.Text.Json;
using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Mirror object referencing original JavaScript object.
/// </summary>
public sealed class RemoteObject
{
    /// <summary>
    /// Object type. Allowed values: <c>object</c>, <c>function</c>, <c>undefined</c>, <c>string</c>,
    /// <c>number</c>, <c>boolean</c>, <c>symbol</c>, <c>bigint</c>.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "";

    /// <summary>
    /// Object subtype hint. Specified for <c>object</c> type values only. Allowed values: <c>array</c>,
    /// <c>null</c>, <c>node</c>, <c>regexp</c>, <c>date</c>, <c>map</c>, <c>set</c>, <c>weakmap</c>,
    /// <c>weakset</c>, <c>iterator</c>, <c>generator</c>, <c>error</c>, <c>proxy</c>, <c>promise</c>,
    /// <c>typedarray</c>, <c>arraybuffer</c>, <c>dataview</c>, <c>webassemblymemory</c>, <c>wasmvalue</c>.
    /// </summary>
    [JsonPropertyName("subtype")]
    public string? Subtype { get; set; }

    /// <summary>
    /// String representation of the object.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Remote object value in case of primitive values or JSON values (if it was requested).
    /// </summary>
    [JsonPropertyName("value")]
    public JsonElement Value { get; set; }

    /// <summary>
    /// Unique object identifier (for non-primitive values).
    /// </summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }
}

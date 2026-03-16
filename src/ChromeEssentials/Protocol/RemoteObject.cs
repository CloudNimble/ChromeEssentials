using System.Text.Json;
using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Represents a mirror object referencing an original JavaScript object in the browser.
/// </summary>
public sealed class RemoteObject
{
    /// <summary>
    /// Gets or sets the object type (<c>"object"</c>, <c>"function"</c>, <c>"undefined"</c>, <c>"string"</c>,
    /// <c>"number"</c>, <c>"boolean"</c>, <c>"symbol"</c>, <c>"bigint"</c>).
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "";

    /// <summary>
    /// Gets or sets the object subtype (e.g., <c>"array"</c>, <c>"null"</c>, <c>"regexp"</c>, <c>"date"</c>,
    /// <c>"error"</c>, <c>"map"</c>, <c>"set"</c>, <c>"promise"</c>, <c>"node"</c>).
    /// </summary>
    [JsonPropertyName("subtype")]
    public string? Subtype { get; set; }

    /// <summary>
    /// Gets or sets the string representation of the object.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Gets or sets the remote object value (for primitive values and JSON-serializable objects).
    /// </summary>
    [JsonPropertyName("value")]
    public JsonElement Value { get; set; }

    /// <summary>
    /// Gets or sets the unique object identifier (for non-primitive values).
    /// </summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }
}

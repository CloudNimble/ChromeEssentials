using System.Text.Json;
using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Wraps the value portion of a <c>Runtime.evaluate</c> result.
/// </summary>
public sealed class EvalResultValue
{
    /// <summary>
    /// Gets or sets the evaluated value as a <see cref="JsonElement"/>.
    /// </summary>
    [JsonPropertyName("value")]
    public JsonElement Value { get; set; }
}

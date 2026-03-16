using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Parameters for the <c>Network.setCacheDisabled</c> CDP command.
/// Toggles ignoring cache for each request. If <c>true</c>, cache will not be used.
/// </summary>
public sealed class SetCacheDisabledParams
{
    /// <summary>
    /// Gets or sets the cache disabled state.
    /// </summary>
    [JsonPropertyName("cacheDisabled")]
    public bool CacheDisabled { get; set; }
}

using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Parameters for the <c>Network.setCacheDisabled</c> CDP command.
/// </summary>
public sealed class SetCacheDisabledParams
{
    /// <summary>
    /// Gets or sets a value indicating whether the cache should be disabled.
    /// </summary>
    [JsonPropertyName("cacheDisabled")]
    public bool CacheDisabled { get; set; }
}

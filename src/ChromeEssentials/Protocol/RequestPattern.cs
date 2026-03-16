using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Represents a URL pattern for request interception in the Fetch domain.
/// </summary>
public sealed class RequestPattern
{
    /// <summary>
    /// Gets or sets the URL pattern to match (wildcards <c>*</c> are supported).
    /// </summary>
    [JsonPropertyName("urlPattern")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? UrlPattern { get; set; }

    /// <summary>
    /// Gets or sets the resource type to match (e.g., <c>"Document"</c>, <c>"Script"</c>).
    /// </summary>
    [JsonPropertyName("resourceType")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? ResourceType { get; set; }

    /// <summary>
    /// Gets or sets the stage at which to intercept (<c>"Request"</c> or <c>"Response"</c>).
    /// </summary>
    [JsonPropertyName("requestStage")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? RequestStage { get; set; }
}

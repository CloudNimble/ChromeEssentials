using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Represents a URL pattern for request interception in the Fetch domain.
/// </summary>
public sealed class RequestPattern
{
    /// <summary>
    /// Gets or sets the URL pattern to match. Wildcards (<c>*</c> -> zero or more, <c>?</c> -> exactly one) are allowed.
    /// Escape character is backslash. Omitting is equivalent to <c>"*"</c>.
    /// </summary>
    [JsonPropertyName("urlPattern")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? UrlPattern { get; set; }

    /// <summary>
    /// Gets or sets the resource type to match. If set, only requests for matching resource types will be intercepted.
    /// </summary>
    [JsonPropertyName("resourceType")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? ResourceType { get; set; }

    /// <summary>
    /// Gets or sets the stage at which to begin intercepting requests. Default is <c>"Request"</c>.
    /// </summary>
    [JsonPropertyName("requestStage")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? RequestStage { get; set; }
}

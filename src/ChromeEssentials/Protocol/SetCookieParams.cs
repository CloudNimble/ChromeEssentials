using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Parameters for the <c>Network.setCookie</c> CDP command.
/// Sets a cookie with the given cookie data; may overwrite equivalent cookies if they exist.
/// </summary>
public sealed class SetCookieParams
{
    /// <summary>
    /// Gets or sets the cookie name.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = "";

    /// <summary>
    /// Gets or sets the cookie value.
    /// </summary>
    [JsonPropertyName("value")]
    public string Value { get; set; } = "";

    /// <summary>
    /// Gets or sets the request-URI to associate with the setting of the cookie.
    /// </summary>
    [JsonPropertyName("url")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Url { get; set; }

    /// <summary>
    /// Gets or sets the cookie domain.
    /// </summary>
    [JsonPropertyName("domain")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Domain { get; set; }

    /// <summary>
    /// Gets or sets the cookie path.
    /// </summary>
    [JsonPropertyName("path")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Path { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the cookie is secure.
    /// </summary>
    [JsonPropertyName("secure")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public bool Secure { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the cookie is http-only.
    /// </summary>
    [JsonPropertyName("httpOnly")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public bool HttpOnly { get; set; }

    /// <summary>
    /// Gets or sets the cookie SameSite type.
    /// </summary>
    [JsonPropertyName("sameSite")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? SameSite { get; set; }

    /// <summary>
    /// Gets or sets the cookie expiration date, session cookie if not set.
    /// </summary>
    [JsonPropertyName("expires")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public double Expires { get; set; }
}

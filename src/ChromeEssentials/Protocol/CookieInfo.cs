using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Represents a browser cookie.
/// </summary>
public sealed class CookieInfo
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
    /// Gets or sets the cookie domain.
    /// </summary>
    [JsonPropertyName("domain")]
    public string Domain { get; set; } = "";

    /// <summary>
    /// Gets or sets the cookie path.
    /// </summary>
    [JsonPropertyName("path")]
    public string Path { get; set; } = "";

    /// <summary>
    /// Gets or sets the cookie expiration date as a Unix timestamp.
    /// </summary>
    [JsonPropertyName("expires")]
    public double Expires { get; set; }

    /// <summary>
    /// Gets or sets the cookie size in bytes.
    /// </summary>
    [JsonPropertyName("size")]
    public int Size { get; set; }

    /// <summary>
    /// Gets or sets whether the cookie is HTTP-only.
    /// </summary>
    [JsonPropertyName("httpOnly")]
    public bool HttpOnly { get; set; }

    /// <summary>
    /// Gets or sets whether the cookie is secure.
    /// </summary>
    [JsonPropertyName("secure")]
    public bool Secure { get; set; }

    /// <summary>
    /// Gets or sets whether the cookie is a session cookie (no expiry).
    /// </summary>
    [JsonPropertyName("session")]
    public bool Session { get; set; }

    /// <summary>
    /// Gets or sets the SameSite attribute.
    /// </summary>
    [JsonPropertyName("sameSite")]
    public string? SameSite { get; set; }
}

using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Represents an error returned by the browser in response to a CDP command.
/// </summary>
public sealed class CdpError
{
    /// <summary>
    /// Gets or sets the human-readable error message describing what went wrong.
    /// </summary>
    [JsonPropertyName("message")]
    public string Message { get; set; } = "";
}

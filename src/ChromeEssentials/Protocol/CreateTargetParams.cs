using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Parameters for the <c>Target.createTarget</c> CDP command.
/// </summary>
public sealed class CreateTargetParams
{
    /// <summary>
    /// Gets or sets the initial URL for the new target.
    /// </summary>
    [JsonPropertyName("url")]
    public string Url { get; set; } = "";
}

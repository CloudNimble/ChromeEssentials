using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Parameters for the <c>Target.createTarget</c> CDP command.
/// Creates a new page.
/// </summary>
public sealed class CreateTargetParams
{
    /// <summary>
    /// Gets or sets the initial URL the page will be navigated to. An empty string indicates about:blank.
    /// </summary>
    [JsonPropertyName("url")]
    public string Url { get; set; } = "";
}

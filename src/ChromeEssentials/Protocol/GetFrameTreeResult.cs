using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Represents the result of the <c>Page.getFrameTree</c> CDP command.
/// </summary>
public sealed class GetFrameTreeResult
{
    /// <summary>
    /// Gets or sets the frame tree starting from the main frame.
    /// </summary>
    [JsonPropertyName("frameTree")]
    public FrameTree FrameTree { get; set; } = new();
}

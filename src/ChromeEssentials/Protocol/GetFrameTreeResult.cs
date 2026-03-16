using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Represents the result of the <c>Page.getFrameTree</c> CDP command.
/// Returns present frame tree structure.
/// </summary>
public sealed class GetFrameTreeResult
{
    /// <summary>
    /// Gets or sets the present frame tree structure.
    /// </summary>
    [JsonPropertyName("frameTree")]
    public FrameTree FrameTree { get; set; } = new();
}

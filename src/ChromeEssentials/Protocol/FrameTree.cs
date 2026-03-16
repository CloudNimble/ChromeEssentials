using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Represents a frame tree structure returned by the <c>Page.getFrameTree</c> CDP command.
/// </summary>
public sealed class FrameTree
{
    /// <summary>
    /// Gets or sets the frame information.
    /// </summary>
    [JsonPropertyName("frame")]
    public FrameInfo Frame { get; set; } = new();

    /// <summary>
    /// Gets or sets the child frame trees.
    /// </summary>
    [JsonPropertyName("childFrames")]
    public FrameTree[]? ChildFrames { get; set; }
}

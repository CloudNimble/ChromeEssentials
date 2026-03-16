using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Represents a FrameTree type in the CDP protocol.
/// </summary>
public sealed class FrameTree
{
    /// <summary>
    /// Gets or sets the frame information for this tree item.
    /// </summary>
    [JsonPropertyName("frame")]
    public FrameInfo Frame { get; set; } = new();

    /// <summary>
    /// Gets or sets the child frames.
    /// </summary>
    [JsonPropertyName("childFrames")]
    public FrameTree[]? ChildFrames { get; set; }
}

using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Parameters for the <c>Input.dispatchMouseEvent</c> CDP command.
/// Dispatches a mouse event to the page.
/// </summary>
public sealed class MouseEventParams
{
    /// <summary>
    /// Gets or sets the type of the mouse event.
    /// Allowed values: <c>"mousePressed"</c>, <c>"mouseReleased"</c>, <c>"mouseMoved"</c>, <c>"mouseWheel"</c>.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "";

    /// <summary>
    /// Gets or sets the X coordinate of the event relative to the main frame's viewport in CSS pixels.
    /// </summary>
    [JsonPropertyName("x")]
    public double X { get; set; }

    /// <summary>
    /// Gets or sets the Y coordinate of the event relative to the main frame's viewport in CSS pixels.
    /// </summary>
    [JsonPropertyName("y")]
    public double Y { get; set; }

    /// <summary>
    /// Gets or sets the mouse button (default: <c>"none"</c>).
    /// </summary>
    [JsonPropertyName("button")]
    public string Button { get; set; } = "left";

    /// <summary>
    /// Gets or sets the number of times the mouse button was clicked (default: 0).
    /// </summary>
    [JsonPropertyName("clickCount")]
    public int ClickCount { get; set; } = 1;

    /// <summary>
    /// Gets or sets the bit field representing pressed modifier keys.
    /// Alt=1, Ctrl=2, Meta/Command=4, Shift=8 (default: 0).
    /// </summary>
    [JsonPropertyName("modifiers")]
    public int Modifiers { get; set; }
}

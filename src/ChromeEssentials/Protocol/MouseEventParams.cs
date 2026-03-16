using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Parameters for the <c>Input.dispatchMouseEvent</c> CDP command.
/// Dispatches a synthetic mouse event to the page.
/// </summary>
public sealed class MouseEventParams
{
    /// <summary>
    /// Gets or sets the type of mouse event (e.g., <c>"mousePressed"</c>, <c>"mouseReleased"</c>, <c>"mouseMoved"</c>).
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
    /// Gets or sets the mouse button being pressed or released (e.g., <c>"left"</c>, <c>"middle"</c>, <c>"right"</c>).
    /// Defaults to <c>"left"</c>.
    /// </summary>
    [JsonPropertyName("button")]
    public string Button { get; set; } = "left";

    /// <summary>
    /// Gets or sets the number of times the mouse button was clicked. Defaults to 1.
    /// </summary>
    [JsonPropertyName("clickCount")]
    public int ClickCount { get; set; } = 1;

    /// <summary>
    /// Gets or sets the bit field representing pressed modifier keys.
    /// 1 = Alt, 2 = Ctrl, 4 = Meta/Command, 8 = Shift.
    /// </summary>
    [JsonPropertyName("modifiers")]
    public int Modifiers { get; set; }
}

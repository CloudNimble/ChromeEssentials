using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Parameters for the <c>Emulation.setDeviceMetricsOverride</c> CDP command.
/// Overrides the values of device screen dimensions (<c>window.screen.width</c>,
/// <c>window.screen.height</c>, <c>window.innerWidth</c>, <c>window.innerHeight</c>, and
/// <c>"device-width"</c>/<c>"device-height"</c>-related CSS media query results).
/// </summary>
public sealed class SetDeviceMetricsOverrideParams
{
    /// <summary>
    /// Gets or sets the overriding width in pixels. Use 0 to disable the override.
    /// </summary>
    [JsonPropertyName("width")]
    public int Width { get; set; }

    /// <summary>
    /// Gets or sets the overriding height in pixels. Use 0 to disable the override.
    /// </summary>
    [JsonPropertyName("height")]
    public int Height { get; set; }

    /// <summary>
    /// Gets or sets the device scale factor. Use 0 to disable the override.
    /// </summary>
    [JsonPropertyName("deviceScaleFactor")]
    public double DeviceScaleFactor { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to emulate a mobile device. This includes viewport meta tag, overlay scrollbars, text autosizing, and more.
    /// </summary>
    [JsonPropertyName("mobile")]
    public bool Mobile { get; set; }
}

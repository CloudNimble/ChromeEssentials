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
    /// Gets or sets the overriding width value in pixels (minimum 0, maximum 10000000). 0 disables the override.
    /// </summary>
    [JsonPropertyName("width")]
    public int Width { get; set; }

    /// <summary>
    /// Gets or sets the overriding height value in pixels (minimum 0, maximum 10000000). 0 disables the override.
    /// </summary>
    [JsonPropertyName("height")]
    public int Height { get; set; }

    /// <summary>
    /// Gets or sets the overriding device scale factor value. 0 disables the override.
    /// </summary>
    [JsonPropertyName("deviceScaleFactor")]
    public double DeviceScaleFactor { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to emulate mobile device. This includes viewport meta tag, overlay scrollbars, text autosizing and more.
    /// </summary>
    [JsonPropertyName("mobile")]
    public bool Mobile { get; set; }
}

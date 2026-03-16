using System.Text.Json;
using CloudNimble.ChromeEssentials.Protocol;

namespace CloudNimble.ChromeEssentials.Tests;

/// <summary>
/// Unit tests for Emulation domain protocol types.
/// </summary>
[TestClass]
public sealed class EmulationTypesTests
{
    /// <summary>
    /// Verifies that SetDeviceMetricsOverrideParams serializes mobile emulation settings.
    /// </summary>
    [TestMethod]
    public void SetDeviceMetricsOverrideParams_Serializes_MobileDevice()
    {
        var metricsParams = new SetDeviceMetricsOverrideParams
        {
            Width = 375,
            Height = 812,
            DeviceScaleFactor = 3,
            Mobile = true,
        };
        var json = JsonSerializer.Serialize(metricsParams, ChromeEssentialsJsonContext.Default.SetDeviceMetricsOverrideParams);

        Assert.IsTrue(json.Contains("\"width\":375"));
        Assert.IsTrue(json.Contains("\"height\":812"));
        Assert.IsTrue(json.Contains("\"deviceScaleFactor\":3"));
        Assert.IsTrue(json.Contains("\"mobile\":true"));
    }

    /// <summary>
    /// Verifies that SetEmulatedMediaParams serializes dark mode preference.
    /// </summary>
    [TestMethod]
    public void SetEmulatedMediaParams_Serializes_DarkMode()
    {
        var mediaParams = new SetEmulatedMediaParams
        {
            Features = [new MediaFeature { Name = "prefers-color-scheme", Value = "dark" }],
        };
        var json = JsonSerializer.Serialize(mediaParams, ChromeEssentialsJsonContext.Default.SetEmulatedMediaParams);

        Assert.IsTrue(json.Contains("\"prefers-color-scheme\""));
        Assert.IsTrue(json.Contains("\"dark\""));
    }

    /// <summary>
    /// Verifies that SetGeolocationOverrideParams serializes coordinates.
    /// </summary>
    [TestMethod]
    public void SetGeolocationOverrideParams_Serializes_Coordinates()
    {
        var geoParams = new SetGeolocationOverrideParams
        {
            Latitude = 37.7749,
            Longitude = -122.4194,
            Accuracy = 100,
        };
        var json = JsonSerializer.Serialize(geoParams, ChromeEssentialsJsonContext.Default.SetGeolocationOverrideParams);

        Assert.IsTrue(json.Contains("37.7749"));
        Assert.IsTrue(json.Contains("-122.4194"));
    }
}

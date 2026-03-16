using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Parameters for the <c>Emulation.setGeolocationOverride</c> CDP command.
/// Overrides the Geolocation Position or Error. Omitting latitude, longitude or accuracy
/// emulates position unavailable.
/// </summary>
public sealed class SetGeolocationOverrideParams
{
    /// <summary>
    /// Gets or sets the mock latitude.
    /// </summary>
    [JsonPropertyName("latitude")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? Latitude { get; set; }

    /// <summary>
    /// Gets or sets the mock longitude.
    /// </summary>
    [JsonPropertyName("longitude")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? Longitude { get; set; }

    /// <summary>
    /// Gets or sets the mock accuracy.
    /// </summary>
    [JsonPropertyName("accuracy")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? Accuracy { get; set; }
}

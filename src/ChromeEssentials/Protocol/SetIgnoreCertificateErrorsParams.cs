using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Enable/disable whether all certificate errors should be ignored.
/// </summary>
public sealed class SetIgnoreCertificateErrorsParams
{
    /// <summary>
    /// If true, all certificate errors will be ignored.
    /// </summary>
    [JsonPropertyName("ignore")]
    public bool Ignore { get; set; }
}

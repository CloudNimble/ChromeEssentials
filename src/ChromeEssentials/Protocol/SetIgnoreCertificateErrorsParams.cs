using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Parameters for the <c>Security.setIgnoreCertificateErrors</c> CDP command.
/// Controls whether certificate errors should be ignored.
/// </summary>
public sealed class SetIgnoreCertificateErrorsParams
{
    /// <summary>
    /// Gets or sets a value indicating whether to ignore certificate errors.
    /// </summary>
    [JsonPropertyName("ignore")]
    public bool Ignore { get; set; }
}

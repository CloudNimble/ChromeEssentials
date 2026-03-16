using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Represents the result of the <c>Page.printToPDF</c> CDP command.
/// </summary>
public sealed class PrintToPdfResult
{
    /// <summary>
    /// Gets or sets the Base64-encoded PDF data.
    /// </summary>
    [JsonPropertyName("data")]
    public string Data { get; set; } = "";

    /// <summary>
    /// Gets or sets a stream handle for streaming transfer. Only present when <c>transferMode</c> is <c>"ReturnAsStream"</c>.
    /// </summary>
    [JsonPropertyName("stream")]
    public string? Stream { get; set; }
}

using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Parameters for the <c>Page.printToPDF</c> CDP command.
/// Print page as PDF.
/// </summary>
public sealed class PrintToPdfParams
{
    /// <summary>
    /// Gets or sets a value indicating whether to print background graphics. Defaults to <c>false</c>.
    /// </summary>
    [JsonPropertyName("printBackground")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public bool PrintBackground { get; set; }

    /// <summary>
    /// Gets or sets a value indicating paper orientation. Defaults to <c>false</c>.
    /// </summary>
    [JsonPropertyName("landscape")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public bool Landscape { get; set; }

    /// <summary>
    /// Gets or sets the paper width in inches. Defaults to 8.5 inches.
    /// </summary>
    [JsonPropertyName("paperWidth")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? PaperWidth { get; set; }

    /// <summary>
    /// Gets or sets the paper height in inches. Defaults to 11 inches.
    /// </summary>
    [JsonPropertyName("paperHeight")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? PaperHeight { get; set; }

    /// <summary>
    /// Gets or sets the top margin in inches. Defaults to ~0.4 inches.
    /// </summary>
    [JsonPropertyName("marginTop")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? MarginTop { get; set; }

    /// <summary>
    /// Gets or sets the bottom margin in inches. Defaults to ~0.4 inches.
    /// </summary>
    [JsonPropertyName("marginBottom")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? MarginBottom { get; set; }

    /// <summary>
    /// Gets or sets the left margin in inches. Defaults to ~0.4 inches.
    /// </summary>
    [JsonPropertyName("marginLeft")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? MarginLeft { get; set; }

    /// <summary>
    /// Gets or sets the right margin in inches. Defaults to ~0.4 inches.
    /// </summary>
    [JsonPropertyName("marginRight")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? MarginRight { get; set; }

    /// <summary>
    /// Gets or sets the scale of the webpage rendering. Defaults to 1.
    /// </summary>
    [JsonPropertyName("scale")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? Scale { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to display header and footer. Defaults to <c>false</c>.
    /// </summary>
    [JsonPropertyName("displayHeaderFooter")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public bool DisplayHeaderFooter { get; set; }

    /// <summary>
    /// Gets or sets the HTML template for the print header.
    /// </summary>
    [JsonPropertyName("headerTemplate")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? HeaderTemplate { get; set; }

    /// <summary>
    /// Gets or sets the HTML template for the print footer.
    /// </summary>
    [JsonPropertyName("footerTemplate")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FooterTemplate { get; set; }

    /// <summary>
    /// Gets or sets the paper ranges to print, e.g., <c>"1-5, 8, 11-13"</c>. Defaults to the empty string, which means print all pages.
    /// </summary>
    [JsonPropertyName("pageRanges")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? PageRanges { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether or not to prefer page size as defined by css. Defaults to <c>false</c>.
    /// </summary>
    [JsonPropertyName("preferCSSPageSize")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public bool PreferCSSPageSize { get; set; }
}

using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Parameters for the <c>Page.printToPDF</c> CDP command.
/// Generates a PDF of the current page.
/// </summary>
public sealed class PrintToPdfParams
{
    /// <summary>
    /// Gets or sets a value indicating whether to print the background graphics. Defaults to <c>false</c>.
    /// </summary>
    [JsonPropertyName("printBackground")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public bool PrintBackground { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to use landscape orientation. Defaults to <c>false</c>.
    /// </summary>
    [JsonPropertyName("landscape")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public bool Landscape { get; set; }

    /// <summary>
    /// Gets or sets the paper width in inches. Defaults to 8.5.
    /// </summary>
    [JsonPropertyName("paperWidth")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? PaperWidth { get; set; }

    /// <summary>
    /// Gets or sets the paper height in inches. Defaults to 11.
    /// </summary>
    [JsonPropertyName("paperHeight")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? PaperHeight { get; set; }

    /// <summary>
    /// Gets or sets the top margin in inches. Defaults to 0.4.
    /// </summary>
    [JsonPropertyName("marginTop")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? MarginTop { get; set; }

    /// <summary>
    /// Gets or sets the bottom margin in inches. Defaults to 0.4.
    /// </summary>
    [JsonPropertyName("marginBottom")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? MarginBottom { get; set; }

    /// <summary>
    /// Gets or sets the left margin in inches. Defaults to 0.4.
    /// </summary>
    [JsonPropertyName("marginLeft")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? MarginLeft { get; set; }

    /// <summary>
    /// Gets or sets the right margin in inches. Defaults to 0.4.
    /// </summary>
    [JsonPropertyName("marginRight")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? MarginRight { get; set; }

    /// <summary>
    /// Gets or sets the scale of the page rendering. Defaults to 1.
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
    /// Gets or sets the HTML template for the page header.
    /// </summary>
    [JsonPropertyName("headerTemplate")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? HeaderTemplate { get; set; }

    /// <summary>
    /// Gets or sets the HTML template for the page footer.
    /// </summary>
    [JsonPropertyName("footerTemplate")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FooterTemplate { get; set; }

    /// <summary>
    /// Gets or sets the page ranges to print (e.g., <c>"1-5, 8, 11-13"</c>). Empty string means all pages.
    /// </summary>
    [JsonPropertyName("pageRanges")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? PageRanges { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to prefer CSS page size over paper size. Defaults to <c>false</c>.
    /// </summary>
    [JsonPropertyName("preferCSSPageSize")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public bool PreferCSSPageSize { get; set; }
}

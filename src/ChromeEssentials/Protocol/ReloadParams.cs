using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Parameters for the <c>Page.reload</c> CDP command.
/// Reloads the current page.
/// </summary>
public sealed class ReloadParams
{
    /// <summary>
    /// Gets or sets a value indicating whether to bypass the cache and force a fresh load.
    /// </summary>
    [JsonPropertyName("ignoreCache")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public bool IgnoreCache { get; set; }

    /// <summary>
    /// Gets or sets a JavaScript script to inject on page load, before any page scripts run.
    /// </summary>
    [JsonPropertyName("scriptToEvaluateOnLoad")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? ScriptToEvaluateOnLoad { get; set; }
}

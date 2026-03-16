using System.Text.Json.Serialization;

namespace CloudNimble.ChromeEssentials.Protocol;

/// <summary>
/// Parameters for the <c>Page.reload</c> CDP command.
/// Reloads given page optionally ignoring the cache.
/// </summary>
public sealed class ReloadParams
{
    /// <summary>
    /// Gets or sets a value indicating whether, if true, browser cache is ignored (as if the user pressed Shift+refresh).
    /// </summary>
    [JsonPropertyName("ignoreCache")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public bool IgnoreCache { get; set; }

    /// <summary>
    /// Gets or sets the script that, if set, will be injected into all frames of the inspected page after reload.
    /// </summary>
    [JsonPropertyName("scriptToEvaluateOnLoad")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? ScriptToEvaluateOnLoad { get; set; }
}

using System.Text.Json;
using CloudNimble.ChromeEssentials.Protocol;

namespace CloudNimble.ChromeEssentials.Tests;

/// <summary>
/// Unit tests for Browser, Security, and Log domain protocol types.
/// </summary>
[TestClass]
public sealed class BrowserAndSecurityTypesTests
{
    /// <summary>
    /// Verifies that BrowserVersionResult deserializes version information.
    /// </summary>
    [TestMethod]
    public void BrowserVersionResult_Deserializes_VersionInfo()
    {
        var json = """{"protocolVersion":"1.3","product":"Chrome/120.0.6099.109","jsVersion":"12.0.267.8","userAgent":"Mozilla/5.0","revision":"@abc123"}""";
        var result = JsonSerializer.Deserialize(json, ChromeEssentialsJsonContext.Default.BrowserVersionResult);

        Assert.IsNotNull(result);
        Assert.AreEqual("1.3", result.ProtocolVersion);
        Assert.AreEqual("Chrome/120.0.6099.109", result.Product);
        Assert.AreEqual("12.0.267.8", result.JsVersion);
    }

    /// <summary>
    /// Verifies that SetIgnoreCertificateErrorsParams serializes correctly.
    /// </summary>
    [TestMethod]
    public void SetIgnoreCertificateErrorsParams_Serializes()
    {
        var certParams = new SetIgnoreCertificateErrorsParams { Ignore = true };
        var json = JsonSerializer.Serialize(certParams, ChromeEssentialsJsonContext.Default.SetIgnoreCertificateErrorsParams);

        Assert.IsTrue(json.Contains("\"ignore\":true"));
    }

    /// <summary>
    /// Verifies that LogEntry deserializes log entry data.
    /// </summary>
    [TestMethod]
    public void LogEntryAddedParams_Deserializes_Entry()
    {
        var json = """{"entry":{"source":"network","level":"error","text":"Failed to load resource","timestamp":1234567890.123,"url":"https://example.com/missing.js"}}""";
        var result = JsonSerializer.Deserialize(json, ChromeEssentialsJsonContext.Default.LogEntryAddedParams);

        Assert.IsNotNull(result);
        Assert.AreEqual("network", result.Entry.Source);
        Assert.AreEqual("error", result.Entry.Level);
        Assert.AreEqual("Failed to load resource", result.Entry.Text);
        Assert.AreEqual("https://example.com/missing.js", result.Entry.Url);
    }

    /// <summary>
    /// Verifies that KeyEventParams serializes keyboard input.
    /// </summary>
    [TestMethod]
    public void KeyEventParams_Serializes_EnterKey()
    {
        var keyParams = new KeyEventParams
        {
            Type = "keyDown",
            Key = "Enter",
            Code = "Enter",
            WindowsVirtualKeyCode = 13,
            NativeVirtualKeyCode = 13,
            Text = "\r",
        };
        var json = JsonSerializer.Serialize(keyParams, ChromeEssentialsJsonContext.Default.KeyEventParams);

        Assert.IsTrue(json.Contains("\"type\":\"keyDown\""));
        Assert.IsTrue(json.Contains("\"key\":\"Enter\""));
        Assert.IsTrue(json.Contains("\"windowsVirtualKeyCode\":13"));
    }

    /// <summary>
    /// Verifies that ConsoleApiCalledParams deserializes console event.
    /// </summary>
    [TestMethod]
    public void ConsoleApiCalledParams_Deserializes_LogEvent()
    {
        var json = """{"type":"log","args":[{"type":"string","value":"hello world"}],"executionContextId":1,"timestamp":1234567890.0}""";
        var result = JsonSerializer.Deserialize(json, ChromeEssentialsJsonContext.Default.ConsoleApiCalledParams);

        Assert.IsNotNull(result);
        Assert.AreEqual("log", result.Type);
        Assert.AreEqual(1, result.Args.Length);
        Assert.AreEqual("string", result.Args[0].Type);
    }

    /// <summary>
    /// Verifies that CdpResponse deserializes sessionId for session-scoped events.
    /// </summary>
    [TestMethod]
    public void CdpResponse_Deserializes_SessionId()
    {
        var json = """{"method":"Page.loadEventFired","params":{"timestamp":12345.6},"sessionId":"session-abc"}""";
        var response = JsonSerializer.Deserialize(json, ChromeEssentialsJsonContext.Default.CdpResponse);

        Assert.IsNotNull(response);
        Assert.AreEqual("session-abc", response.SessionId);
        Assert.AreEqual("Page.loadEventFired", response.Method);
    }
}

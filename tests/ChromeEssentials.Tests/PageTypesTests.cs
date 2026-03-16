using System.Text.Json;
using CloudNimble.ChromeEssentials.Protocol;

namespace CloudNimble.ChromeEssentials.Tests;

/// <summary>
/// Unit tests for Page domain protocol types.
/// </summary>
[TestClass]
public sealed class PageTypesTests
{
    /// <summary>
    /// Verifies that PrintToPdfParams serializes with non-default values.
    /// </summary>
    [TestMethod]
    public void PrintToPdfParams_Serializes_CustomSettings()
    {
        var pdfParams = new PrintToPdfParams
        {
            PrintBackground = true,
            Landscape = true,
            PaperWidth = 11,
            PaperHeight = 8.5,
        };
        var json = JsonSerializer.Serialize(pdfParams, ChromeEssentialsJsonContext.Default.PrintToPdfParams);

        Assert.IsTrue(json.Contains("\"printBackground\":true"));
        Assert.IsTrue(json.Contains("\"landscape\":true"));
        Assert.IsTrue(json.Contains("\"paperWidth\":11"));
    }

    /// <summary>
    /// Verifies that PrintToPdfResult deserializes Base64 data.
    /// </summary>
    [TestMethod]
    public void PrintToPdfResult_Deserializes_Data()
    {
        var json = """{"data":"JVBERi0xLjQ="}""";
        var result = JsonSerializer.Deserialize(json, ChromeEssentialsJsonContext.Default.PrintToPdfResult);

        Assert.IsNotNull(result);
        Assert.AreEqual("JVBERi0xLjQ=", result.Data);
    }

    /// <summary>
    /// Verifies that HandleJavaScriptDialogParams serializes accept and prompt text.
    /// </summary>
    [TestMethod]
    public void HandleJavaScriptDialogParams_Serializes_WithPromptText()
    {
        var dialogParams = new HandleJavaScriptDialogParams { Accept = true, PromptText = "user input" };
        var json = JsonSerializer.Serialize(dialogParams, ChromeEssentialsJsonContext.Default.HandleJavaScriptDialogParams);

        Assert.IsTrue(json.Contains("\"accept\":true"));
        Assert.IsTrue(json.Contains("\"promptText\":\"user input\""));
    }

    /// <summary>
    /// Verifies that JavaScriptDialogOpeningParams deserializes event data.
    /// </summary>
    [TestMethod]
    public void JavaScriptDialogOpeningParams_Deserializes_Event()
    {
        var json = """{"url":"https://test.com","message":"Are you sure?","type":"confirm","hasBrowserHandler":false}""";
        var result = JsonSerializer.Deserialize(json, ChromeEssentialsJsonContext.Default.JavaScriptDialogOpeningParams);

        Assert.IsNotNull(result);
        Assert.AreEqual("confirm", result.Type);
        Assert.AreEqual("Are you sure?", result.Message);
    }

    /// <summary>
    /// Verifies that ScreenshotParams serializes with clip region.
    /// </summary>
    [TestMethod]
    public void ScreenshotParams_Serializes_WithClip()
    {
        var screenshotParams = new ScreenshotParams
        {
            Format = "jpeg",
            Quality = 80,
            Clip = new ViewportClip { X = 0, Y = 0, Width = 800, Height = 600 },
        };
        var json = JsonSerializer.Serialize(screenshotParams, ChromeEssentialsJsonContext.Default.ScreenshotParams);

        Assert.IsTrue(json.Contains("\"format\":\"jpeg\""));
        Assert.IsTrue(json.Contains("\"quality\":80"));
        Assert.IsTrue(json.Contains("\"width\":800"));
    }

    /// <summary>
    /// Verifies that GetFrameTreeResult deserializes frame hierarchy.
    /// </summary>
    [TestMethod]
    public void GetFrameTreeResult_Deserializes_FrameHierarchy()
    {
        var json = """{"frameTree":{"frame":{"id":"main","url":"https://example.com","securityOrigin":"https://example.com","mimeType":"text/html"},"childFrames":[{"frame":{"id":"iframe1","parentId":"main","url":"https://ads.example.com","securityOrigin":"https://ads.example.com","mimeType":"text/html"}}]}}""";
        var result = JsonSerializer.Deserialize(json, ChromeEssentialsJsonContext.Default.GetFrameTreeResult);

        Assert.IsNotNull(result);
        Assert.AreEqual("main", result.FrameTree.Frame.Id);
        Assert.IsNotNull(result.FrameTree.ChildFrames);
        Assert.AreEqual(1, result.FrameTree.ChildFrames.Length);
        Assert.AreEqual("iframe1", result.FrameTree.ChildFrames[0].Frame.Id);
    }

    /// <summary>
    /// Verifies that AddScriptToEvaluateOnNewDocumentResult deserializes the identifier.
    /// </summary>
    [TestMethod]
    public void AddScriptToEvaluateOnNewDocumentResult_Deserializes_Identifier()
    {
        var json = """{"identifier":"script-1"}""";
        var result = JsonSerializer.Deserialize(json, ChromeEssentialsJsonContext.Default.AddScriptToEvaluateOnNewDocumentResult);

        Assert.IsNotNull(result);
        Assert.AreEqual("script-1", result.Identifier);
    }
}

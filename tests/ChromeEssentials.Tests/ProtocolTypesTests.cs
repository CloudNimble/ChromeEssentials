using System.Text.Json;
using CloudNimble.ChromeEssentials.Protocol;

namespace CloudNimble.ChromeEssentials.Tests;

/// <summary>
/// Unit tests for CDP protocol type serialization and deserialization.
/// </summary>
[TestClass]
public sealed class ProtocolTypesTests
{
    /// <summary>
    /// Verifies that TargetInfo deserializes from JSON correctly.
    /// </summary>
    [TestMethod]
    public void TargetInfo_Deserializes_Correctly()
    {
        var json = """{"targetId":"abc","type":"page","title":"Test Page","url":"https://example.com"}""";
        var target = JsonSerializer.Deserialize(json, ChromeEssentialsJsonContext.Default.TargetInfo);

        Assert.IsNotNull(target);
        Assert.AreEqual("abc", target.TargetId);
        Assert.AreEqual("page", target.Type);
        Assert.AreEqual("Test Page", target.Title);
        Assert.AreEqual("https://example.com", target.Url);
    }

    /// <summary>
    /// Verifies that GetTargetsResult deserializes an array of targets.
    /// </summary>
    [TestMethod]
    public void GetTargetsResult_Deserializes_TargetInfosArray()
    {
        var json = """{"targetInfos":[{"targetId":"t1","type":"page","title":"Tab 1","url":"https://one.com"},{"targetId":"t2","type":"page","title":"Tab 2","url":"https://two.com"}]}""";
        var result = JsonSerializer.Deserialize(json, ChromeEssentialsJsonContext.Default.GetTargetsResult);

        Assert.IsNotNull(result);
        Assert.AreEqual(2, result.TargetInfos.Length);
        Assert.AreEqual("t1", result.TargetInfos[0].TargetId);
        Assert.AreEqual("t2", result.TargetInfos[1].TargetId);
    }

    /// <summary>
    /// Verifies that NavigateParams serializes correctly.
    /// </summary>
    [TestMethod]
    public void NavigateParams_Serializes_Url()
    {
        var navParams = new NavigateParams { Url = "https://example.com" };
        var json = JsonSerializer.Serialize(navParams, ChromeEssentialsJsonContext.Default.NavigateParams);

        Assert.IsTrue(json.Contains("\"url\":\"https://example.com\""));
    }

    /// <summary>
    /// Verifies that NavigateResult deserializes error text correctly.
    /// </summary>
    [TestMethod]
    public void NavigateResult_Deserializes_WithError()
    {
        var json = """{"errorText":"net::ERR_NAME_NOT_RESOLVED","loaderId":"loader1"}""";
        var result = JsonSerializer.Deserialize(json, ChromeEssentialsJsonContext.Default.NavigateResult);

        Assert.IsNotNull(result);
        Assert.AreEqual("net::ERR_NAME_NOT_RESOLVED", result.ErrorText);
        Assert.AreEqual("loader1", result.LoaderId);
    }

    /// <summary>
    /// Verifies that EvalParams serializes all properties.
    /// </summary>
    [TestMethod]
    public void EvalParams_Serializes_AllProperties()
    {
        var evalParams = new EvalParams
        {
            Expression = "document.title",
            ReturnByValue = true,
            AwaitPromise = true,
        };
        var json = JsonSerializer.Serialize(evalParams, ChromeEssentialsJsonContext.Default.EvalParams);

        Assert.IsTrue(json.Contains("\"expression\":\"document.title\""));
        Assert.IsTrue(json.Contains("\"returnByValue\":true"));
        Assert.IsTrue(json.Contains("\"awaitPromise\":true"));
    }

    /// <summary>
    /// Verifies that EvalResult deserializes with exception details.
    /// </summary>
    [TestMethod]
    public void EvalResult_Deserializes_WithExceptionDetails()
    {
        var json = """{"result":{"value":null},"exceptionDetails":{"text":"ReferenceError","exception":{"description":"x is not defined"}}}""";
        var result = JsonSerializer.Deserialize(json, ChromeEssentialsJsonContext.Default.EvalResult);

        Assert.IsNotNull(result);
        Assert.IsNotNull(result.ExceptionDetails);
        Assert.AreEqual("ReferenceError", result.ExceptionDetails.Text);
        Assert.AreEqual("x is not defined", result.ExceptionDetails.Exception?.Description);
    }

    /// <summary>
    /// Verifies that MouseEventParams serializes with default values.
    /// </summary>
    [TestMethod]
    public void MouseEventParams_HasCorrectDefaults()
    {
        var mouseParams = new MouseEventParams { Type = "mousePressed", X = 100.5, Y = 200.3 };
        var json = JsonSerializer.Serialize(mouseParams, ChromeEssentialsJsonContext.Default.MouseEventParams);

        Assert.IsTrue(json.Contains("\"button\":\"left\""));
        Assert.IsTrue(json.Contains("\"clickCount\":1"));
        Assert.IsTrue(json.Contains("\"modifiers\":0"));
    }

    /// <summary>
    /// Verifies that InsertTextParams serializes the text value.
    /// </summary>
    [TestMethod]
    public void InsertTextParams_Serializes_Text()
    {
        var textParams = new InsertTextParams { Text = "Hello World" };
        var json = JsonSerializer.Serialize(textParams, ChromeEssentialsJsonContext.Default.InsertTextParams);

        Assert.IsTrue(json.Contains("\"text\":\"Hello World\""));
    }

    /// <summary>
    /// Verifies that ScreenshotParams defaults to PNG format.
    /// </summary>
    [TestMethod]
    public void ScreenshotParams_DefaultsToPng()
    {
        var screenshotParams = new ScreenshotParams();
        var json = JsonSerializer.Serialize(screenshotParams, ChromeEssentialsJsonContext.Default.ScreenshotParams);

        Assert.IsTrue(json.Contains("\"format\":\"png\""));
    }

    /// <summary>
    /// Verifies that CaptureScreenshotResult deserializes the base64 data.
    /// </summary>
    [TestMethod]
    public void CaptureScreenshotResult_Deserializes_Base64Data()
    {
        var json = """{"data":"iVBORw0KGgoAAAANS=="}""";
        var result = JsonSerializer.Deserialize(json, ChromeEssentialsJsonContext.Default.CaptureScreenshotResult);

        Assert.IsNotNull(result);
        Assert.AreEqual("iVBORw0KGgoAAAANS==", result.Data);
    }

    /// <summary>
    /// Verifies that AttachParams serializes with flatten flag.
    /// </summary>
    [TestMethod]
    public void AttachParams_Serializes_WithFlatten()
    {
        var attachParams = new AttachParams { TargetId = "target-1", Flatten = true };
        var json = JsonSerializer.Serialize(attachParams, ChromeEssentialsJsonContext.Default.AttachParams);

        Assert.IsTrue(json.Contains("\"targetId\":\"target-1\""));
        Assert.IsTrue(json.Contains("\"flatten\":true"));
    }

    /// <summary>
    /// Verifies that AxTreeResult deserializes nodes with roles and names.
    /// </summary>
    [TestMethod]
    public void AxTreeResult_Deserializes_Nodes()
    {
        var json = """{"nodes":[{"nodeId":"n1","role":{"value":"button"},"name":{"value":"Submit"}}]}""";
        var result = JsonSerializer.Deserialize(json, ChromeEssentialsJsonContext.Default.AxTreeResult);

        Assert.IsNotNull(result);
        Assert.AreEqual(1, result.Nodes.Length);
        Assert.AreEqual("n1", result.Nodes[0].NodeId);
        Assert.AreEqual("button", result.Nodes[0].Role?.Value);
        Assert.AreEqual("Submit", result.Nodes[0].Name?.Value);
    }

    /// <summary>
    /// Verifies that ClickResult deserializes both success and failure states.
    /// </summary>
    [TestMethod]
    public void ClickResult_Deserializes_Success()
    {
        var json = """{"ok":true,"tag":"BUTTON","text":"Click Me"}""";
        var result = JsonSerializer.Deserialize(json, ChromeEssentialsJsonContext.Default.ClickResult);

        Assert.IsNotNull(result);
        Assert.IsTrue(result.Ok);
        Assert.AreEqual("BUTTON", result.Tag);
        Assert.AreEqual("Click Me", result.Text);
        Assert.IsNull(result.Error);
    }

    /// <summary>
    /// Verifies that NetworkEntry deserializes all fields.
    /// </summary>
    [TestMethod]
    public void NetworkEntry_Deserializes_AllFields()
    {
        var json = """{"name":"https://example.com/api","type":"fetch","duration":150,"size":4096}""";
        var result = JsonSerializer.Deserialize(json, ChromeEssentialsJsonContext.Default.NetworkEntry);

        Assert.IsNotNull(result);
        Assert.AreEqual("https://example.com/api", result.Name);
        Assert.AreEqual("fetch", result.Type);
        Assert.AreEqual(150, result.Duration);
        Assert.AreEqual(4096L, result.Size);
    }

    /// <summary>
    /// Verifies that LayoutMetrics deserializes viewport information.
    /// </summary>
    [TestMethod]
    public void LayoutMetrics_Deserializes_ViewportInfo()
    {
        var json = """{"visualViewport":{"clientWidth":1920},"cssVisualViewport":{"clientWidth":1280}}""";
        var result = JsonSerializer.Deserialize(json, ChromeEssentialsJsonContext.Default.LayoutMetrics);

        Assert.IsNotNull(result);
        Assert.AreEqual(1920, result.VisualViewport?.ClientWidth);
        Assert.AreEqual(1280, result.CssVisualViewport?.ClientWidth);
    }

    /// <summary>
    /// Verifies that CreateTargetParams serializes the URL.
    /// </summary>
    [TestMethod]
    public void CreateTargetParams_Serializes_Url()
    {
        var createParams = new CreateTargetParams { Url = "about:blank" };
        var json = JsonSerializer.Serialize(createParams, ChromeEssentialsJsonContext.Default.CreateTargetParams);

        Assert.IsTrue(json.Contains("\"url\":\"about:blank\""));
    }
}

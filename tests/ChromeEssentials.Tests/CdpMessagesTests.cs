using System.Text.Json;
using CloudNimble.ChromeEssentials.Protocol;

namespace CloudNimble.ChromeEssentials.Tests;

/// <summary>
/// Unit tests for CDP message serialization and deserialization.
/// </summary>
[TestClass]
public sealed class CdpMessagesTests
{
    /// <summary>
    /// Verifies that a CdpRequest serializes correctly with the AOT-compatible context.
    /// </summary>
    [TestMethod]
    public void CdpRequest_Serializes_WithMethodAndId()
    {
        var request = new CdpRequest { Id = 1, Method = "Page.navigate" };
        var json = JsonSerializer.Serialize(request, ChromeEssentialsJsonContext.Default.CdpRequest);

        Assert.IsTrue(json.Contains("\"id\":1"));
        Assert.IsTrue(json.Contains("\"method\":\"Page.navigate\""));
    }

    /// <summary>
    /// Verifies that null Params and SessionId are omitted from serialized output.
    /// </summary>
    [TestMethod]
    public void CdpRequest_OmitsNullParams_WhenNotSet()
    {
        var request = new CdpRequest { Id = 1, Method = "Page.enable" };
        var json = JsonSerializer.Serialize(request, ChromeEssentialsJsonContext.Default.CdpRequest);

        Assert.IsFalse(json.Contains("\"params\""));
        Assert.IsFalse(json.Contains("\"sessionId\""));
    }

    /// <summary>
    /// Verifies that a CdpRequest with Params serializes them correctly.
    /// </summary>
    [TestMethod]
    public void CdpRequest_Serializes_WithParams()
    {
        var paramsJson = JsonSerializer.SerializeToElement(new { url = "https://example.com" });
        var request = new CdpRequest { Id = 2, Method = "Page.navigate", Params = paramsJson };
        var json = JsonSerializer.Serialize(request, ChromeEssentialsJsonContext.Default.CdpRequest);

        Assert.IsTrue(json.Contains("\"params\""));
        Assert.IsTrue(json.Contains("https://example.com"));
    }

    /// <summary>
    /// Verifies that a CdpResponse with an error deserializes correctly.
    /// </summary>
    [TestMethod]
    public void CdpResponse_Deserializes_WithError()
    {
        var json = """{"id":1,"error":{"message":"Not found"}}""";
        var response = JsonSerializer.Deserialize(json, ChromeEssentialsJsonContext.Default.CdpResponse);

        Assert.IsNotNull(response);
        Assert.AreEqual(1, response.Id);
        Assert.IsNotNull(response.Error);
        Assert.AreEqual("Not found", response.Error.Message);
    }

    /// <summary>
    /// Verifies that a CdpResponse representing an event deserializes correctly.
    /// </summary>
    [TestMethod]
    public void CdpResponse_Deserializes_AsEvent()
    {
        var json = """{"method":"Page.loadEventFired","params":{"timestamp":12345.6}}""";
        var response = JsonSerializer.Deserialize(json, ChromeEssentialsJsonContext.Default.CdpResponse);

        Assert.IsNotNull(response);
        Assert.AreEqual("Page.loadEventFired", response.Method);
        Assert.AreEqual(0, response.Id);
    }

    /// <summary>
    /// Verifies that CdpRequest with a SessionId includes it in serialized output.
    /// </summary>
    [TestMethod]
    public void CdpRequest_Serializes_WithSessionId()
    {
        var request = new CdpRequest { Id = 3, Method = "Runtime.evaluate", SessionId = "session-123" };
        var json = JsonSerializer.Serialize(request, ChromeEssentialsJsonContext.Default.CdpRequest);

        Assert.IsTrue(json.Contains("\"sessionId\":\"session-123\""));
    }
}

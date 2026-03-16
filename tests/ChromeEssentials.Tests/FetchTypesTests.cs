using System.Text.Json;
using CloudNimble.ChromeEssentials.Protocol;

namespace CloudNimble.ChromeEssentials.Tests;

/// <summary>
/// Unit tests for Fetch domain protocol types.
/// </summary>
[TestClass]
public sealed class FetchTypesTests
{
    /// <summary>
    /// Verifies that FetchEnableParams serializes with patterns.
    /// </summary>
    [TestMethod]
    public void FetchEnableParams_Serializes_WithPatterns()
    {
        var enableParams = new FetchEnableParams
        {
            Patterns = [new RequestPattern { UrlPattern = "*.js", RequestStage = "Request" }],
        };
        var json = JsonSerializer.Serialize(enableParams, ChromeEssentialsJsonContext.Default.FetchEnableParams);

        Assert.IsTrue(json.Contains("\"urlPattern\":\"*.js\""));
        Assert.IsTrue(json.Contains("\"requestStage\":\"Request\""));
    }

    /// <summary>
    /// Verifies that FulfillRequestParams serializes a mock response.
    /// </summary>
    [TestMethod]
    public void FulfillRequestParams_Serializes_MockResponse()
    {
        var fulfillParams = new FulfillRequestParams
        {
            RequestId = "req-1",
            ResponseCode = 200,
            ResponseHeaders = [new HeaderEntry { Name = "Content-Type", Value = "application/json" }],
            Body = Convert.ToBase64String("{\"mock\":true}"u8),
        };
        var json = JsonSerializer.Serialize(fulfillParams, ChromeEssentialsJsonContext.Default.FulfillRequestParams);

        Assert.IsTrue(json.Contains("\"responseCode\":200"));
        Assert.IsTrue(json.Contains("\"Content-Type\""));
    }

    /// <summary>
    /// Verifies that FailRequestParams serializes the error reason.
    /// </summary>
    [TestMethod]
    public void FailRequestParams_Serializes_Reason()
    {
        var failParams = new FailRequestParams { RequestId = "req-2", Reason = "BlockedByClient" };
        var json = JsonSerializer.Serialize(failParams, ChromeEssentialsJsonContext.Default.FailRequestParams);

        Assert.IsTrue(json.Contains("\"reason\":\"BlockedByClient\""));
    }

    /// <summary>
    /// Verifies that RequestPausedParams deserializes intercepted request data.
    /// </summary>
    [TestMethod]
    public void RequestPausedParams_Deserializes_InterceptedRequest()
    {
        var json = """{"requestId":"int-1","request":{"url":"https://api.example.com/data","method":"GET","headers":{}},"frameId":"frame-1","resourceType":"Fetch"}""";
        var result = JsonSerializer.Deserialize(json, ChromeEssentialsJsonContext.Default.RequestPausedParams);

        Assert.IsNotNull(result);
        Assert.AreEqual("int-1", result.RequestId);
        Assert.AreEqual("https://api.example.com/data", result.Request.Url);
        Assert.AreEqual("Fetch", result.ResourceType);
    }
}

using System.Text.Json;
using CloudNimble.ChromeEssentials.Protocol;

namespace CloudNimble.ChromeEssentials.Tests;

/// <summary>
/// Unit tests for Network domain protocol types.
/// </summary>
[TestClass]
public sealed class NetworkTypesTests
{
    /// <summary>
    /// Verifies that SetCookieParams serializes all properties correctly.
    /// </summary>
    [TestMethod]
    public void SetCookieParams_Serializes_AllProperties()
    {
        var cookieParams = new SetCookieParams
        {
            Name = "session",
            Value = "abc123",
            Domain = ".example.com",
            Path = "/",
            Secure = true,
            HttpOnly = true,
            SameSite = "Strict",
        };
        var json = JsonSerializer.Serialize(cookieParams, ChromeEssentialsJsonContext.Default.SetCookieParams);

        Assert.IsTrue(json.Contains("\"name\":\"session\""));
        Assert.IsTrue(json.Contains("\"value\":\"abc123\""));
        Assert.IsTrue(json.Contains("\"domain\":\".example.com\""));
        Assert.IsTrue(json.Contains("\"secure\":true"));
        Assert.IsTrue(json.Contains("\"httpOnly\":true"));
        Assert.IsTrue(json.Contains("\"sameSite\":\"Strict\""));
    }

    /// <summary>
    /// Verifies that GetCookiesResult deserializes cookie arrays.
    /// </summary>
    [TestMethod]
    public void GetCookiesResult_Deserializes_CookieArray()
    {
        var json = """{"cookies":[{"name":"sid","value":"xyz","domain":".test.com","path":"/","expires":0,"size":6,"httpOnly":false,"secure":false,"session":true}]}""";
        var result = JsonSerializer.Deserialize(json, ChromeEssentialsJsonContext.Default.GetCookiesResult);

        Assert.IsNotNull(result);
        Assert.AreEqual(1, result.Cookies.Length);
        Assert.AreEqual("sid", result.Cookies[0].Name);
        Assert.AreEqual("xyz", result.Cookies[0].Value);
        Assert.IsTrue(result.Cookies[0].Session);
    }

    /// <summary>
    /// Verifies that ResponseInfo deserializes HTTP response information.
    /// </summary>
    [TestMethod]
    public void ResponseInfo_Deserializes_HttpResponse()
    {
        var json = """{"url":"https://example.com","status":200,"statusText":"OK","headers":{"content-type":"text/html"},"mimeType":"text/html"}""";
        var result = JsonSerializer.Deserialize(json, ChromeEssentialsJsonContext.Default.ResponseInfo);

        Assert.IsNotNull(result);
        Assert.AreEqual(200, result.Status);
        Assert.AreEqual("OK", result.StatusText);
        Assert.AreEqual("text/html", result.MimeType);
        Assert.AreEqual("text/html", result.Headers["content-type"]);
    }

    /// <summary>
    /// Verifies that GetResponseBodyResult deserializes correctly.
    /// </summary>
    [TestMethod]
    public void GetResponseBodyResult_Deserializes_Body()
    {
        var json = """{"body":"<html></html>","base64Encoded":false}""";
        var result = JsonSerializer.Deserialize(json, ChromeEssentialsJsonContext.Default.GetResponseBodyResult);

        Assert.IsNotNull(result);
        Assert.AreEqual("<html></html>", result.Body);
        Assert.IsFalse(result.Base64Encoded);
    }

    /// <summary>
    /// Verifies that SetExtraHTTPHeadersParams serializes headers dictionary.
    /// </summary>
    [TestMethod]
    public void SetExtraHTTPHeadersParams_Serializes_Headers()
    {
        var headersParams = new SetExtraHTTPHeadersParams
        {
            Headers = new Dictionary<string, string> { ["Authorization"] = "Bearer token123" },
        };
        var json = JsonSerializer.Serialize(headersParams, ChromeEssentialsJsonContext.Default.SetExtraHTTPHeadersParams);

        Assert.IsTrue(json.Contains("\"Authorization\":\"Bearer token123\""));
    }

    /// <summary>
    /// Verifies that LoadingFailedParams deserializes error information.
    /// </summary>
    [TestMethod]
    public void LoadingFailedParams_Deserializes_Error()
    {
        var json = """{"requestId":"req1","timestamp":123.4,"type":"Document","errorText":"net::ERR_CONNECTION_REFUSED","canceled":false}""";
        var result = JsonSerializer.Deserialize(json, ChromeEssentialsJsonContext.Default.LoadingFailedParams);

        Assert.IsNotNull(result);
        Assert.AreEqual("req1", result.RequestId);
        Assert.AreEqual("net::ERR_CONNECTION_REFUSED", result.ErrorText);
        Assert.IsFalse(result.Canceled);
    }
}

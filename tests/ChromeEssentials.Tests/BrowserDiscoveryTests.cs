namespace CloudNimble.ChromeEssentials.Tests;

/// <summary>
/// Unit tests for the <see cref="BrowserDiscovery"/> class.
/// </summary>
[TestClass]
public sealed class BrowserDiscoveryTests
{
    /// <summary>
    /// Verifies that GetWsUrl throws CdpException when no browser is running
    /// and no override environment variable is set.
    /// </summary>
    [TestMethod]
    public void GetWsUrl_ThrowsCdpException_WhenNoBrowserFound()
    {
        // Clear any override
        Environment.SetEnvironmentVariable("CDP_PORT_FILE", null);

        var ex = Assert.ThrowsExactly<CdpException>(BrowserDiscovery.GetWsUrl);
        Assert.IsTrue(ex.Message.Contains("No DevToolsActivePort found"));
    }

    /// <summary>
    /// Verifies that GetWsUrl uses the CDP_PORT_FILE environment variable override.
    /// </summary>
    [TestMethod]
    public void GetWsUrl_UsesEnvironmentVariable_WhenSet()
    {
        var tempFile = Path.GetTempFileName();
        try
        {
            File.WriteAllText(tempFile, "9222\n/devtools/browser/abc-123");
            Environment.SetEnvironmentVariable("CDP_PORT_FILE", tempFile);

            var wsUrl = BrowserDiscovery.GetWsUrl();

            Assert.AreEqual("ws://127.0.0.1:9222/devtools/browser/abc-123", wsUrl);
        }
        finally
        {
            Environment.SetEnvironmentVariable("CDP_PORT_FILE", null);
            File.Delete(tempFile);
        }
    }

    /// <summary>
    /// Verifies that GetWsUrl throws CdpException for an invalid DevToolsActivePort file.
    /// </summary>
    [TestMethod]
    public void GetWsUrl_ThrowsCdpException_ForInvalidPortFile()
    {
        var tempFile = Path.GetTempFileName();
        try
        {
            File.WriteAllText(tempFile, "invalid-single-line");
            Environment.SetEnvironmentVariable("CDP_PORT_FILE", tempFile);

            var ex = Assert.ThrowsExactly<CdpException>(BrowserDiscovery.GetWsUrl);
            Assert.IsTrue(ex.Message.Contains("Invalid DevToolsActivePort file"));
        }
        finally
        {
            Environment.SetEnvironmentVariable("CDP_PORT_FILE", null);
            File.Delete(tempFile);
        }
    }

    /// <summary>
    /// Verifies that GetWsUrl throws CdpException when the port file has empty lines.
    /// </summary>
    [TestMethod]
    public void GetWsUrl_ThrowsCdpException_ForEmptyLines()
    {
        var tempFile = Path.GetTempFileName();
        try
        {
            File.WriteAllText(tempFile, "\n");
            Environment.SetEnvironmentVariable("CDP_PORT_FILE", tempFile);

            var ex = Assert.ThrowsExactly<CdpException>(BrowserDiscovery.GetWsUrl);
            Assert.IsTrue(ex.Message.Contains("Invalid DevToolsActivePort file"));
        }
        finally
        {
            Environment.SetEnvironmentVariable("CDP_PORT_FILE", null);
            File.Delete(tempFile);
        }
    }
}

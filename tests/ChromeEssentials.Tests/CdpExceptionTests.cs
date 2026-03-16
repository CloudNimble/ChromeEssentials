namespace CloudNimble.ChromeEssentials.Tests;

/// <summary>
/// Unit tests for the <see cref="CdpException"/> class.
/// </summary>
[TestClass]
public sealed class CdpExceptionTests
{
    /// <summary>
    /// Verifies that the exception message is correctly assigned.
    /// </summary>
    [TestMethod]
    public void Constructor_SetsMessage()
    {
        var ex = new CdpException("test error");
        Assert.AreEqual("test error", ex.Message);
    }

    /// <summary>
    /// Verifies that CdpException derives from Exception.
    /// </summary>
    [TestMethod]
    public void CdpException_IsException()
    {
        var ex = new CdpException("fail");
        Assert.IsInstanceOfType<Exception>(ex);
    }
}

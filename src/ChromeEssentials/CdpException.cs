namespace CloudNimble.ChromeEssentials;

/// <summary>
/// Represents an error that occurred while communicating with a browser via the Chrome DevTools Protocol.
/// This exception is thrown for connection failures, command errors, and timeout conditions.
/// </summary>
/// <param name="message">A message describing the CDP error.</param>
public sealed class CdpException(string message) : Exception(message);

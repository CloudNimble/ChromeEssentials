namespace CloudNimble.ChromeEssentials;

/// <summary>
/// Provides methods for discovering Chrome-based browser instances with remote debugging enabled.
/// Searches for the DevToolsActivePort file across multiple browsers and platforms.
/// </summary>
public static class BrowserDiscovery
{
    /// <summary>
    /// Finds the Chrome DevTools WebSocket URL by locating the DevToolsActivePort file.
    /// Searches Chrome, Chromium, Brave, Edge, and Vivaldi on macOS, Linux, and Windows.
    /// Set the <c>CDP_PORT_FILE</c> environment variable to override with a custom path.
    /// </summary>
    /// <returns>The WebSocket URL (e.g., <c>ws://127.0.0.1:9222/devtools/browser/...</c>) to connect to Chrome DevTools.</returns>
    /// <exception cref="CdpException">Thrown when no DevToolsActivePort file is found or the file content is invalid.</exception>
    public static string GetWsUrl()
    {
        var home = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        var candidates = new List<string>();

        // Explicit override via environment variable
        var envPath = Environment.GetEnvironmentVariable("CDP_PORT_FILE");
        if (!string.IsNullOrEmpty(envPath))
            candidates.Add(envPath);

        if (OperatingSystem.IsMacOS())
        {
            string[] macBrowsers =
            [
                "Google/Chrome", "Google/Chrome Beta", "Google/Chrome for Testing",
                "Chromium", "BraveSoftware/Brave-Browser", "Microsoft Edge",
            ];
            foreach (var b in macBrowsers)
            {
                candidates.Add(Path.Combine(home, "Library/Application Support", b, "DevToolsActivePort"));
                candidates.Add(Path.Combine(home, "Library/Application Support", b, "Default/DevToolsActivePort"));
            }
        }

        if (OperatingSystem.IsLinux())
        {
            string[] linuxBrowsers =
            [
                "google-chrome", "google-chrome-beta", "chromium",
                "vivaldi", "vivaldi-snapshot",
                "BraveSoftware/Brave-Browser", "microsoft-edge",
            ];
            foreach (var b in linuxBrowsers)
            {
                candidates.Add(Path.Combine(home, ".config", b, "DevToolsActivePort"));
                candidates.Add(Path.Combine(home, ".config", b, "Default/DevToolsActivePort"));
            }
        }

        if (OperatingSystem.IsWindows())
        {
            string[] windowsBrowsers =
            [
                "Google/Chrome", "BraveSoftware/Brave-Browser", "Microsoft/Edge",
            ];
            foreach (var b in windowsBrowsers)
            {
                candidates.Add(Path.Combine(home, "AppData/Local", b, "User Data/DevToolsActivePort"));
                candidates.Add(Path.Combine(home, "AppData/Local", b, "User Data/Default/DevToolsActivePort"));
            }
        }

        var portFile = candidates.FirstOrDefault(File.Exists);
        if (portFile is null)
            throw new CdpException("No DevToolsActivePort found. Enable remote debugging at chrome://inspect/#remote-debugging");

        var lines = File.ReadAllText(portFile).Trim().Split('\n');
        if (lines.Length < 2 || string.IsNullOrEmpty(lines[0]) || string.IsNullOrEmpty(lines[1]))
            throw new CdpException($"Invalid DevToolsActivePort file: {portFile}");

        return $"ws://127.0.0.1:{lines[0]}{lines[1]}";
    }
}

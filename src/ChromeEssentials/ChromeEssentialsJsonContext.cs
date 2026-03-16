using System.Text.Json;
using System.Text.Json.Serialization;
using CloudNimble.ChromeEssentials.Protocol;

namespace CloudNimble.ChromeEssentials;

/// <summary>
/// AOT-compatible JSON serialization context for all Chrome DevTools Protocol types.
/// This source-generated context enables Native AOT compilation by avoiding reflection-based serialization.
/// </summary>
[JsonSerializable(typeof(string))]
[JsonSerializable(typeof(JsonElement))]

// CDP protocol messages
[JsonSerializable(typeof(CdpRequest))]
[JsonSerializable(typeof(CdpResponse))]

// Target domain
[JsonSerializable(typeof(TargetInfo))]
[JsonSerializable(typeof(TargetInfo[]))]
[JsonSerializable(typeof(GetTargetsResult))]
[JsonSerializable(typeof(AttachResult))]
[JsonSerializable(typeof(AttachParams))]
[JsonSerializable(typeof(CreateTargetResult))]
[JsonSerializable(typeof(CreateTargetParams))]
[JsonSerializable(typeof(TargetDestroyedParams))]
[JsonSerializable(typeof(DetachedParams))]

// Page domain
[JsonSerializable(typeof(CaptureScreenshotResult))]
[JsonSerializable(typeof(ScreenshotParams))]
[JsonSerializable(typeof(ViewportClip))]
[JsonSerializable(typeof(LayoutMetrics))]
[JsonSerializable(typeof(NavigateResult))]
[JsonSerializable(typeof(NavigateParams))]
[JsonSerializable(typeof(ReloadParams))]
[JsonSerializable(typeof(PrintToPdfParams))]
[JsonSerializable(typeof(PrintToPdfResult))]
[JsonSerializable(typeof(JavaScriptDialogOpeningParams))]
[JsonSerializable(typeof(HandleJavaScriptDialogParams))]
[JsonSerializable(typeof(AddScriptToEvaluateOnNewDocumentParams))]
[JsonSerializable(typeof(AddScriptToEvaluateOnNewDocumentResult))]
[JsonSerializable(typeof(SetDocumentContentParams))]
[JsonSerializable(typeof(GetFrameTreeResult))]
[JsonSerializable(typeof(FrameTree))]
[JsonSerializable(typeof(FrameInfo))]

// Runtime domain
[JsonSerializable(typeof(EvalResult))]
[JsonSerializable(typeof(EvalParams))]
[JsonSerializable(typeof(CallFunctionOnParams))]
[JsonSerializable(typeof(CallArgument))]
[JsonSerializable(typeof(CallArgument[]))]
[JsonSerializable(typeof(RemoteObject))]
[JsonSerializable(typeof(RemoteObject[]))]
[JsonSerializable(typeof(ConsoleApiCalledParams))]
[JsonSerializable(typeof(ExceptionThrownParams))]

// Input domain
[JsonSerializable(typeof(InsertTextParams))]
[JsonSerializable(typeof(MouseEventParams))]
[JsonSerializable(typeof(KeyEventParams))]

// Accessibility domain
[JsonSerializable(typeof(AxTreeResult))]

// DOM domain
[JsonSerializable(typeof(GetDocumentResult))]
[JsonSerializable(typeof(DomNode))]
[JsonSerializable(typeof(DomNode[]))]
[JsonSerializable(typeof(QuerySelectorParams))]
[JsonSerializable(typeof(QuerySelectorResult))]
[JsonSerializable(typeof(QuerySelectorAllResult))]
[JsonSerializable(typeof(GetOuterHTMLParams))]
[JsonSerializable(typeof(GetOuterHTMLResult))]

// DOM/Performance helpers
[JsonSerializable(typeof(ClickResult))]
[JsonSerializable(typeof(NetworkEntry))]
[JsonSerializable(typeof(NetworkEntry[]))]

// Network domain
[JsonSerializable(typeof(NetworkEnableParams))]
[JsonSerializable(typeof(SetCookieParams))]
[JsonSerializable(typeof(SetCookieResult))]
[JsonSerializable(typeof(GetCookiesParams))]
[JsonSerializable(typeof(GetCookiesResult))]
[JsonSerializable(typeof(CookieInfo))]
[JsonSerializable(typeof(CookieInfo[]))]
[JsonSerializable(typeof(DeleteCookiesParams))]
[JsonSerializable(typeof(SetExtraHTTPHeadersParams))]
[JsonSerializable(typeof(SetCacheDisabledParams))]
[JsonSerializable(typeof(GetResponseBodyParams))]
[JsonSerializable(typeof(GetResponseBodyResult))]
[JsonSerializable(typeof(RequestWillBeSentParams))]
[JsonSerializable(typeof(RequestInfo))]
[JsonSerializable(typeof(ResponseReceivedParams))]
[JsonSerializable(typeof(ResponseInfo))]
[JsonSerializable(typeof(LoadingFinishedParams))]
[JsonSerializable(typeof(LoadingFailedParams))]

// Fetch domain
[JsonSerializable(typeof(FetchEnableParams))]
[JsonSerializable(typeof(RequestPattern))]
[JsonSerializable(typeof(RequestPattern[]))]
[JsonSerializable(typeof(RequestPausedParams))]
[JsonSerializable(typeof(ContinueRequestParams))]
[JsonSerializable(typeof(HeaderEntry))]
[JsonSerializable(typeof(HeaderEntry[]))]
[JsonSerializable(typeof(FulfillRequestParams))]
[JsonSerializable(typeof(FailRequestParams))]

// Emulation domain
[JsonSerializable(typeof(SetDeviceMetricsOverrideParams))]
[JsonSerializable(typeof(SetUserAgentOverrideParams))]
[JsonSerializable(typeof(SetGeolocationOverrideParams))]
[JsonSerializable(typeof(SetEmulatedMediaParams))]
[JsonSerializable(typeof(MediaFeature))]
[JsonSerializable(typeof(MediaFeature[]))]

// Browser domain
[JsonSerializable(typeof(BrowserVersionResult))]

// Security domain
[JsonSerializable(typeof(SetIgnoreCertificateErrorsParams))]

// Log domain
[JsonSerializable(typeof(LogEntryAddedParams))]
[JsonSerializable(typeof(LogEntry))]
public partial class ChromeEssentialsJsonContext : JsonSerializerContext
{
}

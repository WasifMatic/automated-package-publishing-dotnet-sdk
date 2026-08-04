## Cancel Handler

Cancel lifecycle events.

Events in this group are uniquely identified by the `event` field.

## Events

Events available in this group. Subscribe to receive webhook notifications when these events occur.

| Name | Description | Event Identifier |
|  --- | --- | --- |
| [cancelFinished](../../../doc/events/webhooks/cancel/cancel-finished.md) | Fired when a cancellation request reaches a terminal status (`successful`, `failed`, `error`). The `data` field contains the full Cancel object. | cancel_finished |

## SDK Usage Example

```csharp
using Microsoft.AspNetCore.Mvc;
using UnivaPay.Events.Webhooks;
using UnivaPay.Http.Request;

namespace EventListener.Controller;

[Route("webhooks")]
[ApiController]
public class WebhooksController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> ReceiveEvent()
    {
        // Create the HttpRequestData from the incoming HttpRequest
        var eventRequest = HttpRequestData.FromAspNetCoreParams(
            Request.Method,
            Request.Scheme,
            Request.Host.ToString(),
            Request.Path.ToString(),
            Request.QueryString.ToString(),
            Request.Headers,
            Request.Body,
            Request.Query,
            Request.Cookies,
            Request.Protocol,
            Request.ContentType,
            Request.ContentLength
        );

        var cancelParsingResult = await CancelHandler.ParseEventAsync(eventRequest);
        var result = cancelParsingResult.MatchSome<string>(
            cancelFinished: cancelFinished => $"CancelFinished event received {cancelFinished}",
            unknown: () => "Unknown event received"
        );

        return Ok();
    }
}
```


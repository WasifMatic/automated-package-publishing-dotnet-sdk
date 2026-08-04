## Refund Handler

Refund lifecycle events.

Events in this group are uniquely identified by the `event` field.

## Events

Events available in this group. Subscribe to receive webhook notifications when these events occur.

| Name | Description | Event Identifier |
|  --- | --- | --- |
| [refundFinished](../../../doc/events/webhooks/refund/refund-finished.md) | Fired when a refund reaches a terminal status (`successful`, `failed`, `error`). The `data` field contains the full Refund object. | refund_finished |

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

        var refundParsingResult = await RefundHandler.ParseEventAsync(eventRequest);
        var result = refundParsingResult.MatchSome<string>(
            refundFinished: refundFinished => $"RefundFinished event received {refundFinished}",
            unknown: () => "Unknown event received"
        );

        return Ok();
    }
}
```


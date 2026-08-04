## Charge Handler

Charge lifecycle events.

Events in this group are uniquely identified by the `event` field.

## Events

Events available in this group. Subscribe to receive webhook notifications when these events occur.

| Name | Description | Event Identifier |
|  --- | --- | --- |
| [chargeUpdated](../../../doc/events/webhooks/charge/charge-updated.md) | Fired whenever a charge transitions to a new status (e.g., `pending` → `awaiting`). The `data` field contains the full Charge object at the time of the event. | charge_updated |
| [chargeFinished](../../../doc/events/webhooks/charge/charge-finished.md) | Fired when a charge reaches a terminal status (`successful`, `failed`, `error`). The `data` field contains the full Charge object. | charge_finished |

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

        var chargeParsingResult = await ChargeHandler.ParseEventAsync(eventRequest);
        var result = chargeParsingResult.MatchSome<string>(
            chargeUpdated: chargeUpdated => $"ChargeUpdated event received {chargeUpdated}",
            chargeFinished: chargeFinished => $"ChargeFinished event received {chargeFinished}",
            unknown: () => "Unknown event received"
        );

        return Ok();
    }
}
```


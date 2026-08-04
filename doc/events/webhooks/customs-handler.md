## Customs Handler

Customs declaration lifecycle events.

Events in this group are uniquely identified by the `event` field.

## Events

Events available in this group. Subscribe to receive webhook notifications when these events occur.

| Name | Description | Event Identifier |
|  --- | --- | --- |
| [customsDeclarationFinished](../../../doc/events/webhooks/customs/customs-declaration-finished.md) | Fired when a customs declaration associated with a charge reaches a terminal state. The `data` field contains the CustomsDeclaration resource returned by the backend formatter. | customs_declaration_finished |

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

        var customsParsingResult = await CustomsHandler.ParseEventAsync(eventRequest);
        var result = customsParsingResult.MatchSome<string>(
            customsDeclarationFinished: customsDeclarationFinished => $"CustomsDeclarationFinished event received {customsDeclarationFinished}",
            unknown: () => "Unknown event received"
        );

        return Ok();
    }
}
```


## Bank-Transfer Handler

Bank transfer status update events.

Events in this group are uniquely identified by the `event` field.

## Events

Events available in this group. Subscribe to receive webhook notifications when these events occur.

| Name | Description | Event Identifier |
|  --- | --- | --- |
| [bankTransferStatusUpdated](../../../doc/events/webhooks/bank_transfer/bank-transfer-status-updated.md) | Fired when the payment status of a bank transfer charge changes (e.g., when a deposit is received and matched against the expected amount). The `data` field contains a `BankTransferStatusData` object with the extension record, deposit amounts, and originating charge/token metadata. | bank_transfer_status_updated |

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

        var bankTransferParsingResult = await BankTransferHandler.ParseEventAsync(eventRequest);
        var result = bankTransferParsingResult.MatchSome<string>(
            bankTransferStatusUpdated: bankTransferStatusUpdated => $"BankTransferStatusUpdated event received {bankTransferStatusUpdated}",
            unknown: () => "Unknown event received"
        );

        return Ok();
    }
}
```


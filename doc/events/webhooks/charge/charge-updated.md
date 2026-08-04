
# Charge Updated

Fired whenever a charge transitions to a new status (e.g., `pending` → `awaiting`). The `data` field contains the full Charge object at the time of the event.

## Headers

This event's request contains the following headers.

| Name | Description |
|  --- | --- |
| Idempotency-Key | An optional idempotency key to prevent double charges and duplicate operations. We recommend a randomly generated UUID (v4). |
| Content-Type |  |

## Payload Type

This event's request payload is of type [ChargeWebhookEvent](../../../../doc/models/charge-webhook-event.md).

## Payload Example

```json
{
  "id": "11ef0000-0000-4000-8000-000000000001",
  "event": "charge_updated",
  "data": {
    "id": "6efb4e5c-690a-40f3-a4f1-0e19c5f84e98",
    "store_id": "11edf541-c42d-653c-8c3d-dfe0a55f95c0",
    "transaction_token_id": "11ef32a7-3a71-8662-803f-1bc27702eeec",
    "transaction_token_type": "recurring",
    "subscription_id": "11ef335e-9aa5-c54a-8313-7f9847da313a",
    "requested_amount": 1250,
    "requested_currency": "USD",
    "requested_amount_formatted": 12.5,
    "charged_amount": 1250,
    "charged_currency": "USD",
    "charged_amount_formatted": 12.5,
    "only_direct_currency": false,
    "status": "successful",
    "error": null,
    "mode": "test",
    "created_on": "2024-06-26T01:51:30.000000Z",
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "created_on": "2026-04-09T07:35:50.000000Z",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

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
            unknown: () => "Unknown event received"
        );

        return Ok();
    }
}
```

## Accepted Server Responses

The server should responds with one of the following status codes:

| Status Code | Description |
|  --- | --- |
| 200 | Return 200 to acknowledge receipt of the event. Returns an empty JSON object. |


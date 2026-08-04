
# Refund Finished

Fired when a refund reaches a terminal status (`successful`, `failed`, `error`). The `data` field contains the full Refund object.

## Headers

This event's request contains the following headers.

| Name | Description |
|  --- | --- |
| Idempotency-Key | An optional idempotency key to prevent double charges and duplicate operations. We recommend a randomly generated UUID (v4). |
| Content-Type |  |

## Payload Type

This event's request payload is of type [RefundWebhookCallback](../../../../doc/models/refund-webhook-callback.md).

## Payload Example

```json
{
  "id": "11ef0000-0000-4000-8000-000000000001",
  "event": "refund_finished",
  "data": {
    "id": "b4d9fea9-c9b3-4e76-a25d-b61f7e4821b6",
    "store_id": "76cf4a64-02bc-4cb3-9a28-74622e5928a1",
    "charge_id": "6efb4e5c-690a-40f3-a4f1-0e19c5f84e98",
    "status": "successful",
    "amount": 1000,
    "currency": "JPY",
    "amount_formatted": 1000,
    "reason": "customer_request",
    "message": "Customer returned item",
    "error": null,
    "metadata": {
      "order_id": "order_12345"
    },
    "mode": "live",
    "created_on": "2026-04-09T07:35:50.000000Z",
    "updated_on": "2026-04-09T07:36:00.000000Z",
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

        var refundParsingResult = await RefundHandler.ParseEventAsync(eventRequest);
        var result = refundParsingResult.MatchSome<string>(
            refundFinished: refundFinished => $"RefundFinished event received {refundFinished}",
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


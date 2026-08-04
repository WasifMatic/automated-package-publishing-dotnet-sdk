
# Token Three Ds Updated

Fired when the 3-D Secure data associated with a token is updated. The `data` field contains the full TransactionToken object.

## Headers

This event's request contains the following headers.

| Name | Description |
|  --- | --- |
| Idempotency-Key | An optional idempotency key to prevent double charges and duplicate operations. We recommend a randomly generated UUID (v4). |
| Content-Type |  |

## Payload Type

This event's request payload is of type [TokenWebhookEvent](../../../../doc/models/token-webhook-event.md).

## Payload Example

```json
{
  "id": "11ef0000-0000-4000-8000-000000000001",
  "event": "token_three_d_s_updated",
  "data": {
    "id": "6426bbd2-17bd-41bf-883b-1fe970db48ee",
    "store_id": "fc264608-9a9e-495e-844e-a08129a81af4",
    "email": "test@univapay.com",
    "payment_type": "card",
    "active": true,
    "mode": "live",
    "type": "recurring",
    "confirmed": true,
    "metadata": {
      "customer_id": "cust_12345"
    },
    "created_on": "2026-04-09T07:35:50.000000Z",
    "updated_on": "2026-04-09T07:35:50.000000Z",
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

        var tokenParsingResult = await TokenHandler.ParseEventAsync(eventRequest);
        var result = tokenParsingResult.MatchSome<string>(
            tokenThreeDsUpdated: tokenThreeDsUpdated => $"TokenThreeDsUpdated event received {tokenThreeDsUpdated}",
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


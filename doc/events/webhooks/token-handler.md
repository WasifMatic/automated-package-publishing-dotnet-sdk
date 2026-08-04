## Token Handler

Transaction token lifecycle events.

Events in this group are uniquely identified by the `event` field.

## Events

Events available in this group. Subscribe to receive webhook notifications when these events occur.

| Name | Description | Event Identifier |
|  --- | --- | --- |
| [tokenCreated](../../../doc/events/webhooks/token/token-created.md) | Fired when a new transaction token is created. The `data` field contains the full TransactionToken object. | token_created |
| [tokenUpdated](../../../doc/events/webhooks/token/token-updated.md) | Fired when a transaction token is updated (e.g., metadata change). The `data` field contains the full TransactionToken object. | token_updated |
| [tokenThreeDsUpdated](../../../doc/events/webhooks/token/token-three-ds-updated.md) | Fired when the 3-D Secure data associated with a token is updated. The `data` field contains the full TransactionToken object. | token_three_d_s_updated |
| [tokenCvvAuthUpdated](../../../doc/events/webhooks/token/token-cvv-auth-updated.md) | Fired when the CVV authorization result for a token is updated. The `data` field contains the full TransactionToken object. | token_cvv_auth_updated |
| [tokenCvvAuthCheckUpdated](../../../doc/events/webhooks/token/token-cvv-auth-check-updated.md) | Fired when the CVV auth check status for a token changes. The `data` field contains the full TransactionToken object. | token_cvv_auth_check_updated |
| [tokenReplaced](../../../doc/events/webhooks/token/token-replaced.md) | Fired when a transaction token is replaced by a new token (e.g., after card update). The `data` field contains the replacement TransactionToken object. | token_replaced |
| [recurringTokenDeleted](../../../doc/events/webhooks/token/recurring-token-deleted.md) | Fired when a recurring transaction token is deleted. The `data` field contains the deleted TransactionToken object. | recurring_token_deleted |

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
            tokenCreated: tokenCreated => $"TokenCreated event received {tokenCreated}",
            tokenUpdated: tokenUpdated => $"TokenUpdated event received {tokenUpdated}",
            tokenThreeDsUpdated: tokenThreeDsUpdated => $"TokenThreeDsUpdated event received {tokenThreeDsUpdated}",
            unknown: () => "Unknown event received"
        );

        return Ok();
    }
}
```


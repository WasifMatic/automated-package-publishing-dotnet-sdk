## Subscription Handler

Subscription lifecycle events.

Events in this group are uniquely identified by the `event` field.

## Events

Events available in this group. Subscribe to receive webhook notifications when these events occur.

| Name | Description | Event Identifier |
|  --- | --- | --- |
| [subscriptionCreated](../../../doc/events/webhooks/subscription/subscription-created.md) | Fired when a new subscription is created and its first payment has been initiated. The `data` field contains the full Subscription object. | subscription_created |
| [subscriptionPayment](../../../doc/events/webhooks/subscription/subscription-payment.md) | Fired when a scheduled subscription payment is successfully processed. The `data` field contains the full Subscription object. | subscription_payment |
| [subscriptionCompleted](../../../doc/events/webhooks/subscription/subscription-completed.md) | Fired when a subscription completes all of its scheduled payments. The `data` field contains the full Subscription object. | subscription_completed |
| [subscriptionFailure](../../../doc/events/webhooks/subscription/subscription-failure.md) | Fired when a scheduled subscription payment fails. The `data` field contains the full Subscription object. | subscription_failure |
| [subscriptionCanceled](../../../doc/events/webhooks/subscription/subscription-canceled.md) | Fired when a subscription is cancelled before all payments complete. The `data` field contains the full Subscription object. | subscription_canceled |
| [subscriptionSuspended](../../../doc/events/webhooks/subscription/subscription-suspended.md) | Fired when a subscription is suspended (paused). The `data` field contains the full Subscription object. | subscription_suspended |

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

        var subscriptionParsingResult = await SubscriptionHandler.ParseEventAsync(eventRequest);
        var result = subscriptionParsingResult.MatchSome<string>(
            subscriptionCreated: subscriptionCreated => $"SubscriptionCreated event received {subscriptionCreated}",
            subscriptionPayment: subscriptionPayment => $"SubscriptionPayment event received {subscriptionPayment}",
            subscriptionCompleted: subscriptionCompleted => $"SubscriptionCompleted event received {subscriptionCompleted}",
            unknown: () => "Unknown event received"
        );

        return Ok();
    }
}
```


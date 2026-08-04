
# Subscription Event

Event type discriminator — `subscription_created`, `subscription_payment`, `subscription_completed`, `subscription_failure`, `subscription_canceled`, or `subscription_suspended`.

## Enumeration

`SubscriptionEvent`

## Fields

| Name |
|  --- |
| `SubscriptionCreated` |
| `SubscriptionPayment` |
| `SubscriptionCompleted` |
| `SubscriptionFailure` |
| `SubscriptionCanceled` |
| `SubscriptionSuspended` |

## Example

```csharp
using UnivaPay.Models;

SubscriptionEvent subscriptionEvent = SubscriptionEvent.SubscriptionCanceled;
```


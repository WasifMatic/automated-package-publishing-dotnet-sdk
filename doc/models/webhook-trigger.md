
# Webhook Trigger

Event type that triggers a webhook notification.

## Enumeration

`WebhookTrigger`

## Fields

| Name |
|  --- |
| `TokenCreated` |
| `TokenUpdated` |
| `TokenThreeDSUpdated` |
| `TokenCvvAuthUpdated` |
| `TokenCvvAuthCheckUpdated` |
| `TokenReplaced` |
| `ChargeUpdated` |
| `ChargeFinished` |
| `RefundFinished` |
| `CancelFinished` |
| `CustomsDeclarationFinished` |
| `RecurringTokenDeleted` |
| `BankTransferStatusUpdated` |
| `SubscriptionCreated` |
| `SubscriptionPayment` |
| `SubscriptionCompleted` |
| `SubscriptionFailure` |
| `SubscriptionCanceled` |
| `SubscriptionSuspended` |

## Example

```csharp
using UnivaPay.Models;

WebhookTrigger webhookTrigger = WebhookTrigger.BankTransferStatusUpdated;
```


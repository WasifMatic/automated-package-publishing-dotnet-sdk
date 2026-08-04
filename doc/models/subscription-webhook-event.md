
# Subscription Webhook Event

Webhook envelope for subscription lifecycle events. Fired as `subscription_created` when a subscription is created and its first payment initiated, `subscription_payment` when a scheduled payment processes successfully, `subscription_completed` when all scheduled payments complete, `subscription_failure` when a scheduled payment fails, `subscription_canceled` when a subscription is cancelled before all payments complete, and `subscription_suspended` when a subscription is paused. The `data` field contains the full Subscription object at the time of the event.

*This model accepts additional fields of type object.*

## Structure

`SubscriptionWebhookEvent`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `Guid` | Required | Unique ID of this webhook delivery. |
| `Event` | [`SubscriptionEvent`](../../doc/models/subscription-event.md) | Required | Event type discriminator — `subscription_created`, `subscription_payment`, `subscription_completed`, `subscription_failure`, `subscription_canceled`, or `subscription_suspended`. |
| `Data` | [`Subscription`](../../doc/models/subscription.md) | Optional | The Subscription object represents a recurring payment schedule. |
| `CreatedOn` | `DateTime` | Required | Timestamp when the event was fired. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using System.Globalization;
using UnivaPay.Models;
using UnivaPay.Utilities;

SubscriptionWebhookEvent subscriptionWebhookEvent = new SubscriptionWebhookEvent
{
    Id = new Guid("11ef0000-0000-4000-8000-000000000001"),
    MEvent = SubscriptionEvent.SubscriptionCreated,
    CreatedOn = DateTime.ParseExact("2026-04-09T07:35:50.000000Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    Data = new Subscription
    {
        Id = new Guid("11ef335e-9aa5-c54a-8313-7f9847da313a"),
        StoreId = new Guid("11edf541-c42d-653c-8c3d-dfe0a55f95c0"),
        TransactionTokenId = new Guid("11ef32a7-3a71-8662-803f-1bc27702eeec"),
        Amount = 1250,
        Currency = "USD",
        AmountFormatted = 12.5,
        ScheduleSettings = new SubscriptionScheduleSettings
        {
            StartOn = DateTime.Parse("2024-07-01"),
            ZoneId = "Asia/Tokyo",
            PreserveEndOfMonth = false,
            RetryInterval = "P7D",
            TerminationMode = SubscriptionTerminationMode.OnNextPayment,
        },
        OnlyDirectCurrency = false,
        FirstChargeAuthorizationOnly = false,
        Status = SubscriptionStatus.Current,
        Metadata = new GenericMetadata
        {
            OrderId = "12345",
        },
        Mode = ChargeMode.Test,
        CreatedOn = DateTime.ParseExact("2024-06-26T01:51:28.627023Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        Period = SubscriptionPeriod.Monthly,
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```



# Subscription Update Request

Request payload for updating a subscription.

*This model accepts additional fields of type object.*

## Structure

`SubscriptionUpdateRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TransactionTokenId` | `Guid?` | Optional | Transaction token ID used for the subscription.  Can be changed to update the payment method (e.g., when a card expires).  Allowed only when the status is `unconfirmed`, `unpaid`, `current`, or `suspended`. |
| `Amount` | `int?` | Optional | The recurring charge amount (applied to the cycle after the next one).  Not available for limited-cycle subscriptions.  To change the immediate next payment amount, update `next_payment.amount` instead. |
| `Metadata` | [`GenericMetadata`](../../doc/models/generic-metadata.md) | Optional | A free-form dictionary for custom metadata. |
| `Status` | [`SubscriptionUpdateStatus?`](../../doc/models/subscription-update-status.md) | Optional | Update the subscription status.  `suspended`: Pause the subscription.  `unpaid`: Resume a suspended subscription. |
| `ScheduleSettings` | [`SubscriptionUpdateScheduleSettings`](../../doc/models/subscription-update-schedule-settings.md) | Optional | Schedule settings that can be updated on a subscription. |
| `NextPayment` | [`SubscriptionUpdateNextPayment`](../../doc/models/subscription-update-next-payment.md) | Optional | Fields that can be updated on the next scheduled payment. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using System.Globalization;
using UnivaPay.Models;
using UnivaPay.Models.Containers;
using UnivaPay.Utilities;

SubscriptionUpdateRequest subscriptionUpdateRequest = new SubscriptionUpdateRequest
{
    TransactionTokenId = new Guid("11ef3362-3700-c54a-9baa-6f7e6527c9d9"),
    Amount = 230,
    Metadata = new GenericMetadata
    {
        OrderId = "12345",
        UnivapayName = "univapay-name8",
        UnivapayPhoneNumber = "univapay-phone-number2",
        ["exampleAdditionalProperty"] = GenericMetadataValue.FromString("String4"),
    },
    Status = SubscriptionUpdateStatus.Suspended,
    ScheduleSettings = new SubscriptionUpdateScheduleSettings
    {
        TerminationMode = SubscriptionTerminationMode.OnNextPayment,
        StartOn = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        RetryInterval = "retry_interval2",
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    NextPayment = new SubscriptionUpdateNextPayment
    {
        DueDate = DateTime.Parse("2030-01-01"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```



# Subscription Update Next Payment

Fields that can be updated on the next scheduled payment.

*This model accepts additional fields of type object.*

## Structure

`SubscriptionUpdateNextPayment`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DueDate` | `DateTime?` | Optional | Next payment date (YYYY-MM-DD).  Note: Only available for merchants permitted to edit next payment dates. |
| `Amount` | `int?` | Optional | Next payment amount. Not available for limited-cycle subscriptions.  Only available for permitted merchants.  This does not change subsequent cycle amounts. |
| `TerminateWithStatus` | [`SubscriptionTerminateWithStatus?`](../../doc/models/subscription-terminate-with-status.md) | Optional | Schedule a status transition on a payment's due date. Set to `suspended` or `canceled` to schedule termination. Send `null` to cancel a previously scheduled transition. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

SubscriptionUpdateNextPayment subscriptionUpdateNextPayment = new SubscriptionUpdateNextPayment
{
    DueDate = DateTime.Parse("2016-03-13"),
    Amount = 120,
    TerminateWithStatus = SubscriptionTerminateWithStatus.Suspended,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


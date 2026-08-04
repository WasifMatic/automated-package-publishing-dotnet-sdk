
# Subscription Next Payment

Next scheduled payment details for a subscription.

*This model accepts additional fields of type object.*

## Structure

`SubscriptionNextPayment`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `Guid?` | Optional | Unique identifier. |
| `DueDate` | `DateTime?` | Optional | Scheduled due date. |
| `ZoneId` | `string` | Optional | IANA timezone identifier. |
| `Amount` | `int?` | Optional | Amount in the smallest currency unit. |
| `Currency` | `string` | Optional | ISO-4217 currency code. |
| `AmountFormatted` | `double?` | Optional | Amount formatted for display. |
| `IsPaid` | `bool?` | Optional | Whether the payment has been paid. |
| `IsLastPayment` | `bool?` | Optional | Whether this is the final payment in the schedule. |
| `CreatedOn` | `DateTime?` | Optional | Timestamp when the resource was created. |
| `UpdatedOn` | `DateTime?` | Optional | Timestamp when the resource was last updated. |
| `RetryDate` | `DateTime?` | Optional | Scheduled retry date. |
| `TerminateWithStatus` | [`SubscriptionTerminateWithStatus?`](../../doc/models/subscription-terminate-with-status.md) | Optional | Schedule a status transition on a payment's due date. Set to `suspended` or `canceled` to schedule termination. Send `null` to cancel a previously scheduled transition. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

SubscriptionNextPayment subscriptionNextPayment = new SubscriptionNextPayment
{
    Id = new Guid("00000e0e-0000-0000-0000-000000000000"),
    DueDate = DateTime.Parse("2016-03-13"),
    ZoneId = "zone_id4",
    Amount = 176,
    Currency = "currency8",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


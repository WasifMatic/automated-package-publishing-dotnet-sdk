
# Subscription

The Subscription object represents a recurring payment schedule.

*This model accepts additional fields of type object.*

## Structure

`Subscription`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `Guid?` | Optional | Unique identifier. |
| `StoreId` | `Guid?` | Optional | Store identifier. |
| `TransactionTokenId` | `Guid?` | Optional | Transaction token identifier. |
| `Amount` | `int?` | Optional | Amount in the smallest currency unit. |
| `Currency` | `string` | Optional | ISO-4217 currency code. |
| `AmountFormatted` | `double?` | Optional | Amount formatted for display. |
| `InitialAmount` | `int?` | Optional | Initial amount in the smallest currency unit. |
| `InitialAmountFormatted` | `double?` | Optional | Initial amount formatted for display. |
| `SubsequentCyclesStart` | `DateTime?` | Optional | Timestamp when recurring cycles begin. |
| `ScheduleSettings` | [`SubscriptionScheduleSettings`](../../doc/models/subscription-schedule-settings.md) | Optional | Schedule settings applied to a subscription. |
| `OnlyDirectCurrency` | `bool?` | Optional | Whether only direct currency processing is allowed. |
| `FirstChargeCaptureAfter` | `string` | Optional | ISO-8601 Duration (e.g., P3D). |
| `FirstChargeAuthorizationOnly` | `bool?` | Optional | Whether the first charge is authorization-only. |
| `Status` | [`SubscriptionStatus?`](../../doc/models/subscription-status.md) | Optional | Subscription Status schema. |
| `Metadata` | [`GenericMetadata`](../../doc/models/generic-metadata.md) | Optional | A free-form dictionary for custom metadata. |
| `Mode` | [`ChargeMode?`](../../doc/models/charge-mode.md) | Optional | Charge Mode schema. |
| `CreatedOn` | `DateTime?` | Optional | Timestamp when the resource was created. |
| `Period` | [`SubscriptionPeriod?`](../../doc/models/subscription-period.md) | Optional | Subscription Period schema. |
| `NextPayment` | [`SubscriptionNextPayment`](../../doc/models/subscription-next-payment.md) | Optional | Next scheduled payment details for a subscription. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using System.Globalization;
using UnivaPay.Models;
using UnivaPay.Utilities;

Subscription subscription = new Subscription
{
    Id = new Guid("11ef335e-9aa5-c54a-8313-7f9847da313a"),
    StoreId = new Guid("11edf541-c42d-653c-8c3d-dfe0a55f95c0"),
    TransactionTokenId = new Guid("11ef32a7-3a71-8662-803f-1bc27702eeec"),
    Amount = 1250,
    Currency = "USD",
    AmountFormatted = 12.5,
    ScheduleSettings = new SubscriptionScheduleSettings
    {
    },
    OnlyDirectCurrency = false,
    FirstChargeAuthorizationOnly = false,
    Status = SubscriptionStatus.Current,
    Metadata = new GenericMetadata
    {
        OrderId = "12345",
    },
    Mode = ChargeMode.Live,
    CreatedOn = DateTime.ParseExact("2024-06-26T01:51:28.627023Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    Period = SubscriptionPeriod.Monthly,
    NextPayment = new SubscriptionNextPayment
    {
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```



# Merchant Webhook Transfer Schedule Configuration

Transfer schedule configuration inherited by the merchant.

*This model accepts additional fields of type object.*

## Structure

`MerchantWebhookTransferScheduleConfiguration`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `WaitPeriod` | `string` | Optional | ISO-8601 period before charges become payable. |
| `Period` | `string` | Optional | Transfer period selected for payouts. |
| `FullPeriodRequired` | `bool?` | Optional | Whether the first transfer period must be fully completed. |
| `DayOfWeek` | `string` | Optional | Payout day of week when using weekly schedules. |
| `WeekOfMonth` | `int?` | Optional | Week of month used by monthly schedules. |
| `DayOfMonth` | `int?` | Optional | Day of month used by monthly schedules. |
| `WeeklyClosingDay` | `string` | Optional | Weekly closing day for balance aggregation. |
| `WeeklyPayoutDay` | `string` | Optional | Weekly payout day. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

MerchantWebhookTransferScheduleConfiguration merchantWebhookTransferScheduleConfiguration = new MerchantWebhookTransferScheduleConfiguration
{
    WaitPeriod = "P7D",
    Period = "weekly",
    FullPeriodRequired = false,
    DayOfWeek = "day_of_week8",
    WeekOfMonth = 26,
    WeeklyClosingDay = "sunday",
    WeeklyPayoutDay = "friday",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


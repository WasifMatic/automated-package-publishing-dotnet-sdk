
# Merchant Webhook Limit Refund by Sales Configuration

Refund-limiting configuration based on sales history.

*This model accepts additional fields of type object.*

## Structure

`MerchantWebhookLimitRefundBySalesConfiguration`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Enabled` | `bool?` | Optional | Enables sales-based refund limit checks. |
| `Period` | `string` | Optional | Sales aggregation period used to evaluate refund limits. |
| `RollingWindow` | `bool?` | Optional | Uses a rolling window instead of fixed calendar periods. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

MerchantWebhookLimitRefundBySalesConfiguration merchantWebhookLimitRefundBySalesConfiguration = new MerchantWebhookLimitRefundBySalesConfiguration
{
    Enabled = true,
    Period = "monthly",
    RollingWindow = true,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


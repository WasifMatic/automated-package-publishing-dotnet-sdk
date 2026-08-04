
# Merchant Webhook Subscription Plan Configuration

Subscription plan configuration.

*This model accepts additional fields of type object.*

## Structure

`MerchantWebhookSubscriptionPlanConfiguration`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Enabled` | `bool?` | Optional | Enables limited-cycle subscription plans. |
| `FixedCycle` | `bool?` | Optional | Allows plans limited by a fixed number of cycles. |
| `FixedCycleAmount` | `bool?` | Optional | Allows plans limited by a total target amount. |
| `SupportedPaymentTypes` | `List<string>` | Optional | Payment types that can use subscription plans. |
| `MinChargeAmount` | [`MerchantWebhookMoneyAmount`](../../doc/models/merchant-webhook-money-amount.md) | Optional | Monetary amount object serialized by backend config models. |
| `MaxPayoutPeriod` | `string` | Optional | Maximum payout delay allowed for subscription plan settlements. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using System.Collections.Generic;
using UnivaPay.Models;
using UnivaPay.Utilities;

MerchantWebhookSubscriptionPlanConfiguration merchantWebhookSubscriptionPlanConfiguration = new MerchantWebhookSubscriptionPlanConfiguration
{
    Enabled = true,
    FixedCycle = true,
    FixedCycleAmount = true,
    SupportedPaymentTypes = new List<string>
    {
        "card",
    },
    MinChargeAmount = new MerchantWebhookMoneyAmount
    {
        Amount = 3000,
        Currency = "JPY",
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    MaxPayoutPeriod = "P12M",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


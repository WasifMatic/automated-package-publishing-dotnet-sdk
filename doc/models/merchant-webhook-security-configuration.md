
# Merchant Webhook Security Configuration

Merchant-level fraud and refund safety settings.

*This model accepts additional fields of type object.*

## Structure

`MerchantWebhookSecurityConfiguration`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CardChargeCooldown` | `string` | Optional | ISO-8601 duration between card charge attempts. |
| `SubscriptionCooldown` | `string` | Optional | ISO-8601 duration between subscription charge attempts. |
| `IdempotentCardChargeCooldown` | `string` | Optional | ISO-8601 duration for reusing an idempotent card charge key. |
| `IdempotentSubscriptionCooldown` | `string` | Optional | ISO-8601 duration for reusing an idempotent subscription key. |
| `RestrictIpAfterFailedCharge` | [`RestrictIpAfterFailedChargeConfig`](../../doc/models/restrict-ip-after-failed-charge-config.md) | Optional | IP restriction policy applied after repeated failed charges. |
| `InspectSuspiciousLoginAfter` | `string` | Optional | Look-back period used to review suspicious login activity. |
| `RefundPercentLimit` | `double?` | Optional | Maximum refund-to-sales percentage allowed before restriction. |
| `LimitChargeByCardConfiguration` | [`MerchantWebhookLimitChargeByCardConfiguration`](../../doc/models/merchant-webhook-limit-charge-by-card-configuration.md) | Optional | Per-card velocity limit configuration. |
| `ConfirmationRequired` | `bool?` | Optional | Requires confirmation before protected refund actions proceed. |
| `MinRefundThreshold` | `int?` | Optional | Minimum refund amount, in minor units, subject to confirmation checks. |
| `LimitRefundBySales` | [`MerchantWebhookLimitRefundBySalesConfiguration`](../../doc/models/merchant-webhook-limit-refund-by-sales-configuration.md) | Optional | Refund-limiting configuration based on sales history. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

MerchantWebhookSecurityConfiguration merchantWebhookSecurityConfiguration = new MerchantWebhookSecurityConfiguration
{
    CardChargeCooldown = "PT5M",
    SubscriptionCooldown = "PT10M",
    IdempotentCardChargeCooldown = "idempotent_card_charge_cooldown2",
    IdempotentSubscriptionCooldown = "idempotent_subscription_cooldown6",
    RestrictIpAfterFailedCharge = new RestrictIpAfterFailedChargeConfig
    {
        Enabled = true,
        Count = 5,
        Cooldown = "PT1H",
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    RefundPercentLimit = 100,
    ConfirmationRequired = false,
    MinRefundThreshold = 100,
    LimitRefundBySales = new MerchantWebhookLimitRefundBySalesConfiguration
    {
        Enabled = true,
        Period = "monthly",
        RollingWindow = true,
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


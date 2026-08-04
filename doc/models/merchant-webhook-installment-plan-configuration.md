
# Merchant Webhook Installment Plan Configuration

Installment plan configuration.

*This model accepts additional fields of type object.*

## Structure

`MerchantWebhookInstallmentPlanConfiguration`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Enabled` | `bool?` | Optional | Enables installment plan features for eligible payments. |
| `CardProcessor` | [`CardProcessorInstallmentConfig`](../../doc/models/card-processor-installment-config.md) | Optional | Card-processor capabilities available for installment payments. |
| `SupportedPaymentTypes` | `List<string>` | Optional | Payment types that can use installment plans. |
| `MinChargeAmount` | [`MerchantWebhookMoneyAmount`](../../doc/models/merchant-webhook-money-amount.md) | Optional | Monetary amount object serialized by backend config models. |
| `MaxPayoutPeriod` | `string` | Optional | Maximum payout delay allowed for installment settlements. |
| `OnlyWithProcessor` | `bool?` | Optional | Restricts installment use to processor-backed flows. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using System.Collections.Generic;
using UnivaPay.Models;
using UnivaPay.Utilities;

MerchantWebhookInstallmentPlanConfiguration merchantWebhookInstallmentPlanConfiguration = new MerchantWebhookInstallmentPlanConfiguration
{
    Enabled = true,
    CardProcessor = new CardProcessorInstallmentConfig
    {
        Revolving = true,
        FixedCycle = true,
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
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
    OnlyWithProcessor = true,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


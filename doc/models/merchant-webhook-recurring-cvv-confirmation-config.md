
# Merchant Webhook Recurring Cvv Confirmation Config

CVV confirmation rules for recurring token charges.

*This model accepts additional fields of type object.*

## Structure

`MerchantWebhookRecurringCvvConfirmationConfig`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Enabled` | `bool?` | Optional | Enables recurring-charge CVV confirmation checks. |
| `Threshold` | [`List<MerchantWebhookMoneyAmount>`](../../doc/models/merchant-webhook-money-amount.md) | Optional | Amount thresholds that trigger CVV confirmation. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using System.Collections.Generic;
using UnivaPay.Models;
using UnivaPay.Utilities;

MerchantWebhookRecurringCvvConfirmationConfig merchantWebhookRecurringCvvConfirmationConfig = new MerchantWebhookRecurringCvvConfirmationConfig
{
    Enabled = false,
    Threshold = new List<MerchantWebhookMoneyAmount>
    {
        null,
        new MerchantWebhookMoneyAmount
        {
        },
        new MerchantWebhookMoneyAmount
        {
        },
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


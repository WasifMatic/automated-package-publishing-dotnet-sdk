
# Merchant Webhook Checkout Configuration

Checkout field collection settings.

*This model accepts additional fields of type object.*

## Structure

`MerchantWebhookCheckoutConfiguration`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `EcEmail` | [`MerchantWebhookCheckoutToggle`](../../doc/models/merchant-webhook-checkout-toggle.md) | Optional | Checkout feature toggle. |
| `EcProducts` | [`MerchantWebhookCheckoutToggle`](../../doc/models/merchant-webhook-checkout-toggle.md) | Optional | Checkout feature toggle. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

MerchantWebhookCheckoutConfiguration merchantWebhookCheckoutConfiguration = new MerchantWebhookCheckoutConfiguration
{
    EcEmail = new MerchantWebhookCheckoutToggle
    {
        Enabled = true,
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    EcProducts = new MerchantWebhookCheckoutToggle
    {
        Enabled = true,
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


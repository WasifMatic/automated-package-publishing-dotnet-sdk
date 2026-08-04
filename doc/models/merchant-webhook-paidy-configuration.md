
# Merchant Webhook Paidy Configuration

Paidy payment settings.

*This model accepts additional fields of type object.*

## Structure

`MerchantWebhookPaidyConfiguration`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Enabled` | `bool?` | Optional | Enables Paidy payments. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

MerchantWebhookPaidyConfiguration merchantWebhookPaidyConfiguration = new MerchantWebhookPaidyConfiguration
{
    Enabled = false,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


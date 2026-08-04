
# Merchant Webhook Convenience Configuration

Convenience-store payment settings.

*This model accepts additional fields of type object.*

## Structure

`MerchantWebhookConvenienceConfiguration`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Enabled` | `bool?` | Optional | Enables convenience-store payments. |
| `Expiration` | `string` | Optional | ISO-8601 duration before convenience payment expiry. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

MerchantWebhookConvenienceConfiguration merchantWebhookConvenienceConfiguration = new MerchantWebhookConvenienceConfiguration
{
    Enabled = true,
    Expiration = "P3D",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


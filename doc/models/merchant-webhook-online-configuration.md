
# Merchant Webhook Online Configuration

Online payment settings.

*This model accepts additional fields of type object.*

## Structure

`MerchantWebhookOnlineConfiguration`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Enabled` | `bool?` | Optional | Enables online redirect and wallet payment flows. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

MerchantWebhookOnlineConfiguration merchantWebhookOnlineConfiguration = new MerchantWebhookOnlineConfiguration
{
    Enabled = true,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


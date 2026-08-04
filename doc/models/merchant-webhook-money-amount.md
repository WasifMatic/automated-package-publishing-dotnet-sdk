
# Merchant Webhook Money Amount

Monetary amount object serialized by backend config models.

*This model accepts additional fields of type object.*

## Structure

`MerchantWebhookMoneyAmount`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Amount` | `int?` | Optional | Amount in minor currency units. |
| `Currency` | `string` | Optional | ISO 4217 currency code. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

MerchantWebhookMoneyAmount merchantWebhookMoneyAmount = new MerchantWebhookMoneyAmount
{
    Amount = 1000,
    Currency = "JPY",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


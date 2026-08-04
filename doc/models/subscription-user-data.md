
# Subscription User Data

Customer-facing payment method summary data.

*This model accepts additional fields of type object.*

## Structure

`SubscriptionUserData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Optional | Type of the resource. |
| `CardholderName` | `string` | Optional | Cardholder name value. |
| `Email` | `string` | Optional | Customer email address. |
| `Brand` | `string` | Optional | Brand or network name. |
| `Gateway` | `string` | Optional | Gateway identifier. |
| `ServiceProvider` | `string` | Optional | Service provider identifier. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

SubscriptionUserData subscriptionUserData = new SubscriptionUserData
{
    Type = "type8",
    CardholderName = "cardholder_name2",
    Email = "email4",
    Brand = "brand6",
    Gateway = "gateway2",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


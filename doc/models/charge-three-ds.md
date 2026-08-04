
# Charge Three Ds

Charge Three Ds schema.

*This model accepts additional fields of type object.*

## Structure

`ChargeThreeDs`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RedirectEndpoint` | `string` | Optional | Redirect endpoint URL. |
| `Mode` | `string` | Optional | Processing mode for the resource. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

ChargeThreeDs chargeThreeDs = new ChargeThreeDs
{
    RedirectEndpoint = "redirect_endpoint0",
    Mode = "mode6",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


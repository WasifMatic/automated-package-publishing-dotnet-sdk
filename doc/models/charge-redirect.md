
# Charge Redirect

Charge Redirect schema.

*This model accepts additional fields of type object.*

## Structure

`ChargeRedirect`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Endpoint` | `string` | Optional | Endpoint value. |
| `RedirectId` | `Guid?` | Optional | Redirect identifier. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

ChargeRedirect chargeRedirect = new ChargeRedirect
{
    Endpoint = "endpoint8",
    RedirectId = new Guid("00001874-0000-0000-0000-000000000000"),
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


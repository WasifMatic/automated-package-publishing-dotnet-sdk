
# Charge Create Request Three Ds

Charge Create Request Three Ds schema.

*This model accepts additional fields of type object.*

## Structure

`ChargeCreateRequestThreeDs`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RedirectEndpoint` | `string` | Optional | URL to redirect the customer to after 3DS authentication. |
| `Mode` | [`ChargeCreateRequestThreeDsMode?`](../../doc/models/charge-create-request-three-ds-mode.md) | Optional | 3D-Secure authentication type. App Token Secret is required to use 'skip'.<br><br>**Default**: `ChargeCreateRequestThreeDsMode.normal` |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

ChargeCreateRequestThreeDs chargeCreateRequestThreeDs = new ChargeCreateRequestThreeDs
{
    RedirectEndpoint = "redirect_endpoint8",
    Mode = ChargeCreateRequestThreeDsMode.Normal,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```



# Charge Capture Request

Request payload for capturing an authorized charge.

*This model accepts additional fields of type object.*

## Structure

`ChargeCaptureRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Amount` | `int` | Required | The amount to capture. Must be less than or equal to the authorized amount. |
| `Currency` | `string` | Required | ISO-4217 currency code. Must exactly match the currency used during authorization. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

ChargeCaptureRequest chargeCaptureRequest = new ChargeCaptureRequest
{
    Amount = 1000,
    Currency = "JPY",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


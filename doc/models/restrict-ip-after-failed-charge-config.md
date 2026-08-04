
# Restrict Ip After Failed Charge Config

IP restriction policy applied after repeated failed charges.

*This model accepts additional fields of type object.*

## Structure

`RestrictIpAfterFailedChargeConfig`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Enabled` | `bool?` | Optional | Enables temporary IP restrictions after repeated failures. |
| `Count` | `int?` | Optional | Number of failed charges allowed before restriction starts. |
| `Cooldown` | `string` | Optional | ISO-8601 duration that the IP restriction remains active. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

RestrictIpAfterFailedChargeConfig restrictIpAfterFailedChargeConfig = new RestrictIpAfterFailedChargeConfig
{
    Enabled = true,
    Count = 5,
    Cooldown = "PT1H",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


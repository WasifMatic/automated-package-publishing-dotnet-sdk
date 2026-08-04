
# Base Bank Transfer Data

Base Bank Transfer Data schema.

*This model accepts additional fields of type object.*

## Structure

`BaseBankTransferData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Brand` | `string` | Optional | The bank brand identifier (e.g., 'aozora_bank'). |
| `ExpirationPeriod` | `string` | Optional | ISO 8601 duration format (e.g., 'PT168H'). |
| `ExpirationTimeShift` | `string` | Optional | Time shift applied to the expiration, typically pushing it to the end of the day  in a specific timezone (e.g., '23:59:59+09:00'). |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

BaseBankTransferData baseBankTransferData = new BaseBankTransferData
{
    Brand = "aozora_bank",
    ExpirationPeriod = "PT168H",
    ExpirationTimeShift = "23:59:59+09:00",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


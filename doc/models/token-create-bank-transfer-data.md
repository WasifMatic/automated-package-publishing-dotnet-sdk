
# Token Create Bank Transfer Data

Token Create Bank Transfer Data schema.

*This model accepts additional fields of type object.*

## Structure

`TokenCreateBankTransferData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Brand` | `string` | Required | The bank brand identifier (e.g., 'aozora_bank'). |
| `ExpirationPeriod` | `string` | Optional | ISO 8601 duration format (e.g., 'PT168H'). |
| `ExpirationTimeShift` | `string` | Optional | Time shift applied to the expiration, typically pushing it to the end of the day  in a specific timezone (e.g., '23:59:59+09:00'). |
| `Name` | `string` | Optional | The name of the customer initiating the transfer. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

TokenCreateBankTransferData tokenCreateBankTransferData = new TokenCreateBankTransferData
{
    Brand = "aozora_bank",
    ExpirationPeriod = "PT168H",
    ExpirationTimeShift = "23:59:59+09:00",
    Name = "Taro Yamada",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


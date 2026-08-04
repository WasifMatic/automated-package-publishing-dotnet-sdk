
# Token Create Card Data Cvv Authorize

Token Create Card Data Cvv Authorize schema.

*This model accepts additional fields of type object.*

## Structure

`TokenCreateCardDataCvvAuthorize`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Enabled` | `bool?` | Optional | Enabled value.<br><br>**Default**: `false` |
| `Currency` | `string` | Optional | ISO-4217 currency code. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

TokenCreateCardDataCvvAuthorize tokenCreateCardDataCvvAuthorize = new TokenCreateCardDataCvvAuthorize
{
    Enabled = false,
    Currency = "JPY",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


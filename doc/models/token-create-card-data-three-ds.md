
# Token Create Card Data Three Ds

Token Create Card Data Three Ds schema.

*This model accepts additional fields of type object.*

## Structure

`TokenCreateCardDataThreeDs`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Enabled` | `bool?` | Optional | Enabled value. |
| `RedirectEndpoint` | `string` | Optional | Redirect endpoint URL. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

TokenCreateCardDataThreeDs tokenCreateCardDataThreeDs = new TokenCreateCardDataThreeDs
{
    Enabled = false,
    RedirectEndpoint = "redirect_endpoint0",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


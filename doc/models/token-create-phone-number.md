
# Token Create Phone Number

Token Create Phone Number schema.

*This model accepts additional fields of type object.*

## Structure

`TokenCreatePhoneNumber`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CountryCode` | `string` | Required | Country code as string (e.g., '1' or '81'). |
| `LocalNumber` | `string` | Required | Local phone number.<br><br>**Constraints**: *Maximum Length*: `15` |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

TokenCreatePhoneNumber tokenCreatePhoneNumber = new TokenCreatePhoneNumber
{
    CountryCode = "81",
    LocalNumber = "08012341234",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


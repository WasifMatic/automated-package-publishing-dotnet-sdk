
# Token Response Phone Number

Token Response Phone Number schema.

*This model accepts additional fields of type object.*

## Structure

`TokenResponsePhoneNumber`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CountryCode` | `int?` | Optional | Returned as an integer in the response. |
| `LocalNumber` | `string` | Optional | Local phone number. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

TokenResponsePhoneNumber tokenResponsePhoneNumber = new TokenResponsePhoneNumber
{
    CountryCode = 81,
    LocalNumber = "08012341234",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


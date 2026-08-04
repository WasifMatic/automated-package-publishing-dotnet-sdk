
# Api Error Detail

Structured detail entry describing a single API validation or business error.

*This model accepts additional fields of type object.*

## Structure

`ApiErrorDetail`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Field` | `string` | Optional | The field name of the parameter that caused the error (lower_snake_case). |
| `Reason` | `string` | Optional | Detailed reason for the nested error (UPPER_SNAKE_CASE or English description). |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

ApiErrorDetail apiErrorDetail = new ApiErrorDetail
{
    Field = "card_number",
    Reason = "INVALID_CARD_NUMBER",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


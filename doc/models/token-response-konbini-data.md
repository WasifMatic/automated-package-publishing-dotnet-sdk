
# Token Response Konbini Data

Token Response Konbini Data schema.

*This model accepts additional fields of type object.*

## Structure

`TokenResponseKonbiniData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CustomerName` | `string` | Optional | Customer name. |
| `ConvenienceStore` | [`BaseKonbiniDataConvenienceStore?`](../../doc/models/base-konbini-data-convenience-store.md) | Optional | Base Konbini Data Convenience Store schema. |
| `ExpirationPeriod` | `string` | Optional | ISO-8601 Duration (e.g., 'P7D'). Default is 30 days. |
| `ExpirationTimeShift` | `string` | Optional | Time shift applied to the expiration, typically pushing it to the end of the day in a specific timezone (e.g., '23:59:59.999999+09:00'). |
| `PhoneNumber` | [`TokenResponsePhoneNumber`](../../doc/models/token-response-phone-number.md) | Optional | Token Response Phone Number schema. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

TokenResponseKonbiniData tokenResponseKonbiniData = new TokenResponseKonbiniData
{
    CustomerName = "Taro Yamada",
    ConvenienceStore = BaseKonbiniDataConvenienceStore.SevenEleven,
    ExpirationPeriod = "P7D",
    ExpirationTimeShift = null,
    PhoneNumber = new TokenResponsePhoneNumber
    {
        CountryCode = 81,
        LocalNumber = "08012341234",
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


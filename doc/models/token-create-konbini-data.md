
# Token Create Konbini Data

Token Create Konbini Data schema.

*This model accepts additional fields of type object.*

## Structure

`TokenCreateKonbiniData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CustomerName` | `string` | Required | Customer name. |
| `ConvenienceStore` | [`BaseKonbiniDataConvenienceStore`](../../doc/models/base-konbini-data-convenience-store.md) | Required | Base Konbini Data Convenience Store schema. |
| `ExpirationPeriod` | `string` | Optional | ISO-8601 Duration (e.g., 'P7D'). Default is 30 days. |
| `PhoneNumber` | [`TokenCreatePhoneNumber`](../../doc/models/token-create-phone-number.md) | Required | Token Create Phone Number schema. |
| `ExpirationTimeShift` | `string` | Optional | Expiration time shift value. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

TokenCreateKonbiniData tokenCreateKonbiniData = new TokenCreateKonbiniData
{
    CustomerName = "Taro Yamada",
    ConvenienceStore = BaseKonbiniDataConvenienceStore.SevenEleven,
    PhoneNumber = new TokenCreatePhoneNumber
    {
        CountryCode = "81",
        LocalNumber = "08012341234",
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ExpirationPeriod = "P7D",
    ExpirationTimeShift = "23:59:59+09:00",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


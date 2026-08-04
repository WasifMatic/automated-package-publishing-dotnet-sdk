
# Base Konbini Data

Base Konbini Data schema.

*This model accepts additional fields of type object.*

## Structure

`BaseKonbiniData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CustomerName` | `string` | Optional | Customer name. |
| `ConvenienceStore` | [`BaseKonbiniDataConvenienceStore?`](../../doc/models/base-konbini-data-convenience-store.md) | Optional | Base Konbini Data Convenience Store schema. |
| `ExpirationPeriod` | `string` | Optional | ISO-8601 Duration (e.g., 'P7D'). Default is 30 days. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

BaseKonbiniData baseKonbiniData = new BaseKonbiniData
{
    CustomerName = "Taro Yamada",
    ConvenienceStore = BaseKonbiniDataConvenienceStore.SevenEleven,
    ExpirationPeriod = "P7D",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```



# Store List Item

Store row returned by store list queries.

*This model accepts additional fields of type object.*

## Structure

`StoreListItem`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `Guid?` | Optional | Store identifier. |
| `Name` | `string` | Optional | Store display name. |
| `MerchantName` | `string` | Optional | Merchant display name associated with the store row. |
| `CreatedOn` | `DateTime?` | Optional | Timestamp when the store was created. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using System.Globalization;
using UnivaPay.Models;
using UnivaPay.Utilities;

StoreListItem storeListItem = new StoreListItem
{
    Id = new Guid("11ef0000-0000-4000-8000-000000000022"),
    Name = "Tokyo Store",
    MerchantName = "Example Merchant",
    CreatedOn = DateTime.ParseExact("2026-04-09T07:35:50.000000Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


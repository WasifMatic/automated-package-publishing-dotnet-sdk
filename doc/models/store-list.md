
# Store List

Paginated store search result.

*This model accepts additional fields of type object.*

## Structure

`StoreList`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Items` | [`List<StoreListItem>`](../../doc/models/store-list-item.md) | Optional | Store rows matching the current filter set. |
| `HasMore` | `bool?` | Optional | Whether another page is available. |
| `TotalHits` | `int?` | Optional | Total number of matching stores when available. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using System.Collections.Generic;
using System.Globalization;
using UnivaPay.Models;
using UnivaPay.Utilities;

StoreList storeList = new StoreList
{
    Items = new List<StoreListItem>
    {
        new StoreListItem
        {
            Id = new Guid("11ef0000-0000-4000-8000-000000000022"),
            Name = "Tokyo Store",
            MerchantName = "Example Merchant",
            CreatedOn = DateTime.ParseExact("2026-04-09T07:35:50.000000Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
        new StoreListItem
        {
            Id = new Guid("11ef0000-0000-4000-8000-000000000023"),
            Name = "Osaka Store",
            MerchantName = "Example Merchant",
            CreatedOn = DateTime.ParseExact("2026-04-10T09:12:30.000000Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
    },
    HasMore = false,
    TotalHits = 2,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


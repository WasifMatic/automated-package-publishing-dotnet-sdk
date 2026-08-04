
# Transaction Token List

Paginated list of transaction tokens.

*This model accepts additional fields of type object.*

## Structure

`TransactionTokenList`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Items` | [`List<TransactionTokenListItem>`](../../doc/models/transaction-token-list-item.md) | Optional | List of resources. |
| `HasMore` | `bool?` | Optional | Whether more results are available. |
| `TotalHits` | `int?` | Optional | Total number of matching resources. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using System.Collections.Generic;
using System.Globalization;
using UnivaPay.Models;
using UnivaPay.Utilities;

TransactionTokenList transactionTokenList = new TransactionTokenList
{
    Items = new List<TransactionTokenListItem>
    {
        new TransactionTokenListItem
        {
            Id = new Guid("2fe23e45-f95d-4c95-9963-739070096443"),
            StoreId = new Guid("79e9504e-96d8-46ed-8d22-2e8b36238605"),
            MerchantName = "Test Merchant",
            StoreName = "Tokyo Store",
            Email = "taro@example.com",
            PaymentType = "card",
            Active = true,
            Mode = "live",
            Type = "recurring",
            CreatedOn = DateTime.ParseExact("2026-04-09T07:35:50Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            UpdatedOn = DateTime.ParseExact("2026-04-09T07:35:50Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            UserData = new TransactionTokenListItemUserData
            {
                CardholderName = "TARO YAMADA",
                Email = "taro@example.com",
            },
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
        new TransactionTokenListItem
        {
            Id = new Guid("3af34f56-a06e-4d06-aa74-84a181107554"),
            StoreId = new Guid("8bfa615f-a7e9-47fe-9e33-3f9c47349716"),
            MerchantName = "Test Merchant",
            StoreName = "Osaka Store",
            Email = "hanako@example.com",
            PaymentType = "card",
            Active = true,
            Mode = "live",
            Type = "one_time",
            CreatedOn = DateTime.ParseExact("2026-04-10T10:20:11Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            UpdatedOn = DateTime.ParseExact("2026-04-10T10:20:11Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            UserData = new TransactionTokenListItemUserData
            {
                CardholderName = "HANAKO SUZUKI",
                Email = "hanako@example.com",
            },
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
    },
    HasMore = false,
    TotalHits = 2,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```



# Transaction Token List Item

Transaction token entry returned in list responses.

*This model accepts additional fields of type object.*

## Structure

`TransactionTokenListItem`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `Guid?` | Optional | Unique identifier. |
| `StoreId` | `Guid?` | Optional | Store identifier. |
| `MerchantName` | `string` | Optional | Merchant display name. |
| `StoreName` | `string` | Optional | Store display name. |
| `Email` | `string` | Optional | Customer email address. |
| `PaymentType` | `string` | Optional | Payment method type. |
| `Active` | `bool?` | Optional | Whether the resource is active. |
| `Mode` | `string` | Optional | Processing mode for the resource. |
| `Type` | `string` | Optional | Type of the resource. |
| `CreatedOn` | `DateTime?` | Optional | Timestamp when the resource was created. |
| `UpdatedOn` | `DateTime?` | Optional | Timestamp when the resource was last updated. |
| `UserData` | [`TransactionTokenListItemUserData`](../../doc/models/transaction-token-list-item-user-data.md) | Optional | Transaction Token List Item User Data schema. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using System.Globalization;
using UnivaPay.Models;
using UnivaPay.Utilities;

TransactionTokenListItem transactionTokenListItem = new TransactionTokenListItem
{
    Id = new Guid("2fe23e45-f95d-4c95-9963-739070096443"),
    StoreId = new Guid("79e9504e-96d8-46ed-8d22-2e8b36238605"),
    MerchantName = "Test Merchant",
    StoreName = "Tokyo Store",
    Email = "user@example.com",
    PaymentType = "card",
    Active = true,
    Mode = "live",
    Type = "one_time",
    CreatedOn = DateTime.ParseExact("2026-04-09T07:35:50Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    UpdatedOn = DateTime.ParseExact("2026-04-09T07:35:50Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    UserData = new TransactionTokenListItemUserData
    {
        CardholderName = "TARO YAMADA",
        Email = "user@example.com",
        Brand = "visa",
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```



# Subscription List

Paginated list of subscriptions.

*This model accepts additional fields of type object.*

## Structure

`SubscriptionList`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Items` | [`List<SubscriptionListItem>`](../../doc/models/subscription-list-item.md) | Optional | List of resources. |
| `HasMore` | `bool?` | Optional | Whether more results are available. |
| `TotalHits` | `int?` | Optional | Total number of matching resources. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using System.Collections.Generic;
using UnivaPay.Models;
using UnivaPay.Utilities;

SubscriptionList subscriptionList = new SubscriptionList
{
    Items = new List<SubscriptionListItem>
    {
        new SubscriptionListItem
        {
            Id = new Guid("11ef3410-aaaa-4bcd-8e1f-1a2b3c4d5e60"),
            StoreId = new Guid("11edf541-c42d-653c-8c3d-dfe0a55f95c0"),
            TransactionTokenId = new Guid("11ef3413-dddd-4ef0-b142-4d5e6f809193"),
            Amount = 1250,
            Currency = "USD",
            AmountFormatted = 12.5,
            Status = SubscriptionStatus.Current,
            MerchantName = "管理画面ガイド",
            StoreName = "管理画面ガイド_TEST店舗",
            PaymentType = "card",
            NextPaymentDate = DateTime.Parse("2024-07-26"),
            UserData = new SubscriptionUserData
            {
                Type = "charge",
                CardholderName = "taro yamada",
                Email = "taro@test.com",
                Brand = "visa",
            },
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
        new SubscriptionListItem
        {
            Id = new Guid("11ef3411-bbbb-4cde-9f20-2b3c4d5e6f71"),
            StoreId = new Guid("22af6520-d53e-764d-9d4e-ef01b66fa6d1"),
            TransactionTokenId = new Guid("11ef3414-eeee-4f01-c253-5e6f80919204"),
            Amount = 3000,
            Currency = "JPY",
            AmountFormatted = 3000,
            Status = SubscriptionStatus.Current,
            MerchantName = "管理画面ガイド",
            StoreName = "管理画面ガイド_Online店舗",
            PaymentType = "card",
            NextPaymentDate = DateTime.Parse("2024-08-10"),
            UserData = new SubscriptionUserData
            {
                Type = "charge",
                CardholderName = "hanako suzuki",
                Email = "hanako@test.com",
                Brand = "mastercard",
            },
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
    },
    HasMore = false,
    TotalHits = 2,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


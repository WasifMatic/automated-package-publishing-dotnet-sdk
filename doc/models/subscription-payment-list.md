
# Subscription Payment List

Paginated list of subscription payments.

*This model accepts additional fields of type object.*

## Structure

`SubscriptionPaymentList`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Items` | [`List<SubscriptionPayment>`](../../doc/models/subscription-payment.md) | Optional | List of resources. |
| `HasMore` | `bool?` | Optional | Whether more results are available. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using System.Collections.Generic;
using System.Globalization;
using UnivaPay.Models;
using UnivaPay.Utilities;

SubscriptionPaymentList subscriptionPaymentList = new SubscriptionPaymentList
{
    Items = new List<SubscriptionPayment>
    {
        new SubscriptionPayment
        {
            Id = new Guid("11e89a0a-8cee-d660-b984-3fcaaed46e7c"),
            DueDate = DateTime.Parse("2018-08-21"),
            ZoneId = "Asia/Tokyo",
            Amount = 10000,
            Currency = "JPY",
            AmountFormatted = 10000,
            IsPaid = false,
            IsLastPayment = false,
            CreatedOn = DateTime.ParseExact("2018-08-07T06:24:33.961256Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            UpdatedOn = DateTime.ParseExact("2018-08-07T06:24:33.961256Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
        new SubscriptionPayment
        {
            Id = new Guid("11e89a0a-8cc5-2662-9460-2b14b1a601ba"),
            DueDate = DateTime.Parse("2018-08-07"),
            ZoneId = "Asia/Tokyo",
            Amount = 1000,
            Currency = "JPY",
            AmountFormatted = 1000,
            IsPaid = true,
            IsLastPayment = false,
            CreatedOn = DateTime.ParseExact("2018-08-07T06:24:33.646223Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            UpdatedOn = DateTime.ParseExact("2018-08-07T06:24:33.887760Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
    },
    HasMore = false,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


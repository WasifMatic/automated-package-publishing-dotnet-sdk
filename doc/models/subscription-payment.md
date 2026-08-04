
# Subscription Payment

Represents a single scheduled or historical payment for a subscription.

*This model accepts additional fields of type object.*

## Structure

`SubscriptionPayment`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `Guid?` | Optional | Unique identifier. |
| `DueDate` | `DateTime?` | Optional | Scheduled due date. |
| `ZoneId` | `string` | Optional | IANA Timezone ID. |
| `Amount` | `int?` | Optional | Amount in the smallest currency unit. |
| `Currency` | `string` | Optional | ISO-4217 currency code. |
| `AmountFormatted` | `double?` | Optional | Amount formatted for display. |
| `IsPaid` | `bool?` | Optional | Indicates whether this specific payment cycle has been successfully charged. |
| `IsLastPayment` | `bool?` | Optional | Indicates if this is the final payment in a limited-cycle subscription. |
| `CreatedOn` | `DateTime?` | Optional | Timestamp when the resource was created. |
| `UpdatedOn` | `DateTime?` | Optional | Timestamp when the resource was last updated. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using System.Globalization;
using UnivaPay.Models;
using UnivaPay.Utilities;

SubscriptionPayment subscriptionPayment = new SubscriptionPayment
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
};
```


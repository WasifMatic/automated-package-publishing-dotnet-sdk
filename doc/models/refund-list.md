
# Refund List

Paginated list of refunds.

*This model accepts additional fields of type object.*

## Structure

`RefundList`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Items` | [`List<Refund>`](../../doc/models/refund.md) | Optional | List of resources. |
| `HasMore` | `bool?` | Optional | Whether more results are available. |
| `TotalHits` | `int?` | Optional | Total number of matching resources. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using System.Collections.Generic;
using System.Globalization;
using UnivaPay.Models;
using UnivaPay.Utilities;

RefundList refundList = new RefundList
{
    Items = new List<Refund>
    {
        new Refund
        {
            Id = new Guid("b4d9fea9-c9b3-4e76-a25d-b61f7e4821b6"),
            StoreId = new Guid("76cf4a64-02bc-4cb3-9a28-74622e5928a1"),
            ChargeId = new Guid("6efb4e5c-690a-40f3-a4f1-0e19c5f84e98"),
            Status = RefundStatus.Successful,
            Amount = 1000,
            Currency = "JPY",
            AmountFormatted = 1000,
            Reason = RefundReasonResponse.CustomerRequest,
            Message = "Customer returned item",
            Error = new PaymentError
            {
            },
            Metadata = new GenericMetadata
            {
            },
            Mode = ChargeMode.Live,
            CreatedOn = DateTime.ParseExact("2026-04-09T07:35:50.000000Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            UpdatedOn = DateTime.ParseExact("2026-04-09T07:36:00.000000Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
        new Refund
        {
            Id = new Guid("c5e0afb0-dac4-5f87-b36e-c72f8f5932c7"),
            StoreId = new Guid("76cf4a64-02bc-4cb3-9a28-74622e5928a1"),
            ChargeId = new Guid("7fac5f6d-7a1b-51e4-b5f2-1f2ad6f95fa9"),
            Status = RefundStatus.Pending,
            Amount = 2500,
            Currency = "JPY",
            AmountFormatted = 2500,
            Reason = RefundReasonResponse.Duplicate,
            Message = "Duplicate charge",
            Error = new PaymentError
            {
            },
            Metadata = new GenericMetadata
            {
                OrderId = "ORD-1002",
            },
            Mode = ChargeMode.Live,
            CreatedOn = DateTime.ParseExact("2026-04-10T10:00:00.000000Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            UpdatedOn = DateTime.ParseExact("2026-04-10T10:00:05.000000Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
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


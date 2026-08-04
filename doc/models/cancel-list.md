
# Cancel List

Paginated list of cancels.

*This model accepts additional fields of type object.*

## Structure

`CancelList`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Items` | [`List<Cancel>`](../../doc/models/cancel.md) | Optional | List of resources. |
| `HasMore` | `bool?` | Optional | Whether more results are available. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using System.Collections.Generic;
using System.Globalization;
using UnivaPay.Models;
using UnivaPay.Utilities;

CancelList cancelList = new CancelList
{
    Items = new List<Cancel>
    {
        new Cancel
        {
            Id = new Guid("a1b2c3d4-e5f6-7890-abcd-ef1234567890"),
            ChargeId = new Guid("6efb4e5c-690a-40f3-a4f1-0e19c5f84e98"),
            StoreId = new Guid("76cf4a64-02bc-4cb3-9a28-74622e5928a1"),
            Status = CancelStatus.Successful,
            Error = new PaymentError
            {
                Code = 24,
                Message = "message4",
                Detail = "detail0",
                ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
            },
            Metadata = new GenericMetadata
            {
                OrderId = "ORD-987",
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
        new Cancel
        {
            Id = new Guid("b2c3d4e5-f6a7-8901-bcde-f23456789012"),
            ChargeId = new Guid("7fac5f6d-7a1b-51e4-b5f2-1f2ad6f95fa9"),
            StoreId = new Guid("76cf4a64-02bc-4cb3-9a28-74622e5928a1"),
            Status = CancelStatus.Successful,
            Error = new PaymentError
            {
                Code = 24,
                Message = "message4",
                Detail = "detail0",
                ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
            },
            Metadata = new GenericMetadata
            {
                OrderId = "ORD-988",
            },
            Mode = ChargeMode.Live,
            CreatedOn = DateTime.ParseExact("2026-04-10T10:00:00.000000Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            UpdatedOn = DateTime.ParseExact("2026-04-10T10:00:12.000000Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
    },
    HasMore = false,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```



# Charge List

Paginated list of charges.

*This model accepts additional fields of type object.*

## Structure

`ChargeList`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Items` | [`List<Charge>`](../../doc/models/charge.md) | Optional | List of resources. |
| `HasMore` | `bool?` | Optional | Whether more results are available. |
| `TotalHits` | `int?` | Optional | Total number of matching resources. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using System.Collections.Generic;
using System.Globalization;
using UnivaPay.Models;
using UnivaPay.Utilities;

ChargeList chargeList = new ChargeList
{
    Items = new List<Charge>
    {
        new Charge
        {
            Id = new Guid("11ef32c4-9ea8-169c-a6c8-bfc29867a226"),
            StoreId = new Guid("11edf541-c42d-653c-8c3d-dfe0a55f95c0"),
            TransactionTokenId = new Guid("11ef32c4-9e89-0cac-bd63-17b9a26af61b"),
            TransactionTokenType = ChargeTransactionTokenType.OneTime,
            SubscriptionId = new Guid("00002470-0000-0000-0000-000000000000"),
            RequestedAmount = 1000,
            RequestedCurrency = "JPY",
            RequestedAmountFormatted = 1000,
            ChargedAmount = 1000,
            ChargedCurrency = "JPY",
            ChargedAmountFormatted = 1000,
            OnlyDirectCurrency = false,
            Status = ChargeStatus.Successful,
            Error = new PaymentError
            {
            },
            Metadata = new GenericMetadata
            {
                OrderId = "ORD-2001",
            },
            Mode = ChargeMode.Test,
            CreatedOn = DateTime.ParseExact("2024-06-25T07:29:12.854865Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
        new Charge
        {
            Id = new Guid("11ef32c3-3cfe-3bc0-abed-0bb96f792078"),
            StoreId = new Guid("11edf541-c42d-653c-8c3d-dfe0a55f95c0"),
            TransactionTokenId = new Guid("11ef32c3-3cdd-df92-9dce-c346b9fdf088"),
            TransactionTokenType = ChargeTransactionTokenType.Recurring,
            SubscriptionId = new Guid("00002470-0000-0000-0000-000000000000"),
            RequestedAmount = 1250,
            RequestedCurrency = "USD",
            RequestedAmountFormatted = 12.5,
            ChargedAmount = 1250,
            ChargedCurrency = "USD",
            ChargedAmountFormatted = 12.5,
            OnlyDirectCurrency = false,
            Status = ChargeStatus.Successful,
            Error = new PaymentError
            {
            },
            Metadata = new GenericMetadata
            {
                OrderId = "ORD-2002",
            },
            Mode = ChargeMode.Test,
            CreatedOn = DateTime.ParseExact("2024-06-25T07:19:19.507637Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
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



# Bank Transfer Status Data

Data payload for `bank_transfer_status_updated` webhook events. Contains the bank transfer extension fields inlined alongside amount and metadata.

*This model accepts additional fields of type object.*

## Structure

`BankTransferStatusData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `Guid?` | Optional | Bank transfer charge extension ID. |
| `ChargeId` | `Guid?` | Optional | ID of the associated charge. |
| `PaymentStatus` | [`BankTransferPaymentStatus?`](../../doc/models/bank-transfer-payment-status.md) | Optional | Payment status of a bank transfer charge. |
| `LatestDepositDate` | `DateTime?` | Optional | Date of the most recent deposit. |
| `CreatedOn` | `DateTime?` | Optional | When the bank transfer extension record was created. |
| `LatestDepositAmount` | `int?` | Optional | Amount of the most recent deposit in minor currency units. |
| `Balance` | `int?` | Optional | Current outstanding balance in minor currency units. |
| `Currency` | `string` | Optional | ISO 4217 currency code. |
| `Amount` | `int?` | Optional | Total charge amount in minor currency units. |
| `AmountDifference` | `int?` | Optional | Difference between paid and expected amount (positive = over, negative = under). |
| `TokenMetadata` | [`GenericMetadata`](../../doc/models/generic-metadata.md) | Optional | A free-form dictionary for custom metadata. |
| `ChargeMetadata` | [`GenericMetadata`](../../doc/models/generic-metadata.md) | Optional | A free-form dictionary for custom metadata. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using System.Globalization;
using UnivaPay.Models;
using UnivaPay.Utilities;

BankTransferStatusData bankTransferStatusData = new BankTransferStatusData
{
    Id = new Guid("11ef0000-0000-4000-8000-000000000002"),
    ChargeId = new Guid("11ef0000-0000-4000-8000-000000000001"),
    PaymentStatus = BankTransferPaymentStatus.Exact,
    LatestDepositDate = DateTime.ParseExact("2026-04-09T07:35:50.000000Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    CreatedOn = DateTime.ParseExact("2026-04-09T07:35:50.000000Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    LatestDepositAmount = 1000,
    Balance = 0,
    Currency = "JPY",
    Amount = 1000,
    AmountDifference = 0,
    TokenMetadata = new GenericMetadata
    {
        OrderId = "12345",
    },
    ChargeMetadata = new GenericMetadata
    {
        OrderId = "order_12345",
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


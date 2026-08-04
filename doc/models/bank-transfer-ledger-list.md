
# Bank Transfer Ledger List

Paginated list of bank transfer ledger entries.

*This model accepts additional fields of type object.*

## Structure

`BankTransferLedgerList`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Items` | [`List<BankTransferLedger>`](../../doc/models/bank-transfer-ledger.md) | Optional | List of resources. |
| `HasMore` | `bool?` | Optional | Whether more results are available. |
| `TotalHits` | `int?` | Optional | Total number of matching resources. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using System.Collections.Generic;
using System.Globalization;
using UnivaPay.Models;
using UnivaPay.Utilities;

BankTransferLedgerList bankTransferLedgerList = new BankTransferLedgerList
{
    Items = new List<BankTransferLedger>
    {
        new BankTransferLedger
        {
            BankLedgerType = BankTransferLedgerBankLedgerType.Payment,
            Amount = 1000,
            Balance = 0,
            VirtualBankAccountHolderName = "test holder name",
            VirtualBankAccountNumber = "1234567",
            VirtualAccountId = "test account id",
            TransactionDate = DateTime.Parse("2024-06-25"),
            TransactionTimestamp = DateTime.ParseExact("2024-06-25T07:29:16.367347Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            Mode = BankTransferLedgerMode.Test,
            CreatedOn = DateTime.ParseExact("2024-06-25T07:29:16.373181Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
        new BankTransferLedger
        {
            BankLedgerType = BankTransferLedgerBankLedgerType.Deposit,
            Amount = 1000,
            Balance = 1000,
            VirtualBankAccountHolderName = "test holder name",
            VirtualBankAccountNumber = "1234567",
            VirtualAccountId = "test account id",
            TransactionDate = DateTime.Parse("2024-06-25"),
            TransactionTimestamp = DateTime.ParseExact("2024-06-25T07:29:16.36731Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            Mode = BankTransferLedgerMode.Test,
            CreatedOn = DateTime.ParseExact("2024-06-25T07:29:16.368093Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
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


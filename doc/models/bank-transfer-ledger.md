
# Bank Transfer Ledger

Single bank transfer ledger entry associated with a charge.

*This model accepts additional fields of type object.*

## Structure

`BankTransferLedger`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `BankLedgerType` | [`BankTransferLedgerBankLedgerType?`](../../doc/models/bank-transfer-ledger-bank-ledger-type.md) | Optional | Bank Transfer Ledger Bank Ledger Type schema. |
| `Amount` | `int?` | Optional | Amount in the smallest currency unit. |
| `Balance` | `int?` | Optional | Current balance in the smallest currency unit. |
| `VirtualBankAccountHolderName` | `string` | Optional | Virtual bank account holder name. |
| `VirtualBankAccountNumber` | `string` | Optional | Virtual bank account number. |
| `VirtualAccountId` | `string` | Optional | Virtual account id value. |
| `TransactionDate` | `DateTime?` | Optional | Transaction date. |
| `TransactionTimestamp` | `DateTime?` | Optional | Transaction timestamp. |
| `Mode` | [`BankTransferLedgerMode?`](../../doc/models/bank-transfer-ledger-mode.md) | Optional | Bank Transfer Ledger Mode schema. |
| `CreatedOn` | `DateTime?` | Optional | Timestamp when the resource was created. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using System.Globalization;
using UnivaPay.Models;
using UnivaPay.Utilities;

BankTransferLedger bankTransferLedger = new BankTransferLedger
{
    BankLedgerType = BankTransferLedgerBankLedgerType.Deposit,
    Amount = 1000,
    Balance = 1000,
    VirtualBankAccountHolderName = "TARO YAMADA",
    VirtualBankAccountNumber = "1234567",
    VirtualAccountId = "va_12345",
    TransactionDate = DateTime.Parse("2026-04-09"),
    TransactionTimestamp = DateTime.ParseExact("2026-04-09T07:35:50Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    Mode = BankTransferLedgerMode.Live,
    CreatedOn = DateTime.ParseExact("2026-04-09T07:35:50Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


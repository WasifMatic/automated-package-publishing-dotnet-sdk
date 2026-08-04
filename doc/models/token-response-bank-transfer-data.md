
# Token Response Bank Transfer Data

Token Response Bank Transfer Data schema.

*This model accepts additional fields of type object.*

## Structure

`TokenResponseBankTransferData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Brand` | `string` | Optional | The bank brand identifier (e.g., 'aozora_bank'). |
| `ExpirationPeriod` | `string` | Optional | ISO 8601 duration format (e.g., 'PT168H'). |
| `ExpirationTimeShift` | `string` | Optional | Time shift applied to the expiration, typically pushing it to the end of the day  in a specific timezone (e.g., '23:59:59+09:00'). |
| `BankCode` | `string` | Optional | Bank code value. |
| `BankName` | `string` | Optional | Bank name value. |
| `BranchCode` | `string` | Optional | Bank branch code. |
| `BranchName` | `string` | Optional | Bank branch name. |
| `AccountNumber` | `string` | Optional | Bank account number. |
| `AccountHolderName` | `string` | Optional | Bank account holder name. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

TokenResponseBankTransferData tokenResponseBankTransferData = new TokenResponseBankTransferData
{
    Brand = "aozora_bank",
    ExpirationPeriod = "PT168H",
    ExpirationTimeShift = "23:59:59+09:00",
    BankCode = "0310",
    BankName = "GMOあおぞらネット銀行",
    BranchCode = "123",
    BranchName = "Test Branch",
    AccountNumber = "1234567",
    AccountHolderName = "TARO YAMADA",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


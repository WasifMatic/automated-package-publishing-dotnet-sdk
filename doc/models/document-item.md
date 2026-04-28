
# Document Item

General information that unambiguously identifies a document, such as identification number and issue date time.

## Structure

`DocumentItem`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Identification` | `string` | Required | Provides identification of the document item line.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `35`, *Pattern*: ``^[0-9a-zA-Z/\-\?:\(\)\.,'\+ !#$%&\*=^_`\{\\|\}~";<>@\[\\\]]+$`` |
| `Description` | `string` | Optional | Description associated with the document item line.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `35`, *Pattern*: ``^[0-9a-zA-Z/\-\?:\(\)\.,'\+ !#$%&\*=^_`\{\\|\}~";<>@\[\\\]]+$`` |
| `Amount` | [`Amount1`](../../doc/models/amount-1.md) | Optional | - |
| `CreditDebitIndicator` | [`CreditDebitCodeEnum?`](../../doc/models/credit-debit-code-enum.md) | Optional | - |
| `AdjustmentReason` | `string` | Optional | Specifies the reason for the adjustment.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `35` |

## Example (as JSON)

```json
{
  "identification": "identification2",
  "description": "description4",
  "amount": {
    "currency_code": "currency_code6",
    "amount": "amount0"
  },
  "credit_debit_indicator": "CRDT",
  "adjustment_reason": "adjustment_reason6"
}
```


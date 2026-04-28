
# Active or Historic Currency and Amount Range

Range of amount values.

## Structure

`ActiveOrHistoricCurrencyAndAmountRange`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Amount` | `object` | Required | - |
| `CreditDebitIndicator` | [`CreditDebitCodeEnum?`](../../doc/models/credit-debit-code-enum.md) | Optional | - |
| `Currency` | `string` | Required | A code allocated to a currency by a Maintenance Agency under an international identification scheme, as described in the latest edition of the international standard ISO 4217 "Codes for the representation of currencies and funds".<br><br>**Constraints**: *Pattern*: `^[A-Z]{3,3}$` |

## Example (as JSON)

```json
{
  "amount": {
    "key1": "val1",
    "key2": "val2"
  },
  "credit_debit_indicator": "CRDT",
  "currency": "currency2"
}
```


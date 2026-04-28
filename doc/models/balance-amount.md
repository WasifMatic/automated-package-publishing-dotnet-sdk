
# Balance Amount

## Structure

`BalanceAmount`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Amount` | [`Amount12`](../../doc/models/amount-12.md) | Required | - |
| `CreditDebitIndicator` | [`CreditDebitCodeEnum`](../../doc/models/credit-debit-code-enum.md) | Required | - |

## Example (as JSON)

```json
{
  "amount": {
    "currency": "currency2",
    "amount": "amount0"
  },
  "credit_debit_indicator": "CRDT"
}
```


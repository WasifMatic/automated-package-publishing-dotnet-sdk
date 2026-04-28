
# Amount and Direction 52

Posting of an item to a cash account, in the context of a cash transaction, that results in an increase or decrease to the balance of the account.

## Structure

`AmountAndDirection52`

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


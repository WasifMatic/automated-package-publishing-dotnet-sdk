
# Balance

Numerical representation of the net increases and decreases in an account at a specific point in time.

## Structure

`Balance`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | [`BalanceTypeCodeEnum`](../../doc/models/balance-type-code-enum.md) | Required | - |
| `Amount` | [`Amount1`](../../doc/models/amount-1.md) | Required | - |
| `CreditDebitIndicator` | [`CreditDebitCodeEnum`](../../doc/models/credit-debit-code-enum.md) | Required | - |
| `Date` | [`BalanceDate`](../../doc/models/containers/balance-date.md) | Required | This is a container for one-of cases. |
| `CreditLine` | [`List<CreditLine>`](../../doc/models/credit-line.md) | Optional | Set of elements used to provide details on the credit line. |
| `Availability` | [`List<BalanceAvailability>`](../../doc/models/balance-availability.md) | Optional | Set of elements used to indicate when the booked amount of money will become available, that is can be accessed and starts generating interest.<br><br>Usage: This type of information is used in the US and is linked to particular instruments such as cheques. Example: When a cheque is deposited, it will be booked on the deposit day, but the amount of money will only be accessible as of the indicated availability day (according to national banking regulations). |

## Example (as JSON)

```json
{
  "type": "PRCD",
  "amount": {
    "currency_code": "currency_code6",
    "amount": "amount0"
  },
  "credit_debit_indicator": "CRDT",
  "date": "String7",
  "credit_line": [
    {
      "included": false,
      "type": "type8",
      "amount": {
        "currency_code": "currency_code6",
        "amount": "amount0"
      }
    },
    {
      "included": false,
      "type": "type8",
      "amount": {
        "currency_code": "currency_code6",
        "amount": "amount0"
      }
    }
  ],
  "availability": [
    {
      "date": "date6",
      "amount": {
        "currency_code": "currency_code6",
        "amount": "amount0"
      },
      "credit_debit_indicator": "CRDT"
    },
    {
      "date": "date6",
      "amount": {
        "currency_code": "currency_code6",
        "amount": "amount0"
      },
      "credit_debit_indicator": "CRDT"
    }
  ]
}
```


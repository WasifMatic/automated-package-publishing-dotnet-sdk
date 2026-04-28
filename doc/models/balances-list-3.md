
# Balances List 3

List of the balances that can be retrieved on a given account

## Structure

`BalancesList3`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CurrentBalance` | [`CurrentBalance`](../../doc/models/current-balance.md) | Required | - |
| `AvailableBalance` | [`AvailableBalance`](../../doc/models/available-balance.md) | Optional | - |
| `ForwardAvailableBalance` | [`List<CashForwardAvailableBalance1>`](../../doc/models/cash-forward-available-balance-1.md) | Optional | Provides detailed information of the forward available balance of a specific cash account. Subject to the service provided by the Account Servicer, forward available balance can be presented with multiple times for multiple reference dates. |

## Example (as JSON)

```json
{
  "current_balance": {
    "balance_amount": {
      "amount": {
        "currency": "currency2",
        "amount": "amount0"
      },
      "credit_debit_indicator": "CRDT"
    },
    "last_change_date_time": "last_change_date_time8",
    "date_time": "date_time8",
    "last_committed_transaction_identification": "last_committed_transaction_identification0",
    "credit_line": [
      {
        "included": false,
        "type": "type8",
        "amount": {
          "currency": "currency2",
          "amount": "amount0"
        }
      },
      {
        "included": false,
        "type": "type8",
        "amount": {
          "currency": "currency2",
          "amount": "amount0"
        }
      },
      {
        "included": false,
        "type": "type8",
        "amount": {
          "currency": "currency2",
          "amount": "amount0"
        }
      }
    ]
  },
  "available_balance": {
    "balance_amount": {
      "amount": {
        "currency": "currency2",
        "amount": "amount0"
      },
      "credit_debit_indicator": "CRDT"
    },
    "availability_date": "availability_date2"
  },
  "forward_available_balance": [
    {
      "balance_amount": {
        "amount": {
          "currency": "currency2",
          "amount": "amount0"
        },
        "credit_debit_indicator": "CRDT"
      },
      "availability_date": "availability_date2"
    }
  ]
}
```



# Accounts Response

## Structure

`AccountsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CashAccount` | [`List<CashAccount41>`](../../doc/models/cash-account-41.md) | Required | - |
| `Links` | [`List<Link>`](../../doc/models/link.md) | Optional | - |

## Example (as JSON)

```json
{
  "cash_account": [
    {
      "account_identification": "account_identification6",
      "alternate_identification": "00000b2e-0000-0000-0000-000000000000",
      "account_servicer": "account_servicer0",
      "name": "name2",
      "owner_name": "owner_name4",
      "currency": "currency2",
      "related_account": "related_account6",
      "balances": {
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
          },
          {
            "balance_amount": {
              "amount": {
                "currency": "currency2",
                "amount": "amount0"
              },
              "credit_debit_indicator": "CRDT"
            },
            "availability_date": "availability_date2"
          },
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
      },
      "status": "status4"
    }
  ],
  "links": [
    {
      "href": "href6",
      "rel": "rel0",
      "type": "type4"
    },
    {
      "href": "href6",
      "rel": "rel0",
      "type": "type4"
    },
    {
      "href": "href6",
      "rel": "rel0",
      "type": "type4"
    }
  ]
}
```


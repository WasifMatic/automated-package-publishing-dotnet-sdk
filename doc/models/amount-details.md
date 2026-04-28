
# Amount Details

## Structure

`AmountDetails`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `InstructedAmount` | [`InstructedAmount`](../../doc/models/instructed-amount.md) | Optional | - |
| `TransactionAmount` | [`TransactionAmount`](../../doc/models/transaction-amount.md) | Optional | - |
| `CounterValueAmount` | [`CounterValueAmount`](../../doc/models/counter-value-amount.md) | Optional | - |
| `AnnouncedPostingAmount` | [`AnnouncedPostingAmount`](../../doc/models/announced-posting-amount.md) | Optional | - |
| `ProprietaryAmount` | [`List<AmountAndCurrencyExchangeDetails>`](../../doc/models/amount-and-currency-exchange-details.md) | Optional | Set of elements used to provide information on the original amount and currency exchange. |

## Example (as JSON)

```json
{
  "instructed_amount": {
    "amount": {
      "currency_code": "currency_code6",
      "amount": "amount0"
    },
    "currency_exchange": {
      "source_currency": "source_currency8",
      "target_currency": "target_currency0",
      "unit_currency": "unit_currency0",
      "exchange_rate": "exchange_rate6",
      "contract_identification": "contract_identification6",
      "quotation_date": "quotation_date8"
    }
  },
  "transaction_amount": {
    "amount": {
      "currency_code": "currency_code6",
      "amount": "amount0"
    },
    "currency_exchange": {
      "source_currency": "source_currency8",
      "target_currency": "target_currency0",
      "unit_currency": "unit_currency0",
      "exchange_rate": "exchange_rate6",
      "contract_identification": "contract_identification6",
      "quotation_date": "quotation_date8"
    }
  },
  "counter_value_amount": {
    "amount": {
      "currency_code": "currency_code6",
      "amount": "amount0"
    },
    "currency_exchange": {
      "source_currency": "source_currency8",
      "target_currency": "target_currency0",
      "unit_currency": "unit_currency0",
      "exchange_rate": "exchange_rate6",
      "contract_identification": "contract_identification6",
      "quotation_date": "quotation_date8"
    }
  },
  "announced_posting_amount": {
    "amount": {
      "currency_code": "currency_code6",
      "amount": "amount0"
    },
    "currency_exchange": {
      "source_currency": "source_currency8",
      "target_currency": "target_currency0",
      "unit_currency": "unit_currency0",
      "exchange_rate": "exchange_rate6",
      "contract_identification": "contract_identification6",
      "quotation_date": "quotation_date8"
    }
  },
  "proprietary_amount": [
    {
      "amount": {
        "currency_code": "currency_code6",
        "amount": "amount0"
      },
      "currency_exchange": {
        "source_currency": "source_currency8",
        "target_currency": "target_currency0",
        "unit_currency": "unit_currency0",
        "exchange_rate": "exchange_rate6",
        "contract_identification": "contract_identification6",
        "quotation_date": "quotation_date8"
      }
    }
  ]
}
```


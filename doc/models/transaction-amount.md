
# Transaction Amount

## Structure

`TransactionAmount`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Amount` | [`Amount1`](../../doc/models/amount-1.md) | Required | - |
| `CurrencyExchange` | [`CurrencyExchange2`](../../doc/models/currency-exchange-2.md) | Optional | - |

## Example (as JSON)

```json
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
```


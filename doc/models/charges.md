
# Charges

Provides further details on the charges related to the payment transaction.

## Structure

`Charges`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TotalChargesAndTaxAmount` | [`TotalChargesAndTaxAmount`](../../doc/models/total-charges-and-tax-amount.md) | Optional | - |
| `Record` | [`List<ChargesRecord>`](../../doc/models/charges-record.md) | Optional | Provides details of the individual charges record. |

## Example (as JSON)

```json
{
  "total_charges_and_tax_amount": {
    "currency": "currency2",
    "amount": "amount4"
  },
  "record": [
    {
      "amount": {
        "currency": "currency2",
        "amount": "amount0"
      },
      "credit_debit_indicator": "CRDT",
      "charge_included_indicator": false,
      "type": {
        "identification": "identification8",
        "scheme_name": "scheme_name6",
        "issuer": "issuer0"
      },
      "rate": "rate0",
      "bearer": "DEBT"
    },
    {
      "amount": {
        "currency": "currency2",
        "amount": "amount0"
      },
      "credit_debit_indicator": "CRDT",
      "charge_included_indicator": false,
      "type": {
        "identification": "identification8",
        "scheme_name": "scheme_name6",
        "issuer": "issuer0"
      },
      "rate": "rate0",
      "bearer": "DEBT"
    },
    {
      "amount": {
        "currency": "currency2",
        "amount": "amount0"
      },
      "credit_debit_indicator": "CRDT",
      "charge_included_indicator": false,
      "type": {
        "identification": "identification8",
        "scheme_name": "scheme_name6",
        "issuer": "issuer0"
      },
      "rate": "rate0",
      "bearer": "DEBT"
    }
  ]
}
```


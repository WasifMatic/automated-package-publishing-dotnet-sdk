
# Charges Record

Provides further individual record details on the charges related to the payment transaction.

## Structure

`ChargesRecord`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Amount` | [`Amount`](../../doc/models/amount.md) | Required | - |
| `CreditDebitIndicator` | [`CreditDebitCodeEnum?`](../../doc/models/credit-debit-code-enum.md) | Optional | - |
| `ChargeIncludedIndicator` | `bool?` | Optional | Indicates whether the charge should be included in the amount or is added as pre-advice. |
| `Type` | [`Type`](../../doc/models/type.md) | Optional | - |
| `Rate` | `string` | Optional | Rate expressed as a percentage, that is, in hundredths, for example, 0.7 is 7/10 of a percent, and 7.0 is 7%.<br><br>**Constraints**: *Maximum Length*: `12` |
| `Bearer` | [`ChargeBearerTypeCodeEnum?`](../../doc/models/charge-bearer-type-code-enum.md) | Optional | - |
| `Agent` | [`Agent`](../../doc/models/agent.md) | Optional | - |
| `Tax` | [`Tax`](../../doc/models/tax.md) | Optional | - |

## Example (as JSON)

```json
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
```


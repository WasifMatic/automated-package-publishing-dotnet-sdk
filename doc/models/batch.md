
# Batch

## Structure

`Batch`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MessageIdentification` | `string` | Optional | Point to point reference, as assigned by the sending party, to unambiguously identify the batch of transactions.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `35`, *Pattern*: `^[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]+$` |
| `PaymentInformationIdentification` | `string` | Optional | Unique identification, as assigned by a sending party, to unambiguously identify the payment information group within the message.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `35`, *Pattern*: `^[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]+$` |
| `NumberOfTransactions` | `int?` | Optional | - |
| `TotalAmount` | [`TotalAmount`](../../doc/models/total-amount.md) | Optional | - |
| `CreditDebitIndicator` | [`CreditDebitCodeEnum?`](../../doc/models/credit-debit-code-enum.md) | Optional | - |

## Example (as JSON)

```json
{
  "message_identification": "message_identification8",
  "payment_information_identification": "payment_information_identification8",
  "number_of_transactions": 114,
  "total_amount": {
    "currency": "currency6",
    "amount": "amount8"
  },
  "credit_debit_indicator": "CRDT"
}
```


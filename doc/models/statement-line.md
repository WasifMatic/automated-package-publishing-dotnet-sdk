
# Statement Line

Posting to an account that results in an increase or decrease to a balance.

## Structure

`StatementLine`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `EntryReference` | `string` | Required | Unique reference for the entry. Technical incremental identification of the transaction.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `35`, *Pattern*: `^[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]+$` |
| `References` | [`References`](../../doc/models/references.md) | Optional | - |
| `Batch` | [`Batch`](../../doc/models/batch.md) | Optional | - |
| `Amount` | [`Amount1`](../../doc/models/amount-1.md) | Required | - |
| `CreditDebitIndicator` | [`CreditDebitCodeEnum`](../../doc/models/credit-debit-code-enum.md) | Required | - |
| `BookingDate` | [`StatementLineBookingDate`](../../doc/models/containers/statement-line-booking-date.md) | Optional | This is a container for one-of cases. |
| `ValueDate` | [`StatementLineValueDate`](../../doc/models/containers/statement-line-value-date.md) | Optional | This is a container for one-of cases. |
| `BankTransactionCode` | [`BankTransactionCode1`](../../doc/models/bank-transaction-code-1.md) | Required | - |
| `Purpose` | `string` | Optional | Specifies the external purpose code in the format of character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately. External code sets can be downloaded from www.iso20022.org.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `4` |
| `RemittanceInformation` | `object` | Optional | - |

## Example (as JSON)

```json
{
  "entry_reference": "entry_reference8",
  "references": {
    "message_identification": "message_identification0",
    "account_servicer_reference": "account_servicer_reference6",
    "payment_information_identification": "payment_information_identification4",
    "instruction_identification": "instruction_identification8",
    "end_to_end_identification": "end_to_end_identification2"
  },
  "batch": {
    "message_identification": "message_identification0",
    "payment_information_identification": "payment_information_identification4",
    "number_of_transactions": 212,
    "total_amount": {
      "currency": "currency6",
      "amount": "amount8"
    },
    "credit_debit_indicator": "CRDT"
  },
  "amount": {
    "currency_code": "currency_code6",
    "amount": "amount0"
  },
  "credit_debit_indicator": "CRDT",
  "booking_date": "String7",
  "value_date": "String9",
  "bank_transaction_code": {
    "domain_code": "domain_code4",
    "family_code": "family_code0",
    "sub_family_code": "sub_family_code0",
    "proprietary_code": "proprietary_code2",
    "issuer": "issuer4"
  },
  "purpose": "purpose2"
}
```


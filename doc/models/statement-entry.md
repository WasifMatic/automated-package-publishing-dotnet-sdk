
# Statement Entry

Specifies an entry in the Statement.

Usage - At least one reference must be provided to identify the entry and its underlying transaction(s).

## Structure

`StatementEntry`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `EntryReference` | `string` | Required | Unique reference for the entry. The entry is unique per transaction within the statement. Technical incremental identification of the transaction.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `35`, *Pattern*: `^[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]+$` |
| `AccountServicerReference` | `string` | Optional | Unique reference as assigned by the account servicing institution to unambiguously identify the entry.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `35`, *Pattern*: `^[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]+$` |
| `Amount` | [`Amount1`](../../doc/models/amount-1.md) | Required | - |
| `CreditDebitIndicator` | [`CreditDebitCodeEnum`](../../doc/models/credit-debit-code-enum.md) | Required | - |
| `ReversalIndicator` | `bool?` | Optional | Indicates whether or not the entry is the result of a reversal.<br><br>*`Usage:` This element should only be present if the entry is the result of a reversal. If the CreditDebitIndicator is CRDT and ReversalIndicator is Yes, the original operation was a debit entry. If the CreditDebitIndicator is DBIT and ReversalIndicator is Yes, the original operation was a credit entry.<br><br>**Default**: `false` |
| `Status` | `string` | Required | Specifies the status of an entry on the books of the account servicer, as published in an external code set. External code sets can be downloaded from www.iso20022.org.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `4` |
| `BookingDate` | [`StatementEntryBookingDate`](../../doc/models/containers/statement-entry-booking-date.md) | Optional | This is a container for one-of cases. |
| `ValueDate` | [`StatementEntryValueDate`](../../doc/models/containers/statement-entry-value-date.md) | Required | This is a container for one-of cases. |
| `Availability` | [`List<CashAvailability>`](../../doc/models/cash-availability.md) | Optional | Set of elements used to indicate when the booked amount of money will become available, that is can be accessed and starts generating interest.<br><br>Usage: This type of information is used in the US and is linked to particular instruments such as cheques. Example: When a cheque is deposited, it will be booked on the deposit day, but the amount of money will only be accessible as of the indicated availability day (according to national banking regulations). |
| `BankTransactionCode` | [`BankTransactionCode1`](../../doc/models/bank-transaction-code-1.md) | Required | - |
| `AmountDetails` | [`AmountDetails`](../../doc/models/amount-details.md) | Optional | - |
| `Charges` | [`Charges1`](../../doc/models/charges-1.md) | Optional | - |
| `EntryDetails` | [`EntryDetails`](../../doc/models/entry-details.md) | Optional | - |

## Example (as JSON)

```json
{
  "entry_reference": "entry_reference0",
  "amount": {
    "currency_code": "currency_code6",
    "amount": "amount0"
  },
  "credit_debit_indicator": "CRDT",
  "reversal_indicator": false,
  "status": "status0",
  "value_date": "String1",
  "bank_transaction_code": {
    "domain_code": "domain_code4",
    "family_code": "family_code0",
    "sub_family_code": "sub_family_code0",
    "proprietary_code": "proprietary_code2",
    "issuer": "issuer4"
  },
  "account_servicer_reference": "account_servicer_reference0",
  "booking_date": "String9",
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
    },
    {
      "date": "date6",
      "amount": {
        "currency_code": "currency_code6",
        "amount": "amount0"
      },
      "credit_debit_indicator": "CRDT"
    }
  ],
  "amount_details": {
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
}
```


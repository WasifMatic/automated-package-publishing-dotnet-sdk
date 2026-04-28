
# Statement Entry Details

Provides details on the entry.

## Structure

`StatementEntryDetails`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Batch` | [`Batch`](../../doc/models/batch.md) | Optional | - |
| `TransactionDetails` | [`List<StatementTransactionDetails>`](../../doc/models/statement-transaction-details.md) | Required | Provides information on the underlying transaction(s). This provides a breakdown of the transaction details when the entry is 'batched'. If the entry is not batched and transaction details are to be reported, then transaction details must only occur once. |

## Example (as JSON)

```json
{
  "transaction_details": [
    {
      "references": {
        "message_identification": "message_identification0",
        "account_servicer_reference": "account_servicer_reference6",
        "payment_information_identification": "payment_information_identification4",
        "instruction_identification": "instruction_identification8",
        "end_to_end_identification": "end_to_end_identification2"
      },
      "amount": {
        "currency_code": "currency_code6",
        "amount": "amount0"
      },
      "credit_debit_indicator": "CRDT",
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
      },
      "availability": [
        {
          "date": "date6",
          "amount": {
            "currency_code": "currency_code6",
            "amount": "amount0"
          },
          "credit_debit_indicator": "CRDT"
        }
      ],
      "bank_transaction_code": {
        "domain_code": "domain_code4",
        "family_code": "family_code0",
        "sub_family_code": "sub_family_code0",
        "proprietary_code": "proprietary_code2",
        "issuer": "issuer4"
      },
      "charges": {
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
    }
  ],
  "batch": {
    "message_identification": "message_identification0",
    "payment_information_identification": "payment_information_identification4",
    "number_of_transactions": 212,
    "total_amount": {
      "currency": "currency6",
      "amount": "amount8"
    },
    "credit_debit_indicator": "CRDT"
  }
}
```


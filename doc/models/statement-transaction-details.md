
# Statement Transaction Details

Provides information on the underlying transaction(s). This provides a breakdown of the transaction details when the entry is 'batched'. If the entry is not batched and transaction details are to be reported, then transaction details must only occur once.

## Structure

`StatementTransactionDetails`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `References` | [`References`](../../doc/models/references.md) | Required | - |
| `Amount` | [`Amount1`](../../doc/models/amount-1.md) | Optional | - |
| `CreditDebitIndicator` | [`CreditDebitCodeEnum`](../../doc/models/credit-debit-code-enum.md) | Required | - |
| `AmountDetails` | [`AmountDetails`](../../doc/models/amount-details.md) | Optional | - |
| `Availability` | [`List<CashAvailability>`](../../doc/models/cash-availability.md) | Optional | Set of elements used to indicate when the booked amount of money will become available, that is can be accessed and starts generating interest.<br><br>Usage - This type of information is used in the US and is linked to particular instruments such as cheques. Example - When a cheque is deposited, it will be booked on the deposit day, but the amount of money will only be accessible as of the indicated availability day (according to national banking regulations). |
| `BankTransactionCode` | [`BankTransactionCode1`](../../doc/models/bank-transaction-code-1.md) | Optional | - |
| `Charges` | [`Charges1`](../../doc/models/charges-1.md) | Optional | - |
| `RelatedParties` | [`RelatedParties`](../../doc/models/related-parties.md) | Optional | - |
| `RelatedAgents` | [`RelatedAgents`](../../doc/models/related-agents.md) | Optional | - |
| `Purpose` | `string` | Optional | Specifies the external purpose code in the format of character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately. External code sets can be downloaded from www.iso20022.org.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `4` |
| `RemittanceInformation` | `object` | Optional | - |
| `RelatedDates` | [`RelatedDates`](../../doc/models/related-dates.md) | Optional | - |
| `ReturnInformation` | [`ReturnInformation`](../../doc/models/return-information.md) | Optional | - |

## Example (as JSON)

```json
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
```


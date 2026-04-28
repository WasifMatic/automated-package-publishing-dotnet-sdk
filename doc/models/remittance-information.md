
# Remittance Information

Information supplied to enable the matching of an entry with the items that the transfer is intended to settle, such as commercial invoices in an accounts' receivable system.

## Structure

`RemittanceInformation`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ReferredDocumentInformation` | [`List<Document>`](../../doc/models/document.md) | Optional | Provides the identification and the content of the referred document. For example if they payment is against outstanding invoice, provide the invoice details or to apply a credit note specify the detail. |
| `Amount` | [`Amount1`](../../doc/models/amount-1.md) | Optional | - |
| `CreditorReferenceCode` | [`CreditorReferenceCodeEnum?`](../../doc/models/creditor-reference-code-enum.md) | Optional | - |
| `CreditorReference` | `string` | Optional | Unique reference, as assigned by the creditor, to unambiguously refer to the payment transaction.<br><br>Usage: If available, the initiating party should provide this reference in the structured remittance information, to enable reconciliation by the creditor upon receipt of the amount of money.<br><br>If the business context requires the use of a creditor reference or a payment remit identification, and only one identifier can be passed through the end-to-end chain, the creditor's reference or payment remittance identification should be quoted in the end-to-end transaction identification.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `35` |

## Example (as JSON)

```json
{
  "referred_document_information": [
    {
      "type": {
        "code": "MSIN",
        "proprietary": "proprietary6"
      },
      "number": "number0",
      "related_date": "related_date0",
      "line_details": [
        {
          "identification": "identification6",
          "description": "description8",
          "amount": {
            "currency_code": "currency_code6",
            "amount": "amount0"
          },
          "credit_debit_indicator": "CRDT",
          "adjustment_reason": "adjustment_reason0"
        },
        {
          "identification": "identification6",
          "description": "description8",
          "amount": {
            "currency_code": "currency_code6",
            "amount": "amount0"
          },
          "credit_debit_indicator": "CRDT",
          "adjustment_reason": "adjustment_reason0"
        },
        {
          "identification": "identification6",
          "description": "description8",
          "amount": {
            "currency_code": "currency_code6",
            "amount": "amount0"
          },
          "credit_debit_indicator": "CRDT",
          "adjustment_reason": "adjustment_reason0"
        }
      ]
    },
    {
      "type": {
        "code": "MSIN",
        "proprietary": "proprietary6"
      },
      "number": "number0",
      "related_date": "related_date0",
      "line_details": [
        {
          "identification": "identification6",
          "description": "description8",
          "amount": {
            "currency_code": "currency_code6",
            "amount": "amount0"
          },
          "credit_debit_indicator": "CRDT",
          "adjustment_reason": "adjustment_reason0"
        },
        {
          "identification": "identification6",
          "description": "description8",
          "amount": {
            "currency_code": "currency_code6",
            "amount": "amount0"
          },
          "credit_debit_indicator": "CRDT",
          "adjustment_reason": "adjustment_reason0"
        },
        {
          "identification": "identification6",
          "description": "description8",
          "amount": {
            "currency_code": "currency_code6",
            "amount": "amount0"
          },
          "credit_debit_indicator": "CRDT",
          "adjustment_reason": "adjustment_reason0"
        }
      ]
    }
  ],
  "amount": {
    "currency_code": "currency_code6",
    "amount": "amount0"
  },
  "creditor_reference_code": "PUOR",
  "creditor_reference": "creditor_reference6"
}
```


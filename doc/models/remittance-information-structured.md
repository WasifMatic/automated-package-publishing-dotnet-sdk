
# Remittance Information Structured

## Structure

`RemittanceInformationStructured`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Structured` | [`List<RemittanceInformation>`](../../doc/models/remittance-information.md) | Required | - |

## Example (as JSON)

```json
{
  "structured": [
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
      "creditor_reference": "creditor_reference8"
    }
  ]
}
```


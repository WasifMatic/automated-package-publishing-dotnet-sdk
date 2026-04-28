
# Accounts Response 2

## Structure

`AccountsResponse2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountIdentification` | `string` | Required | Identification of the account as defined by the account service provider. It can be in IBAN or proprietary format.<br><br>RECOMMENDATION IN ORDER OF PREFERENCE:<br>IBAN - When available IBAN must be specified for instance endpoint or hyper link to work.<br>Other - In the absence of IBAN, this must be an unique account identification used for routing of the payment to the account via clearing system. A format which is agreed between the account owner and the account servicer. For example a SWIFT BIC/Branch Code and Account number.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `34` |
| `AlternateIdentification` | `Guid?` | Optional | The ID of the account that the bank account is associated with. The value must be constant throughout the lifecycle of the account. This identification shall be used as a resource identifier where account identification cannot be used as a resource identification. Specified as Universally Unique Identifier (UUID) version 4, as described in IETC RFC 4122 "Universally Unique Identifier (UUID) URN Namespace<br><br>Usage: The account_identification is the resource identification. This identification should be used when account_identification cannot be used as an identification due to the internal policy of an organisation. Should that be the case, all other endpoint require account_identification in path parameter must use the same identification return by this endpoint. |
| `AccountServicer` | `string` | Optional | Code allocated to a financial institution by the ISO 9362 Registration Authority as described in ISO 9362 - 2014 - Banking - Banking telecommunication messages - Business identifier code (BIC)<br><br>**Constraints**: *Pattern*: `^[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}$` |
| `Name` | `string` | Required | Specifies a character string with a maximum length of 70characters.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `70` |
| `OwnerName` | `string` | Optional | Specifies a character string with a maximum length of 70characters.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `70` |
| `Currency` | `string` | Required | A code allocated to a currency by a Maintenance Agency under an international identification scheme as described in the latest edition of the international standard ISO 4217 'Codes for the representation of currencies and funds<br><br>**Constraints**: *Pattern*: `^[A-Z]{3,3}$` |
| `RelatedAccount` | `string` | Optional | Identifies the parent account of the account for which the statement has been issued.<br>Usage: Should be used when more than one identification is required to clearly establish the identity. For example when Proxy Identification is specified in primary identification a secondary identification Proxy Code is required for unambiguous identification. Another example is when Virtual Account or Zero Balance Account is specified in the primary identification, the alternate identification should be the parent account.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `34` |
| `Balances` | [`Balances`](../../doc/models/balances.md) | Required | - |
| `Status` | `string` | Optional | Specifies a character string with a maximum length of 35 characters.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `35` |
| `CreditLimit` | [`CreditLimit`](../../doc/models/credit-limit.md) | Optional | - |
| `Links` | [`List<Link>`](../../doc/models/link.md) | Optional | - |

## Example (as JSON)

```json
{
  "account_identification": "account_identification2",
  "alternate_identification": "00001db2-0000-0000-0000-000000000000",
  "account_servicer": "account_servicer4",
  "name": "name8",
  "owner_name": "owner_name0",
  "currency": "currency8",
  "related_account": "related_account8",
  "balances": {
    "current_balance": {
      "balance_amount": {
        "amount": {
          "currency": "currency2",
          "amount": "amount0"
        },
        "credit_debit_indicator": "CRDT"
      },
      "last_change_date_time": "last_change_date_time8",
      "date_time": "date_time8",
      "last_committed_transaction_identification": "last_committed_transaction_identification0",
      "credit_line": [
        {
          "included": false,
          "type": "type8",
          "amount": {
            "currency": "currency2",
            "amount": "amount0"
          }
        },
        {
          "included": false,
          "type": "type8",
          "amount": {
            "currency": "currency2",
            "amount": "amount0"
          }
        },
        {
          "included": false,
          "type": "type8",
          "amount": {
            "currency": "currency2",
            "amount": "amount0"
          }
        }
      ]
    },
    "available_balance": {
      "balance_amount": {
        "amount": {
          "currency": "currency2",
          "amount": "amount0"
        },
        "credit_debit_indicator": "CRDT"
      },
      "availability_date": "availability_date2"
    },
    "forward_available_balance": [
      {
        "balance_amount": {
          "amount": {
            "currency": "currency2",
            "amount": "amount0"
          },
          "credit_debit_indicator": "CRDT"
        },
        "availability_date": "availability_date2"
      },
      {
        "balance_amount": {
          "amount": {
            "currency": "currency2",
            "amount": "amount0"
          },
          "credit_debit_indicator": "CRDT"
        },
        "availability_date": "availability_date2"
      },
      {
        "balance_amount": {
          "amount": {
            "currency": "currency2",
            "amount": "amount0"
          },
          "credit_debit_indicator": "CRDT"
        },
        "availability_date": "availability_date2"
      }
    ]
  },
  "status": "status0"
}
```


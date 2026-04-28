
# References

## Structure

`References`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MessageIdentification` | `string` | Optional | Point to point reference, as assigned by the instructing party of the underlying message.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `35`, *Pattern*: `^[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]+$` |
| `AccountServicerReference` | `string` | Optional | Unique reference, as assigned by the account servicing institution, to unambiguously identify the instruction.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `35`, *Pattern*: `^[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]+$` |
| `PaymentInformationIdentification` | `string` | Optional | Unique identification, as assigned by a sending party, to unambiguously identify the payment information group within the message.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `35`, *Pattern*: `^[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]+$` |
| `InstructionIdentification` | `string` | Optional | Unique identification, as assigned by an instructing party for an instructed party, to unambiguously identify the instruction.  Usage: The instruction identification is a point to point reference that can be used between the instructing party and the instructed party to refer to the individual instruction. It can be included in several messages related to the instruction.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `35`, *Pattern*: `^[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]+$` |
| `EndToEndIdentification` | `string` | Optional | Unique identification, as assigned by the initiating party, to unambiguously identify the transaction. This identification is passed on, unchanged, throughout the entire end-to-end chain.  Usage: The end-to-end identification can be used for reconciliation or to link tasks relating to the transaction. It can be included in several messages related to the transaction.  Usage: In case there are technical limitations to pass on multiple references, the end-to-end identification must be passed on throughout the entire end-to-end chain.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `35`, *Pattern*: `^[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]+$` |
| `Uetr` | `Guid?` | Optional | Universally unique identifier to provide an end-to-end reference of a payment transaction. |
| `TransactionIdentification` | `string` | Optional | Unique identification, as assigned by the first instructing agent, to unambiguously identify the transaction that is passed on, unchanged, throughout the entire interbank chain.  Usage: The transaction identification can be used for reconciliation, tracking or to link tasks relating to the transaction on the interbank level.  Usage: The instructing agent has to make sure that the transaction identification is unique for a pre-agreed period.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `35`, *Pattern*: `^[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]+$` |
| `MandateIdentification` | `string` | Optional | Unique identification, as assigned by the creditor, to unambiguously identify the mandate.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `35`, *Pattern*: `^[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]+$` |
| `ChequeNumber` | `string` | Optional | Unique and unambiguous identifier for a cheque as assigned by the agent.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `35`, *Pattern*: `^[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]+$` |
| `ClearingSystemReference` | `string` | Optional | Unique reference, as assigned by a clearing system, to unambiguously identify the instruction. Usage: In case there are technical limitations to pass on multiple references, the end-to-end identification must be passed on throughout the entire end-to-end chain.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `35` |

## Example (as JSON)

```json
{
  "message_identification": "message_identification8",
  "account_servicer_reference": "account_servicer_reference8",
  "payment_information_identification": "payment_information_identification2",
  "instruction_identification": "instruction_identification6",
  "end_to_end_identification": "end_to_end_identification0"
}
```


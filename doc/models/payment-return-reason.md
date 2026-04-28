
# Payment Return Reason

Provides further details on the reason of the return of the transaction.

## Structure

`PaymentReturnReason`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `OriginalTransactionIdentification` | `string` | Optional | Specify the original statement entry reference (transaction_identification) as specified in the previous statement.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `35` |
| `Reason` | `object` | Optional | - |
| `AdditionalInformation` | `string` | Optional | Further details on the return reason.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `105` |

## Example (as JSON)

```json
{
  "original_transaction_identification": "original_transaction_identification8",
  "reason": {
    "key1": "val1",
    "key2": "val2"
  },
  "additional_information": "additional_information4"
}
```



# Account Identification IBAN

## Structure

`AccountIdentificationIBAN`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Iban` | `string` | Required | An identifier used internationally by financial institutions to uniquely identify the account of a customer at a financial institution, as described in the latest edition of the international standard ISO 13616: 2007 - "Banking and related financial services - International Bank Account Number (IBAN)".<br><br>**Constraints**: *Pattern*: `^[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}$` |

## Example (as JSON)

```json
{
  "iban": "iban4"
}
```



# Creditor Account

## Structure

`CreditorAccount`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Identification` | `object` | Required | - |
| `Type` | `object` | Optional | - |
| `Currency` | `string` | Optional | A code allocated to a currency by a Maintenance Agency under an international identification scheme, as described in the latest edition of the international standard ISO 4217 "Codes for the representation of currencies and funds".<br><br>**Constraints**: *Pattern*: `^[A-Z]{3,3}$` |
| `Name` | `string` | Optional | Name of the account, as assigned by the account servicing institution, in agreement with the account owner in order to provide an additional means of identification of the account.<br><br>Usage: The account name is different from the account owner name. The account name is used in certain user communities to provide a means of identifying the account, in addition to the account owners identity and the account number.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `70`, *Pattern*: `^[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]+$` |
| `AlternateIdentification` | [`AlternateIdentification`](../../doc/models/alternate-identification.md) | Optional | - |

## Example (as JSON)

```json
{
  "identification": {
    "key1": "val1",
    "key2": "val2"
  },
  "type": {
    "key1": "val1",
    "key2": "val2"
  },
  "currency": "currency8",
  "name": "name8",
  "alternate_identification": {
    "identification": "identification2",
    "scheme_name": "scheme_name6",
    "issuer": "issuer0"
  }
}
```


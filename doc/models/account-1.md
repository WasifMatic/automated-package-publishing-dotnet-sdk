
# Account 1

## Structure

`Account1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Identification` | `object` | Required | - |
| `Type` | `object` | Optional | - |
| `Currency` | `string` | Required | A code allocated to a currency by a Maintenance Agency under an international identification scheme, as described in the latest edition of the international standard ISO 4217 "Codes for the representation of currencies and funds".<br><br>**Constraints**: *Pattern*: `^[A-Z]{3,3}$` |
| `Name` | `string` | Optional | Name of the account, as assigned by the account servicing institution, in agreement with the account owner in order to provide an additional means of identification of the account.<br><br>Usage: The account name is different from the account owner name. The account name is used in certain user communities to provide a means of identifying the account, in addition to the account owner's identity and the account number.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `70`, *Pattern*: `^[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]+$` |
| `AlternateIdentification` | [`AlternateIdentification`](../../doc/models/alternate-identification.md) | Optional | - |
| `Owner` | [`Owner`](../../doc/models/owner.md) | Optional | - |
| `Servicer` | [`Servicer`](../../doc/models/servicer.md) | Optional | - |

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
  "currency": "currency0",
  "name": "name0",
  "alternate_identification": {
    "identification": "identification2",
    "scheme_name": "scheme_name6",
    "issuer": "issuer0"
  },
  "owner": {
    "name": "name4",
    "postal_address": {
      "department": "department8",
      "sub_department": "sub_department8",
      "street_name": "street_name4",
      "building_number": "building_number0",
      "building_name": "building_name2",
      "town_name": "town_name0",
      "country": "country6"
    },
    "identification": {
      "key1": "val1",
      "key2": "val2"
    },
    "country_of_residence": "country_of_residence2"
  },
  "servicer": {
    "financial_institution_identification": {
      "bicfi": "bicfi4",
      "clearing_system_member_identification": {
        "clearing_system_identification": {
          "key1": "val1",
          "key2": "val2"
        },
        "member_identification": "member_identification8"
      },
      "lei": "lei8",
      "name": "name0",
      "postal_address": {
        "department": "department8",
        "sub_department": "sub_department8",
        "street_name": "street_name4",
        "building_number": "building_number0",
        "building_name": "building_name2",
        "town_name": "town_name0",
        "country": "country6"
      }
    },
    "branch_identification": {
      "identification": "identification4",
      "lei": "lei0",
      "name": "name8",
      "postal_address": {
        "department": "department8",
        "sub_department": "sub_department8",
        "street_name": "street_name4",
        "building_number": "building_number0",
        "building_name": "building_name2",
        "town_name": "town_name0",
        "country": "country6"
      }
    }
  }
}
```


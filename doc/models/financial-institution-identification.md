
# Financial Institution Identification

Specifies the details to identify a financial institution.

## Structure

`FinancialInstitutionIdentification`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Bicfi` | `string` | Optional | Code allocated to a financial institution by the ISO 9362 Registration Authority as described in ISO 9362 - 2014 - Banking - Banking telecommunication messages - Business identifier code (BIC)<br><br>**Constraints**: *Pattern*: `^[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}$` |
| `ClearingSystemMemberIdentification` | [`ClearingSystemMemberIdentification2`](../../doc/models/clearing-system-member-identification-2.md) | Optional | - |
| `Lei` | `string` | Optional | Legal Entity Identifier is a code allocated to a party as described in ISO 17442 "Financial Services - Legal Entity Identifier (LEI)".<br><br>**Constraints**: *Pattern*: `^[A-Z0-9]{18,18}[0-9]{2,2}$` |
| `Name` | `string` | Optional | Name by which an agent is known and which is usually used to identify that agent.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `140`, *Pattern*: ``^[0-9a-zA-Z/\-\?:\(\)\.,'\+ !#$%&\*=^_`\{\\|\}~";<>@\[\\\]]+$`` |
| `PostalAddress` | [`FinancialInstitutionIdentificationPostalAddress`](../../doc/models/containers/financial-institution-identification-postal-address.md) | Optional | This is a container for one-of cases. |
| `Other` | [`Other`](../../doc/models/other.md) | Optional | - |

## Example (as JSON)

```json
{
  "bicfi": "bicfi8",
  "clearing_system_member_identification": {
    "clearing_system_identification": {
      "key1": "val1",
      "key2": "val2"
    },
    "member_identification": "member_identification8"
  },
  "lei": "lei2",
  "name": "name6",
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
```


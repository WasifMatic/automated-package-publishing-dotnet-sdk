
# Branch Identification 2

## Structure

`BranchIdentification2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Identification` | `string` | Optional | Unique and unambiguous identification of a branch of a financial institution.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `35` |
| `Lei` | `string` | Optional | Legal Entity Identifier is a code allocated to a party as described in ISO 17442 "Financial Services - Legal Entity Identifier (LEI)".<br><br>**Constraints**: *Pattern*: `^[A-Z0-9]{18,18}[0-9]{2,2}$` |
| `Name` | `string` | Optional | Name by which an agent is known and which is usually used to identify that agent.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `35` |
| `PostalAddress` | [`BranchIdentification2PostalAddress`](../../doc/models/containers/branch-identification-2-postal-address.md) | Optional | This is a container for one-of cases. |

## Example (as JSON)

```json
{
  "identification": "identification0",
  "lei": "lei6",
  "name": "name2",
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


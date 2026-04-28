
# Branch Identification

Information that locates and identifies a specific branch of a financial institution.

## Structure

`BranchIdentification`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Identification` | `string` | Optional | Unique and unambiguous identification of a branch of a financial institution.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `35` |
| `Lei` | `string` | Optional | Legal Entity Identifier is a code allocated to a party as described in ISO 17442 "Financial Services - Legal Entity Identifier (LEI)".<br><br>**Constraints**: *Pattern*: `^[A-Z0-9]{18,18}[0-9]{2,2}$` |
| `Name` | `string` | Optional | Name by which an agent is known and which is usually used to identify that agent.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `35` |
| `PostalAddress` | [`BranchIdentificationPostalAddress`](../../doc/models/containers/branch-identification-postal-address.md) | Optional | This is a container for one-of cases. |

## Example (as JSON)

```json
{
  "identification": "identification4",
  "lei": "lei8",
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


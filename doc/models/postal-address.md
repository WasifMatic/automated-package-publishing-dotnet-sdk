
# Postal Address

Information that locates and identifies a specific address.

## Structure

`PostalAddress`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Department` | `string` | Optional | Identification of a division of a large organisation or building.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `70` |
| `SubDepartment` | `string` | Optional | Identification of a sub-division of a large organisation or building.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `70` |
| `StreetName` | `string` | Optional | Name of a street or thoroughfare.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `70` |
| `BuildingNumber` | `string` | Optional | Number that identifies the position of a building on a street.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `16` |
| `BuildingName` | `string` | Optional | Name of the building or house.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `35` |
| `Floor` | `string` | Optional | Floor or storey within a building.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `70` |
| `PostBox` | `string` | Optional | Numbered box in a post office, assigned to a person or organisation, where letters are kept until called for.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `16` |
| `Room` | `string` | Optional | Building room number.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `70` |
| `PostCode` | `string` | Optional | Identifier consisting of a group of letters and/or numbers that is added to a postal address to assist the sorting of mail.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `16` |
| `TownName` | `string` | Required | Name of a built-up area, with defined boundaries, and a local government.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `35` |
| `TownLocationName` | `string` | Optional | Specific location name within the town.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `35` |
| `DistrictName` | `string` | Optional | Identifies a subdivision within a country sub-division.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `35` |
| `CountrySubDivision` | `string` | Optional | Identifies a subdivision of a country such as state, region, county.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `35` |
| `Country` | `string` | Required | Nation with its own government.<br><br>**Constraints**: *Minimum Length*: `2`, *Maximum Length*: `2`, *Pattern*: `^[A-Z]{2,2}$` |

## Example (as JSON)

```json
{
  "department": "department8",
  "sub_department": "sub_department8",
  "street_name": "street_name4",
  "building_number": "building_number0",
  "building_name": "building_name2",
  "town_name": "town_name0",
  "country": "country6"
}
```


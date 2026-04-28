
# Party Identification

Specifies the identification of a person or an organisation.

## Structure

`PartyIdentification`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | Name by which a party is known and which is usually used to identify that party.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `140` |
| `PostalAddress` | [`PartyIdentificationPostalAddress`](../../doc/models/containers/party-identification-postal-address.md) | Optional | This is a container for one-of cases. |
| `Identification` | `object` | Optional | - |
| `CountryOfResidence` | `string` | Optional | Code to identify a country, a dependency, or another area of particular geopolitical interest, on the basis of country names obtained from the United Nations (ISO 3166, Alpha-2 code).<br><br>**Constraints**: *Pattern*: `^[A-Z]{2,2}$` |

## Example (as JSON)

```json
{
  "name": "name6",
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
  "country_of_residence": "country_of_residence4"
}
```


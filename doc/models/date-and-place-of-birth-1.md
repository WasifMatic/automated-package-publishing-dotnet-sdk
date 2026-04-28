
# Date and Place of Birth 1

## Structure

`DateAndPlaceOfBirth1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `BirthDate` | `string` | Required | A particular point in the progression of time in a calendar year expressed in the YYYY-MM-DD format. This representation is defined in "XML Schema Part 2: Datatypes Second Edition - W3C Recommendation 28 October 2004" which is aligned with ISO 8601.<br><br>**Constraints**: *Pattern*: `^(?:[1-9]\d{3}-(?:(?:0[1-9]\|1[0-2])-(?:0[1-9]\|1\d\|2[0-8])\|(?:0[13-9]\|1[0-2])-(?:29\|30)\|(?:0[13578]\|1[02])-31)\|(?:[1-9]\d(?:0[48]\|[2468][048]\|[13579][26])\|(?:[2468][048]\|[13579][26])00)-02-29)$` |
| `ProvinceOfBirth` | `string` | Optional | Province where a person was born.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `35` |
| `CityOfBirth` | `string` | Required | City where a person was born.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `35` |
| `CountryOfBirth` | `string` | Required | Code to identify a country, a dependency, or another area of particular geopolitical interest, on the basis of country names obtained from the United Nations (ISO 3166, Alpha-2 code).<br><br>**Constraints**: *Pattern*: `^[A-Z]{2,2}$` |

## Example (as JSON)

```json
{
  "birth_date": "birth_date0",
  "province_of_birth": "province_of_birth2",
  "city_of_birth": "city_of_birth4",
  "country_of_birth": "country_of_birth6"
}
```


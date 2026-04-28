
# Private Identification

## Structure

`PrivateIdentification`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DateAndPlaceOfBirth` | [`DateAndPlaceOfBirth1`](../../doc/models/date-and-place-of-birth-1.md) | Optional | - |
| `Other` | [`List<GenericPersonIdentification>`](../../doc/models/generic-person-identification.md) | Optional | Unique identification of a person, as assigned by an institution, using an identification scheme.<br><br>**Constraints**: *Maximum Items*: `2` |

## Example (as JSON)

```json
{
  "date_and_place_of_birth": {
    "birth_date": "birth_date0",
    "province_of_birth": "province_of_birth2",
    "city_of_birth": "city_of_birth4",
    "country_of_birth": "country_of_birth6"
  },
  "other": [
    {
      "identification": "identification0",
      "scheme_name": {
        "key1": "val1",
        "key2": "val2"
      },
      "issuer": "issuer2"
    }
  ]
}
```



# Private Party Identification

## Structure

`PrivatePartyIdentification`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PrivateIdentification` | [`PrivateIdentification`](../../doc/models/private-identification.md) | Required | - |

## Example (as JSON)

```json
{
  "private_identification": {
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
      },
      {
        "identification": "identification0",
        "scheme_name": {
          "key1": "val1",
          "key2": "val2"
        },
        "issuer": "issuer2"
      },
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
}
```


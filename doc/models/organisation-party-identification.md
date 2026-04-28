
# Organisation Party Identification

## Structure

`OrganisationPartyIdentification`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `OrganisationIdentification` | [`OrganisationIdentification1`](../../doc/models/organisation-identification-1.md) | Required | - |

## Example (as JSON)

```json
{
  "organisation_identification": {
    "any_bic": "any_bic2",
    "lei": "lei2",
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
      }
    ]
  }
}
```


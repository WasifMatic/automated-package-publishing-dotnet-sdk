
# Organisation Identification

Unique and unambiguous way to identify an organisation.

## Structure

`OrganisationIdentification`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AnyBic` | `string` | Optional | Code allocated to a financial or non-financial institution by the ISO 9362 Registration Authority, as described in ISO 9362: 2014 - "Banking - Banking telecommunication messages - Business identifier code (BIC)".<br><br>**Constraints**: *Pattern*: `^[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}$` |
| `Lei` | `string` | Optional | Legal Entity Identifier is a code allocated to a party as described in ISO 17442 "Financial Services - Legal Entity Identifier (LEI)".<br><br>**Constraints**: *Pattern*: `^[A-Z0-9]{18,18}[0-9]{2,2}$` |
| `Other` | [`List<GenericOrganisationIdentification>`](../../doc/models/generic-organisation-identification.md) | Optional | Unique identification of an organisation, as assigned by an institution, using an identification scheme.<br><br>**Constraints**: *Maximum Items*: `2` |

## Example (as JSON)

```json
{
  "any_bic": "any_bic4",
  "lei": "lei8",
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


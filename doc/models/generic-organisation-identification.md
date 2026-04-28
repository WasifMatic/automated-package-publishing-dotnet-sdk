
# Generic Organisation Identification

Information related to an identification of an organisation.

## Structure

`GenericOrganisationIdentification`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Identification` | `string` | Required | Identification assigned by an institution.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `35` |
| `SchemeName` | `object` | Optional | - |
| `Issuer` | `string` | Optional | Entity that assigns the identification.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `35` |

## Example (as JSON)

```json
{
  "identification": "identification0",
  "scheme_name": {
    "key1": "val1",
    "key2": "val2"
  },
  "issuer": "issuer2"
}
```


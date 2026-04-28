
# Generic Person Identification

Information related to an identification of a person.

## Structure

`GenericPersonIdentification`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Identification` | `string` | Required | Unique and unambiguous identification of a person.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `35` |
| `SchemeName` | `object` | Optional | - |
| `Issuer` | `string` | Optional | Entity that assigns the identification.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `35` |

## Example (as JSON)

```json
{
  "identification": "identification8",
  "scheme_name": {
    "key1": "val1",
    "key2": "val2"
  },
  "issuer": "issuer4"
}
```


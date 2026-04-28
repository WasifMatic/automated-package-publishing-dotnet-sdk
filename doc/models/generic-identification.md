
# Generic Identification

Information related to an identification, for example, party identification or account identification.

## Structure

`GenericIdentification`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Identification` | `string` | Required | Proprietary information, often a code, issued by the data source scheme issuer.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `36` |
| `SchemeName` | `string` | Optional | Short textual description of the scheme.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `35` |
| `Issuer` | `string` | Optional | Entity that assigns the identification.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `35` |

## Example (as JSON)

```json
{
  "identification": "identification0",
  "scheme_name": "scheme_name4",
  "issuer": "issuer2"
}
```


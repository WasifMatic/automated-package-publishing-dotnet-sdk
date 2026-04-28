
# Referred Document Type Choice

Specifies the type of the document referred in the remittance information.

## Structure

`ReferredDocumentTypeChoice`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Code` | [`DocumentTypeCodeEnum?`](../../doc/models/document-type-code-enum.md) | Optional | - |
| `Proprietary` | `string` | Optional | Proprietary identification of the type of the remittance document.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `35` |

## Example (as JSON)

```json
{
  "code": "MSIN",
  "proprietary": "proprietary8"
}
```


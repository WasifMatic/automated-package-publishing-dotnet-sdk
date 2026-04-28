
# Error Message Exception

Custom error schema to support detailed error message.

## Structure

`ErrorMessageException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Severity` | [`SeverityEnum`](../../doc/models/severity-enum.md) | Required | - |
| `Code` | `string` | Required | Specifies the custom error code as defined by the service provider.<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `70` |
| `Text` | `string` | Required | Specifies the detail error message identifying the cause of the error.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `255` |
| `UserMessage` | `string` | Optional | A human-readable text describing the error.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `255` |
| `MoreInfo` | `string` | Optional | Specifies an URL to find more information about the error. |

## Example (as JSON)

```json
{
  "severity": "Fatal",
  "code": "code8",
  "text": "text0",
  "user_message": "user_message4",
  "more_info": "more_info2"
}
```


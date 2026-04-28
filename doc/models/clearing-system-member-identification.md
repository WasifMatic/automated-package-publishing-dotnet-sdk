
# Clearing System Member Identification

Unique identification, as assigned by a clearing system, to unambiguously identify a member of the clearing system.

## Structure

`ClearingSystemMemberIdentification`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ClearingSystemIdentification` | `object` | Optional | - |
| `MemberIdentification` | `string` | Required | Identification of a member of a clearing system.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `35`, *Pattern*: `^[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]+$` |

## Example (as JSON)

```json
{
  "clearing_system_identification": {
    "key1": "val1",
    "key2": "val2"
  },
  "member_identification": "member_identification2"
}
```


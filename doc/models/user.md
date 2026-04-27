
# User

*This model accepts additional fields of type object.*

## Structure

`User`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `long?` | Optional | - |
| `Username` | `string` | Optional | - |
| `FirstName` | `string` | Optional | - |
| `LastName` | `string` | Optional | - |
| `Email` | `string` | Optional | - |
| `Password` | `string` | Optional | - |
| `Phone` | `string` | Optional | - |
| `UserStatus` | `int?` | Optional | User Status |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "id": 82,
  "username": "username6",
  "firstName": "firstName8",
  "lastName": "lastName0",
  "email": "email0",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```


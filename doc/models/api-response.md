
# Api Response

*This model accepts additional fields of type object.*

## Structure

`ApiResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Code` | `int?` | Optional | - |
| `Type` | `string` | Optional | - |
| `Message` | `string` | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "code": 142,
  "type": "type0",
  "message": "message0",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```


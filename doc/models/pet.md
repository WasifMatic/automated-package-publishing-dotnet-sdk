
# Pet

*This model accepts additional fields of type object.*

## Structure

`Pet`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `long?` | Optional | - |
| `Name` | `string` | Required | - |
| `Category` | [`Category`](../../doc/models/category.md) | Optional | - |
| `PhotoUrls` | `List<string>` | Required | - |
| `Tags` | [`List<Tag>`](../../doc/models/tag.md) | Optional | - |
| `Status` | [`PetStatus?`](../../doc/models/pet-status.md) | Optional | pet status in the store |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "id": 120,
  "name": "name0",
  "category": {
    "id": 232,
    "name": "name2",
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "photoUrls": [
    "photoUrls5",
    "photoUrls6"
  ],
  "tags": [
    {
      "id": 26,
      "name": "name0",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "status": "available",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```


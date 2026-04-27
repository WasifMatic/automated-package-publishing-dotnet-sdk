
# Order

*This model accepts additional fields of type object.*

## Structure

`Order`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `long?` | Optional | - |
| `PetId` | `long?` | Optional | - |
| `Quantity` | `int?` | Optional | - |
| `ShipDate` | `DateTime?` | Optional | - |
| `Status` | [`OrderStatus?`](../../doc/models/order-status.md) | Optional | Order Status |
| `Complete` | `bool?` | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "id": 180,
  "petId": 220,
  "quantity": 136,
  "shipDate": "2016-03-13T12:52:32.123Z",
  "status": "placed",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```


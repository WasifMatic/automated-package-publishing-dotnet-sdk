
# Rate

Set of elements used to qualify the interest rate.

## Structure

`Rate`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `object` | Required | - |
| `ValidityRange` | [`ValidityRange`](../../doc/models/validity-range.md) | Optional | - |

## Example (as JSON)

```json
{
  "type": {
    "key1": "val1",
    "key2": "val2"
  },
  "validity_range": {
    "amount": {
      "key1": "val1",
      "key2": "val2"
    },
    "credit_debit_indicator": "CRDT",
    "currency": "currency0"
  }
}
```


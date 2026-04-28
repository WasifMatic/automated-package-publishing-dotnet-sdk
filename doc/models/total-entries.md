
# Total Entries

## Structure

`TotalEntries`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `NumberOfEntries` | `string` | Required | Specifies a numeric string with a maximum length of 15 digits.<br><br>**Constraints**: *Pattern*: `^[0-9]{1,15}$` |
| `TotalNetEntry` | [`TotalNetEntry`](../../doc/models/total-net-entry.md) | Required | - |

## Example (as JSON)

```json
{
  "number_of_entries": "number_of_entries6",
  "total_net_entry": {
    "amount": {
      "currency": "currency2",
      "amount": "amount0"
    },
    "credit_debit_indicator": "CRDT"
  }
}
```



# Total Credit Entries

## Structure

`TotalCreditEntries`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `NumberOfEntries` | `string` | Required | Specifies a numeric string with a maximum length of 15 digits.<br><br>**Constraints**: *Pattern*: `^[0-9]{1,15}$` |
| `Total` | [`Total`](../../doc/models/total.md) | Required | - |

## Example (as JSON)

```json
{
  "number_of_entries": "number_of_entries4",
  "total": {
    "currency": "currency0",
    "amount": "amount2"
  }
}
```


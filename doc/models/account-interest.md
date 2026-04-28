
# Account Interest

Provides general interest information that applies to the account at a particular moment in time.

## Structure

`AccountInterest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `object` | Optional | - |
| `Rate` | [`List<Rate>`](../../doc/models/rate.md) | Optional | Set of elements used to qualify the interest rate. |
| `FromToDate` | [`FromToDate`](../../doc/models/from-to-date.md) | Optional | - |
| `Reason` | `string` | Optional | Specifies the reason for the interest.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `35` |
| `Tax` | [`Tax`](../../doc/models/tax.md) | Optional | - |

## Example (as JSON)

```json
{
  "type": {
    "key1": "val1",
    "key2": "val2"
  },
  "rate": [
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
  ],
  "from_to_date": {
    "from_date_time": "from_date_time4",
    "to_date_time": "to_date_time4"
  },
  "reason": "reason2",
  "tax": {
    "identification": "identification8",
    "rate": "rate6",
    "amount": {
      "currency": "currency2",
      "amount": "amount0"
    }
  }
}
```


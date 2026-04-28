
# Credit Line 6

Specifies the details of a credit line.

## Structure

`CreditLine6`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Included` | `bool` | Required | Indicates whether or not the credit line is included in the balance. |
| `Type` | `string` | Optional | Specifies a character string with a maximum length of 35 characters.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `35` |
| `Amount` | [`Amount12`](../../doc/models/amount-12.md) | Optional | - |

## Example (as JSON)

```json
{
  "included": false,
  "type": "type6",
  "amount": {
    "currency": "currency2",
    "amount": "amount0"
  }
}
```


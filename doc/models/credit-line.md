
# Credit Line

Specifies the details of a credit line.

## Structure

`CreditLine`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Included` | `bool` | Required | Indicates whether or not the credit line is included in the balance. |
| `Type` | `string` | Optional | Specifies the external credit line type code in the format of character string with a maximum length of 4 characters. The list of valid codes is an external code set published separately. External code sets can be downloaded from www.iso20022.org.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `4` |
| `Amount` | [`Amount1`](../../doc/models/amount-1.md) | Optional | - |

## Example (as JSON)

```json
{
  "included": false,
  "type": "type2",
  "amount": {
    "currency_code": "currency_code6",
    "amount": "amount0"
  }
}
```


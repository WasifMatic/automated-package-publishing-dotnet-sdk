
# To Amount

## Structure

`ToAmount`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `BoundaryAmount` | `string` | Required | Number of monetary units specified in a currency where the unit of currency is implied by the context and compliant with ISO 4217. The decimal separator is a dot.<br>Note: a zero amount is considered a positive amount.<br><br>**Constraints**: *Maximum Length*: `18`, *Pattern*: `^0*(([0-9]{0,13}\.[0-9]{1,5})\|([0-9]{0,14}\.[0-9]{1,4})\|([0-9]{0,15}\.[0-9]{1,3})\|([0-9]{0,16}\.[0-9]{1,2})\|([0-9]{0,17}\.[0-9]{1,1})\|0*\|([0-9]{0,18}))$` |
| `Included` | `bool` | Required | Indicates whether the boundary amount is included in the range of amount values. |

## Example (as JSON)

```json
{
  "boundary_amount": "boundary_amount6",
  "included": false
}
```


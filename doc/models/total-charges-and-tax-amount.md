
# Total Charges and Tax Amount

## Structure

`TotalChargesAndTaxAmount`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Currency` | `string` | Optional | A code allocated to a currency by a Maintenance Agency under an international identification scheme, as described in the latest edition of the international standard ISO 4217 "Codes for the representation of currencies and funds".<br><br>**Constraints**: *Pattern*: `^[A-Z]{3,3}$` |
| `Amount` | `string` | Optional | **Constraints**: *Maximum Length*: `18`, *Pattern*: `^0*(([0-9]{0,13}\.[0-9]{1,5})\|([0-9]{0,14}\.[0-9]{1,4})\|([0-9]{0,15}\.[0-9]{1,3})\|([0-9]{0,16}\.[0-9]{1,2})\|([0-9]{0,17}\.[0-9]{1,1})\|0*\|([0-9]{0,18}))$` |

## Example (as JSON)

```json
{
  "currency": "currency8",
  "amount": "amount0"
}
```


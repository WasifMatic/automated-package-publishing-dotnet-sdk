
# Tax

## Structure

`Tax`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Identification` | `string` | Optional | Unique reference to unambiguously identify the nature of the tax levied, such as Value Added Tax (VAT).<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `35` |
| `Rate` | `string` | Optional | Rate expressed as a percentage, that is, in hundredths, for example, 0.7 is 7/10 of a percent, and 7.0 is 7%.<br><br>**Constraints**: *Maximum Length*: `12` |
| `Amount` | [`Amount`](../../doc/models/amount.md) | Optional | - |

## Example (as JSON)

```json
{
  "identification": "identification8",
  "rate": "rate0",
  "amount": {
    "currency": "currency2",
    "amount": "amount0"
  }
}
```


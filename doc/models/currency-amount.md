
# Currency Amount

Amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.

## Structure

`CurrencyAmount`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CurrencyCode` | `string` | Required | ISO three character currency code.<br><br>The Currency Code must be registered, or have already been registered. Valid active or historic currency codes are registered with the ISO 4217 Maintenance Agency, consist of three (3) contiguous letters, and may be or not be withdrawn on the day the message containing the Currency is exchanged.<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `3`, *Pattern*: `^[A-Z]{3,3}$` |
| `Amount` | `string` | Required | The amount with fractional digit. The number of fractional digits (or minor unit of currency) must comply with ISO 4217.<br><br>fractionDigits - 5<br>totalDigits - 18<br>*`Note:` The decimal separator is a dot.<br><br>**Constraints**: *Maximum Length*: `19`, *Pattern*: `^0*(([0-9]{0,13}\.[0-9]{1,5})\|([0-9]{0,14}\.[0-9]{1,4})\|([0-9]{0,15}\.[0-9]{1,3})\|([0-9]{0,16}\.[0-9]{1,2})\|([0-9]{0,17}\.[0-9]{1,1})\|0*\|([0-9]{0,18}))$` |

## Example (as JSON)

```json
{
  "currency_code": "currency_code2",
  "amount": "amount8"
}
```


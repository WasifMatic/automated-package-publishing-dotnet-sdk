
# Currency Exchange

Set of elements used to provide details of the currency exchange.

## Structure

`CurrencyExchange`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SourceCurrency` | `string` | Required | Code allocated to a currency, by a maintenance agency, under an international identification scheme as described in the latest edition of the international standard ISO 4217 "Codes for the representation of currencies and funds". Valid currency codes are registered with the ISO 4217 Maintenance Agency, and consist of three contiguous letters.<br><br>**Constraints**: *Pattern*: `^[A-Z]{3,3}$` |
| `TargetCurrency` | `string` | Optional | Code allocated to a currency, by a maintenance agency, under an international identification scheme as described in the latest edition of the international standard ISO 4217 "Codes for the representation of currencies and funds". Valid currency codes are registered with the ISO 4217 Maintenance Agency, and consist of three contiguous letters.<br><br>**Constraints**: *Pattern*: `^[A-Z]{3,3}$` |
| `UnitCurrency` | `string` | Optional | Code allocated to a currency, by a maintenance agency, under an international identification scheme as described in the latest edition of the international standard ISO 4217 "Codes for the representation of currencies and funds". Valid currency codes are registered with the ISO 4217 Maintenance Agency, and consist of three contiguous letters.<br><br>**Constraints**: *Pattern*: `^[A-Z]{3,3}$` |
| `ExchangeRate` | `string` | Required | Rate expressed as a decimal, for example, 0.7 is 7/10 and 70%.<br><br>**Constraints**: *Maximum Length*: `12` |
| `ContractIdentification` | `string` | Optional | Unique identification to unambiguously identify the foreign exchange contract.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `35` |
| `QuotationDate` | `string` | Optional | A particular point in the progression of time defined by a mandatory date and a mandatory time component, expressed in either UTC time format (YYYY-MM-DDThh:mm:ss.sssZ), local time with UTC offset format (YYYY-MM-DDThh:mm:ss.sss+/-hh:mm), or local time format (YYYY-MM-DDThh:mm:ss.sss). These representations are defined in "XML Schema Part 2: Datatypes Second Edition - W3C Recommendation 28 October 2004" which is aligned with ISO 8601.<br>Note on the time format:<br><br>1) beginning / end of calendar day<br>   00:00:00 = the beginning of a calendar day<br>   24:00:00 = the end of a calendar day<br>2) fractions of second in time format<br>   Decimal fractions of seconds may be included. In this case, the involved parties shall agree on the maximum number of digits that are allowed.<br><br>**Constraints**: *Pattern*: `^(?:[1-9]\d{3}-(?:(?:0[1-9]\|1[0-2])-(?:0[1-9]\|1\d\|2[0-8])\|(?:0[13-9]\|1[0-2])-(?:29\|30)\|(?:0[13578]\|1[02])-31)\|(?:[1-9]\d(?:0[48]\|[2468][048]\|[13579][26])\|(?:[2468][048]\|[13579][26])00)-02-29)T(?:[01]\d\|2[0-3]):[0-5]\d:[0-5]\d(?:\.[0-9]+)?(?:Z\|[+-][01]\d:[0-5]\d)?$` |

## Example (as JSON)

```json
{
  "source_currency": "source_currency2",
  "target_currency": "target_currency4",
  "unit_currency": "unit_currency4",
  "exchange_rate": "exchange_rate2",
  "contract_identification": "contract_identification0",
  "quotation_date": "quotation_date2"
}
```


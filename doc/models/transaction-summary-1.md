
# Transaction Summary 1

Provides a summary on entries for a specific period.

## Structure

`TransactionSummary1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountIdentification` | `string` | Required | Specifies a character string with a maximum length of 34 characters.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `34` |
| `FromDateTime` | `string` | Required | A particular point in the progression of time defined by a mandatory date and a mandatory time component, expressed in either UTC time format (YYYY-MM-DDThh:mm:ss.sssZ), local time with UTC offset format (YYYY-MM-DDThh:mm:ss.sss+/-hh:mm), or local time format (YYYY-MM-DDThh:mm:ss.sss). These representations are defined in "XML Schema Part 2: Datatypes Second Edition - W3C Recommendation 28 October 2004" which is aligned with ISO 8601.<br>Note on the time format:<br><br>1) beginning / end of calendar day<br>   00:00:00 = the beginning of a calendar day<br>   24:00:00 = the end of a calendar day<br>2) fractions of second in time format<br>   Decimal fractions of seconds may be included. In this case, the involved parties shall agree on the maximum number of digits that are allowed.<br><br>**Constraints**: *Pattern*: `^(?:[1-9]\d{3}-(?:(?:0[1-9]\|1[0-2])-(?:0[1-9]\|1\d\|2[0-8])\|(?:0[13-9]\|1[0-2])-(?:29\|30)\|(?:0[13578]\|1[02])-31)\|(?:[1-9]\d(?:0[48]\|[2468][048]\|[13579][26])\|(?:[2468][048]\|[13579][26])00)-02-29)T(?:[01]\d\|2[0-3]):[0-5]\d:[0-5]\d(?:\.[0-9]+)?(?:Z\|[+-][01]\d:[0-5]\d)?$` |
| `ToDateTime` | `string` | Required | A particular point in the progression of time defined by a mandatory date and a mandatory time component, expressed in either UTC time format (YYYY-MM-DDThh:mm:ss.sssZ), local time with UTC offset format (YYYY-MM-DDThh:mm:ss.sss+/-hh:mm), or local time format (YYYY-MM-DDThh:mm:ss.sss). These representations are defined in "XML Schema Part 2: Datatypes Second Edition - W3C Recommendation 28 October 2004" which is aligned with ISO 8601.<br>Note on the time format:<br><br>1) beginning / end of calendar day<br>   00:00:00 = the beginning of a calendar day<br>   24:00:00 = the end of a calendar day<br>2) fractions of second in time format<br>   Decimal fractions of seconds may be included. In this case, the involved parties shall agree on the maximum number of digits that are allowed.<br><br>**Constraints**: *Pattern*: `^(?:[1-9]\d{3}-(?:(?:0[1-9]\|1[0-2])-(?:0[1-9]\|1\d\|2[0-8])\|(?:0[13-9]\|1[0-2])-(?:29\|30)\|(?:0[13578]\|1[02])-31)\|(?:[1-9]\d(?:0[48]\|[2468][048]\|[13579][26])\|(?:[2468][048]\|[13579][26])00)-02-29)T(?:[01]\d\|2[0-3]):[0-5]\d:[0-5]\d(?:\.[0-9]+)?(?:Z\|[+-][01]\d:[0-5]\d)?$` |
| `TotalEntries` | [`TotalEntries`](../../doc/models/total-entries.md) | Optional | - |
| `TotalCreditEntries` | [`TotalCreditEntries`](../../doc/models/total-credit-entries.md) | Optional | - |
| `TotalDebitEntries` | [`TotalDebitEntries`](../../doc/models/total-debit-entries.md) | Optional | - |

## Example (as JSON)

```json
{
  "account_identification": "account_identification0",
  "from_date_time": "from_date_time2",
  "to_date_time": "to_date_time2",
  "total_entries": {
    "number_of_entries": "number_of_entries4",
    "total_net_entry": {
      "amount": {
        "currency": "currency2",
        "amount": "amount0"
      },
      "credit_debit_indicator": "CRDT"
    }
  },
  "total_credit_entries": {
    "number_of_entries": "number_of_entries0",
    "total": {
      "currency": "currency0",
      "amount": "amount2"
    }
  },
  "total_debit_entries": {
    "number_of_entries": "number_of_entries0",
    "total": {
      "currency": "currency0",
      "amount": "amount2"
    }
  }
}
```


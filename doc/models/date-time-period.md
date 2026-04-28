
# Date Time Period

Time span defined by a start date and time, and an end date and time.

## Structure

`DateTimePeriod`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `FromDateTime` | `string` | Required | A particular point in the progression of time defined by a mandatory date and a mandatory time component, expressed in either UTC time format (YYYY-MM-DDThh:mm:ss.sssZ), local time with UTC offset format (YYYY-MM-DDThh:mm:ss.sss+/-hh:mm), or local time format (YYYY-MM-DDThh:mm:ss.sss). These representations are defined in "XML Schema Part 2: Datatypes Second Edition - W3C Recommendation 28 October 2004" which is aligned with ISO 8601.<br>Note on the time format:<br><br>1) beginning / end of calendar day<br>   00:00:00 = the beginning of a calendar day<br>   24:00:00 = the end of a calendar day<br>2) fractions of second in time format<br>   Decimal fractions of seconds may be included. In this case, the involved parties shall agree on the maximum number of digits that are allowed.<br><br>**Constraints**: *Pattern*: `^(?:[1-9]\d{3}-(?:(?:0[1-9]\|1[0-2])-(?:0[1-9]\|1\d\|2[0-8])\|(?:0[13-9]\|1[0-2])-(?:29\|30)\|(?:0[13578]\|1[02])-31)\|(?:[1-9]\d(?:0[48]\|[2468][048]\|[13579][26])\|(?:[2468][048]\|[13579][26])00)-02-29)T(?:[01]\d\|2[0-3]):[0-5]\d:[0-5]\d(?:\.[0-9]+)?(?:Z\|[+-][01]\d:[0-5]\d)?$` |
| `ToDateTime` | `string` | Required | A particular point in the progression of time defined by a mandatory date and a mandatory time component, expressed in either UTC time format (YYYY-MM-DDThh:mm:ss.sssZ), local time with UTC offset format (YYYY-MM-DDThh:mm:ss.sss+/-hh:mm), or local time format (YYYY-MM-DDThh:mm:ss.sss). These representations are defined in "XML Schema Part 2: Datatypes Second Edition - W3C Recommendation 28 October 2004" which is aligned with ISO 8601.<br>Note on the time format:<br><br>1) beginning / end of calendar day<br>   00:00:00 = the beginning of a calendar day<br>   24:00:00 = the end of a calendar day<br>2) fractions of second in time format<br>   Decimal fractions of seconds may be included. In this case, the involved parties shall agree on the maximum number of digits that are allowed.<br><br>**Constraints**: *Pattern*: `^(?:[1-9]\d{3}-(?:(?:0[1-9]\|1[0-2])-(?:0[1-9]\|1\d\|2[0-8])\|(?:0[13-9]\|1[0-2])-(?:29\|30)\|(?:0[13578]\|1[02])-31)\|(?:[1-9]\d(?:0[48]\|[2468][048]\|[13579][26])\|(?:[2468][048]\|[13579][26])00)-02-29)T(?:[01]\d\|2[0-3]):[0-5]\d:[0-5]\d(?:\.[0-9]+)?(?:Z\|[+-][01]\d:[0-5]\d)?$` |

## Example (as JSON)

```json
{
  "from_date_time": "from_date_time6",
  "to_date_time": "to_date_time6"
}
```



# Statement Line Summary

Provides underlying details of transactions that have been included in the entry. Corporate can receive information from their bank(s) about the activity happening on a given account for cash management balance reporting. This will include all entries booked to the account for the specified period.

## Structure

`StatementLineSummary`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Identification` | `string` | Required | Unique identification, as assigned by the account servicer, to unambiguously identify the account statement.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `36`, *Pattern*: `^[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]+$` |
| `CreationDateTime` | `string` | Optional | A particular point in the progression of time defined by a mandatory date and a mandatory time component, expressed in either UTC time format (YYYY-MM-DDThh:mm:ss.sssZ), local time with UTC offset format (YYYY-MM-DDThh:mm:ss.sss+/-hh:mm), or local time format (YYYY-MM-DDThh:mm:ss.sss). These representations are defined in "XML Schema Part 2: Datatypes Second Edition - W3C Recommendation 28 October 2004" which is aligned with ISO 8601.<br>Note on the time format:<br><br>1) beginning / end of calendar day<br>   00:00:00 = the beginning of a calendar day<br>   24:00:00 = the end of a calendar day<br>2) fractions of second in time format<br>   Decimal fractions of seconds may be included. In this case, the involved parties shall agree on the maximum number of digits that are allowed.<br><br>**Constraints**: *Pattern*: `^(?:[1-9]\d{3}-(?:(?:0[1-9]\|1[0-2])-(?:0[1-9]\|1\d\|2[0-8])\|(?:0[13-9]\|1[0-2])-(?:29\|30)\|(?:0[13578]\|1[02])-31)\|(?:[1-9]\d(?:0[48]\|[2468][048]\|[13579][26])\|(?:[2468][048]\|[13579][26])00)-02-29)T(?:[01]\d\|2[0-3]):[0-5]\d:[0-5]\d(?:\.[0-9]+)?(?:Z\|[+-][01]\d:[0-5]\d)?$` |
| `FromDateTime` | `string` | Optional | A particular point in the progression of time defined by a mandatory date and a mandatory time component, expressed in either UTC time format (YYYY-MM-DDThh:mm:ss.sssZ), local time with UTC offset format (YYYY-MM-DDThh:mm:ss.sss+/-hh:mm), or local time format (YYYY-MM-DDThh:mm:ss.sss). These representations are defined in "XML Schema Part 2: Datatypes Second Edition - W3C Recommendation 28 October 2004" which is aligned with ISO 8601.<br>Note on the time format:<br><br>1) beginning / end of calendar day<br>   00:00:00 = the beginning of a calendar day<br>   24:00:00 = the end of a calendar day<br>2) fractions of second in time format<br>   Decimal fractions of seconds may be included. In this case, the involved parties shall agree on the maximum number of digits that are allowed.<br><br>**Constraints**: *Pattern*: `^(?:[1-9]\d{3}-(?:(?:0[1-9]\|1[0-2])-(?:0[1-9]\|1\d\|2[0-8])\|(?:0[13-9]\|1[0-2])-(?:29\|30)\|(?:0[13578]\|1[02])-31)\|(?:[1-9]\d(?:0[48]\|[2468][048]\|[13579][26])\|(?:[2468][048]\|[13579][26])00)-02-29)T(?:[01]\d\|2[0-3]):[0-5]\d:[0-5]\d(?:\.[0-9]+)?(?:Z\|[+-][01]\d:[0-5]\d)?$` |
| `ToDateTime` | `string` | Optional | A particular point in the progression of time defined by a mandatory date and a mandatory time component, expressed in either UTC time format (YYYY-MM-DDThh:mm:ss.sssZ), local time with UTC offset format (YYYY-MM-DDThh:mm:ss.sss+/-hh:mm), or local time format (YYYY-MM-DDThh:mm:ss.sss). These representations are defined in "XML Schema Part 2: Datatypes Second Edition - W3C Recommendation 28 October 2004" which is aligned with ISO 8601.<br>Note on the time format:<br><br>1) beginning / end of calendar day<br>   00:00:00 = the beginning of a calendar day<br>   24:00:00 = the end of a calendar day<br>2) fractions of second in time format<br>   Decimal fractions of seconds may be included. In this case, the involved parties shall agree on the maximum number of digits that are allowed.<br><br>**Constraints**: *Pattern*: `^(?:[1-9]\d{3}-(?:(?:0[1-9]\|1[0-2])-(?:0[1-9]\|1\d\|2[0-8])\|(?:0[13-9]\|1[0-2])-(?:29\|30)\|(?:0[13578]\|1[02])-31)\|(?:[1-9]\d(?:0[48]\|[2468][048]\|[13579][26])\|(?:[2468][048]\|[13579][26])00)-02-29)T(?:[01]\d\|2[0-3]):[0-5]\d:[0-5]\d(?:\.[0-9]+)?(?:Z\|[+-][01]\d:[0-5]\d)?$` |
| `Account` | [`Account1`](../../doc/models/account-1.md) | Required | - |
| `StatementLine` | [`List<StatementLine>`](../../doc/models/statement-line.md) | Optional | Specifies one or more debit/credit entry. |
| `Links` | [`List<Link>`](../../doc/models/link.md) | Optional | - |

## Example (as JSON)

```json
{
  "identification": "identification0",
  "creation_date_time": "creation_date_time2",
  "from_date_time": "from_date_time6",
  "to_date_time": "to_date_time6",
  "account": {
    "identification": {
      "key1": "val1",
      "key2": "val2"
    },
    "type": {
      "key1": "val1",
      "key2": "val2"
    },
    "currency": "currency0",
    "name": "name0",
    "alternate_identification": {
      "identification": "identification2",
      "scheme_name": "scheme_name6",
      "issuer": "issuer0"
    },
    "owner": {
      "name": "name4",
      "postal_address": {
        "department": "department8",
        "sub_department": "sub_department8",
        "street_name": "street_name4",
        "building_number": "building_number0",
        "building_name": "building_name2",
        "town_name": "town_name0",
        "country": "country6"
      },
      "identification": {
        "key1": "val1",
        "key2": "val2"
      },
      "country_of_residence": "country_of_residence2"
    },
    "servicer": {
      "financial_institution_identification": {
        "bicfi": "bicfi4",
        "clearing_system_member_identification": {
          "clearing_system_identification": {
            "key1": "val1",
            "key2": "val2"
          },
          "member_identification": "member_identification8"
        },
        "lei": "lei8",
        "name": "name0",
        "postal_address": {
          "department": "department8",
          "sub_department": "sub_department8",
          "street_name": "street_name4",
          "building_number": "building_number0",
          "building_name": "building_name2",
          "town_name": "town_name0",
          "country": "country6"
        }
      },
      "branch_identification": {
        "identification": "identification4",
        "lei": "lei0",
        "name": "name8",
        "postal_address": {
          "department": "department8",
          "sub_department": "sub_department8",
          "street_name": "street_name4",
          "building_number": "building_number0",
          "building_name": "building_name2",
          "town_name": "town_name0",
          "country": "country6"
        }
      }
    }
  },
  "statement_line": [
    {
      "entry_reference": "entry_reference0",
      "references": {
        "message_identification": "message_identification0",
        "account_servicer_reference": "account_servicer_reference6",
        "payment_information_identification": "payment_information_identification4",
        "instruction_identification": "instruction_identification8",
        "end_to_end_identification": "end_to_end_identification2"
      },
      "batch": {
        "message_identification": "message_identification0",
        "payment_information_identification": "payment_information_identification4",
        "number_of_transactions": 212,
        "total_amount": {
          "currency": "currency6",
          "amount": "amount8"
        },
        "credit_debit_indicator": "CRDT"
      },
      "amount": {
        "currency_code": "currency_code6",
        "amount": "amount0"
      },
      "credit_debit_indicator": "CRDT",
      "booking_date": "String9",
      "value_date": "String1",
      "bank_transaction_code": {
        "domain_code": "domain_code4",
        "family_code": "family_code0",
        "sub_family_code": "sub_family_code0",
        "proprietary_code": "proprietary_code2",
        "issuer": "issuer4"
      },
      "purpose": "purpose4"
    }
  ],
  "links": [
    {
      "href": "href6",
      "rel": "rel0",
      "type": "type4"
    }
  ]
}
```


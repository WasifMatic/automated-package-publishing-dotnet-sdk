
# Accounts Statements Response

## Structure

`AccountsStatementsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Identification` | `string` | Required | Unique identification, as assigned by the account servicer, to unambiguously identify the account statement.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `36`, *Pattern*: `^[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]+$` |
| `CreationDateTime` | `string` | Optional | A particular point in the progression of time defined by a mandatory date and a mandatory time component, expressed in either UTC time format (YYYY-MM-DDThh:mm:ss.sssZ), local time with UTC offset format (YYYY-MM-DDThh:mm:ss.sss+/-hh:mm), or local time format (YYYY-MM-DDThh:mm:ss.sss). These representations are defined in "XML Schema Part 2: Datatypes Second Edition - W3C Recommendation 28 October 2004" which is aligned with ISO 8601.<br>Note on the time format:<br><br>1) beginning / end of calendar day<br>   00:00:00 = the beginning of a calendar day<br>   24:00:00 = the end of a calendar day<br>2) fractions of second in time format<br>   Decimal fractions of seconds may be included. In this case, the involved parties shall agree on the maximum number of digits that are allowed.<br><br>**Constraints**: *Pattern*: `^(?:[1-9]\d{3}-(?:(?:0[1-9]\|1[0-2])-(?:0[1-9]\|1\d\|2[0-8])\|(?:0[13-9]\|1[0-2])-(?:29\|30)\|(?:0[13578]\|1[02])-31)\|(?:[1-9]\d(?:0[48]\|[2468][048]\|[13579][26])\|(?:[2468][048]\|[13579][26])00)-02-29)T(?:[01]\d\|2[0-3]):[0-5]\d:[0-5]\d(?:\.[0-9]+)?(?:Z\|[+-][01]\d:[0-5]\d)?$` |
| `FromDateTime` | `string` | Optional | A particular point in the progression of time defined by a mandatory date and a mandatory time component, expressed in either UTC time format (YYYY-MM-DDThh:mm:ss.sssZ), local time with UTC offset format (YYYY-MM-DDThh:mm:ss.sss+/-hh:mm), or local time format (YYYY-MM-DDThh:mm:ss.sss). These representations are defined in "XML Schema Part 2: Datatypes Second Edition - W3C Recommendation 28 October 2004" which is aligned with ISO 8601.<br>Note on the time format:<br><br>1) beginning / end of calendar day<br>   00:00:00 = the beginning of a calendar day<br>   24:00:00 = the end of a calendar day<br>2) fractions of second in time format<br>   Decimal fractions of seconds may be included. In this case, the involved parties shall agree on the maximum number of digits that are allowed.<br><br>**Constraints**: *Pattern*: `^(?:[1-9]\d{3}-(?:(?:0[1-9]\|1[0-2])-(?:0[1-9]\|1\d\|2[0-8])\|(?:0[13-9]\|1[0-2])-(?:29\|30)\|(?:0[13578]\|1[02])-31)\|(?:[1-9]\d(?:0[48]\|[2468][048]\|[13579][26])\|(?:[2468][048]\|[13579][26])00)-02-29)T(?:[01]\d\|2[0-3]):[0-5]\d:[0-5]\d(?:\.[0-9]+)?(?:Z\|[+-][01]\d:[0-5]\d)?$` |
| `ToDateTime` | `string` | Optional | A particular point in the progression of time defined by a mandatory date and a mandatory time component, expressed in either UTC time format (YYYY-MM-DDThh:mm:ss.sssZ), local time with UTC offset format (YYYY-MM-DDThh:mm:ss.sss+/-hh:mm), or local time format (YYYY-MM-DDThh:mm:ss.sss). These representations are defined in "XML Schema Part 2: Datatypes Second Edition - W3C Recommendation 28 October 2004" which is aligned with ISO 8601.<br>Note on the time format:<br><br>1) beginning / end of calendar day<br>   00:00:00 = the beginning of a calendar day<br>   24:00:00 = the end of a calendar day<br>2) fractions of second in time format<br>   Decimal fractions of seconds may be included. In this case, the involved parties shall agree on the maximum number of digits that are allowed.<br><br>**Constraints**: *Pattern*: `^(?:[1-9]\d{3}-(?:(?:0[1-9]\|1[0-2])-(?:0[1-9]\|1\d\|2[0-8])\|(?:0[13-9]\|1[0-2])-(?:29\|30)\|(?:0[13578]\|1[02])-31)\|(?:[1-9]\d(?:0[48]\|[2468][048]\|[13579][26])\|(?:[2468][048]\|[13579][26])00)-02-29)T(?:[01]\d\|2[0-3]):[0-5]\d:[0-5]\d(?:\.[0-9]+)?(?:Z\|[+-][01]\d:[0-5]\d)?$` |
| `StatementPeriod` | [`StatementPeriodEnum`](../../doc/models/statement-period-enum.md) | Required | - |
| `Account` | [`Account1`](../../doc/models/account-1.md) | Required | - |
| `RelatedAccount` | [`RelatedAccount`](../../doc/models/related-account.md) | Optional | - |
| `Interest` | [`List<AccountInterest>`](../../doc/models/account-interest.md) | Optional | Provides general interest information that applies to the account at a particular moment in time. |
| `Balance` | [`List<Balance>`](../../doc/models/balance.md) | Required | Set of elements used to define the balance as a numerical representation of the net increases and decreases in an account at a specific point in time.  <br>Usage - Required balance types - OPBD = OpeningBooked with date on which the opening balance was determined CLBD = ClosingBooked. Rest of the balance types must be bilaterally determined.<br><br>**Constraints**: *Minimum Items*: `2` |
| `StatementEntry` | [`List<StatementEntry>`](../../doc/models/statement-entry.md) | Optional | Specifies an entry in the Statement. For reporting single transaction or batch.<br><br>Usage - At least one reference must be provided to identify the entry and its underlying transaction(s). |
| `Links` | [`List<Link>`](../../doc/models/link.md) | Optional | - |

## Example (as JSON)

```json
{
  "identification": "identification4",
  "statement_period": "EOMH",
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
  "balance": [
    {
      "type": "ITAV",
      "amount": {
        "currency_code": "currency_code6",
        "amount": "amount0"
      },
      "credit_debit_indicator": "CRDT",
      "date": "String1",
      "credit_line": [
        {
          "included": false,
          "type": "type8",
          "amount": {
            "currency_code": "currency_code6",
            "amount": "amount0"
          }
        }
      ],
      "availability": [
        {
          "date": "date6",
          "amount": {
            "currency_code": "currency_code6",
            "amount": "amount0"
          },
          "credit_debit_indicator": "CRDT"
        }
      ]
    }
  ],
  "creation_date_time": "creation_date_time8",
  "from_date_time": "from_date_time0",
  "to_date_time": "to_date_time0",
  "related_account": {
    "identification": {
      "key1": "val1",
      "key2": "val2"
    },
    "type": {
      "key1": "val1",
      "key2": "val2"
    },
    "currency": "currency6",
    "name": "name6",
    "alternate_identification": {
      "identification": "identification2",
      "scheme_name": "scheme_name6",
      "issuer": "issuer0"
    }
  },
  "interest": [
    {
      "type": {
        "key1": "val1",
        "key2": "val2"
      },
      "rate": [
        {
          "type": {
            "key1": "val1",
            "key2": "val2"
          },
          "validity_range": {
            "amount": {
              "key1": "val1",
              "key2": "val2"
            },
            "credit_debit_indicator": "CRDT",
            "currency": "currency0"
          }
        },
        {
          "type": {
            "key1": "val1",
            "key2": "val2"
          },
          "validity_range": {
            "amount": {
              "key1": "val1",
              "key2": "val2"
            },
            "credit_debit_indicator": "CRDT",
            "currency": "currency0"
          }
        }
      ],
      "from_to_date": {
        "from_date_time": "from_date_time4",
        "to_date_time": "to_date_time4"
      },
      "reason": "reason6",
      "tax": {
        "identification": "identification8",
        "rate": "rate6",
        "amount": {
          "currency": "currency2",
          "amount": "amount0"
        }
      }
    },
    {
      "type": {
        "key1": "val1",
        "key2": "val2"
      },
      "rate": [
        {
          "type": {
            "key1": "val1",
            "key2": "val2"
          },
          "validity_range": {
            "amount": {
              "key1": "val1",
              "key2": "val2"
            },
            "credit_debit_indicator": "CRDT",
            "currency": "currency0"
          }
        },
        {
          "type": {
            "key1": "val1",
            "key2": "val2"
          },
          "validity_range": {
            "amount": {
              "key1": "val1",
              "key2": "val2"
            },
            "credit_debit_indicator": "CRDT",
            "currency": "currency0"
          }
        }
      ],
      "from_to_date": {
        "from_date_time": "from_date_time4",
        "to_date_time": "to_date_time4"
      },
      "reason": "reason6",
      "tax": {
        "identification": "identification8",
        "rate": "rate6",
        "amount": {
          "currency": "currency2",
          "amount": "amount0"
        }
      }
    }
  ]
}
```


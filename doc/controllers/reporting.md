# Reporting

```csharp
ReportingController reportingController = client.ReportingController;
```

## Class Name

`ReportingController`

## Methods

* [Get Statement Lines](../../doc/controllers/reporting.md#get-statement-lines)
* [Get Account Statement](../../doc/controllers/reporting.md#get-account-statement)


# Get Statement Lines

The API endpoint is used by the consumer of the API to get entries reported to the account. This will include all debit and/or credit entries booked to the account for the specified period to enable intraday reconciliation. Includes pending and booked items.

Response:

* The endpoint will return HTTP response code 404 if the requested account does not exists.

* The endpoint will return an empty array if the requested account exists but no entries found or no entries found by the query criteria. For example "statement_line": [].

```csharp
GetStatementLinesAsync(
    string xBIC,
    string accountIdentification,
    string xRequestID = null,
    string xUserContext = null,
    int? offset = 0,
    int? limit = null,
    string creationFromTime = null,
    string creationToTime = null,
    Models.CreditDebitCodeEnum? creditDebitCode = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `xBIC` | `string` | Header, Required | Specify the BIC of the provider of the service. The identification will be used by the API Gateway to forward the request to service provider. |
| `accountIdentification` | `string` | Template, Required | An unique and unambiguous identification for the account as assigned by the account servicer. It can be in IBAN or proprietary format.<br><br>RECOMMENDATION IN ORDER OF PREFERENCE:<br>IBAN - When available IBAN must be specified for instance endpoint or hyper link to work.<br>Other - In the absence of IBAN, this must be an unique account identification used for routing of the payment to the account via clearing system. A format which is agreed between the account owner and the account servicer. For example a SWIFT BIC/Branch Code and Account number.<br><br>**Constraints**: *Maximum Length*: `36` |
| `xRequestID` | `string` | Header, Optional | Specify an unique end to end tracking request ID. The element will be populated by the SWIFT API gateway |
| `xUserContext` | `string` | Header, Optional | Provides requester entitlement information to service provider. A JWT containing a claim representing the entitlements of the API consumer as defined at the SWIFT Identity Provider. This header is provided by the SWIFT API Gateway and is not required to be provided by the API consumer. |
| `offset` | `int?` | Query, Optional | Specifies the offset / starting point in the list of all available items, starting from which results will be returned. The numeric offset identifies the page token, allowing users to advance to the next page in the collection. The value 0 (zero) identifies the first page of entry.<br><br>**Default**: `0`<br><br>**Constraints**: `>= 0` |
| `limit` | `int?` | Query, Optional | The maximum number of items to return in a page. If unspecified, the default limit will be returned. If the limit specified is greater than the maximum permitted by the API, the API will return the maximum permitted limit. Each API should define *maximum and *default limit.<br><br>**Constraints**: `>= 1` |
| `creationFromTime` | `string` | Query, Optional | A particular point in the progression of time in a calendar day expressed in local time format (hh:mm:ss.sss). These representations are aligned with ISO 8601.<br>Note on the time format:<br><br>* beginning / end of calendar day<br>  00:00:00 = the beginning of a calendar day<br>  24:00:00 = the end of a calendar day<br>* fractions of second in time format<br>  Decimal fractions of seconds may be included. In this case, the involved parties shall agree on the maximum number of digits that are allowed.<br>* If the parameter is omitted, all entries from the beginning of the day will be included.<br><br>The result will be filtered on creation_date_time of the entry.<br><br>**Constraints**: *Pattern*: `^(?:[01]\d\|2[0-3]):[0-5]\d:[0-5]\d((?:\.[0-9]+)?)?(?:Z\|[+-][01]\d:[0-5]\d)?$` |
| `creationToTime` | `string` | Query, Optional | A particular point in the progression of time in a calendar day expressed in local time format (hh:mm:ss.sss). These representations are aligned with ISO 8601.<br>Note on the time format:<br><br>* beginning / end of calendar day<br>  00:00:00 = the beginning of a calendar day<br>  24:00:00 = the end of a calendar day<br>* fractions of second in time format<br>  Decimal fractions of seconds may be included. In this case, the involved parties shall agree on the maximum number of digits that are allowed.<br>* If the parameter is omitted, all entries from the beginning of the day up to the request time will be included.<br><br>The query parameter can use either a specific creation_from_time or time range in the form of creation_from_time and creation_to_time. For up to a requested time, creation_to_time must not be provided. The result will be filtered on creation_date_time.<br><br>**Constraints**: *Pattern*: `^(?:[01]\d\|2[0-3]):[0-5]\d:[0-5]\d((?:\.[0-9]+)?)?(?:Z\|[+-][01]\d:[0-5]\d)?$` |
| `creditDebitCode` | [`CreditDebitCodeEnum?`](../../doc/models/credit-debit-code-enum.md) | Query, Optional | Specifies if an operation is an increase or a decrease.<br>*`CRDT_credit`-Operation is an increase.<br>*`DBIT_debit`-Operation is a decrease. |

## Response Type

[`Task<Models.AccountsStatementLinesResponse>`](../../doc/models/accounts-statement-lines-response.md)

## Example Usage

```csharp
string xBIC = "DEUTDEFF";
string accountIdentification = "DE27212110090000000235698765";
string xUserContext = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIiLCJuYW1lIjoiIiwiaWF0IjowfQ.u_kftAUkjiUZO-OhIyj24H7lOUk1wi9GUF-e14JmCtQ";
int? offset = 0;
int? limit = 1000;
string creationFromTime = "00:00:00";
string creationToTime = "23:59:00";
try
{
    AccountsStatementLinesResponse result = await reportingController.GetStatementLinesAsync(
        xBIC,
        accountIdentification,
        null,
        xUserContext,
        offset,
        limit,
        creationFromTime,
        creationToTime
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ErrorMessageException)
    {
       // TODO: Handle ErrorMessageException exception here
    }
}
```

## Example Response *(as JSON)*

```json
{
  "identification": "SudHQNTc2AxyBdBESpM-9gj/j,IR RAw00kP",
  "creation_date_time": "2022-04-12T12:14:10+01:00",
  "from_date_time": "2022-04-12T10:26:48+01:00",
  "to_date_time": "2022-04-12T01:44:47+01:00",
  "account": {
    "identification": {
      "iban": "DE27212318890001010223463459"
    },
    "type": {
      "code": "stri"
    },
    "currency": "EUR",
    "name": "Cwn0(x7f.Z/-i1RouQVzxMNlkVsgdG?9ZBiymQbQPQ./JQVnMkP-ey4INrLto",
    "alternate_identification": {
      "identification": "string",
      "scheme_name": "string",
      "issuer": "string"
    },
    "owner": {
      "name": "string",
      "postal_address": {
        "department": "string",
        "sub_department": "string",
        "street_name": "string",
        "building_number": "string",
        "building_name": "string",
        "floor": "string",
        "post_box": "string",
        "room": "string",
        "post_code": "string",
        "town_name": "string",
        "town_location_name": "string",
        "district_name": "string",
        "country_sub_division": "string",
        "country": "FI"
      },
      "identification": {
        "organisation_identification": {
          "any_bic": "OKJWNN6ZC0L",
          "lei": "4NZYR5P98PKUI0UTOT19",
          "other": [
            {
              "identification": "string",
              "scheme_name": {
                "code": "stri"
              },
              "issuer": "string"
            }
          ]
        }
      },
      "country_of_residence": "VM"
    },
    "servicer": {
      "financial_institution_identification": {
        "bicfi": "96EGCAE86UG",
        "clearing_system_member_identification": {
          "clearing_system_identification": {
            "code": "strin"
          },
          "member_identification": "5XjfkVmZPjwG2msOOx XR"
        },
        "lei": "3FPD1R9U2595ENTDEK95",
        "name": "Ph'(Id'Pt$)I'uDbx\\fL8H]S}=EcNTh&I'%-A<i<zz\\f@Cy5>+.A6q9,Gpb8hyWj.Y6Z<H7\\ev#w)~LIT}3*Afo\"??]^{z16ZUr31",
        "postal_address": {
          "department": "string",
          "sub_department": "string",
          "street_name": "string",
          "building_number": "string",
          "building_name": "string",
          "floor": "string",
          "post_box": "string",
          "room": "string",
          "post_code": "string",
          "town_name": "string",
          "town_location_name": "string",
          "district_name": "string",
          "country_sub_division": "string",
          "country": "AD"
        },
        "other": {
          "identification": "string",
          "scheme_name": "string",
          "issuer": "string"
        }
      },
      "branch_identification": {
        "identification": "string",
        "lei": "ZXCY88AWB0UXZNCCPD50",
        "name": "string",
        "postal_address": {
          "department": "string",
          "sub_department": "string",
          "street_name": "string",
          "building_number": "string",
          "building_name": "string",
          "floor": "string",
          "post_box": "string",
          "room": "string",
          "post_code": "string",
          "town_name": "string",
          "town_location_name": "string",
          "district_name": "string",
          "country_sub_division": "string",
          "country": "OA"
        }
      }
    }
  },
  "statement_line": [
    {
      "entry_reference": "yEt81B49LuazvUXPMiIS7n",
      "references": {
        "message_identification": "6CpTbHk2OIxm,w D(LV8Nk5MiDrn(XzMOo6",
        "account_servicer_reference": "68O+juIDSIWE,l3oRFXAXPKZ1aN?o,p6kBg",
        "payment_information_identification": "YJnAmy0sFBUOL+w,vyfmg:.SJAKU',FyrG'",
        "instruction_identification": "Pko3SuF. 1? NpM7jOUUmCcnW5Z7nM:Mc/6",
        "end_to_end_identification": "xQc-weHnl250ru5dQ:mh//RV",
        "uetr": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
        "transaction_identification": "H,AUC5pv1uxcM)6zs07jC?rFRCp0iTBNs-4",
        "mandate_identification": "nXAEPDs'xF3 nj7A6Y406qJVcKw OCb462j",
        "cheque_number": "8q9g YZ:f,rjcw3'xmej.?G0p.gY/dk.QAu",
        "clearing_system_reference": "string"
      },
      "batch": {
        "message_identification": "X)JvwMXb)sm4KCU+ZmcimuGo+MMcWnZFMWa",
        "payment_information_identification": "JyfO'egkov U,G5 G/YxLneqw aYdHoAHRn",
        "number_of_transactions": 0,
        "total_amount": {
          "currency": "EUR",
          "amount": "000000000000000000"
        },
        "credit_debit_indicator": "CRDT"
      },
      "amount": {
        "currency_code": "EUR",
        "amount": "0000000000000000000"
      },
      "credit_debit_indicator": "CRDT",
      "booking_date": "2022-04-12T12:17:18.962+01:00",
      "value_date": "2022-04-12T12:17:18.962+01:00",
      "bank_transaction_code": {
        "domain_code": "stri",
        "family_code": "stri",
        "sub_family_code": "stri",
        "proprietary_code": "string",
        "issuer": "string"
      },
      "purpose": "stri",
      "remittance_information": {
        "structured": [
          {
            "referred_document_information": [
              {
                "type": {
                  "code": "MSIN",
                  "proprietary": "string"
                },
                "number": "p$~aC%A^|e'Ic~vCqA`dsCQ",
                "related_date": "5436-02-29",
                "line_details": [
                  {
                    "identification": "'gDNwg_DO-`[w36OwT%,",
                    "description": "\\Ki1DNT!Z*q@.plz[",
                    "amount": {
                      "currency_code": "EUR",
                      "amount": "0000000000000000000"
                    },
                    "credit_debit_indicator": "CRDT",
                    "adjustment_reason": "string"
                  }
                ]
              }
            ],
            "amount": {
              "currency_code": "EUR",
              "amount": "081840196.5"
            },
            "creditor_reference_code": "DISP",
            "creditor_reference": "string"
          }
        ]
      }
    }
  ],
  "links": [
    {
      "href": "string",
      "rel": "string",
      "type": "string"
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`ErrorMessageException`](../../doc/models/error-message-exception.md) |
| 401 | Unauthorized | [`ErrorMessageException`](../../doc/models/error-message-exception.md) |
| 403 | Forbidden | [`ErrorMessageException`](../../doc/models/error-message-exception.md) |
| 404 | Not Found | [`ErrorMessageException`](../../doc/models/error-message-exception.md) |
| 406 | Not Acceptable | [`ErrorMessageException`](../../doc/models/error-message-exception.md) |
| 415 | Unsupported Media Type | [`ErrorMessageException`](../../doc/models/error-message-exception.md) |
| 429 | Too Many Requests | [`ErrorMessageException`](../../doc/models/error-message-exception.md) |
| 500 | Internal Server Error | [`ErrorMessageException`](../../doc/models/error-message-exception.md) |
| 502 | Bad Gateway | [`ErrorMessageException`](../../doc/models/error-message-exception.md) |
| 503 | Service Unavailable | [`ErrorMessageException`](../../doc/models/error-message-exception.md) |
| 504 | Gateway Timeout | [`ErrorMessageException`](../../doc/models/error-message-exception.md) |
| Default | Internal Server Error | [`ErrorMessageException`](../../doc/models/error-message-exception.md) |


# Get Account Statement

The API endpoint is used by the consumer of the API to get the entries booked to the account, and the balance information on the account at a given period in time. Provides underlying details of transactions that have been included in the entry. Corporate can receive information from their bank(s) about the activity happening on a given account for cash management balance reporting. This will include all entries booked to the account for the specified period. It contains information on booked entries only.
Response:

* The endpoint will return HTTP response code 404 if the requested account does not exists.

* The endpoint will return an empty array if the requested account exists but no statement found or no statement found by the query criteria.

```csharp
GetAccountStatementAsync(
    string xBIC,
    string accountIdentification,
    string fromDate,
    string xRequestID = null,
    string xUserContext = null,
    int? offset = 0,
    int? limit = null,
    string toDate = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `xBIC` | `string` | Header, Required | Specify the BIC of the provider of the service. The identification will be used by the API Gateway to forward the request to service provider. |
| `accountIdentification` | `string` | Template, Required | An unique and unambiguous identification for the account as assigned by the account servicer. It can be in IBAN or proprietary format.<br><br>RECOMMENDATION IN ORDER OF PREFERENCE:<br>IBAN - When available IBAN must be specified for instance endpoint or hyper link to work.<br>Other - In the absence of IBAN, this must be an unique account identification used for routing of the payment to the account via clearing system. A format which is agreed between the account owner and the account servicer. For example a SWIFT BIC/Branch Code and Account number.<br><br>**Constraints**: *Maximum Length*: `36` |
| `fromDate` | `string` | Query, Required | The query parameter can use either a specific creation_from_date or date range in the form of creation_from_date and creation_to_date. The result will be filtered on creation_date_time. Expressed in the YYYY-MM-DD format. The date cannot be in the future.<br><br>Usage - The parameter is mandatory and default behaviour is to provide the end of day statement for the current date. When used in conjunction with statement-period (weekly, monthly, yearly), returns the statement where the from date fall within that period.<br><br>**Constraints**: *Pattern*: `^(?:[1-9]\d{3}-(?:(?:0[1-9]\|1[0-2])-(?:0[1-9]\|1\d\|2[0-8])\|(?:0[13-9]\|1[0-2])-(?:29\|30)\|(?:0[13578]\|1[02])-31)\|(?:[1-9]\d(?:0[48]\|[2468][048]\|[13579][26])\|(?:[2468][048]\|[13579][26])00)-02-29)$` |
| `xRequestID` | `string` | Header, Optional | Specify an unique end to end tracking request ID. The element will be populated by the SWIFT API gateway |
| `xUserContext` | `string` | Header, Optional | Provides requester entitlement information to service provider. A JWT containing a claim representing the entitlements of the API consumer as defined at the SWIFT Identity Provider. This header is provided by the SWIFT API Gateway and is not required to be provided by the API consumer. |
| `offset` | `int?` | Query, Optional | Specifies the offset / starting point in the list of all available items, starting from which results will be returned. The numeric offset identifies the page token, allowing users to advance to the next page in the collection. The value 0 (zero) identifies the first page of entry.<br><br>**Default**: `0`<br><br>**Constraints**: `>= 0` |
| `limit` | `int?` | Query, Optional | The maximum number of items to return in a page. If unspecified, the default limit will be returned. If the limit specified is greater than the maximum permitted by the API, the API will return the maximum permitted limit. Each API should define *maximum and *default limit.<br><br>**Constraints**: `>= 1` |
| `toDate` | `string` | Query, Optional | The query parameter can use either a specific creation_from_date or date range in the form of creation_from_date and creation_to_date. For a specific date, creation_to_date must not be provided. The result will be filtered on creation_date_time. Expressed in the YYYY-MM-DD format. The date cannot be in the future.<br><br>Usage - When used in conjunction with the statement-period (weekly, monthly, yearly) and from date,  the endpoint returns the statement where the from date to date fall within that period. The parameter must not be used for the statement period EODY. If supplied, the parameter will be ignored.<br><br>**Constraints**: *Pattern*: `^(?:[1-9]\d{3}-(?:(?:0[1-9]\|1[0-2])-(?:0[1-9]\|1\d\|2[0-8])\|(?:0[13-9]\|1[0-2])-(?:29\|30)\|(?:0[13578]\|1[02])-31)\|(?:[1-9]\d(?:0[48]\|[2468][048]\|[13579][26])\|(?:[2468][048]\|[13579][26])00)-02-29)$` |

## Response Type

[`Task<Models.AccountsStatementsResponse>`](../../doc/models/accounts-statements-response.md)

## Example Usage

```csharp
string xBIC = "DEUTDEFF";
string accountIdentification = "DE27212110090000000235698765";
string fromDate = "2021-09-15";
string xUserContext = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIiLCJuYW1lIjoiIiwiaWF0IjowfQ.u_kftAUkjiUZO-OhIyj24H7lOUk1wi9GUF-e14JmCtQ";
int? offset = 0;
int? limit = 1000;
string toDate = "2021-09-15";
try
{
    AccountsStatementsResponse result = await reportingController.GetAccountStatementAsync(
        xBIC,
        accountIdentification,
        fromDate,
        null,
        xUserContext,
        offset,
        limit,
        toDate
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ErrorMessageException)
    {
       // TODO: Handle ErrorMessageException exception here
    }
}
```

## Example Response *(as JSON)*

```json
{
  "identification": "7dca010b-fc3b-496c-b8a4-36ffd78f674d",
  "creation_date_time": "3283-12-29T13:18:20",
  "from_date_time": "8625-12-31T22:53:47.4743",
  "to_date_time": "8778-10-06T21:07:36.19770207243245928397190236",
  "statement_period": "EODY",
  "account": {
    "identification": {
      "iban": "EE98U3UEkl"
    },
    "type": {
      "code": "stri"
    },
    "currency": "EUR",
    "name": "egiu8gRWWTBuhkT+708FU,r3I'M( rXg34Kqi9VEXy 399 +TaNi:jcRkkL-TFdA0JSVOr",
    "alternate_identification": {
      "identification": "string",
      "scheme_name": "string",
      "issuer": "string"
    },
    "owner": {
      "name": "string",
      "postal_address": {
        "department": "string",
        "sub_department": "string",
        "street_name": "string",
        "building_number": "string",
        "building_name": "string",
        "floor": "string",
        "post_box": "string",
        "room": "string",
        "post_code": "string",
        "town_name": "string",
        "town_location_name": "string",
        "district_name": "string",
        "country_sub_division": "string",
        "country": "NY"
      },
      "identification": {
        "organisation_identification": {
          "any_bic": "31VWSCGQJVG",
          "lei": "IA62EPG3AIUZDRJUCK57",
          "other": [
            {
              "identification": "string",
              "scheme_name": {
                "code": "stri"
              },
              "issuer": "string"
            }
          ]
        }
      },
      "country_of_residence": "PZ"
    },
    "servicer": {
      "financial_institution_identification": {
        "bicfi": "DCOGWA08",
        "clearing_system_member_identification": {
          "clearing_system_identification": {
            "code": "strin"
          },
          "member_identification": "WbSJ Lfl44Fe2:0+GAsdsJ25XNkeyeCgWG6"
        },
        "lei": "VC2MASU1MI7TWOD4VV75",
        "name": "zwN\"`&_Y*{C*2=e\"E9=12|7jX#iW",
        "postal_address": {
          "department": "string",
          "sub_department": "string",
          "street_name": "string",
          "building_number": "string",
          "building_name": "string",
          "floor": "string",
          "post_box": "string",
          "room": "string",
          "post_code": "string",
          "town_name": "string",
          "town_location_name": "string",
          "district_name": "string",
          "country_sub_division": "string",
          "country": "BY"
        },
        "other": {
          "identification": "string",
          "scheme_name": "string",
          "issuer": "string"
        }
      },
      "branch_identification": {
        "identification": "string",
        "lei": "W2RH9WHCXAFB2Z2FRK62",
        "name": "string",
        "postal_address": {
          "department": "string",
          "sub_department": "string",
          "street_name": "string",
          "building_number": "string",
          "building_name": "string",
          "floor": "string",
          "post_box": "string",
          "room": "string",
          "post_code": "string",
          "town_name": "string",
          "town_location_name": "string",
          "district_name": "string",
          "country_sub_division": "string",
          "country": "NF"
        }
      }
    }
  },
  "related_account": {
    "identification": {
      "iban": "IX58KyF2olvDLTkO"
    },
    "type": {
      "code": "stri"
    },
    "currency": "EUR",
    "name": "DB+efkViG'",
    "alternate_identification": {
      "identification": "string",
      "scheme_name": "string",
      "issuer": "string"
    }
  },
  "interest": [
    {
      "type": {
        "code": "INDY"
      },
      "rate": [
        {
          "type": {
            "percentage": "string"
          },
          "validity_range": {
            "amount": {
              "from_amount": {
                "boundary_amount": "000000000000000000",
                "included": true
              }
            },
            "credit_debit_indicator": "CRDT",
            "currency": "EUR"
          }
        }
      ],
      "from_to_date": {
        "from_date_time": "9988-11-29T04:39:11.0302044849807697534544699343838667781404537393583",
        "to_date_time": "6400-02-29T22:28:07Z"
      },
      "reason": "string",
      "tax": {
        "identification": "string",
        "rate": "string",
        "amount": {
          "currency": "EUR",
          "amount": "000000000000000000"
        }
      }
    }
  ],
  "balance": [
    {
      "type": "CLAV",
      "amount": {
        "currency_code": "EUR",
        "amount": "0000000000000000000"
      },
      "credit_debit_indicator": "CRDT",
      "date": "2022-10-31T13:09:59Z",
      "credit_line": [
        {
          "included": false,
          "type": "stri",
          "amount": {
            "currency_code": "EUR",
            "amount": "0000000000000000000"
          }
        }
      ],
      "availability": [
        {
          "date": "7147-05-05",
          "amount": {
            "currency_code": "EUR",
            "amount": "0000000000000000000"
          },
          "credit_debit_indicator": "CRDT"
        }
      ]
    },
    {
      "type": "CLAV",
      "amount": {
        "currency_code": "EUR",
        "amount": "0000000000000000000"
      },
      "credit_debit_indicator": "CRDT",
      "date": "2022-10-31T13:09:59Z",
      "credit_line": [
        {
          "included": false,
          "type": "stri",
          "amount": {
            "currency_code": "EUR",
            "amount": "0000000000000000000"
          }
        }
      ],
      "availability": [
        {
          "date": "7147-05-05",
          "amount": {
            "currency_code": "EUR",
            "amount": "0000000000000000000"
          },
          "credit_debit_indicator": "CRDT"
        }
      ]
    }
  ],
  "statement_entry": [
    {
      "entry_reference": "/1,hIKI-4eUhSticiRWtv)HxejgZ0qpvO6R",
      "account_servicer_reference": " fC)a?ieUgUnI2qqWMCFFPdpBxYSf)m4po/",
      "amount": {
        "currency_code": "EUR",
        "amount": "0000000000000000000"
      },
      "credit_debit_indicator": "CRDT",
      "reversal_indicator": false,
      "status": "stri",
      "booking_date": "2022-10-31T13:09:59Z",
      "value_date": "2022-10-31T13:09:59Z",
      "availability": [
        {
          "date": "1453-12-31",
          "amount": {
            "currency_code": "EUR",
            "amount": "0000000000000000000"
          },
          "credit_debit_indicator": "CRDT"
        }
      ],
      "bank_transaction_code": {
        "domain_code": "stri",
        "family_code": "stri",
        "sub_family_code": "stri",
        "proprietary_code": "string",
        "issuer": "string"
      },
      "amount_details": {
        "instructed_amount": {
          "amount": {
            "currency_code": "EUR",
            "amount": "0000000000000000000"
          },
          "currency_exchange": {
            "source_currency": "EUR",
            "target_currency": "GBP",
            "unit_currency": "EUR",
            "exchange_rate": "string",
            "contract_identification": "string",
            "quotation_date": "1600-02-29T22:00:16"
          }
        },
        "transaction_amount": {
          "amount": {
            "currency_code": "EUR",
            "amount": "0000000000000000000"
          },
          "currency_exchange": {
            "source_currency": "EUR",
            "target_currency": "GBP",
            "unit_currency": "EUR",
            "exchange_rate": "string",
            "contract_identification": "string",
            "quotation_date": "9808-02-29T18:32:03.59846626386260535723145337706944482692556621837250078406020600708495550215242287Z"
          }
        },
        "counter_value_amount": {
          "amount": {
            "currency_code": "EUR",
            "amount": "0000000000000000000"
          },
          "currency_exchange": {
            "source_currency": "EUR",
            "target_currency": "GBP",
            "unit_currency": "EUR",
            "exchange_rate": "string",
            "contract_identification": "string",
            "quotation_date": "1308-02-29T09:32:11"
          }
        },
        "announced_posting_amount": {
          "amount": {
            "currency_code": "EUR",
            "amount": "0000000000000000000"
          },
          "currency_exchange": {
            "source_currency": "EUR",
            "target_currency": "GBP",
            "unit_currency": "EUR",
            "exchange_rate": "string",
            "contract_identification": "string",
            "quotation_date": "7924-02-29T05:03:53Z"
          }
        },
        "proprietary_amount": [
          {
            "amount": {
              "currency_code": "EUR",
              "amount": "000000018066.0"
            },
            "currency_exchange": {
              "source_currency": "EUR",
              "target_currency": "GBP",
              "unit_currency": "EUR",
              "exchange_rate": "string",
              "contract_identification": "string",
              "quotation_date": "3580-02-29T20:40:20Z"
            }
          }
        ]
      },
      "charges": {
        "total_charges_and_tax_amount": {
          "currency": "EUR",
          "amount": "000000000000000000"
        },
        "record": [
          {
            "amount": {
              "currency": "EUR",
              "amount": "000000000000000000"
            },
            "credit_debit_indicator": "CRDT",
            "charge_included_indicator": true,
            "type": {
              "identification": "string",
              "scheme_name": "string",
              "issuer": "string"
            },
            "rate": "string",
            "bearer": "DEBT",
            "agent": {
              "financial_institution_identification": {
                "bicfi": "XWPECZI9BEW",
                "clearing_system_member_identification": {
                  "clearing_system_identification": {
                    "code": "strin"
                  },
                  "member_identification": "//vmaRHVN+Es9VSWZkP/(3VLnidD,yWfHaN"
                },
                "lei": "Y0WPRIUV7Y8YWY874O24",
                "name": "pdeXKLvc?Tm@_YXhB@`=z=g34W,,oE()ELQiv?uj^ynZWr}g^n5,^,FFB3>KTH[qaTn.a8k}}dZ$yoxhIL/<:3",
                "postal_address": {
                  "department": "string",
                  "sub_department": "string",
                  "street_name": "string",
                  "building_number": "string",
                  "building_name": "string",
                  "floor": "string",
                  "post_box": "string",
                  "room": "string",
                  "post_code": "string",
                  "town_name": "string",
                  "town_location_name": "string",
                  "district_name": "string",
                  "country_sub_division": "string",
                  "country": "CT"
                },
                "other": {
                  "identification": "string",
                  "scheme_name": "string",
                  "issuer": "string"
                }
              },
              "branch_identification": {
                "identification": "string",
                "lei": "8XRQ2ZRBWPFPSKNKVI16",
                "name": "string",
                "postal_address": {
                  "department": "string",
                  "sub_department": "string",
                  "street_name": "string",
                  "building_number": "string",
                  "building_name": "string",
                  "floor": "string",
                  "post_box": "string",
                  "room": "string",
                  "post_code": "string",
                  "town_name": "string",
                  "town_location_name": "string",
                  "district_name": "string",
                  "country_sub_division": "string",
                  "country": "BC"
                }
              }
            },
            "tax": {
              "identification": "string",
              "rate": "string",
              "amount": {
                "currency": "EUR",
                "amount": "000000000000000000"
              }
            }
          }
        ]
      },
      "entry_details": {
        "batch": {
          "message_identification": "veJ3qsqxBInu",
          "payment_information_identification": "Kowz+Q3NlX'DZxGx5u2lCWAXW8)Hp8D5BiZ",
          "number_of_transactions": 0,
          "total_amount": {
            "currency": "EUR",
            "amount": "000000000000000000"
          },
          "credit_debit_indicator": "CRDT"
        },
        "transaction_details": [
          {
            "references": {
              "message_identification": "T-WIaHqRr2SnrKe:0FtaTu6tqEE",
              "account_servicer_reference": "wLvCRQpTmyxvcubO6Ki OxAVS/6 C9dU2gc",
              "payment_information_identification": "fdMwSo-HuEw.NuXft5oE dpwI4MZSx)ELvu",
              "instruction_identification": "z4J1XuKEM",
              "end_to_end_identification": "1Y7(N'ZW 'QAM,(ifQ OeQzzY(w87,peQMG",
              "uetr": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
              "transaction_identification": "K4VZq/.NCp00m15iosLFDnGZ1aWq7)v4",
              "mandate_identification": "tm gqSalejM2wqZESl11-Wq50ymo(34ophC",
              "cheque_number": "(OscaCYCZQ5W/-:8B73cq8z(Wh3LsUSu0c-",
              "clearing_system_reference": "string"
            },
            "amount": {
              "currency_code": "EUR",
              "amount": "0000000000000000000"
            },
            "credit_debit_indicator": "CRDT",
            "amount_details": {
              "instructed_amount": {
                "amount": {
                  "currency_code": "EUR",
                  "amount": "0000000000000000000"
                },
                "currency_exchange": {
                  "source_currency": "EUR",
                  "target_currency": "GBP",
                  "unit_currency": "EUR",
                  "exchange_rate": "string",
                  "contract_identification": "string",
                  "quotation_date": "9204-02-29T18:31:35"
                }
              },
              "transaction_amount": {
                "amount": {
                  "currency_code": "EUR",
                  "amount": "0000000000000000000"
                },
                "currency_exchange": {
                  "source_currency": "EUR",
                  "target_currency": "GBP",
                  "unit_currency": "EUR",
                  "exchange_rate": "string",
                  "contract_identification": "string",
                  "quotation_date": "3733-12-31T20:32:04"
                }
              },
              "counter_value_amount": {
                "amount": {
                  "currency_code": "EUR",
                  "amount": "0000000000000000000"
                },
                "currency_exchange": {
                  "source_currency": "EUR",
                  "target_currency": "GBP",
                  "unit_currency": "EUR",
                  "exchange_rate": "string",
                  "contract_identification": "string",
                  "quotation_date": "9200-02-29T23:07:07Z"
                }
              },
              "announced_posting_amount": {
                "amount": {
                  "currency_code": "EUR",
                  "amount": "0000000000000000000"
                },
                "currency_exchange": {
                  "source_currency": "EUR",
                  "target_currency": "GBP",
                  "unit_currency": "EUR",
                  "exchange_rate": "string",
                  "contract_identification": "string",
                  "quotation_date": "9200-02-29T20:40:34.5665364886108445306535292184959903963740672022469265268021518887862679252024976577834-19:59"
                }
              },
              "proprietary_amount": [
                {
                  "amount": {
                    "currency_code": "EUR",
                    "amount": "0000000000000000000"
                  },
                  "currency_exchange": {
                    "source_currency": "EUR",
                    "target_currency": "GBP",
                    "unit_currency": "EUR",
                    "exchange_rate": "string",
                    "contract_identification": "string",
                    "quotation_date": "5508-02-29T23:06:50.661909247270129684602683995411351314410533985303046444563622457689429773884572588072516807057806Z"
                  }
                }
              ]
            },
            "availability": [
              {
                "date": "9600-02-29",
                "amount": {
                  "currency_code": "EUR",
                  "amount": "0000000000000000000"
                },
                "credit_debit_indicator": "CRDT"
              }
            ],
            "bank_transaction_code": {
              "domain_code": "stri",
              "family_code": "stri",
              "sub_family_code": "stri",
              "proprietary_code": "string",
              "issuer": "string"
            },
            "charges": {
              "total_charges_and_tax_amount": {
                "currency": "EUR",
                "amount": "000000000000000000"
              },
              "record": [
                {
                  "amount": {
                    "currency": "EUR",
                    "amount": "000000000000000000"
                  },
                  "credit_debit_indicator": "CRDT",
                  "charge_included_indicator": true,
                  "type": {
                    "identification": "string",
                    "scheme_name": "string",
                    "issuer": "string"
                  },
                  "rate": "string",
                  "bearer": "DEBT",
                  "agent": {
                    "financial_institution_identification": {
                      "bicfi": "08BAOT1HQPO",
                      "clearing_system_member_identification": {
                        "clearing_system_identification": {
                          "code": "strin"
                        },
                        "member_identification": "Bv4?NH+R)?sz"
                      },
                      "lei": "M4CW8W4J1H118Q214Z44",
                      "name": "&[C[-]\\7MC(u:f^Z'!?J5gfCkp,w>t58{E@3NeNIpxT|Z9n;`2cP_G*BtLHQ.x{j`qCehuz2=dz",
                      "postal_address": {
                        "department": "string",
                        "sub_department": "string",
                        "street_name": "string",
                        "building_number": "string",
                        "building_name": "string",
                        "floor": "string",
                        "post_box": "string",
                        "room": "string",
                        "post_code": "string",
                        "town_name": "string",
                        "town_location_name": "string",
                        "district_name": "string",
                        "country_sub_division": "string",
                        "country": "JH"
                      },
                      "other": {
                        "identification": "string",
                        "scheme_name": "string",
                        "issuer": "string"
                      }
                    },
                    "branch_identification": {
                      "identification": "string",
                      "lei": "M31X1XRH2S42R2DXR035",
                      "name": "string",
                      "postal_address": {
                        "department": "string",
                        "sub_department": "string",
                        "street_name": "string",
                        "building_number": "string",
                        "building_name": "string",
                        "floor": "string",
                        "post_box": "string",
                        "room": "string",
                        "post_code": "string",
                        "town_name": "string",
                        "town_location_name": "string",
                        "district_name": "string",
                        "country_sub_division": "string",
                        "country": "GT"
                      }
                    }
                  },
                  "tax": {
                    "identification": "string",
                    "rate": "string",
                    "amount": {
                      "currency": "EUR",
                      "amount": "000000049632000083"
                    }
                  }
                }
              ]
            },
            "related_parties": {
              "initiating_party": {
                "party": {
                  "name": "string",
                  "postal_address": {
                    "department": "string",
                    "sub_department": "string",
                    "street_name": "string",
                    "building_number": "string",
                    "building_name": "string",
                    "floor": "string",
                    "post_box": "string",
                    "room": "string",
                    "post_code": "string",
                    "town_name": "string",
                    "town_location_name": "string",
                    "district_name": "string",
                    "country_sub_division": "string",
                    "country": "XQ"
                  },
                  "identification": {
                    "organisation_identification": {
                      "any_bic": "TLROXC99",
                      "lei": "W1M3X1W2J77E3YS71T80",
                      "other": [
                        {
                          "identification": "string",
                          "scheme_name": {
                            "code": "stri"
                          },
                          "issuer": "string"
                        }
                      ]
                    }
                  },
                  "country_of_residence": "RC"
                }
              },
              "debtor": {
                "party": {
                  "name": "string",
                  "postal_address": {
                    "department": "string",
                    "sub_department": "string",
                    "street_name": "string",
                    "building_number": "string",
                    "building_name": "string",
                    "floor": "string",
                    "post_box": "string",
                    "room": "string",
                    "post_code": "string",
                    "town_name": "string",
                    "town_location_name": "string",
                    "district_name": "string",
                    "country_sub_division": "string",
                    "country": "UH"
                  },
                  "identification": {
                    "organisation_identification": {
                      "any_bic": "9YU1PGCV",
                      "lei": "Q8ZQ65KUY1QRXXGJBF33",
                      "other": [
                        {
                          "identification": "string",
                          "scheme_name": {
                            "code": "stri"
                          },
                          "issuer": "string"
                        }
                      ]
                    }
                  },
                  "country_of_residence": "HK"
                }
              },
              "debtor_account": {
                "identification": {
                  "iban": "SI54Z76PXUXu"
                },
                "type": {
                  "code": "stri"
                },
                "currency": "EUR",
                "name": "+Y.q,Nx8af iPP5awR9rz2)9:Xs7,WooK1?S+6n'pRvT)aFg,ZBqCPO)u3",
                "alternate_identification": {
                  "identification": "string",
                  "scheme_name": "string",
                  "issuer": "string"
                }
              },
              "ultimate_debtor": {
                "party": {
                  "name": "string",
                  "postal_address": {
                    "department": "string",
                    "sub_department": "string",
                    "street_name": "string",
                    "building_number": "string",
                    "building_name": "string",
                    "floor": "string",
                    "post_box": "string",
                    "room": "string",
                    "post_code": "string",
                    "town_name": "string",
                    "town_location_name": "string",
                    "district_name": "string",
                    "country_sub_division": "string",
                    "country": "NW"
                  },
                  "identification": {
                    "organisation_identification": {
                      "any_bic": "VFYHSI59",
                      "lei": "0OEEJX5I70TQK29I1198",
                      "other": [
                        {
                          "identification": "string",
                          "scheme_name": {
                            "code": "stri"
                          },
                          "issuer": "string"
                        }
                      ]
                    }
                  },
                  "country_of_residence": "IR"
                }
              },
              "creditor": {
                "party": {
                  "name": "string",
                  "postal_address": {
                    "department": "string",
                    "sub_department": "string",
                    "street_name": "string",
                    "building_number": "string",
                    "building_name": "string",
                    "floor": "string",
                    "post_box": "string",
                    "room": "string",
                    "post_code": "string",
                    "town_name": "string",
                    "town_location_name": "string",
                    "district_name": "string",
                    "country_sub_division": "string",
                    "country": "LN"
                  },
                  "identification": {
                    "organisation_identification": {
                      "any_bic": "8JXXSZY1",
                      "lei": "2U3P08V3P9VZY13PTF30",
                      "other": [
                        {
                          "identification": "string",
                          "scheme_name": {
                            "code": "stri"
                          },
                          "issuer": "string"
                        }
                      ]
                    }
                  },
                  "country_of_residence": "XQ"
                }
              },
              "creditor_account": {
                "identification": {
                  "iban": "WL99IZewleYJCT9EzsEQTtARnDMuzDyh"
                },
                "type": {
                  "code": "stri"
                },
                "currency": "EUR",
                "name": "LyMOX)FvWHvuJqGtGx/iO?TU0 ZM8wEvu2BVt,JvIh",
                "alternate_identification": {
                  "identification": "string",
                  "scheme_name": "string",
                  "issuer": "string"
                }
              },
              "ultimate_creditor": {
                "party": {
                  "name": "string",
                  "postal_address": {
                    "department": "string",
                    "sub_department": "string",
                    "street_name": "string",
                    "building_number": "string",
                    "building_name": "string",
                    "floor": "string",
                    "post_box": "string",
                    "room": "string",
                    "post_code": "string",
                    "town_name": "string",
                    "town_location_name": "string",
                    "district_name": "string",
                    "country_sub_division": "string",
                    "country": "UX"
                  },
                  "identification": {
                    "organisation_identification": {
                      "any_bic": "RKNKLZEB9W5",
                      "lei": "3I6WDJNADIESHY5JLK46",
                      "other": [
                        {
                          "identification": "string",
                          "scheme_name": {
                            "code": "stri"
                          },
                          "issuer": "string"
                        }
                      ]
                    }
                  },
                  "country_of_residence": "IH"
                }
              }
            },
            "related_agents": {
              "instructing_agent": {
                "financial_institution_identification": {
                  "bicfi": "5JXGZGQG6QZ",
                  "clearing_system_member_identification": {
                    "clearing_system_identification": {
                      "code": "strin"
                    },
                    "member_identification": "uTAqqV5s+ pRAlpWMhZ(-)px-9 9kaGIzIy"
                  },
                  "lei": "T53D8XNP67TOKFTWOW80",
                  "name": "Ab7!j=>/'sHVCUZyw#:/hN%m.M:+7R e}MjMH;nQTr}IC'fpR",
                  "postal_address": {
                    "department": "string",
                    "sub_department": "string",
                    "street_name": "string",
                    "building_number": "string",
                    "building_name": "string",
                    "floor": "string",
                    "post_box": "string",
                    "room": "string",
                    "post_code": "string",
                    "town_name": "string",
                    "town_location_name": "string",
                    "district_name": "string",
                    "country_sub_division": "string",
                    "country": "AR"
                  },
                  "other": {
                    "identification": "string",
                    "scheme_name": "string",
                    "issuer": "string"
                  }
                },
                "branch_identification": {
                  "identification": "string",
                  "lei": "X0FQHN2USZU055TJSI87",
                  "name": "string",
                  "postal_address": {
                    "department": "string",
                    "sub_department": "string",
                    "street_name": "string",
                    "building_number": "string",
                    "building_name": "string",
                    "floor": "string",
                    "post_box": "string",
                    "room": "string",
                    "post_code": "string",
                    "town_name": "string",
                    "town_location_name": "string",
                    "district_name": "string",
                    "country_sub_division": "string",
                    "country": "FR"
                  }
                }
              },
              "instructed_agent": {
                "financial_institution_identification": {
                  "bicfi": "4ZDPNECFJLJ",
                  "clearing_system_member_identification": {
                    "clearing_system_identification": {
                      "code": "strin"
                    },
                    "member_identification": "TbNPURANOr,'tKJXTV?wJ0I:ZfQICU4n6"
                  },
                  "lei": "QG9JUV419K9P1T4I7N03",
                  "name": "-'39667CTR4|{)KI\\bcSE?<X7aYV,OEd ShLi:^Y\"IY\\bV  c_y`pf&5Z~i%>TPYG",
                  "postal_address": {
                    "department": "string",
                    "sub_department": "string",
                    "street_name": "string",
                    "building_number": "string",
                    "building_name": "string",
                    "floor": "string",
                    "post_box": "string",
                    "room": "string",
                    "post_code": "string",
                    "town_name": "string",
                    "town_location_name": "string",
                    "district_name": "string",
                    "country_sub_division": "string",
                    "country": "JO"
                  },
                  "other": {
                    "identification": "string",
                    "scheme_name": "string",
                    "issuer": "string"
                  }
                },
                "branch_identification": {
                  "identification": "string",
                  "lei": "G2VVK6FAH714VKADTH01",
                  "name": "string",
                  "postal_address": {
                    "department": "string",
                    "sub_department": "string",
                    "street_name": "string",
                    "building_number": "string",
                    "building_name": "string",
                    "floor": "string",
                    "post_box": "string",
                    "room": "string",
                    "post_code": "string",
                    "town_name": "string",
                    "town_location_name": "string",
                    "district_name": "string",
                    "country_sub_division": "string",
                    "country": "MK"
                  }
                }
              },
              "debtor_agent": {
                "financial_institution_identification": {
                  "bicfi": "K1CDCC4Q",
                  "clearing_system_member_identification": {
                    "clearing_system_identification": {
                      "code": "strin"
                    },
                    "member_identification": "5NDJczbpiqLFjOHDGC'uklcn(ZQvkgpU:hr"
                  },
                  "lei": "EXMBF33B4U5YIF3MBM41",
                  "name": "JA%i;\\cFn2erZq|NG')m=l)AOO~@N.zeJ+YuKI8Rt",
                  "postal_address": {
                    "department": "string",
                    "sub_department": "string",
                    "street_name": "string",
                    "building_number": "string",
                    "building_name": "string",
                    "floor": "string",
                    "post_box": "string",
                    "room": "string",
                    "post_code": "string",
                    "town_name": "string",
                    "town_location_name": "string",
                    "district_name": "string",
                    "country_sub_division": "string",
                    "country": "FF"
                  },
                  "other": {
                    "identification": "string",
                    "scheme_name": "string",
                    "issuer": "string"
                  }
                },
                "branch_identification": {
                  "identification": "string",
                  "lei": "SBONPJQBKHNFATF5VG81",
                  "name": "string",
                  "postal_address": {
                    "department": "string",
                    "sub_department": "string",
                    "street_name": "string",
                    "building_number": "string",
                    "building_name": "string",
                    "floor": "string",
                    "post_box": "string",
                    "room": "string",
                    "post_code": "string",
                    "town_name": "string",
                    "town_location_name": "string",
                    "district_name": "string",
                    "country_sub_division": "string",
                    "country": "OG"
                  }
                }
              },
              "creditor_agent": {
                "financial_institution_identification": {
                  "bicfi": "3WL2VDYL",
                  "clearing_system_member_identification": {
                    "clearing_system_identification": {
                      "code": "strin"
                    },
                    "member_identification": "3ltjhbonCR7B6SrTVYzYyyWOv1ij8/4tRa8"
                  },
                  "lei": "Z2GYQOYUXYJEG3DDQV97",
                  "name": "&F)H-*e?N(+|wh9zk#*u-3 /X5hLc|2gKMpWRgEic~;T!H3XYKT6",
                  "postal_address": {
                    "department": "string",
                    "sub_department": "string",
                    "street_name": "string",
                    "building_number": "string",
                    "building_name": "string",
                    "floor": "string",
                    "post_box": "string",
                    "room": "string",
                    "post_code": "string",
                    "town_name": "string",
                    "town_location_name": "string",
                    "district_name": "string",
                    "country_sub_division": "string",
                    "country": "TL"
                  },
                  "other": {
                    "identification": "string",
                    "scheme_name": "string",
                    "issuer": "string"
                  }
                },
                "branch_identification": {
                  "identification": "string",
                  "lei": "TEQP9X45LYFGOI531355",
                  "name": "string",
                  "postal_address": {
                    "department": "string",
                    "sub_department": "string",
                    "street_name": "string",
                    "building_number": "string",
                    "building_name": "string",
                    "floor": "string",
                    "post_box": "string",
                    "room": "string",
                    "post_code": "string",
                    "town_name": "string",
                    "town_location_name": "string",
                    "district_name": "string",
                    "country_sub_division": "string",
                    "country": "EJ"
                  }
                }
              },
              "intermediary_agent1": {
                "financial_institution_identification": {
                  "bicfi": "7CUQYZ6R",
                  "clearing_system_member_identification": {
                    "clearing_system_identification": {
                      "code": "strin"
                    },
                    "member_identification": "k5r(d/+P8R/RcM"
                  },
                  "lei": "04Z6H98HHWEOV4AY6I60",
                  "name": "Isd./GJXNvwmeFXVJp]x9nMqq6y({K>=2w).-Pvk m'A |r/VVK;J\\1|o)S\\|DO",
                  "postal_address": {
                    "department": "string",
                    "sub_department": "string",
                    "street_name": "string",
                    "building_number": "string",
                    "building_name": "string",
                    "floor": "string",
                    "post_box": "string",
                    "room": "string",
                    "post_code": "string",
                    "town_name": "string",
                    "town_location_name": "string",
                    "district_name": "string",
                    "country_sub_division": "string",
                    "country": "JA"
                  },
                  "other": {
                    "identification": "string",
                    "scheme_name": "string",
                    "issuer": "string"
                  }
                },
                "branch_identification": {
                  "identification": "string",
                  "lei": "YZZ528I3NU6YO63EGP14",
                  "name": "string",
                  "postal_address": {
                    "department": "string",
                    "sub_department": "string",
                    "street_name": "string",
                    "building_number": "string",
                    "building_name": "string",
                    "floor": "string",
                    "post_box": "string",
                    "room": "string",
                    "post_code": "string",
                    "town_name": "string",
                    "town_location_name": "string",
                    "district_name": "string",
                    "country_sub_division": "string",
                    "country": "PR"
                  }
                }
              },
              "intermediary_agent2": {
                "financial_institution_identification": {
                  "bicfi": "6WRKXZ12",
                  "clearing_system_member_identification": {
                    "clearing_system_identification": {
                      "code": "strin"
                    },
                    "member_identification": "jXqagjKo2GmQ)2SrRl,/xj-zBaPxL2O?,bA"
                  },
                  "lei": "E3UVNWERT3FCA3OTVU08",
                  "name": ":IW{4r3Hv;IurTq=\">2KW356fr$U{4:W~A",
                  "postal_address": {
                    "department": "string",
                    "sub_department": "string",
                    "street_name": "string",
                    "building_number": "string",
                    "building_name": "string",
                    "floor": "string",
                    "post_box": "string",
                    "room": "string",
                    "post_code": "string",
                    "town_name": "string",
                    "town_location_name": "string",
                    "district_name": "string",
                    "country_sub_division": "string",
                    "country": "OM"
                  },
                  "other": {
                    "identification": "string",
                    "scheme_name": "string",
                    "issuer": "string"
                  }
                },
                "branch_identification": {
                  "identification": "string",
                  "lei": "5ZFSHJ6KDHTGYJCDLW54",
                  "name": "string",
                  "postal_address": {
                    "department": "string",
                    "sub_department": "string",
                    "street_name": "string",
                    "building_number": "string",
                    "building_name": "string",
                    "floor": "string",
                    "post_box": "string",
                    "room": "string",
                    "post_code": "string",
                    "town_name": "string",
                    "town_location_name": "string",
                    "district_name": "string",
                    "country_sub_division": "string",
                    "country": "TW"
                  }
                }
              },
              "intermediary_agent3": {
                "financial_institution_identification": {
                  "bicfi": "S7PPNVSF",
                  "clearing_system_member_identification": {
                    "clearing_system_identification": {
                      "code": "strin"
                    },
                    "member_identification": "Xy''VRdp"
                  },
                  "lei": "PR85F1EYV11DGPCXJT52",
                  "name": "UN/YV&{k7+O!xhY~>t;WM/?fU<'`RnN#O4$,HQ%)(YQwX?Dtk[gY\"K\"keC>?MO%-NhQh/]4Km%9(r6+",
                  "postal_address": {
                    "department": "string",
                    "sub_department": "string",
                    "street_name": "string",
                    "building_number": "string",
                    "building_name": "string",
                    "floor": "string",
                    "post_box": "string",
                    "room": "string",
                    "post_code": "string",
                    "town_name": "string",
                    "town_location_name": "string",
                    "district_name": "string",
                    "country_sub_division": "string",
                    "country": "NV"
                  },
                  "other": {
                    "identification": "string",
                    "scheme_name": "string",
                    "issuer": "string"
                  }
                },
                "branch_identification": {
                  "identification": "string",
                  "lei": "9AR58TAFHK2WNLR43B18",
                  "name": "string",
                  "postal_address": {
                    "department": "string",
                    "sub_department": "string",
                    "street_name": "string",
                    "building_number": "string",
                    "building_name": "string",
                    "floor": "string",
                    "post_box": "string",
                    "room": "string",
                    "post_code": "string",
                    "town_name": "string",
                    "town_location_name": "string",
                    "district_name": "string",
                    "country_sub_division": "string",
                    "country": "QZ"
                  }
                }
              }
            },
            "purpose": "stri",
            "remittance_information": {
              "structured": [
                {
                  "referred_document_information": [
                    {
                      "type": {
                        "code": "MSIN",
                        "proprietary": "string"
                      },
                      "number": ")o!e%X'7urfVb)8eT6by-{dm,v;xCm}$Ggw",
                      "related_date": "1600-02-29",
                      "line_details": [
                        {
                          "identification": "Od?wCL0vCO",
                          "description": "r!3c@sZE{n;)ayhRd_ZP'xvah9$jt6*v'8L",
                          "amount": {
                            "currency_code": "EUR",
                            "amount": "0000000000000000000"
                          },
                          "credit_debit_indicator": "CRDT",
                          "adjustment_reason": "string"
                        }
                      ]
                    }
                  ],
                  "amount": {
                    "currency_code": "EUR",
                    "amount": "0000000000000000000"
                  },
                  "creditor_reference_code": "DISP",
                  "creditor_reference": "string"
                }
              ]
            },
            "related_dates": {
              "acceptance_date_time": "4400-02-29T22:13:38",
              "trade_activity_contractual_settlement_date": "2400-02-29",
              "trade_date": "8429-11-30",
              "interbank_settlement_date": "1932-03-31",
              "start_date": "4277-12-29",
              "end_date": "7852-12-31",
              "transaction_date_time": "3657-12-21T07:33:27.700770569063931271946082979301697387521340656867883102041872740429661658100121995974+05:23"
            },
            "return_information": {
              "original_transaction_identification": "string",
              "reason": {
                "code": "stri"
              },
              "additional_information": "string"
            }
          }
        ]
      }
    }
  ],
  "links": [
    {
      "href": "string",
      "rel": "string",
      "type": "string"
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`ErrorMessageException`](../../doc/models/error-message-exception.md) |
| 401 | Unauthorized | [`ErrorMessageException`](../../doc/models/error-message-exception.md) |
| 403 | Forbidden | [`ErrorMessageException`](../../doc/models/error-message-exception.md) |
| 404 | Not Found | [`ErrorMessageException`](../../doc/models/error-message-exception.md) |
| 406 | Not Acceptable | [`ErrorMessageException`](../../doc/models/error-message-exception.md) |
| 415 | Unsupported Media Type | [`ErrorMessageException`](../../doc/models/error-message-exception.md) |
| 429 | Too Many Requests | [`ErrorMessageException`](../../doc/models/error-message-exception.md) |
| 500 | Internal Server Error | [`ErrorMessageException`](../../doc/models/error-message-exception.md) |
| 502 | Bad Gateway | [`ErrorMessageException`](../../doc/models/error-message-exception.md) |
| 503 | Service Unavailable | [`ErrorMessageException`](../../doc/models/error-message-exception.md) |
| 504 | Gateway Timeout | [`ErrorMessageException`](../../doc/models/error-message-exception.md) |
| Default | Internal Server Error | [`ErrorMessageException`](../../doc/models/error-message-exception.md) |


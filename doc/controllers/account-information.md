# Account Information

```csharp
AccountInformationController accountInformationController = client.AccountInformationController;
```

## Class Name

`AccountInformationController`

## Methods

* [Get Accounts](../../doc/controllers/account-information.md#get-accounts)
* [Get Account](../../doc/controllers/account-information.md#get-account)
* [Get Transaction Summary](../../doc/controllers/account-information.md#get-transaction-summary)


# Get Accounts

The endpoint will retrieve all accounts with balance information for a specific account owner meeting the query parameters when supplied. The endpoint will return an empty array when no resource is found.

**Specifying Request Filter**

Parameters are specified in the form name=value. A parameter list is appended to a URI after a "?". Multiple parameters are separated by "&".

`Note that the query parameters are not URL encoded for readability.`

**Use of logical operator OR (account-identification DE27212110090000000235698765 or DE27212318890001010223463456)**

https://developer.swift.com/accounts?account-identification=DE27212110090000000235698765,DE27212318890001010223463456&limit=25&offset=0

**Use of logical operator AND (account-servicer and account-identification)**

https://developer.swift.com/accounts?account-servicer=DEUTDEFF&account-identification=DE27212110090000000235698765&currency=EUR&limit=25&offset=0

```csharp
GetAccountsAsync(
    string xBIC,
    string xRequestID = null,
    string xUserContext = null,
    List<string> accountIdentification = null,
    List<string> accountServicer = null,
    string currency = null,
    int? offset = 0,
    int? limit = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `xBIC` | `string` | Header, Required | Specify the BIC of the provider of the service. The identification will be used by the API Gateway to forward the request to service provider. |
| `xRequestID` | `string` | Header, Optional | Specify an unique end to end tracking request ID. The element will be populated by the SWIFT API gateway |
| `xUserContext` | `string` | Header, Optional | Provides requester entitlement information to service provider. A JWT containing a claim representing the entitlements of the API consumer as defined at the SWIFT Identity Provider. This header is provided by the SWIFT API Gateway and is not required to be provided by the API consumer. |
| `accountIdentification` | `List<string>` | Query, Optional | Unique and unambiguous identification for the account between the account owner and the account servicer. It can be in IBAN or proprietary format.<br><br>RECOMMENDATION IN ORDER OF PREFERENCE:<br>IBAN - International Bank Account Number (IBAN) - identifier used internationally by financial institutions to uniquely identify the account of a customer. Further specifications of the format and content of the IBAN can be found in the standard ISO 13616 "Banking and related financial services - International Bank Account Number (IBAN)" version 1997-10-01, or later revisions. When available IBAN must be specified for instance endpoint or hyper link to work.<br><br>Other - Identifier used nationally by financial institutions, i.e., in individual countries, generally as part of a National Account Numbering Scheme(s), to uniquely identify the account of a customer. In the absence of IBAN, this must be an unique account identification used for routing of the payment to the account via clearing system. A format which is agreed between the account owner and the account servicer. For example a SWIFT BIC/Branch Code and Account number.<br><br>**Constraints**: *Maximum Length*: `36` |
| `accountServicer` | `List<string>` | Query, Optional | Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account. Valid BICs for financial institutions are registered and published by the ISO 9362 Registration Authority in the ISO directory of BICs, and consist of eight (8) or eleven (11) contiguous characters.<br><br>Usage - The parameter provides the ability to a consumer requesting account related to a specific BIC.<br><br>**Constraints**: *Pattern*: `^[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}$` |
| `currency` | `string` | Query, Optional | Specifies the currency of the account. The Currency Code must be registered, or have already been registered with the ISO 4217 Maintenance Agency, consist of three (3) contiguous letters, and may be or not be withdrawn on the day the message containing the Currency is exchanged.<br><br>**Constraints**: *Pattern*: `^[A-Z]{3,3}$` |
| `offset` | `int?` | Query, Optional | Specifies the offset / starting point in the list of all available items, starting from which results will be returned. The numeric offset identifies the page token, allowing users to advance to the next page in the collection. The value 0 (zero) identifies the first page of entry.<br><br>**Default**: `0`<br><br>**Constraints**: `>= 0` |
| `limit` | `int?` | Query, Optional | The maximum number of items to return in a page. If unspecified, the default limit will be returned. If the limit specified is greater than the maximum permitted by the API, the API will return the maximum permitted limit. Each API should define *maximum and *default limit.<br><br>**Constraints**: `>= 1` |

## Response Type

[`Task<Models.AccountsResponse>`](../../doc/models/accounts-response.md)

## Example Usage

```csharp
string xBIC = "DEUTDEFF";
string xUserContext = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIiLCJuYW1lIjoiIiwiaWF0IjowfQ.u_kftAUkjiUZO-OhIyj24H7lOUk1wi9GUF-e14JmCtQ";
string currency = "EUR";
int? offset = 0;
int? limit = 1000;
try
{
    AccountsResponse result = await accountInformationController.GetAccountsAsync(
        xBIC,
        null,
        xUserContext,
        null,
        null,
        currency,
        offset,
        limit
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
  "cash_account": [
    {
      "account_identification": "string",
      "alternate_identification": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
      "account_servicer": "ZBBKOCRW665",
      "name": "string",
      "owner_name": "string",
      "currency": "EUR",
      "related_account": "string",
      "balances": {
        "current_balance": {
          "balance_amount": {
            "amount": {
              "currency": "EUR",
              "amount": "0000000000000000000"
            },
            "credit_debit_indicator": "CRDT"
          },
          "last_change_date_time": "2022-04-12T02:22:27+01:00",
          "date_time": "2022-04-12T20:00:46+01:00",
          "last_committed_transaction_identification": "string",
          "credit_line": [
            {
              "included": true,
              "type": "string",
              "amount": {
                "currency": "EUR",
                "amount": "0000000000000000000"
              }
            }
          ]
        },
        "available_balance": {
          "balance_amount": {
            "amount": {
              "currency": "EUR",
              "amount": "0000000000000000000"
            },
            "credit_debit_indicator": "CRDT"
          },
          "availability_date": "2022-04-12T04:51:22+01:00"
        },
        "forward_available_balance": [
          {
            "balance_amount": {
              "amount": {
                "currency": "EUR",
                "amount": "0000000000000000000"
              },
              "credit_debit_indicator": "CRDT"
            },
            "availability_date": "7200-02-29"
          }
        ]
      },
      "status": "string",
      "credit_limit": {
        "currency": "EUR",
        "amount": "0000000000000503180"
      },
      "links": [
        {
          "href": "string",
          "rel": "string",
          "type": "string"
        }
      ]
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
| 406 | Not Acceptable | [`ErrorMessageException`](../../doc/models/error-message-exception.md) |
| 415 | Unsupported Media Type | [`ErrorMessageException`](../../doc/models/error-message-exception.md) |
| 429 | Too Many Requests | [`ErrorMessageException`](../../doc/models/error-message-exception.md) |
| 500 | Internal Server Error | [`ErrorMessageException`](../../doc/models/error-message-exception.md) |
| 502 | Bad Gateway | [`ErrorMessageException`](../../doc/models/error-message-exception.md) |
| 503 | Service Unavailable | [`ErrorMessageException`](../../doc/models/error-message-exception.md) |
| 504 | Gateway Timeout | [`ErrorMessageException`](../../doc/models/error-message-exception.md) |
| Default | Internal Server Error | [`ErrorMessageException`](../../doc/models/error-message-exception.md) |


# Get Account

The endpoint will retrieve the account with balance information based on a specific account identification.

```csharp
GetAccountAsync(
    string xBIC,
    string accountIdentification,
    string xRequestID = null,
    string xUserContext = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `xBIC` | `string` | Header, Required | Specify the BIC of the provider of the service. The identification will be used by the API Gateway to forward the request to service provider. |
| `accountIdentification` | `string` | Template, Required | An unique and unambiguous identification for the account as assigned by the account servicer. It can be in IBAN or proprietary format.<br><br>RECOMMENDATION IN ORDER OF PREFERENCE:<br>IBAN - When available IBAN must be specified for instance endpoint or hyper link to work.<br>Other - In the absence of IBAN, this must be an unique account identification used for routing of the payment to the account via clearing system. A format which is agreed between the account owner and the account servicer. For example a SWIFT BIC/Branch Code and Account number.<br><br>**Constraints**: *Maximum Length*: `36` |
| `xRequestID` | `string` | Header, Optional | Specify an unique end to end tracking request ID. The element will be populated by the SWIFT API gateway |
| `xUserContext` | `string` | Header, Optional | Provides requester entitlement information to service provider. A JWT containing a claim representing the entitlements of the API consumer as defined at the SWIFT Identity Provider. This header is provided by the SWIFT API Gateway and is not required to be provided by the API consumer. |

## Response Type

[`Task<Models.AccountsResponse2>`](../../doc/models/accounts-response-2.md)

## Example Usage

```csharp
string xBIC = "DEUTDEFF";
string accountIdentification = "DE27212110090000000235698765";
string xUserContext = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIiLCJuYW1lIjoiIiwiaWF0IjowfQ.u_kftAUkjiUZO-OhIyj24H7lOUk1wi9GUF-e14JmCtQ";
try
{
    AccountsResponse2 result = await accountInformationController.GetAccountAsync(
        xBIC,
        accountIdentification,
        null,
        xUserContext
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
  "account_identification": "string",
  "alternate_identification": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
  "account_servicer": "6XI9UOK4NWX",
  "name": "string",
  "owner_name": "string",
  "currency": "EUR",
  "related_account": "string",
  "balances": {
    "current_balance": {
      "balance_amount": {
        "amount": {
          "currency": "EUR",
          "amount": "0000000000000000000"
        },
        "credit_debit_indicator": "CRDT"
      },
      "last_change_date_time": "2022-04-12T17:20:23+01:00",
      "date_time": "2022-04-12T07:10:35+01:00",
      "last_committed_transaction_identification": "string",
      "credit_line": [
        {
          "included": true,
          "type": "string",
          "amount": {
            "currency": "EUR",
            "amount": "0000000000000000000"
          }
        }
      ]
    },
    "available_balance": {
      "balance_amount": {
        "amount": {
          "currency": "EUR",
          "amount": "0000000000000000000"
        },
        "credit_debit_indicator": "CRDT"
      },
      "availability_date": "2022-04-12T07:10:35+01:00"
    },
    "forward_available_balance": [
      {
        "balance_amount": {
          "amount": {
            "currency": "EUR",
            "amount": "0000000000000000000"
          },
          "credit_debit_indicator": "CRDT"
        },
        "availability_date": "2022-04-12"
      }
    ]
  },
  "status": "string",
  "credit_limit": {
    "currency": "EUR",
    "amount": "0000000000000000000"
  },
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


# Get Transaction Summary

The transaction summary endpoint provides the total net, debit and credit entries.

```csharp
GetTransactionSummaryAsync(
    string xBIC,
    string accountIdentification,
    string fromDate,
    string xRequestID = null,
    string xUserContext = null,
    string toDate = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `xBIC` | `string` | Header, Required | Specify the BIC of the provider of the service. The identification will be used by the API Gateway to forward the request to service provider. |
| `accountIdentification` | `string` | Template, Required | An unique and unambiguous identification for the account as assigned by the account servicer. It can be in IBAN or proprietary format.<br><br>RECOMMENDATION IN ORDER OF PREFERENCE:<br>IBAN - When available IBAN must be specified for instance endpoint or hyper link to work.<br>Other - In the absence of IBAN, this must be an unique account identification used for routing of the payment to the account via clearing system. A format which is agreed between the account owner and the account servicer. For example a SWIFT BIC/Branch Code and Account number.<br><br>**Constraints**: *Maximum Length*: `36` |
| `fromDate` | `string` | Query, Required | The start date for which summary information is requested. The result will be filtered on creation_date_time. Expressed in the YYYY-MM-DD format. The date cannot be in the future.<br><br>**Constraints**: *Pattern*: `^(?:[1-9]\d{3}-(?:(?:0[1-9]\|1[0-2])-(?:0[1-9]\|1\d\|2[0-8])\|(?:0[13-9]\|1[0-2])-(?:29\|30)\|(?:0[13578]\|1[02])-31)\|(?:[1-9]\d(?:0[48]\|[2468][048]\|[13579][26])\|(?:[2468][048]\|[13579][26])00)-02-29)$` |
| `xRequestID` | `string` | Header, Optional | Specify an unique end to end tracking request ID. The element will be populated by the SWIFT API gateway |
| `xUserContext` | `string` | Header, Optional | Provides requester entitlement information to service provider. A JWT containing a claim representing the entitlements of the API consumer as defined at the SWIFT Identity Provider. This header is provided by the SWIFT API Gateway and is not required to be provided by the API consumer. |
| `toDate` | `string` | Query, Optional | The end date for which summary information is requested. The result will be filtered on creation_date_time. Expressed in the YYYY-MM-DD format. The date cannot be in the future.<br><br>**Constraints**: *Pattern*: `^(?:[1-9]\d{3}-(?:(?:0[1-9]\|1[0-2])-(?:0[1-9]\|1\d\|2[0-8])\|(?:0[13-9]\|1[0-2])-(?:29\|30)\|(?:0[13578]\|1[02])-31)\|(?:[1-9]\d(?:0[48]\|[2468][048]\|[13579][26])\|(?:[2468][048]\|[13579][26])00)-02-29)$` |

## Response Type

[`Task<Models.AccountsTransactionSummaryResponse>`](../../doc/models/accounts-transaction-summary-response.md)

## Example Usage

```csharp
string xBIC = "DEUTDEFF";
string accountIdentification = "DE27212110090000000235698765";
string fromDate = "2021-09-15";
string xUserContext = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIiLCJuYW1lIjoiIiwiaWF0IjowfQ.u_kftAUkjiUZO-OhIyj24H7lOUk1wi9GUF-e14JmCtQ";
string toDate = "2021-09-15";
try
{
    AccountsTransactionSummaryResponse result = await accountInformationController.GetTransactionSummaryAsync(
        xBIC,
        accountIdentification,
        fromDate,
        null,
        xUserContext,
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
  "account_identification": "string",
  "from_date_time": "2022-04-12T21:44:56+01:00",
  "to_date_time": "2022-04-12T20:10:42+01:00",
  "total_entries": {
    "number_of_entries": "1574",
    "total_net_entry": {
      "amount": {
        "currency": "EUR",
        "amount": "0000000000000000000"
      },
      "credit_debit_indicator": "CRDT"
    }
  },
  "total_credit_entries": {
    "number_of_entries": "14717605",
    "total": {
      "currency": "EUR",
      "amount": "00000000666183886.3"
    }
  },
  "total_debit_entries": {
    "number_of_entries": "046724",
    "total": {
      "currency": "EUR",
      "amount": "0000000000000000000"
    }
  }
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


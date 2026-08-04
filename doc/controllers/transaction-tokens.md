# Transaction Tokens

```csharp
TransactionTokensApi transactionTokensApi = client.TransactionTokensApi;
```

## Class Name

`TransactionTokensApi`

## Methods

* [Create Transaction Token](../../doc/controllers/transaction-tokens.md#create-transaction-token)
* [List All Transaction Tokens](../../doc/controllers/transaction-tokens.md#list-all-transaction-tokens)
* [List Store Transaction Tokens](../../doc/controllers/transaction-tokens.md#list-store-transaction-tokens)
* [Get Transaction Token](../../doc/controllers/transaction-tokens.md#get-transaction-token)
* [Update Transaction Token](../../doc/controllers/transaction-tokens.md#update-transaction-token)
* [Delete Transaction Token](../../doc/controllers/transaction-tokens.md#delete-transaction-token)
* [Get Token Three Ds Issuer Token](../../doc/controllers/transaction-tokens.md#get-token-three-ds-issuer-token)


# Create Transaction Token

Exchange raw payment data for a secure token. **PCI DSS Compliance Required** if sending raw card numbers.

```csharp
CreateTransactionTokenAsync(
    Models.TransactionTokenCreateRequest body,
    string idempotencyKey = null)
```

## Authentication

This endpoint requires [JWT_TOKEN](../../doc/auth/oauth-2-bearer-token.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`TransactionTokenCreateRequest`](../../doc/models/transaction-token-create-request.md) | Body, Required | Request payload for creating a transaction token. |
| `idempotencyKey` | `string` | Header, Optional | An optional idempotency key to prevent double charges and duplicate operations. We recommend a randomly generated UUID (v4). |

## Response Type

**201**: Token Created

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.TransactionToken](../../doc/models/transaction-token.md).

## Example Usage

```csharp
TransactionTokenCreateRequest body = new TransactionTokenCreateRequest
{
    PaymentType = TransactionTokenCreateRequestPaymentType.Card,
    Type = TransactionTokenCreateRequestType.Recurring,
    Data = TransactionTokenCreateRequestData.FromTokenCreateCardData(
        new TokenCreateCardData
        {
            CardNumber = "4242424242424242",
            ExpMonth = "09",
            ExpYear = "26",
            Cardholder = "TEST TEST",
            Cvv = "123",
            PhoneNumber = new TokenCreatePhoneNumber
            {
                CountryCode = "81",
                LocalNumber = "08012341234",
            },
            CvvAuthorize = new TokenCreateCardDataCvvAuthorize
            {
                Enabled = false,
                Currency = "JPY",
            },
            ThreeDs = new TokenCreateCardDataThreeDs
            {
                RedirectEndpoint = "https://univapay.com/redirect/index.html",
            },
        }
    ),
    Email = "test@univapay.com",
    Metadata = new TransactionTokenCreateRequestMetadata
    {
        UnivapayPhoneNumber = "+81 08012341234",
    },
};

try
{
    ApiResponse<TransactionToken> result = await transactionTokensApi.CreateTransactionTokenAsync(body);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ApiErrorException)
    {
       // TODO: Handle ApiErrorException exception here
    }
}
```

## Example Response *(as JSON)*

```json
{
  "id": "11f11e85-e9e9-b198-b990-c3a715943241",
  "store_id": "11f0e274-1e3b-4752-9513-33d3e07ede13",
  "email": "test@test.com",
  "payment_type": "card",
  "active": true,
  "mode": "live",
  "type": "recurring",
  "usage_limit": null,
  "confirmed": null,
  "metadata": {
    "univapay-link-id": "11f11e85-1b45-dace-bf3d-cbcae52f65fc",
    "univapay-name": "test",
    "univapay-phone-number": "+81 08012341234"
  },
  "created_on": "2026-03-13T02:39:52.908468Z",
  "updated_on": "2026-03-13T02:39:52.908468Z",
  "last_used_on": null,
  "data": {
    "card": {
      "cardholder": "TEST TEST",
      "exp_month": 9,
      "exp_year": 2026,
      "card_bin": "424242",
      "last_four": "424242",
      "brand": "visa",
      "card_type": "credit",
      "country": "JP",
      "category": "standard",
      "issuer": "issuer",
      "sub_brand": "none"
    },
    "billing": {
      "line1": null,
      "line2": null,
      "state": null,
      "city": null,
      "country": null,
      "zip": null,
      "phone_number": {
        "country_code": 81,
        "local_number": "08012341234"
      }
    },
    "cvv_authorize": {
      "enabled": false,
      "status": null,
      "charge_id": null,
      "credentials_id": null,
      "currency": null
    },
    "cvv_authorize_check": {
      "status": null,
      "charge_id": null,
      "date": null
    },
    "three_ds": {
      "enabled": true,
      "status": "pending",
      "redirect_endpoint": "https://univapay.com/redirect/index.html",
      "error": null,
      "exempted": false
    }
  }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request (400). The request was invalid or could not be processed.  Common codes: VALIDATION_ERROR, INVALID_TOKEN_TYPE, NOT_SUPPORTED_BY_PROCESSOR. | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 401 | Unauthorized (401). Authentication failed.  Common codes: AUTH_HEADER_MISSING, INVALID_APP_TOKEN, INVALID_CREDENTIALS. | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 403 | Forbidden (403). The request is understood, but access is refused.  This occurs if permissions are insufficient or if a security lock is triggered. | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 429 | Too Many Requests (429). Rate limit exceeded. Returns an empty JSON object in this spec. | `ApiException` |


# List All Transaction Tokens

Lists all transaction tokens across all stores.

```csharp
ListAllTransactionTokensAsync(
    int? limit = 10,
    Guid? cursor = null,
    Models.CursorDirectionQuery? cursorDirection = Models.CursorDirectionQuery.Desc)
```

## Authentication

This endpoint requires [JWT_TOKEN](../../doc/auth/oauth-2-bearer-token.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `limit` | `int?` | Query, Optional | Maximum number of resources to return in one page.<br><br>**Default**: `10`<br><br>**Constraints**: `<= 100` |
| `cursor` | `Guid?` | Query, Optional | Cursor pointing to the resource after which pagination should continue. |
| `cursorDirection` | [`CursorDirectionQuery?`](../../doc/models/cursor-direction-query.md) | Query, Optional | Pagination direction relative to the supplied cursor.<br><br>**Default**: `CursorDirectionQuery.desc` |

## Response Type

**200**: List of Tokens

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.TransactionTokenList](../../doc/models/transaction-token-list.md).

## Example Usage

```csharp
int? limit = 10;
Guid? cursor = new Guid("3541d4fa-596d-428e-8a36-f274e1b3d505");
CursorDirectionQuery? cursorDirection = CursorDirectionQuery.Asc;
try
{
    ApiResponse<TransactionTokenList> result = await transactionTokensApi.ListAllTransactionTokensAsync(
        limit,
        cursor,
        cursorDirection
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ApiErrorException)
    {
       // TODO: Handle ApiErrorException exception here
    }
}
```

## Example Response *(as JSON)*

```json
{
  "items": [
    {
      "id": "2fe23e45-f95d-4c95-9963-739070096443",
      "store_id": "79e9504e-96d8-46ed-8d22-2e8b36238605",
      "merchant_name": "Test Merchant",
      "store_name": "Tokyo Store",
      "email": "taro@example.com",
      "payment_type": "card",
      "active": true,
      "mode": "live",
      "type": "recurring",
      "created_on": "2026-04-09T07:35:50Z",
      "updated_on": "2026-04-09T07:35:50Z",
      "user_data": {
        "cardholder_name": "TARO YAMADA",
        "email": "taro@example.com"
      }
    },
    {
      "id": "3af34f56-a06e-4d06-aa74-84a181107554",
      "store_id": "8bfa615f-a7e9-47fe-9e33-3f9c47349716",
      "merchant_name": "Test Merchant",
      "store_name": "Osaka Store",
      "email": "hanako@example.com",
      "payment_type": "card",
      "active": true,
      "mode": "live",
      "type": "one_time",
      "created_on": "2026-04-10T10:20:11Z",
      "updated_on": "2026-04-10T10:20:11Z",
      "user_data": {
        "cardholder_name": "HANAKO SUZUKI",
        "email": "hanako@example.com"
      }
    },
    {
      "id": "4bf45e67-b17f-4e17-bb85-95b292218665",
      "store_id": "79e9504e-96d8-46ed-8d22-2e8b36238605",
      "merchant_name": "Test Merchant",
      "store_name": "Tokyo Store",
      "email": "jiro@example.com",
      "payment_type": "card",
      "active": false,
      "mode": "live",
      "type": "subscription",
      "created_on": "2026-04-11T18:05:42Z",
      "updated_on": "2026-04-12T08:31:09Z",
      "user_data": {
        "cardholder_name": "JIRO TANAKA",
        "email": "jiro@example.com"
      }
    }
  ],
  "has_more": false,
  "total_hits": 3
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request (400). The request was invalid or could not be processed.  Common codes: VALIDATION_ERROR, INVALID_TOKEN_TYPE, NOT_SUPPORTED_BY_PROCESSOR. | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 401 | Unauthorized (401). Authentication failed.  Common codes: AUTH_HEADER_MISSING, INVALID_APP_TOKEN, INVALID_CREDENTIALS. | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 403 | Forbidden (403). The request is understood, but access is refused.  This occurs if permissions are insufficient or if a security lock is triggered. | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 429 | Too Many Requests (429). Rate limit exceeded. Returns an empty JSON object in this spec. | `ApiException` |


# List Store Transaction Tokens

Lists all transaction tokens for a specific store.

```csharp
ListStoreTransactionTokensAsync(
    Guid storeId,
    int? limit = 10,
    Guid? cursor = null,
    Models.CursorDirectionQuery? cursorDirection = Models.CursorDirectionQuery.Desc)
```

## Authentication

This endpoint requires [JWT_TOKEN](../../doc/auth/oauth-2-bearer-token.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `storeId` | `Guid` | Template, Required | The unique identifier of the store. |
| `limit` | `int?` | Query, Optional | Maximum number of resources to return in one page.<br><br>**Default**: `10`<br><br>**Constraints**: `<= 100` |
| `cursor` | `Guid?` | Query, Optional | Cursor pointing to the resource after which pagination should continue. |
| `cursorDirection` | [`CursorDirectionQuery?`](../../doc/models/cursor-direction-query.md) | Query, Optional | Pagination direction relative to the supplied cursor.<br><br>**Default**: `CursorDirectionQuery.desc` |

## Response Type

**200**: List of Tokens

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.TransactionTokenList](../../doc/models/transaction-token-list.md).

## Example Usage

```csharp
Guid storeId = new Guid("0cab399b-5621-425b-993b-f8507eba1e78");
int? limit = 10;
Guid? cursor = new Guid("3541d4fa-596d-428e-8a36-f274e1b3d505");
CursorDirectionQuery? cursorDirection = CursorDirectionQuery.Asc;
try
{
    ApiResponse<TransactionTokenList> result = await transactionTokensApi.ListStoreTransactionTokensAsync(
        storeId,
        limit,
        cursor,
        cursorDirection
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ApiErrorException)
    {
       // TODO: Handle ApiErrorException exception here
    }
}
```

## Example Response *(as JSON)*

```json
{
  "items": [
    {
      "id": "2fe23e45-f95d-4c95-9963-739070096443",
      "store_id": "79e9504e-96d8-46ed-8d22-2e8b36238605",
      "merchant_name": "Test Merchant",
      "store_name": "Tokyo Store",
      "email": "taro@example.com",
      "payment_type": "card",
      "active": true,
      "mode": "live",
      "type": "recurring",
      "created_on": "2026-04-09T07:35:50Z",
      "updated_on": "2026-04-09T07:35:50Z",
      "user_data": {
        "cardholder_name": "TARO YAMADA",
        "email": "taro@example.com"
      }
    },
    {
      "id": "5cf56e78-c28a-4f28-cc96-06c303329776",
      "store_id": "79e9504e-96d8-46ed-8d22-2e8b36238605",
      "merchant_name": "Test Merchant",
      "store_name": "Tokyo Store",
      "email": "saburo@example.com",
      "payment_type": "card",
      "active": true,
      "mode": "live",
      "type": "one_time",
      "created_on": "2026-04-10T12:14:00Z",
      "updated_on": "2026-04-10T12:14:00Z",
      "user_data": {
        "cardholder_name": "SABURO KATO",
        "email": "saburo@example.com"
      }
    },
    {
      "id": "6df67e89-d39a-4039-dd07-17d414430887",
      "store_id": "79e9504e-96d8-46ed-8d22-2e8b36238605",
      "merchant_name": "Test Merchant",
      "store_name": "Tokyo Store",
      "email": "shiro@example.com",
      "payment_type": "card",
      "active": true,
      "mode": "live",
      "type": "subscription",
      "created_on": "2026-04-11T16:48:23Z",
      "updated_on": "2026-04-11T16:48:23Z",
      "user_data": {
        "cardholder_name": "SHIRO ITO",
        "email": "shiro@example.com"
      }
    }
  ],
  "has_more": false,
  "total_hits": 3
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request (400). The request was invalid or could not be processed.  Common codes: VALIDATION_ERROR, INVALID_TOKEN_TYPE, NOT_SUPPORTED_BY_PROCESSOR. | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 401 | Unauthorized (401). Authentication failed.  Common codes: AUTH_HEADER_MISSING, INVALID_APP_TOKEN, INVALID_CREDENTIALS. | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 403 | Forbidden (403). The request is understood, but access is refused.  This occurs if permissions are insufficient or if a security lock is triggered. | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 429 | Too Many Requests (429). Rate limit exceeded. Returns an empty JSON object in this spec. | `ApiException` |


# Get Transaction Token

Retrieves the details of an existing transaction token.

```csharp
GetTransactionTokenAsync(
    Guid storeId,
    Guid id)
```

## Authentication

This endpoint requires [JWT_TOKEN](../../doc/auth/oauth-2-bearer-token.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `storeId` | `Guid` | Template, Required | The unique identifier of the store. |
| `id` | `Guid` | Template, Required | The unique identifier of the resource. |

## Response Type

**200**: Token Details

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.TransactionToken](../../doc/models/transaction-token.md).

## Example Usage

```csharp
Guid storeId = new Guid("0cab399b-5621-425b-993b-f8507eba1e78");
Guid id = new Guid("c4e87129-cad4-47fb-8ded-b4c0a4ae0dd4");
try
{
    ApiResponse<TransactionToken> result = await transactionTokensApi.GetTransactionTokenAsync(
        storeId,
        id
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ApiErrorException)
    {
       // TODO: Handle ApiErrorException exception here
    }
}
```

## Example Response *(as JSON)*

```json
{
  "id": "11f11e85-e9e9-b198-b990-c3a715943241",
  "store_id": "11f0e274-1e3b-4752-9513-33d3e07ede13",
  "email": "test@test.com",
  "payment_type": "card",
  "active": true,
  "mode": "live",
  "type": "recurring",
  "usage_limit": null,
  "confirmed": null,
  "metadata": {
    "univapay-link-id": "11f11e85-1b45-dace-bf3d-cbcae52f65fc",
    "univapay-name": "test",
    "univapay-phone-number": "+81 08012341234"
  },
  "created_on": "2026-03-13T02:39:52.908468Z",
  "updated_on": "2026-03-13T02:39:52.908468Z",
  "last_used_on": null,
  "data": {
    "card": {
      "cardholder": "TEST TEST",
      "exp_month": 9,
      "exp_year": 2026,
      "card_bin": "424242",
      "last_four": "424242",
      "brand": "visa",
      "card_type": "credit",
      "country": "JP",
      "category": "standard",
      "issuer": "issuer",
      "sub_brand": "none"
    },
    "billing": {
      "line1": null,
      "line2": null,
      "state": null,
      "city": null,
      "country": null,
      "zip": null,
      "phone_number": {
        "country_code": 81,
        "local_number": "08012341234"
      }
    },
    "cvv_authorize": {
      "enabled": false,
      "status": null,
      "charge_id": null,
      "credentials_id": null,
      "currency": null
    },
    "cvv_authorize_check": {
      "status": null,
      "charge_id": null,
      "date": null
    },
    "three_ds": {
      "enabled": true,
      "status": "pending",
      "redirect_endpoint": "https://univapay.com/redirect/index.html",
      "error": null,
      "exempted": false
    }
  }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request (400). The request was invalid or could not be processed.  Common codes: VALIDATION_ERROR, INVALID_TOKEN_TYPE, NOT_SUPPORTED_BY_PROCESSOR. | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 401 | Unauthorized (401). Authentication failed.  Common codes: AUTH_HEADER_MISSING, INVALID_APP_TOKEN, INVALID_CREDENTIALS. | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 403 | Forbidden (403). The request is understood, but access is refused.  This occurs if permissions are insufficient or if a security lock is triggered. | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 404 | Not Found (404). The requested resource (e.g., Store ID or Token ID) does not exist. | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 429 | Too Many Requests (429). Rate limit exceeded. Returns an empty JSON object in this spec. | `ApiException` |


# Update Transaction Token

⚠️ **LEGACY WARNING: Discouraged Operation**
While it is technically possible to update a transaction token, this practice is highly discouraged and is maintained solely for legacy reasons.
**Updating raw card details requires your server environment to be fully PCI DSS compliant.**
**Recommended Approach:** Instead of updating an existing token, it is best practice to create an entirely new transaction token using Univapay's frontend integrations (**Link Form**, **Widget**, or **Inline Form**). This allows Univapay to securely handle the customer's payment data without it ever touching your servers.
--- **Legacy Usage:** Updates CVV, Address, Email, or Card Details.  *Note: If updating only the CVV to resolve a `RECURRING_USAGE_REQUIRES_CVV` error, the application token secret is not required.*

```csharp
UpdateTransactionTokenAsync(
    Guid storeId,
    Guid id,
    string idempotencyKey = null,
    Models.TransactionTokenUpdateRequest body = null)
```

## Authentication

This endpoint requires [JWT_TOKEN](../../doc/auth/oauth-2-bearer-token.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `storeId` | `Guid` | Template, Required | The unique identifier of the store. |
| `id` | `Guid` | Template, Required | The unique identifier of the resource. |
| `idempotencyKey` | `string` | Header, Optional | An optional idempotency key to prevent double charges and duplicate operations. We recommend a randomly generated UUID (v4). |
| `body` | [`TransactionTokenUpdateRequest`](../../doc/models/transaction-token-update-request.md) | Body, Optional | Request payload for updating a transaction token. |

## Response Type

**200**: Token Updated Successfully

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.TransactionToken](../../doc/models/transaction-token.md).

## Example Usage

```csharp
Guid storeId = new Guid("0cab399b-5621-425b-993b-f8507eba1e78");
Guid id = new Guid("c4e87129-cad4-47fb-8ded-b4c0a4ae0dd4");
TransactionTokenUpdateRequest body = new TransactionTokenUpdateRequest
{
    Email = "test.update@test.com",
    Data = new TransactionTokenUpdateRequestData
    {
        Cvv = "123",
        Cardholder = "TARO YAMADA",
        CardNumber = "4000020000000000",
        ExpMonth = 12,
        ExpYear = 2099,
        Line1 = "11111",
        Line2 = "222",
        State = "Tokyo",
        City = "テスト区一丁目",
        Country = "JP",
        Zip = "1234567",
        PhoneNumber = new TransactionTokenUpdateRequestDataPhoneNumber
        {
            CountryCode = "81",
            LocalNumber = "08000000000",
        },
    },
};

try
{
    ApiResponse<TransactionToken> result = await transactionTokensApi.UpdateTransactionTokenAsync(
        storeId,
        id,
        null,
        body
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ApiErrorException)
    {
       // TODO: Handle ApiErrorException exception here
    }
}
```

## Example Response *(as JSON)*

```json
{
  "id": "11f11e85-e9e9-b198-b990-c3a715943241",
  "store_id": "11f0e274-1e3b-4752-9513-33d3e07ede13",
  "email": "test@test.com",
  "payment_type": "card",
  "active": true,
  "mode": "live",
  "type": "recurring",
  "usage_limit": null,
  "confirmed": null,
  "metadata": {
    "univapay-link-id": "11f11e85-1b45-dace-bf3d-cbcae52f65fc",
    "univapay-name": "test",
    "univapay-phone-number": "+81 08012341234"
  },
  "created_on": "2026-03-13T02:39:52.908468Z",
  "updated_on": "2026-03-13T02:39:52.908468Z",
  "last_used_on": null,
  "data": {
    "card": {
      "cardholder": "TEST TEST",
      "exp_month": 9,
      "exp_year": 2026,
      "card_bin": "424242",
      "last_four": "424242",
      "brand": "visa",
      "card_type": "credit",
      "country": "JP",
      "category": "standard",
      "issuer": "issuer",
      "sub_brand": "none"
    },
    "billing": {
      "line1": null,
      "line2": null,
      "state": null,
      "city": null,
      "country": null,
      "zip": null,
      "phone_number": {
        "country_code": 81,
        "local_number": "08012341234"
      }
    },
    "cvv_authorize": {
      "enabled": false,
      "status": null,
      "charge_id": null,
      "credentials_id": null,
      "currency": null
    },
    "cvv_authorize_check": {
      "status": null,
      "charge_id": null,
      "date": null
    },
    "three_ds": {
      "enabled": true,
      "status": "pending",
      "redirect_endpoint": "https://univapay.com/redirect/index.html",
      "error": null,
      "exempted": false
    }
  }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request (400). The request was invalid or could not be processed.  Common codes: VALIDATION_ERROR, INVALID_TOKEN_TYPE, NOT_SUPPORTED_BY_PROCESSOR. | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 401 | Unauthorized (401). Authentication failed.  Common codes: AUTH_HEADER_MISSING, INVALID_APP_TOKEN, INVALID_CREDENTIALS. | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 403 | Forbidden (403). The request is understood, but access is refused.  This occurs if permissions are insufficient or if a security lock is triggered. | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 404 | Not Found (404). The requested resource (e.g., Store ID or Token ID) does not exist. | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 429 | Too Many Requests (429). Rate limit exceeded. Returns an empty JSON object in this spec. | `ApiException` |


# Delete Transaction Token

Deletes a specific transaction token.
⚠️ **WARNING: Breaks Linked Subscriptions**
Please note that deleting a transaction token will immediately prevent any linked recurring charges or subscriptions from being processed. Proceed with caution.

```csharp
DeleteTransactionTokenAsync(
    Guid storeId,
    Guid id)
```

## Authentication

This endpoint requires [JWT_TOKEN](../../doc/auth/oauth-2-bearer-token.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `storeId` | `Guid` | Template, Required | The unique identifier of the store. |
| `id` | `Guid` | Template, Required | The unique identifier of the resource. |

## Response Type

**204**: Token successfully deleted. No content.

`Task`

## Example Usage

```csharp
Guid storeId = new Guid("0cab399b-5621-425b-993b-f8507eba1e78");
Guid id = new Guid("c4e87129-cad4-47fb-8ded-b4c0a4ae0dd4");
try
{
    await transactionTokensApi.DeleteTransactionTokenAsync(
        storeId,
        id
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ApiErrorException)
    {
       // TODO: Handle ApiErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request (400). The request was invalid or could not be processed.  Common codes: VALIDATION_ERROR, INVALID_TOKEN_TYPE, NOT_SUPPORTED_BY_PROCESSOR. | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 401 | Unauthorized (401). Authentication failed.  Common codes: AUTH_HEADER_MISSING, INVALID_APP_TOKEN, INVALID_CREDENTIALS. | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 403 | Forbidden (403). The request is understood, but access is refused.  This occurs if permissions are insufficient or if a security lock is triggered. | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 404 | Not Found (404). The requested resource (e.g., Store ID or Token ID) does not exist. | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 429 | Too Many Requests (429). Rate limit exceeded. Returns an empty JSON object in this spec. | `ApiException` |


# Get Token Three Ds Issuer Token

Retrieves the information required to execute 3-D Secure authentication when creating a recurring transaction token.
**⚠️ Important Notes:** 1. **PCI DSS Compliance:** This endpoint is only available to PCI DSS compliant merchants who are authorized to send raw card data directly via the API to create tokens. 2. **Target Tokens:** This only applies to tokens where `type` is `recurring`. For `one_time` or `subscription` tokens, 3-D Secure is requested during charge creation, not token creation. 3. **Execution Flow:**

- After creating the token, poll the token object until `data.three_ds.status` becomes `awaiting`.
- Once `awaiting`, use this endpoint to fetch the issuer token details.
- Format the returned `payload` according to the `content_type` (e.g., URL-encoded) and execute an `http_post` request from the consumer's browser to the `issuer_token` URL.

```csharp
GetTokenThreeDsIssuerTokenAsync(
    Guid storeId,
    Guid id)
```

## Authentication

This endpoint requires [JWT_TOKEN](../../doc/auth/oauth-2-bearer-token.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `storeId` | `Guid` | Template, Required | The unique identifier of the store. |
| `id` | `Guid` | Template, Required | The unique identifier of the resource. |

## Response Type

**200**: 3-D Secure authentication details retrieved successfully.

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.ThreeDsIssuerToken](../../doc/models/three-ds-issuer-token.md).

## Example Usage

```csharp
Guid storeId = new Guid("0cab399b-5621-425b-993b-f8507eba1e78");
Guid id = new Guid("c4e87129-cad4-47fb-8ded-b4c0a4ae0dd4");
try
{
    ApiResponse<ThreeDsIssuerToken> result = await transactionTokensApi.GetTokenThreeDsIssuerTokenAsync(
        storeId,
        id
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ApiErrorException)
    {
       // TODO: Handle ApiErrorException exception here
    }
}
```

## Example Response *(as JSON)*

```json
{
  "issuer_token": "http://test.com/action",
  "call_method": "http_post",
  "payload": {
    "request_data": "example_value"
  },
  "payment_type": "card",
  "content_type": "application/x-www-form-urlencoded; charset=UTF-8"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request (400). The request was invalid or could not be processed.  Common codes: VALIDATION_ERROR, INVALID_TOKEN_TYPE, NOT_SUPPORTED_BY_PROCESSOR. | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 401 | Unauthorized (401). Authentication failed.  Common codes: AUTH_HEADER_MISSING, INVALID_APP_TOKEN, INVALID_CREDENTIALS. | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 403 | Forbidden (403). The request is understood, but access is refused.  This occurs if permissions are insufficient or if a security lock is triggered. | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 404 | Not Found (404). The requested resource (e.g., Store ID or Token ID) does not exist. | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 429 | Too Many Requests (429). Rate limit exceeded. Returns an empty JSON object in this spec. | `ApiException` |


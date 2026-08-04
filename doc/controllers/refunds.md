# Refunds

Endpoints to create and manage refunds for charges.

```csharp
RefundsApi refundsApi = client.RefundsApi;
```

## Class Name

`RefundsApi`

## Methods

* [List Refunds](../../doc/controllers/refunds.md#list-refunds)
* [Create Refund](../../doc/controllers/refunds.md#create-refund)
* [Get Refund](../../doc/controllers/refunds.md#get-refund)
* [Update Refund](../../doc/controllers/refunds.md#update-refund)


# List Refunds

Retrieves a list of all refunds for a specific charge.

```csharp
ListRefundsAsync(
    Guid storeId,
    Guid chargeId,
    int? limit = 10,
    Guid? cursor = null,
    Models.CursorDirectionQuery? cursorDirection = Models.CursorDirectionQuery.Desc,
    string metadata = null)
```

## Authentication

This endpoint requires [JWT_TOKEN](../../doc/auth/oauth-2-bearer-token.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `storeId` | `Guid` | Template, Required | The unique identifier of the store. |
| `chargeId` | `Guid` | Template, Required | The unique identifier of the charge. |
| `limit` | `int?` | Query, Optional | Maximum number of resources to return in one page.<br><br>**Default**: `10`<br><br>**Constraints**: `<= 100` |
| `cursor` | `Guid?` | Query, Optional | Cursor pointing to the resource after which pagination should continue. |
| `cursorDirection` | [`CursorDirectionQuery?`](../../doc/models/cursor-direction-query.md) | Query, Optional | Pagination direction relative to the supplied cursor.<br><br>**Default**: `CursorDirectionQuery.desc` |
| `metadata` | `string` | Query, Optional | Filter refunds by metadata content. |

## Response Type

**200**: List of refunds retrieved successfully.

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.RefundList](../../doc/models/refund-list.md).

## Example Usage

```csharp
Guid storeId = new Guid("0cab399b-5621-425b-993b-f8507eba1e78");
Guid chargeId = new Guid("6efb4e5c-690a-40f3-a4f1-0e19c5f84e98");
int? limit = 10;
Guid? cursor = new Guid("3541d4fa-596d-428e-8a36-f274e1b3d505");
CursorDirectionQuery? cursorDirection = CursorDirectionQuery.Asc;
string metadata = "order_id: 12345";
try
{
    ApiResponse<RefundList> result = await refundsApi.ListRefundsAsync(
        storeId,
        chargeId,
        limit,
        cursor,
        cursorDirection,
        metadata
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
      "id": "b4d9fea9-c9b3-4e76-a25d-b61f7e4821b6",
      "store_id": "76cf4a64-02bc-4cb3-9a28-74622e5928a1",
      "charge_id": "6efb4e5c-690a-40f3-a4f1-0e19c5f84e98",
      "status": "successful",
      "amount": 1000,
      "currency": "JPY",
      "amount_formatted": 1000,
      "reason": "customer_request",
      "message": "Customer returned item",
      "error": {},
      "metadata": {},
      "mode": "live",
      "created_on": "2026-04-09T07:35:50.000000Z",
      "updated_on": "2026-04-09T07:36:00.000000Z"
    },
    {
      "id": "c5e0afb0-dac4-5f87-b36e-c72f8f5932c7",
      "store_id": "76cf4a64-02bc-4cb3-9a28-74622e5928a1",
      "charge_id": "7fac5f6d-7a1b-51e4-b5f2-1f2ad6f95fa9",
      "status": "pending",
      "amount": 2500,
      "currency": "JPY",
      "amount_formatted": 2500,
      "reason": "duplicate",
      "message": "Duplicate charge",
      "error": {},
      "metadata": {
        "order_id": "ORD-1002"
      },
      "mode": "live",
      "created_on": "2026-04-10T10:00:00.000000Z",
      "updated_on": "2026-04-10T10:00:05.000000Z"
    },
    {
      "id": "d6f1bac1-ebd5-6098-c47f-d83a906043d8",
      "store_id": "76cf4a64-02bc-4cb3-9a28-74622e5928a1",
      "charge_id": "80bd6a7e-8b2c-62f5-c6a3-2a3be7a06aba",
      "status": "successful",
      "amount": 500,
      "currency": "JPY",
      "amount_formatted": 500,
      "reason": "fraud",
      "message": "Fraudulent transaction reversed",
      "error": {},
      "metadata": {},
      "mode": "live",
      "created_on": "2026-04-11T14:22:08.000000Z",
      "updated_on": "2026-04-11T14:22:20.000000Z"
    }
  ],
  "has_more": false,
  "total_hits": 3
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 401 | Unauthorized (401). Authentication failed.  Common codes: AUTH_HEADER_MISSING, INVALID_APP_TOKEN, INVALID_CREDENTIALS. | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 403 | Forbidden (403). The request is understood, but access is refused.  This occurs if permissions are insufficient or if a security lock is triggered. | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 404 | Not Found (404). The requested resource (e.g., Store ID or Token ID) does not exist. | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Create Refund

Creates a refund for a successful charge. The charge must have status `successful`. Konbini and bank transfer charges cannot be refunded. The refund is processed asynchronously — the initial status will be `pending`.

```csharp
CreateRefundAsync(
    Guid storeId,
    Guid chargeId,
    Models.RefundCreateRequest body,
    string idempotencyKey = null)
```

## Authentication

This endpoint requires [JWT_TOKEN](../../doc/auth/oauth-2-bearer-token.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `storeId` | `Guid` | Template, Required | The unique identifier of the store. |
| `chargeId` | `Guid` | Template, Required | The unique identifier of the charge. |
| `body` | [`RefundCreateRequest`](../../doc/models/refund-create-request.md) | Body, Required | Request payload for creating a refund. |
| `idempotencyKey` | `string` | Header, Optional | An optional idempotency key to prevent double charges and duplicate operations. We recommend a randomly generated UUID (v4). |

## Response Type

**201**: Refund created successfully. Processing is asynchronous — poll or use webhooks to track completion.

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.Refund](../../doc/models/refund.md).

## Example Usage

```csharp
Guid storeId = new Guid("0cab399b-5621-425b-993b-f8507eba1e78");
Guid chargeId = new Guid("6efb4e5c-690a-40f3-a4f1-0e19c5f84e98");
RefundCreateRequest body = new RefundCreateRequest
{
    Amount = 1000,
    Currency = "JPY",
    Reason = RefundReasonRequest.CustomerRequest,
};

string idempotencyKey = "f64be872-353d-4c3c-84cb-3dc617fe89f7";
try
{
    ApiResponse<Refund> result = await refundsApi.CreateRefundAsync(
        storeId,
        chargeId,
        body,
        idempotencyKey
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
  "id": "b4d9fea9-c9b3-4e76-a25d-b61f7e4821b6",
  "store_id": "76cf4a64-02bc-4cb3-9a28-74622e5928a1",
  "charge_id": "6efb4e5c-690a-40f3-a4f1-0e19c5f84e98",
  "status": "pending",
  "amount": 1000,
  "currency": "JPY",
  "amount_formatted": 1000,
  "reason": "customer_request",
  "message": "Customer returned item",
  "error": null,
  "metadata": {},
  "mode": "live",
  "created_on": "2026-04-09T07:35:50.000000Z",
  "updated_on": "2026-04-09T07:35:50.000000Z"
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


# Get Refund

Retrieves the details of a specific refund. Supports long polling — set `polling=true` to wait until the refund status changes from `pending` to a terminal state (`successful`, `failed`, or `error`).

```csharp
GetRefundAsync(
    Guid storeId,
    Guid chargeId,
    Guid id,
    bool? polling = null)
```

## Authentication

This endpoint requires [JWT_TOKEN](../../doc/auth/oauth-2-bearer-token.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `storeId` | `Guid` | Template, Required | The unique identifier of the store. |
| `chargeId` | `Guid` | Template, Required | The unique identifier of the charge. |
| `id` | `Guid` | Template, Required | The unique identifier of the resource. |
| `polling` | `bool?` | Query, Optional | If `true`, the server holds the connection open until the refund status transitions from `pending` to a terminal state, or until the polling timeout is reached. |

## Response Type

**200**: Refund details retrieved successfully.

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.Refund](../../doc/models/refund.md).

## Example Usage

```csharp
Guid storeId = new Guid("0cab399b-5621-425b-993b-f8507eba1e78");
Guid chargeId = new Guid("6efb4e5c-690a-40f3-a4f1-0e19c5f84e98");
Guid id = new Guid("c4e87129-cad4-47fb-8ded-b4c0a4ae0dd4");
bool? polling = true;
try
{
    ApiResponse<Refund> result = await refundsApi.GetRefundAsync(
        storeId,
        chargeId,
        id,
        polling
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
  "id": "b4d9fea9-c9b3-4e76-a25d-b61f7e4821b6",
  "store_id": "76cf4a64-02bc-4cb3-9a28-74622e5928a1",
  "charge_id": "6efb4e5c-690a-40f3-a4f1-0e19c5f84e98",
  "status": "successful",
  "amount": 1000,
  "currency": "JPY",
  "amount_formatted": 1000,
  "reason": "customer_request",
  "message": "Customer returned item",
  "error": null,
  "metadata": {},
  "mode": "live",
  "created_on": "2026-04-09T07:35:50.000000Z",
  "updated_on": "2026-04-09T07:36:00.000000Z"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 401 | Unauthorized (401). Authentication failed.  Common codes: AUTH_HEADER_MISSING, INVALID_APP_TOKEN, INVALID_CREDENTIALS. | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 404 | Not Found (404). The requested resource (e.g., Store ID or Token ID) does not exist. | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Update Refund

Updates metadata, message, or reason on an existing refund.

```csharp
UpdateRefundAsync(
    Guid storeId,
    Guid chargeId,
    Guid id,
    Models.RefundUpdateRequest body,
    string idempotencyKey = null)
```

## Authentication

This endpoint requires [JWT_TOKEN](../../doc/auth/oauth-2-bearer-token.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `storeId` | `Guid` | Template, Required | The unique identifier of the store. |
| `chargeId` | `Guid` | Template, Required | The unique identifier of the charge. |
| `id` | `Guid` | Template, Required | The unique identifier of the resource. |
| `body` | [`RefundUpdateRequest`](../../doc/models/refund-update-request.md) | Body, Required | Request payload for updating refund metadata or reason. |
| `idempotencyKey` | `string` | Header, Optional | An optional idempotency key to prevent double charges and duplicate operations. We recommend a randomly generated UUID (v4). |

## Response Type

**200**: Refund updated successfully.

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.Refund](../../doc/models/refund.md).

## Example Usage

```csharp
Guid storeId = new Guid("0cab399b-5621-425b-993b-f8507eba1e78");
Guid chargeId = new Guid("6efb4e5c-690a-40f3-a4f1-0e19c5f84e98");
Guid id = new Guid("c4e87129-cad4-47fb-8ded-b4c0a4ae0dd4");
RefundUpdateRequest body = new RefundUpdateRequest
{
    Metadata = new GenericMetadata
    {
        OrderId = "12345",
    },
    Message = "Updated reason note",
};

string idempotencyKey = "f64be872-353d-4c3c-84cb-3dc617fe89f7";
try
{
    ApiResponse<Refund> result = await refundsApi.UpdateRefundAsync(
        storeId,
        chargeId,
        id,
        body,
        idempotencyKey
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
  "id": "b4d9fea9-c9b3-4e76-a25d-b61f7e4821b6",
  "store_id": "76cf4a64-02bc-4cb3-9a28-74622e5928a1",
  "charge_id": "6efb4e5c-690a-40f3-a4f1-0e19c5f84e98",
  "status": "successful",
  "amount": 1000,
  "currency": "JPY",
  "amount_formatted": 1000,
  "reason": "customer_request",
  "message": "Updated reason note",
  "error": null,
  "metadata": {
    "order_id": "12345"
  },
  "mode": "live",
  "created_on": "2026-04-09T07:35:50.000000Z",
  "updated_on": "2026-04-09T08:00:00.000000Z"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request (400). The request was invalid or could not be processed.  Common codes: VALIDATION_ERROR, INVALID_TOKEN_TYPE, NOT_SUPPORTED_BY_PROCESSOR. | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 401 | Unauthorized (401). Authentication failed.  Common codes: AUTH_HEADER_MISSING, INVALID_APP_TOKEN, INVALID_CREDENTIALS. | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 403 | Forbidden (403). The request is understood, but access is refused.  This occurs if permissions are insufficient or if a security lock is triggered. | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 404 | Not Found (404). The requested resource (e.g., Store ID or Token ID) does not exist. | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


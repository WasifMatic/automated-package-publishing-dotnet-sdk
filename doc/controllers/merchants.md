# Merchants

Merchant identity and effective configuration endpoints for authenticated operators.

```csharp
MerchantsApi merchantsApi = client.MerchantsApi;
```

## Class Name

`MerchantsApi`


# Get Current Merchant

Returns merchant identity and the effective configuration resolved from bearer credentials. Treat this as the canonical introspection endpoint for merchant integrations.

```csharp
GetCurrentMerchantAsync()
```

## Authentication

This endpoint requires [JWT_TOKEN](../../doc/auth/oauth-2-bearer-token.md)

## Response Type

**200**: Current merchant context.

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.Merchant](../../doc/models/merchant.md).

## Example Usage

```csharp
try
{
    ApiResponse<Merchant> result = await merchantsApi.GetCurrentMerchantAsync();
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
  "id": "11ef0000-0000-4000-8000-000000000020",
  "verification_data_id": "11ef0000-0000-4000-8000-000000000021",
  "name": "Example Merchant",
  "email": "owner@example.com",
  "notification_email": "alerts@example.com",
  "finance_notification_email": "finance@example.com",
  "verified": true,
  "configuration": {
    "percent_fee": 3.6,
    "country": "JP",
    "language": "ja",
    "minimum_charge_amounts": [
      {
        "amount": 100,
        "currency": "JPY"
      }
    ],
    "maximum_charge_amounts": [
      {
        "amount": 100000,
        "currency": "JPY"
      }
    ],
    "user_transactions_configuration": {
      "enabled": true,
      "notify_customer": true,
      "notify_on_webhook_failure": true
    },
    "card_configuration": {
      "enabled": true,
      "debit_enabled": true,
      "prepaid_enabled": false,
      "three_ds_required": true
    },
    "online_configuration": {
      "enabled": true
    },
    "bank_transfer_configuration": {
      "enabled": true,
      "match_amount": true,
      "expiration": "P7D"
    }
  },
  "created_on": "2026-04-09T07:35:50.000000Z"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 401 | Unauthorized (401). Authentication failed.  Common codes: AUTH_HEADER_MISSING, INVALID_APP_TOKEN, INVALID_CREDENTIALS. | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 403 | Forbidden (403). The request is understood, but access is refused.  This occurs if permissions are insufficient or if a security lock is triggered. | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 429 | Too Many Requests (429). Rate limit exceeded. Returns an empty JSON object in this spec. | `ApiException` |


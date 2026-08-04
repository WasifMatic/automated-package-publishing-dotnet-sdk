
# Issuer Token

Issuer token or bank transfer instruction payload.

*This model accepts additional fields of type object.*

## Structure

`IssuerToken`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PaymentType` | [`IssuerTokenPaymentType`](../../doc/models/issuer-token-payment-type.md) | Required | The type of payment method for the charge. |
| `IssuerToken` | `string` | Optional | (Online) The token or payment URL provided by the payment provider for the consumer to execute. |
| `CallMethod` | [`IssuerTokenCallMethod?`](../../doc/models/issuer-token-call-method.md) | Optional | (Online) How the client should execute the token.  - `sdk` / `app`: Direct use in native app environments/SDKs. - `web`: Direct use in special extended browser environments. - `http_get` / `http_post`: Execute directly in a new browser window or iframe. |
| `Payload` | [`IssuerTokenPayload`](../../doc/models/issuer-token-payload.md) | Optional | Key-value pairs required to complete the payment action, or null if not applicable. Used when `call_method` is `http_post`. When present, this JSON must be converted by the client to match the expected `content_type` (e.g., transformed into an `application/x-www-form-urlencoded` string) before sending the POST request. |
| `AccountId` | `string` | Optional | (Bank Transfer) Unique ID of the bank account issued by the connected system. |
| `BranchCode` | `string` | Optional | (Bank Transfer) Branch code. |
| `BranchName` | `string` | Optional | (Bank Transfer) Branch name. |
| `AccountHolderName` | `string` | Optional | (Bank Transfer) Account holder name. |
| `AccountNumber` | `string` | Optional | (Bank Transfer) Account number. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

IssuerToken issuerToken = new IssuerToken
{
    PaymentType = IssuerTokenPaymentType.Online,
    IssuerToken = "https://example.com/payments/issuer",
    CallMethod = IssuerTokenCallMethod.HttpPost,
    Payload = new IssuerTokenPayload
    {
        RequestData = "example",
        SSpcd = "sSpcd6",
        SCptok = "sCptok0",
        STerkn = "sTerkn6",
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    AccountId = "account_id2",
    BranchCode = "branch_code8",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


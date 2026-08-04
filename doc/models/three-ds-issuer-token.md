
# Three Ds Issuer Token

3-D Secure issuer token payload.

*This model accepts additional fields of type object.*

## Structure

`ThreeDsIssuerToken`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PaymentType` | `string` | Required, Constant | Only 'card' is supported for 3-D Secure issuer tokens.<br><br>**Value**: `"card"` |
| `IssuerToken` | `string` | Required | The 3-D Secure authentication URL to which the client must send the request. |
| `CallMethod` | `string` | Required, Constant | Execution method. Currently, only 'http_post' is supported.<br><br>**Value**: `"http_post"` |
| `Payload` | [`IssuerTokenPayload`](../../doc/models/issuer-token-payload.md) | Optional | Key-value pairs required to complete the payment action, or null if not applicable. Used when `call_method` is `http_post`. When present, this JSON must be converted by the client to match the expected `content_type` (e.g., transformed into an `application/x-www-form-urlencoded` string) before sending the POST request. |
| `ContentType` | `string` | Required | The expected content type of the payload required by the card issuer's endpoint  (e.g., 'application/x-www-form-urlencoded; charset=UTF-8'). |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

ThreeDsIssuerToken threeDsIssuerToken = new ThreeDsIssuerToken
{
    PaymentType = "card",
    IssuerToken = "https://example.com/resource",
    CallMethod = "http_post",
    ContentType = "application/x-www-form-urlencoded; charset=UTF-8",
    Payload = new IssuerTokenPayload
    {
        RequestData = "example",
        SSpcd = "sSpcd6",
        SCptok = "sCptok0",
        STerkn = "sTerkn6",
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


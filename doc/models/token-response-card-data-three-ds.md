
# Token Response Card Data Three Ds

Token Response Card Data Three Ds schema.

*This model accepts additional fields of type object.*

## Structure

`TokenResponseCardDataThreeDs`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Enabled` | `bool?` | Optional | Enabled value. |
| `Status` | [`TokenResponseCardDataThreeDsStatus?`](../../doc/models/token-response-card-data-three-ds-status.md) | Optional | Token Response Card Data Three Ds Status schema. |
| `RedirectEndpoint` | `string` | Optional | Redirect endpoint URL. |
| `RedirectId` | `Guid?` | Optional | Redirect identifier. |
| `Exempted` | `bool?` | Optional | Indicates if the 3DS check was exempted. When creating charge 3DS check will not be required. |
| `Error` | [`PaymentError`](../../doc/models/payment-error.md) | Optional | Payment error details, or null if successful. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

TokenResponseCardDataThreeDs tokenResponseCardDataThreeDs = new TokenResponseCardDataThreeDs
{
    Enabled = true,
    Status = TokenResponseCardDataThreeDsStatus.Successful,
    RedirectEndpoint = null,
    RedirectId = null,
    Exempted = false,
    Error = null,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


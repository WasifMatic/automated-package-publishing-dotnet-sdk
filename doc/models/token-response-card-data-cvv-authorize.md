
# Token Response Card Data Cvv Authorize

Token Response Card Data Cvv Authorize schema.

*This model accepts additional fields of type object.*

## Structure

`TokenResponseCardDataCvvAuthorize`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Enabled` | `bool?` | Optional | Enabled value. |
| `Status` | `string` | Optional | Current status of the resource. |
| `ChargeId` | `Guid?` | Optional | Charge identifier. |
| `CredentialsId` | `Guid?` | Optional | Credentials identifier. |
| `Currency` | `string` | Optional | ISO-4217 currency code. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

TokenResponseCardDataCvvAuthorize tokenResponseCardDataCvvAuthorize = new TokenResponseCardDataCvvAuthorize
{
    Enabled = true,
    Status = "successful",
    ChargeId = null,
    CredentialsId = null,
    Currency = "JPY",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


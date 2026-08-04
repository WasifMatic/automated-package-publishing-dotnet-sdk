
# Issuer Token Payload

A dictionary containing necessary key-value pairs for sending the request.

*This model accepts additional fields of type object.*

## Structure

`IssuerTokenPayload`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RequestData` | `string` | Optional | Generic payload key used by most payment providers. |
| `SSpcd` | `string` | Optional | d-barai payment service code. |
| `SCptok` | `string` | Optional | d-barai coupon token. |
| `STerkn` | `string` | Optional | d-barai terminal key. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

IssuerTokenPayload issuerTokenPayload = new IssuerTokenPayload
{
    RequestData = "request_data2",
    SSpcd = "sSpcd2",
    SCptok = "sCptok4",
    STerkn = "sTerkn2",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


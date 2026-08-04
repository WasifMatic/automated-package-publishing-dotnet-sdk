
# Customs Declaration Create Request

Request body for creating a customs declaration. Backend currently accepts this shape only for WeChat Online and WeChat MPM charges.

*This model accepts additional fields of type object.*

## Structure

`CustomsDeclarationCreateRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Customs` | `string` | Required | WeChat customs authority code used for the declaration. |
| `MerchantCustomsNo` | `string` | Required | Merchant customs registration number. |
| `CertificateId` | `string` | Required | Customer certificate or passport identifier used by customs. |
| `CertificateName` | `string` | Required | Customer name exactly as shown on the certificate. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

CustomsDeclarationCreateRequest customsDeclarationCreateRequest = new CustomsDeclarationCreateRequest
{
    Customs = "TOKYO",
    MerchantCustomsNo = "1234567890",
    CertificateId = "AB1234567",
    CertificateName = "TARO YAMADA",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


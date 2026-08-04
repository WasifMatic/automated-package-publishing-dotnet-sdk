
# Customs Declaration Webhook Declaration

WeChat customs declaration payload returned by the backend formatter.

*This model accepts additional fields of type object.*

## Structure

`CustomsDeclarationWebhookDeclaration`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Customs` | `string` | Optional | WeChat customs authority code. |
| `MerchantCustomsNo` | `string` | Optional | Merchant customs registration number. |
| `CertificateId` | `string` | Optional | Customer certificate or passport identifier. |
| `CertificateName` | `string` | Optional | Customer name as provided to customs. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

CustomsDeclarationWebhookDeclaration customsDeclarationWebhookDeclaration = new CustomsDeclarationWebhookDeclaration
{
    Customs = "TOKYO",
    MerchantCustomsNo = "1234567890",
    CertificateId = "AB1234567",
    CertificateName = "TARO YAMADA",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```



# Customs Declaration Patch Request

Request body for updating a customs declaration. Backend patch handling keeps the original `customs`, `certificate_id`, and `certificate_name` values and only accepts a new `merchant_customs_no`.

*This model accepts additional fields of type object.*

## Structure

`CustomsDeclarationPatchRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MerchantCustomsNo` | `string` | Required | Updated merchant customs registration number. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

CustomsDeclarationPatchRequest customsDeclarationPatchRequest = new CustomsDeclarationPatchRequest
{
    MerchantCustomsNo = "1234567891",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


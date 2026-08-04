
# Token Create Card Data

Token Create Card Data schema.

*This model accepts additional fields of type object.*

## Structure

`TokenCreateCardData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Cardholder` | `string` | Optional | Cardholder name. |
| `CardNumber` | `string` | Required | Card number. |
| `ExpMonth` | `string` | Required | Card expiration month. |
| `ExpYear` | `string` | Required | Card expiration year. |
| `Cvv` | `string` | Optional | Card security code. |
| `Line1` | `string` | Optional | Primary street address line. |
| `Line2` | `string` | Optional | Secondary street address line. |
| `State` | `string` | Optional | State or prefecture. |
| `City` | `string` | Optional | City or locality. |
| `Country` | `string` | Optional | Country code. |
| `Zip` | `string` | Optional | Postal code. |
| `PhoneNumber` | [`TokenCreatePhoneNumber`](../../doc/models/token-create-phone-number.md) | Optional | Token Create Phone Number schema. |
| `CvvAuthorize` | [`TokenCreateCardDataCvvAuthorize`](../../doc/models/token-create-card-data-cvv-authorize.md) | Optional | Token Create Card Data Cvv Authorize schema. |
| `ThreeDs` | [`TokenCreateCardDataThreeDs`](../../doc/models/token-create-card-data-three-ds.md) | Optional | Token Create Card Data Three Ds schema. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

TokenCreateCardData tokenCreateCardData = new TokenCreateCardData
{
    CardNumber = "4242424242424242",
    ExpMonth = "12",
    ExpYear = "2026",
    Cardholder = "cardholder8",
    Cvv = "cvv0",
    Line1 = "line14",
    Line2 = "line26",
    State = "state2",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


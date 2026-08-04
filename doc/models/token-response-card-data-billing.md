
# Token Response Card Data Billing

Token Response Card Data Billing schema.

*This model accepts additional fields of type object.*

## Structure

`TokenResponseCardDataBilling`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Line1` | `string` | Optional | Primary street address line. |
| `Line2` | `string` | Optional | Secondary street address line. |
| `State` | `string` | Optional | State or prefecture. |
| `City` | `string` | Optional | City or locality. |
| `Country` | `string` | Optional | Country code. |
| `Zip` | `string` | Optional | Postal code. |
| `PhoneNumber` | [`TokenResponsePhoneNumber`](../../doc/models/token-response-phone-number.md) | Optional | Token Response Phone Number schema. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

TokenResponseCardDataBilling tokenResponseCardDataBilling = new TokenResponseCardDataBilling
{
    Line1 = "1-1-1",
    Line2 = "Shibakoen",
    State = "Tokyo",
    City = "Minato",
    Country = "JP",
    Zip = "105-0011",
    PhoneNumber = new TokenResponsePhoneNumber
    {
        CountryCode = 81,
        LocalNumber = "08012341234",
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


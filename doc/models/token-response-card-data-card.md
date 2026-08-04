
# Token Response Card Data Card

Token Response Card Data Card schema.

*This model accepts additional fields of type object.*

## Structure

`TokenResponseCardDataCard`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Cardholder` | `string` | Optional | Cardholder name. |
| `ExpMonth` | `int?` | Optional | Card expiration month. |
| `ExpYear` | `int?` | Optional | Card expiration year. |
| `CardBin` | `string` | Optional | Card bin value. |
| `LastFour` | `string` | Optional | Last four value. |
| `Brand` | `string` | Optional | Brand or network name. |
| `CardType` | `string` | Optional | Card type value. |
| `Country` | `string` | Optional | Country code. |
| `Category` | `string` | Optional | Category value. |
| `Issuer` | `string` | Optional | Issuer value. |
| `SubBrand` | `string` | Optional | Sub brand value. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

TokenResponseCardDataCard tokenResponseCardDataCard = new TokenResponseCardDataCard
{
    Cardholder = "TARO YAMADA",
    ExpMonth = 12,
    ExpYear = 2026,
    CardBin = "424242",
    LastFour = "4242",
    Brand = "visa",
    CardType = "credit",
    Country = "JP",
    Category = "standard",
    Issuer = null,
    SubBrand = "none",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```



# Token Response Card Data

Token Response Card Data schema.

*This model accepts additional fields of type object.*

## Structure

`TokenResponseCardData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Card` | [`TokenResponseCardDataCard`](../../doc/models/token-response-card-data-card.md) | Optional | Token Response Card Data Card schema. |
| `Billing` | [`TokenResponseCardDataBilling`](../../doc/models/token-response-card-data-billing.md) | Optional | Token Response Card Data Billing schema. |
| `CvvAuthorize` | [`TokenResponseCardDataCvvAuthorize`](../../doc/models/token-response-card-data-cvv-authorize.md) | Optional | Token Response Card Data Cvv Authorize schema. |
| `CvvAuthorizeCheck` | [`TokenResponseCardDataCvvAuthorizeCheck`](../../doc/models/token-response-card-data-cvv-authorize-check.md) | Optional | Token Response Card Data Cvv Authorize Check schema. |
| `ThreeDs` | [`TokenResponseCardDataThreeDs`](../../doc/models/token-response-card-data-three-ds.md) | Optional | Token Response Card Data Three Ds schema. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using System.Globalization;
using UnivaPay.Models;
using UnivaPay.Utilities;

TokenResponseCardData tokenResponseCardData = new TokenResponseCardData
{
    Card = new TokenResponseCardDataCard
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
    },
    Billing = new TokenResponseCardDataBilling
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
    },
    CvvAuthorize = new TokenResponseCardDataCvvAuthorize
    {
        Enabled = true,
        Status = "successful",
        ChargeId = null,
        CredentialsId = null,
        Currency = "JPY",
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    CvvAuthorizeCheck = new TokenResponseCardDataCvvAuthorizeCheck
    {
        Status = "successful",
        ChargeId = null,
        Date = DateTime.ParseExact("2026-04-09T07:35:50Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ThreeDs = new TokenResponseCardDataThreeDs
    {
        Enabled = true,
        Status = TokenResponseCardDataThreeDsStatus.Successful,
        RedirectEndpoint = null,
        RedirectId = null,
        Exempted = false,
        Error = null,
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


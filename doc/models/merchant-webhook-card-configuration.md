
# Merchant Webhook Card Configuration

Card payment settings.

*This model accepts additional fields of type object.*

## Structure

`MerchantWebhookCardConfiguration`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Enabled` | `bool?` | Optional | Enables card payments. |
| `DebitEnabled` | `bool?` | Optional | Allows debit cards for payment flows. |
| `PrepaidEnabled` | `bool?` | Optional | Allows prepaid cards for payment flows. |
| `DebitAuthorizationEnabled` | `bool?` | Optional | Allows authorization-only flows for debit cards. |
| `PrepaidAuthorizationEnabled` | `bool?` | Optional | Allows authorization-only flows for prepaid cards. |
| `ForbiddenCardBrands` | `List<string>` | Optional | Card brands rejected by merchant policy. |
| `AllowedCountriesByIp` | `List<string>` | Optional | Source IP country codes allowed for card payments. |
| `ForeignCardsAllowed` | `bool?` | Optional | Allows cards issued outside the primary operating country. |
| `FailOnNewEmail` | `bool?` | Optional | Rejects card charges from previously unseen customer email addresses. |
| `CardLimit` | `int?` | Optional | Maximum number of cards allowed per customer context. |
| `AllowEmptyCvv` | `bool?` | Optional | Allows card flows without providing a CVV. |
| `OnlyDirectCurrency` | `bool?` | Optional | Limits card processing to direct-settlement currencies only. |
| `ThreeDsRequired` | `bool?` | Optional | Requires 3-D Secure for eligible card flows. |
| `ThreeDsAddressRequired` | `bool?` | Optional | Requires billing address data when running 3-D Secure. |
| `ThreeDsSkipEnabled` | `bool?` | Optional | Allows privileged callers to request 3-D Secure skip mode. |
| `AllowDirectTokenCreation` | `bool?` | Optional | Allows direct card token creation without hosted capture flows. |
| `ThreeDsPhoneNumberRequired` | `bool?` | Optional | Requires a phone number when running 3-D Secure. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

MerchantWebhookCardConfiguration merchantWebhookCardConfiguration = new MerchantWebhookCardConfiguration
{
    Enabled = true,
    DebitEnabled = true,
    PrepaidEnabled = false,
    DebitAuthorizationEnabled = false,
    PrepaidAuthorizationEnabled = false,
    ForeignCardsAllowed = false,
    ThreeDsRequired = true,
    AllowDirectTokenCreation = false,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


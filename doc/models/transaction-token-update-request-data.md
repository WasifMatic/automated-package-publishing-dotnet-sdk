
# Transaction Token Update Request Data

Transaction Token Update Request Data schema.

*This model accepts additional fields of type object.*

## Structure

`TransactionTokenUpdateRequestData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Cvv` | `string` | Optional | Update if RECURRING_USAGE_REQUIRES_CVV error occurs. |
| `Cardholder` | `string` | Optional | Cardholder name. |
| `CardNumber` | `string` | Optional | Card number. |
| `ExpMonth` | `int?` | Optional | Card expiration month. |
| `ExpYear` | `int?` | Optional | Card expiration year. |
| `Line1` | `string` | Optional | Primary street address line. |
| `Line2` | `string` | Optional | Secondary street address line. |
| `State` | `string` | Optional | State or prefecture. |
| `City` | `string` | Optional | City or locality. |
| `Country` | `string` | Optional | Country code. |
| `Zip` | `string` | Optional | Postal code. |
| `PhoneNumber` | [`TransactionTokenUpdateRequestDataPhoneNumber`](../../doc/models/transaction-token-update-request-data-phone-number.md) | Optional | Transaction Token Update Request Data Phone Number schema. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

TransactionTokenUpdateRequestData transactionTokenUpdateRequestData = new TransactionTokenUpdateRequestData
{
    Cvv = "123",
    Cardholder = "TARO YAMADA",
    CardNumber = "4242424242424242",
    ExpMonth = 12,
    ExpYear = 2026,
    Line1 = "1-1-1",
    Line2 = "Shibakoen",
    State = "Tokyo",
    City = "Minato",
    Country = "JP",
    Zip = "105-0011",
    PhoneNumber = new TransactionTokenUpdateRequestDataPhoneNumber
    {
        CountryCode = "81",
        LocalNumber = "08012341234",
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


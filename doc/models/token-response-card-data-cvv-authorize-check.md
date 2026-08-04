
# Token Response Card Data Cvv Authorize Check

Token Response Card Data Cvv Authorize Check schema.

*This model accepts additional fields of type object.*

## Structure

`TokenResponseCardDataCvvAuthorizeCheck`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Optional | Current status of the resource. |
| `ChargeId` | `Guid?` | Optional | Charge identifier. |
| `Date` | `DateTime?` | Optional | Date value. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using System.Globalization;
using UnivaPay.Models;
using UnivaPay.Utilities;

TokenResponseCardDataCvvAuthorizeCheck tokenResponseCardDataCvvAuthorizeCheck = new TokenResponseCardDataCvvAuthorizeCheck
{
    Status = "successful",
    ChargeId = null,
    Date = DateTime.ParseExact("2026-04-09T07:35:50Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


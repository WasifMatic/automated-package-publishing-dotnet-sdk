
# Transaction Token Update Request Data Phone Number

Transaction Token Update Request Data Phone Number schema.

*This model accepts additional fields of type object.*

## Structure

`TransactionTokenUpdateRequestDataPhoneNumber`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CountryCode` | `string` | Optional | Telephone country code. |
| `LocalNumber` | `string` | Optional | Local phone number. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

TransactionTokenUpdateRequestDataPhoneNumber transactionTokenUpdateRequestDataPhoneNumber = new TransactionTokenUpdateRequestDataPhoneNumber
{
    CountryCode = "81",
    LocalNumber = "08012341234",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


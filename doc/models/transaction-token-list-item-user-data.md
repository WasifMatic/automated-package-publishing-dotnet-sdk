
# Transaction Token List Item User Data

Transaction Token List Item User Data schema.

*This model accepts additional fields of type object.*

## Structure

`TransactionTokenListItemUserData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CardholderName` | `string` | Optional | Cardholder name value. |
| `Email` | `string` | Optional | Customer email address. |
| `Brand` | `string` | Optional | Brand or network name. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

TransactionTokenListItemUserData transactionTokenListItemUserData = new TransactionTokenListItemUserData
{
    CardholderName = "TARO YAMADA",
    Email = "user@example.com",
    Brand = "visa",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


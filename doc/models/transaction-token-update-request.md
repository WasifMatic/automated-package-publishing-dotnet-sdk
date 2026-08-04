
# Transaction Token Update Request

Request payload for updating a transaction token.

*This model accepts additional fields of type object.*

## Structure

`TransactionTokenUpdateRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Email` | `string` | Optional | Customer email address. |
| `Metadata` | [`GenericMetadata`](../../doc/models/generic-metadata.md) | Optional | A free-form dictionary for custom metadata. |
| `Data` | [`TransactionTokenUpdateRequestData`](../../doc/models/transaction-token-update-request-data.md) | Optional | Transaction Token Update Request Data schema. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Models.Containers;
using UnivaPay.Utilities;

TransactionTokenUpdateRequest transactionTokenUpdateRequest = new TransactionTokenUpdateRequest
{
    Email = "new_email@test.com",
    Metadata = new GenericMetadata
    {
        OrderId = "12345",
        UnivapayName = "univapay-name8",
        UnivapayPhoneNumber = "univapay-phone-number2",
        ["exampleAdditionalProperty"] = GenericMetadataValue.FromString("String4"),
    },
    Data = new TransactionTokenUpdateRequestData
    {
        Cvv = "123",
        Cardholder = "TARO YAMADA",
        CardNumber = "card_number6",
        ExpMonth = 12,
        ExpYear = 2028,
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


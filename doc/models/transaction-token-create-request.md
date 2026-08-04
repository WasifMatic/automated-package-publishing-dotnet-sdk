
# Transaction Token Create Request

*This model accepts additional fields of type object.*

## Structure

`TransactionTokenCreateRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PaymentType` | [`TransactionTokenCreateRequestPaymentType`](../../doc/models/transaction-token-create-request-payment-type.md) | Required | Transaction Token Create Request Payment Type schema. |
| `Type` | [`TransactionTokenCreateRequestType`](../../doc/models/transaction-token-create-request-type.md) | Required | Transaction Token Create Request Type schema. |
| `Email` | `string` | Optional | Customer email address. |
| `UsageLimit` | `string` | Optional | Usage limit applied to the token. |
| `IpAddress` | `string` | Optional | Consumer's IPv4 address. **Required** when `data.brand` is `we_chat_online` and `data.call_method` is `web` or `http_get`. |
| `Metadata` | [`TransactionTokenCreateRequestMetadata`](../../doc/models/transaction-token-create-request-metadata.md) | Optional | A free-form dictionary for custom metadata. |
| `Data` | [`TransactionTokenCreateRequestData`](../../doc/models/containers/transaction-token-create-request-data.md) | Required | Transaction Token Create Request Data schema. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Models.Containers;
using UnivaPay.Utilities;

TransactionTokenCreateRequest transactionTokenCreateRequest = new TransactionTokenCreateRequest
{
    PaymentType = TransactionTokenCreateRequestPaymentType.Card,
    Type = TransactionTokenCreateRequestType.OneTime,
    Data = TransactionTokenCreateRequestData.FromTokenCreateCardData(
        new TokenCreateCardData
        {
            CardNumber = "4242424242424242",
            ExpMonth = "12",
            ExpYear = "2026",
            Cardholder = "cardholder4",
            Cvv = "cvv6",
            Line1 = "line10",
            Line2 = "line22",
            State = "state6",
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        }
    ),
    Email = "user@example.com",
    UsageLimit = "daily",
    IpAddress = "198.51.100.14",
    Metadata = new TransactionTokenCreateRequestMetadata
    {
        UnivapayReferenceId = "ref-998877",
        UnivapayCustomerId = new Guid("0fd29949-07d5-4a91-8eaf-fbce0897d944"),
        UnivapayName = "univapay-name8",
        UnivapayPhoneNumber = "univapay-phone-number2",
        ["exampleAdditionalProperty"] = TransactionTokenCreateMetadataProps.FromString("String8"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


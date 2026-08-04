
# Transaction Token Create Request Metadata

A free-form dictionary for custom metadata.

*This model accepts additional fields of type [TransactionTokenCreateMetadataProps](../../doc/models/containers/transaction-token-create-metadata-props.md).*

## Structure

`TransactionTokenCreateRequestMetadata`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `UnivapayReferenceId` | `string` | Optional | Any arbitrary value (Free format). |
| `UnivapayCustomerId` | `Guid?` | Optional | Customer ID. |
| `UnivapayName` | `string` | Optional | Consumer name passed to payment processors that require it (e.g., konbini, bank transfer). |
| `UnivapayPhoneNumber` | `string` | Optional | Consumer phone number passed to payment processors that require it. |
| `AdditionalProperties` | [`TransactionTokenCreateMetadataProps this[string key]`](../../doc/models/containers/transaction-token-create-metadata-props.md) | Optional | Transaction Token Create Metadata Props schema. |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Models.Containers;

TransactionTokenCreateRequestMetadata transactionTokenCreateRequestMetadata = new TransactionTokenCreateRequestMetadata
{
    UnivapayReferenceId = "ref-998877",
    UnivapayCustomerId = new Guid("0fd29949-07d5-4a91-8eaf-fbce0897d944"),
    UnivapayName = "univapay-name2",
    UnivapayPhoneNumber = "univapay-phone-number6",
    ["exampleAdditionalProperty"] = TransactionTokenCreateMetadataProps.FromString("String8"),
};
```


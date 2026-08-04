
# Generic Metadata

A free-form dictionary for custom metadata.

*This model accepts additional fields of type [GenericMetadataValue](../../doc/models/containers/generic-metadata-value.md).*

## Structure

`GenericMetadata`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `OrderId` | `string` | Optional | Example of a custom metadata key. |
| `UnivapayName` | `string` | Optional | Consumer name passed to payment processors that require it (e.g., konbini, bank transfer). |
| `UnivapayPhoneNumber` | `string` | Optional | Consumer phone number passed to payment processors that require it. |
| `AdditionalProperties` | [`GenericMetadataValue this[string key]`](../../doc/models/containers/generic-metadata-value.md) | Optional | Allowed values for metadata properties. |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Models.Containers;

GenericMetadata genericMetadata = new GenericMetadata
{
    OrderId = "12345",
    UnivapayName = "univapay-name4",
    UnivapayPhoneNumber = "univapay-phone-number8",
    ["exampleAdditionalProperty"] = GenericMetadataValue.FromString("String4"),
};
```


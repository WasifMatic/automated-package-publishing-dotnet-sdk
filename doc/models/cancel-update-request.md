
# Cancel Update Request

Request body for updating a cancel. Only `metadata` is settable by merchants. All fields are optional; omitted fields are left unchanged.

*This model accepts additional fields of type object.*

## Structure

`CancelUpdateRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Metadata` | [`GenericMetadata`](../../doc/models/generic-metadata.md) | Optional | A free-form dictionary for custom metadata. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Models.Containers;
using UnivaPay.Utilities;

CancelUpdateRequest cancelUpdateRequest = new CancelUpdateRequest
{
    Metadata = new GenericMetadata
    {
        OrderId = "12345",
        UnivapayName = "univapay-name8",
        UnivapayPhoneNumber = "univapay-phone-number2",
        ["exampleAdditionalProperty"] = GenericMetadataValue.FromString("String4"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


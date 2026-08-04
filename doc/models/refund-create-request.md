
# Refund Create Request

Request body for creating a refund against a successful charge. Konbini and bank transfer charges cannot be refunded.

*This model accepts additional fields of type object.*

## Structure

`RefundCreateRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Amount` | `int` | Required | Amount to refund in the smallest currency unit. Must be greater than 0 and not exceed the charged amount. Partial refunds are supported for most payment methods. |
| `Currency` | `string` | Required | ISO-4217 currency code. Must exactly match the currency of the original charge. |
| `Reason` | [`RefundReasonRequest?`](../../doc/models/refund-reason-request.md) | Optional | The reason for the refund (merchant-settable values). `duplicate`: A duplicate charge was made. `fraud`: The charge is fraudulent. `customer_request`: The customer requested the refund. |
| `Message` | `string` | Optional | Optional free-text note about the reason for the refund. |
| `Metadata` | [`GenericMetadata`](../../doc/models/generic-metadata.md) | Optional | A free-form dictionary for custom metadata. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

RefundCreateRequest refundCreateRequest = new RefundCreateRequest
{
    Amount = 1000,
    Currency = "JPY",
    Reason = RefundReasonRequest.CustomerRequest,
    Message = "Customer returned item",
    Metadata = null,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


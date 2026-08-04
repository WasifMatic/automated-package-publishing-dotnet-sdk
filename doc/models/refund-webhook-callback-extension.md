
# Refund Webhook Callback Extension

Refund-specific webhook payload extension.

*This model accepts additional fields of type object.*

## Structure

`RefundWebhookCallbackExtension`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`Refund`](../../doc/models/refund.md) | Optional | Represents a refund issued against a charge. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using System.Globalization;
using UnivaPay.Models;
using UnivaPay.Utilities;

RefundWebhookCallbackExtension refundWebhookCallbackExtension = new RefundWebhookCallbackExtension
{
    Data = new Refund
    {
        Id = new Guid("b4d9fea9-c9b3-4e76-a25d-b61f7e4821b6"),
        StoreId = new Guid("76cf4a64-02bc-4cb3-9a28-74622e5928a1"),
        ChargeId = new Guid("6efb4e5c-690a-40f3-a4f1-0e19c5f84e98"),
        Status = RefundStatus.Successful,
        Amount = 1000,
        Currency = "JPY",
        AmountFormatted = 1000,
        Reason = RefundReasonResponse.CustomerRequest,
        Message = "Customer returned item",
        Error = null,
        Metadata = new GenericMetadata
        {
            OrderId = "order_12345",
        },
        Mode = ChargeMode.Live,
        CreatedOn = DateTime.ParseExact("2026-04-09T07:35:50.000000Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        UpdatedOn = DateTime.ParseExact("2026-04-09T07:36:00.000000Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


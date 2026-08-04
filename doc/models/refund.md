
# Refund

Represents a refund issued against a charge.

*This model accepts additional fields of type object.*

## Structure

`Refund`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `Guid?` | Optional | Unique identifier. |
| `StoreId` | `Guid?` | Optional | Store identifier. |
| `ChargeId` | `Guid?` | Optional | Charge identifier. |
| `Status` | [`RefundStatus?`](../../doc/models/refund-status.md) | Optional | Current status of the refund. `pending`: The refund has been created and is being processed. `successful`: The refund was processed successfully. `failed`: The refund was rejected by the gateway. `error`: An unexpected error occurred during processing. |
| `Amount` | `int?` | Optional | Refund amount in the smallest currency unit (e.g., cents for USD, yen for JPY). |
| `Currency` | `string` | Optional | ISO-4217 currency code. Must match the charged currency. |
| `AmountFormatted` | `double?` | Optional | Refund amount formatted for display. |
| `Reason` | [`RefundReasonResponse?`](../../doc/models/refund-reason-response.md) | Optional | Refund reason returned by the API, or `null` when unset. |
| `Message` | `string` | Optional | Optional free-text note about the refund. |
| `Error` | [`PaymentError`](../../doc/models/payment-error.md) | Optional | Payment error details, or null if successful. |
| `Metadata` | [`GenericMetadata`](../../doc/models/generic-metadata.md) | Optional | A free-form dictionary for custom metadata. |
| `Mode` | [`ChargeMode?`](../../doc/models/charge-mode.md) | Optional | Charge Mode schema. |
| `CreatedOn` | `DateTime?` | Optional | Timestamp when the resource was created. |
| `UpdatedOn` | `DateTime?` | Optional | Timestamp when the resource was last updated. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using System.Globalization;
using UnivaPay.Models;
using UnivaPay.Utilities;

Refund refund = new Refund
{
    Id = new Guid("b4d9fea9-c9b3-4e76-a25d-b61f7e4821b6"),
    StoreId = new Guid("76cf4a64-02bc-4cb3-9a28-74622e5928a1"),
    ChargeId = new Guid("6efb4e5c-690a-40f3-a4f1-0e19c5f84e98"),
    Status = RefundStatus.Pending,
    Amount = 1000,
    Currency = "JPY",
    AmountFormatted = 1000,
    Reason = RefundReasonResponse.CustomerRequest,
    Message = "Customer returned item",
    Error = new PaymentError
    {
        Code = 301,
        Message = "Card number error.",
        Detail = "The provided card number failed validation.",
    },
    Metadata = new GenericMetadata
    {
        OrderId = "12345",
    },
    Mode = ChargeMode.Live,
    CreatedOn = DateTime.ParseExact("2026-04-09T07:35:50Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    UpdatedOn = DateTime.ParseExact("2026-04-09T07:36:00Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


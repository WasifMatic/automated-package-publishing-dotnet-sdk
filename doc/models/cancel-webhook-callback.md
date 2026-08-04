
# Cancel Webhook Callback

Webhook envelope whose `data` payload is a Cancel resource.

*This model accepts additional fields of type object.*

## Structure

`CancelWebhookCallback`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Event` | [`CancelEvent?`](../../doc/models/cancel-event.md) | Optional | Event type discriminator — always `cancel_finished` for this callback. |
| `Id` | `Guid` | Required | Unique ID of this webhook delivery. |
| `CreatedOn` | `DateTime` | Required | Timestamp when the event was fired. |
| `Data` | [`Cancel`](../../doc/models/cancel.md) | Optional | Represents a cancellation request for a charge. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using System.Globalization;
using UnivaPay.Models;
using UnivaPay.Utilities;

CancelWebhookCallback cancelWebhookCallback = new CancelWebhookCallback
{
    Id = new Guid("11ef0000-0000-4000-8000-000000000001"),
    CreatedOn = DateTime.ParseExact("2026-04-09T07:35:50.000000Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    MEvent = CancelEvent.CancelFinished,
    Data = new Cancel
    {
        Id = new Guid("a1b2c3d4-e5f6-7890-abcd-ef1234567890"),
        ChargeId = new Guid("6efb4e5c-690a-40f3-a4f1-0e19c5f84e98"),
        StoreId = new Guid("76cf4a64-02bc-4cb3-9a28-74622e5928a1"),
        Status = CancelStatus.Successful,
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


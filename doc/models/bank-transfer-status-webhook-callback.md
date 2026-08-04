
# Bank Transfer Status Webhook Callback

Webhook envelope whose `data` payload is a BankTransferStatusData resource.

*This model accepts additional fields of type object.*

## Structure

`BankTransferStatusWebhookCallback`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Event` | [`BankTransferEvent?`](../../doc/models/bank-transfer-event.md) | Optional | Event type discriminator — always `bank_transfer_status_updated` for this callback. |
| `Id` | `Guid` | Required | Unique ID of this webhook delivery. |
| `CreatedOn` | `DateTime` | Required | Timestamp when the event was fired. |
| `Data` | [`BankTransferStatusData`](../../doc/models/bank-transfer-status-data.md) | Optional | Data payload for `bank_transfer_status_updated` webhook events. Contains the bank transfer extension fields inlined alongside amount and metadata. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using System.Globalization;
using UnivaPay.Models;
using UnivaPay.Utilities;

BankTransferStatusWebhookCallback bankTransferStatusWebhookCallback = new BankTransferStatusWebhookCallback
{
    Id = new Guid("11ef0000-0000-4000-8000-000000000001"),
    CreatedOn = DateTime.ParseExact("2026-04-09T07:35:50.000000Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    MEvent = BankTransferEvent.BankTransferStatusUpdated,
    Data = new BankTransferStatusData
    {
        Id = new Guid("11ef0000-0000-4000-8000-000000000002"),
        ChargeId = new Guid("11ef0000-0000-4000-8000-000000000001"),
        PaymentStatus = BankTransferPaymentStatus.Exact,
        LatestDepositDate = DateTime.ParseExact("2026-04-09T07:35:50.000000Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        CreatedOn = DateTime.ParseExact("2026-04-09T07:35:50.000000Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        LatestDepositAmount = 1000,
        Balance = 0,
        Currency = "JPY",
        Amount = 1000,
        AmountDifference = 0,
        TokenMetadata = new GenericMetadata
        {
            OrderId = "12345",
        },
        ChargeMetadata = new GenericMetadata
        {
            OrderId = "order_12345",
        },
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


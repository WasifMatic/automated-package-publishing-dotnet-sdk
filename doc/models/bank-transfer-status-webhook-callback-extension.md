
# Bank Transfer Status Webhook Callback Extension

Bank-transfer-specific webhook payload extension.

*This model accepts additional fields of type object.*

## Structure

`BankTransferStatusWebhookCallbackExtension`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`BankTransferStatusData`](../../doc/models/bank-transfer-status-data.md) | Optional | Data payload for `bank_transfer_status_updated` webhook events. Contains the bank transfer extension fields inlined alongside amount and metadata. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using System.Globalization;
using UnivaPay.Models;
using UnivaPay.Utilities;

BankTransferStatusWebhookCallbackExtension bankTransferStatusWebhookCallbackExtension = new BankTransferStatusWebhookCallbackExtension
{
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


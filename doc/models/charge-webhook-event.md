
# Charge Webhook Event

Webhook envelope for charge lifecycle events. Fired as `charge_updated` whenever a charge transitions to a new status (e.g., `pending` → `awaiting`), and as `charge_finished` when a charge reaches a terminal status (`successful`, `failed`, `error`). The `data` field contains the full Charge object at the time of the event.

*This model accepts additional fields of type object.*

## Structure

`ChargeWebhookEvent`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `Guid` | Required | Unique ID of this webhook delivery. |
| `Event` | [`ChargeEvent`](../../doc/models/charge-event.md) | Required | Event type discriminator — `charge_updated` or `charge_finished`. |
| `Data` | [`Charge`](../../doc/models/charge.md) | Optional | Charge resource returned by the payments API. |
| `CreatedOn` | `DateTime` | Required | Timestamp when the event was fired. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using System.Globalization;
using UnivaPay.Models;
using UnivaPay.Utilities;

ChargeWebhookEvent chargeWebhookEvent = new ChargeWebhookEvent
{
    Id = new Guid("11ef0000-0000-4000-8000-000000000001"),
    MEvent = ChargeEvent.ChargeUpdated,
    CreatedOn = DateTime.ParseExact("2026-04-09T07:35:50.000000Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    Data = new Charge
    {
        Id = new Guid("6efb4e5c-690a-40f3-a4f1-0e19c5f84e98"),
        StoreId = new Guid("11edf541-c42d-653c-8c3d-dfe0a55f95c0"),
        TransactionTokenId = new Guid("11ef32a7-3a71-8662-803f-1bc27702eeec"),
        TransactionTokenType = ChargeTransactionTokenType.Recurring,
        SubscriptionId = new Guid("11ef335e-9aa5-c54a-8313-7f9847da313a"),
        RequestedAmount = 1250,
        RequestedCurrency = "USD",
        RequestedAmountFormatted = 12.5,
        ChargedAmount = 1250,
        ChargedCurrency = "USD",
        ChargedAmountFormatted = 12.5,
        OnlyDirectCurrency = false,
        Status = ChargeStatus.Successful,
        Error = null,
        Mode = ChargeMode.Test,
        CreatedOn = DateTime.ParseExact("2024-06-26T01:51:30.000000Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


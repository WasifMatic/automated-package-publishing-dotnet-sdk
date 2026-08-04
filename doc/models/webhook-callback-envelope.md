
# Webhook Callback Envelope

Common wrapper POSTed to your webhook URL for every event. The `data` field contains the domain object relevant to the event type.

*This model accepts additional fields of type object.*

## Structure

`WebhookCallbackEnvelope`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `Guid` | Required | Unique ID of this webhook delivery. |
| `Event` | [`WebhookTrigger`](../../doc/models/webhook-trigger.md) | Required | Event type that triggers a webhook notification. |
| `CreatedOn` | `DateTime` | Required | Timestamp when the event was fired. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using System.Globalization;
using UnivaPay.Models;
using UnivaPay.Utilities;

WebhookCallbackEnvelope webhookCallbackEnvelope = new WebhookCallbackEnvelope
{
    Id = new Guid("11ef0000-0000-4000-8000-000000000001"),
    MEvent = WebhookTrigger.ChargeFinished,
    CreatedOn = DateTime.ParseExact("2026-04-09T07:35:50.000000Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    ["data"] = ApiHelper.JsonDeserialize<object>("{\"id\":\"6efb4e5c-690a-40f3-a4f1-0e19c5f84e98\",\"created_on\":\"2024-06-26T01:51:30.000000Z\"}"),
};
```



# Webhook

Represents a webhook subscription. Webhooks send event notifications to a specified URL when triggered by payment events.

*This model accepts additional fields of type object.*

## Structure

`Webhook`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `Guid?` | Optional | Unique identifier for the webhook. |
| `StoreId` | `Guid?` | Optional | ID of the store this webhook belongs to (null for merchant-level webhooks). |
| `MerchantId` | `Guid?` | Optional | ID of the merchant this webhook belongs to. |
| `Triggers` | [`List<WebhookTrigger>`](../../doc/models/webhook-trigger.md) | Optional | List of event types that trigger this webhook. |
| `Url` | `string` | Optional | The endpoint URL that receives webhook POST requests. |
| `AuthToken` | `string` | Optional | Optional bearer token included in the `Authorization` header of webhook requests. Used to authenticate the webhook receiver. |
| `Active` | `bool?` | Optional | Whether this webhook is currently active and receiving events. |
| `IsIntegration` | `bool?` | Optional | Admin-only flag. Indicates this webhook is used for platform integration purposes. Not settable by merchants. |
| `CreatedOn` | `DateTime?` | Optional | Timestamp when the webhook was created. |
| `UpdatedOn` | `DateTime?` | Optional | Timestamp when the webhook was last updated. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using System.Collections.Generic;
using System.Globalization;
using UnivaPay.Models;
using UnivaPay.Utilities;

Webhook webhook = new Webhook
{
    Id = new Guid("d3e4f5a6-b7c8-9012-def0-123456789abc"),
    StoreId = new Guid("76cf4a64-02bc-4cb3-9a28-74622e5928a1"),
    MerchantId = new Guid("01234567-89ab-cdef-0123-456789abcdef"),
    Triggers = new List<WebhookTrigger>
    {
        WebhookTrigger.ChargeFinished,
        WebhookTrigger.RefundFinished,
    },
    Url = "https://example.com/webhooks/payments",
    AuthToken = "my-secret-token",
    Active = true,
    IsIntegration = false,
    CreatedOn = DateTime.ParseExact("2026-04-01T00:00:00.000000Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    UpdatedOn = DateTime.ParseExact("2026-04-02T00:00:00.000000Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```



# Webhook List

Paginated list of webhooks.

*This model accepts additional fields of type object.*

## Structure

`WebhookList`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Items` | [`List<Webhook>`](../../doc/models/webhook.md) | Optional | List of resources. |
| `HasMore` | `bool?` | Optional | Whether more results are available. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using System.Collections.Generic;
using System.Globalization;
using UnivaPay.Models;
using UnivaPay.Utilities;

WebhookList webhookList = new WebhookList
{
    Items = new List<Webhook>
    {
        new Webhook
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
        },
        new Webhook
        {
            Id = new Guid("e4f5a6b7-c8d9-0123-ef01-23456789abcd"),
            StoreId = new Guid("76cf4a64-02bc-4cb3-9a28-74622e5928a1"),
            MerchantId = new Guid("01234567-89ab-cdef-0123-456789abcdef"),
            Triggers = new List<WebhookTrigger>
            {
                WebhookTrigger.SubscriptionPayment,
                WebhookTrigger.SubscriptionFailure,
            },
            Url = "https://example.com/webhooks/subscriptions",
            AuthToken = null,
            Active = true,
            IsIntegration = false,
            CreatedOn = DateTime.ParseExact("2026-04-03T08:30:00.000000Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            UpdatedOn = DateTime.ParseExact("2026-04-03T08:30:00.000000Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
    },
    HasMore = false,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


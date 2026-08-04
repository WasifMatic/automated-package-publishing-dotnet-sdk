
# Webhook Event List

Paginated list of webhook events.

*This model accepts additional fields of type object.*

## Structure

`WebhookEventList`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Items` | [`List<WebhookEvent>`](../../doc/models/webhook-event.md) | Optional | List of resources. |
| `HasMore` | `bool?` | Optional | Whether more results are available. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using System.Collections.Generic;
using System.Globalization;
using UnivaPay.Models;
using UnivaPay.Utilities;

WebhookEventList webhookEventList = new WebhookEventList
{
    Items = new List<WebhookEvent>
    {
        new WebhookEvent
        {
            Id = new Guid("e1f2a3b4-c5d6-7890-efab-123456789cde"),
            WebhookId = new Guid("d3e4f5a6-b7c8-9012-def0-123456789abc"),
            MEvent = WebhookTrigger.ChargeFinished,
            Data = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
            Successful = true,
            FiredOn = DateTime.ParseExact("2026-04-09T07:36:00.000000Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            ErrorMessage = null,
            CreatedOn = DateTime.ParseExact("2026-04-09T07:35:50.000000Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
        new WebhookEvent
        {
            Id = new Guid("f2a3b4c5-d6e7-8901-fabc-23456789cdef"),
            WebhookId = new Guid("d3e4f5a6-b7c8-9012-def0-123456789abc"),
            MEvent = WebhookTrigger.RefundFinished,
            Data = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
            Successful = true,
            FiredOn = DateTime.ParseExact("2026-04-10T11:00:05.000000Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            ErrorMessage = null,
            CreatedOn = DateTime.ParseExact("2026-04-10T11:00:00.000000Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
    },
    HasMore = false,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


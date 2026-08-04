
# Webhook Create Request

Request body to create a new store-level webhook subscription.

*This model accepts additional fields of type object.*

## Structure

`WebhookCreateRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Triggers` | [`List<WebhookTrigger>`](../../doc/models/webhook-trigger.md) | Required | List of event types that trigger this webhook. Must be non-empty and contain only events valid for the store level. |
| `Url` | `string` | Required | The URL to POST webhook payloads to. |
| `AuthToken` | `string` | Optional | Optional bearer token sent in the `Authorization` header of webhook requests. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using System.Collections.Generic;
using UnivaPay.Models;
using UnivaPay.Utilities;

WebhookCreateRequest webhookCreateRequest = new WebhookCreateRequest
{
    Triggers = new List<WebhookTrigger>
    {
        WebhookTrigger.ChargeFinished,
    },
    Url = "https://example.com/webhooks/payments",
    AuthToken = "my-secret-token",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


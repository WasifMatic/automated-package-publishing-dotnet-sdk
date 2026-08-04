
# Webhook Update Request

Request body for updating a webhook. All fields are optional. Omitted fields are left unchanged.

*This model accepts additional fields of type object.*

## Structure

`WebhookUpdateRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Triggers` | [`List<WebhookTrigger>`](../../doc/models/webhook-trigger.md) | Optional | Replace the trigger list. Must be non-empty if provided. |
| `Url` | `string` | Optional | Update the webhook endpoint URL. |
| `AuthToken` | `string` | Optional | Update or clear the auth token. Send `null` to remove. |
| `Active` | `bool?` | Optional | Enable or disable the webhook. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using System.Collections.Generic;
using UnivaPay.Models;
using UnivaPay.Utilities;

WebhookUpdateRequest webhookUpdateRequest = new WebhookUpdateRequest
{
    Triggers = new List<WebhookTrigger>
    {
        WebhookTrigger.SubscriptionCreated,
        WebhookTrigger.BankTransferStatusUpdated,
    },
    Url = "url6",
    AuthToken = "auth_token8",
    Active = false,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


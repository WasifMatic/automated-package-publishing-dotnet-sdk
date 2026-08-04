
# Customs Declaration Webhook Other Error

Nested customs-processing error entry returned in `others`.

*This model accepts additional fields of type object.*

## Structure

`CustomsDeclarationWebhookOtherError`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Optional | Backend other-error type. |
| `CredentialsId` | `Guid?` | Optional | Gateway credentials involved in the error when applicable. |
| `Message` | `List<string>` | Optional | Additional reason values for `not_selected_reasons`. |
| `ItemName` | `string` | Optional | Related item name for `related_item`. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using System.Collections.Generic;
using UnivaPay.Models;
using UnivaPay.Utilities;

CustomsDeclarationWebhookOtherError customsDeclarationWebhookOtherError = new CustomsDeclarationWebhookOtherError
{
    Type = "related_item",
    CredentialsId = new Guid("00000b8c-0000-0000-0000-000000000000"),
    Message = new List<string>
    {
        "message4",
        "message3",
    },
    ItemName = "charge",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


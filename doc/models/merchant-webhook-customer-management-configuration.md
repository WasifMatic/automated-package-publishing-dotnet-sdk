
# Merchant Webhook Customer Management Configuration

Customer-management defaults.

*This model accepts additional fields of type object.*

## Structure

`MerchantWebhookCustomerManagementConfiguration`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Enabled` | `bool?` | Optional | Enables customer-management features. |
| `DefaultRoles` | `List<string>` | Optional | Roles applied to newly created customers. |
| `DefaultMode` | `string` | Optional | Default processing mode assigned to new customer records. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using System.Collections.Generic;
using UnivaPay.Models;
using UnivaPay.Utilities;

MerchantWebhookCustomerManagementConfiguration merchantWebhookCustomerManagementConfiguration = new MerchantWebhookCustomerManagementConfiguration
{
    Enabled = true,
    DefaultRoles = new List<string>
    {
        "end_user",
    },
    DefaultMode = "live",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```



# Merchant Webhook Subscription Configuration

Subscription feature configuration.

*This model accepts additional fields of type object.*

## Structure

`MerchantWebhookSubscriptionConfiguration`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Enabled` | `bool?` | Optional | Enables subscription payments. |
| `FailedChargesToCancel` | `int?` | Optional | Number of failed charges allowed before cancellation. |
| `SuspendOnCancel` | `bool?` | Optional | Suspends the subscription when its latest charge is canceled. |
| `AllowMerchantAmountPatch` | `bool?` | Optional | Allows merchants to update scheduled subscription amounts. |
| `AllowMerchantDueDatePatch` | `bool?` | Optional | Allows merchants to update scheduled subscription due dates. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

MerchantWebhookSubscriptionConfiguration merchantWebhookSubscriptionConfiguration = new MerchantWebhookSubscriptionConfiguration
{
    Enabled = true,
    FailedChargesToCancel = 3,
    SuspendOnCancel = true,
    AllowMerchantAmountPatch = false,
    AllowMerchantDueDatePatch = false,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


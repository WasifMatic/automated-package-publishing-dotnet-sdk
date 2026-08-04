
# Subscription Patch Payment Request

Request body for updating a scheduled payment. All fields are optional. Omitted fields are left unchanged.

*This model accepts additional fields of type object.*

## Structure

`SubscriptionPatchPaymentRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DueDate` | `DateTime?` | Optional | New due date for this payment (YYYY-MM-DD).  Only available to merchants with permission to edit payment dates. |
| `IsPaid` | `bool?` | Optional | Mark this payment as paid. Setting to `true` will trigger scheduling  of the next payment in the cycle. |
| `TerminateWithStatus` | [`SubscriptionTerminateWithStatus?`](../../doc/models/subscription-terminate-with-status.md) | Optional | Schedule a status transition on a payment's due date. Set to `suspended` or `canceled` to schedule termination. Send `null` to cancel a previously scheduled transition. |
| `RetryInterval` | `string` | Optional | ISO-8601 Duration override for the retry interval on a scheduled payment (for example `P3D`). Send `null` to clear. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

SubscriptionPatchPaymentRequest subscriptionPatchPaymentRequest = new SubscriptionPatchPaymentRequest
{
    DueDate = DateTime.Parse("2026-09-01"),
    IsPaid = false,
    TerminateWithStatus = null,
    RetryInterval = "P3D",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```



# Subscription Patch Token Request

Request body for updating the payment method (transaction token) of a subscription. The new token must belong to the same store, be active, and match the subscription's mode.

*This model accepts additional fields of type object.*

## Structure

`SubscriptionPatchTokenRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TransactionTokenId` | `Guid` | Required | The ID of the new transaction token to use for future subscription payments. Must be a recurring or subscription-type token for the same store. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

SubscriptionPatchTokenRequest subscriptionPatchTokenRequest = new SubscriptionPatchTokenRequest
{
    TransactionTokenId = new Guid("11ef3362-3700-c54a-9baa-6f7e6527c9d9"),
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


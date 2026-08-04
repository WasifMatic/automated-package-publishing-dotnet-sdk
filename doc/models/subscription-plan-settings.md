
# Subscription Plan Settings

Configuration for limited-cycle subscriptions (Univapay side).

*This model accepts additional fields of type object.*

## Structure

`SubscriptionPlanSettings`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PlanType` | [`PlanSettingsType?`](../../doc/models/plan-settings-type.md) | Optional | Plan type selector. |
| `FixedCycles` | `int?` | Optional | Number of cycles for fixed_cycles plan. |
| `FixedCycleAmount` | `int?` | Optional | Total target amount for fixed_cycle_amount plan. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

SubscriptionPlanSettings subscriptionPlanSettings = new SubscriptionPlanSettings
{
    PlanType = PlanSettingsType.FixedCycles,
    FixedCycles = 240,
    FixedCycleAmount = 50,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


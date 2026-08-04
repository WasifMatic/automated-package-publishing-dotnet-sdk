
# Subscription Installment Plan

Configuration for credit card company side installments.

*This model accepts additional fields of type object.*

## Structure

`SubscriptionInstallmentPlan`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PlanType` | [`InstallmentPlanType?`](../../doc/models/installment-plan-type.md) | Optional | Plan type selector. |
| `FixedCycles` | [`InstallmentFixedCycles?`](../../doc/models/installment-fixed-cycles.md) | Optional | Required if plan_type is fixed_cycles. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

SubscriptionInstallmentPlan subscriptionInstallmentPlan = new SubscriptionInstallmentPlan
{
    PlanType = InstallmentPlanType.Revolving,
    FixedCycles = InstallmentFixedCycles.Cycles3,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```



# Subscription Create Request

Request payload for creating a subscription.

*This model accepts additional fields of type object.*

## Structure

`SubscriptionCreateRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TransactionTokenId` | `Guid` | Required | Transaction token ID authorized for recurring payments. |
| `Amount` | `int` | Required | Amount to be charged in each cycle. |
| `Currency` | `string` | Required | ISO-4217 currency code. |
| `InitialAmount` | `int?` | Optional | Optional different amount for the first charge. |
| `Period` | [`SubscriptionPeriod?`](../../doc/models/subscription-period.md) | Optional | Subscription Period schema. |
| `CyclicalPeriod` | `string` | Optional | ISO-8601 Duration for custom frequency (e.g., P3D, P2M).  Cannot be used if 'period' is specified. |
| `ScheduleSettings` | [`SubscriptionScheduleSettings`](../../doc/models/subscription-schedule-settings.md) | Optional | Schedule settings applied to a subscription. |
| `InstallmentPlan` | [`SubscriptionInstallmentPlan`](../../doc/models/subscription-installment-plan.md) | Optional | Configuration for credit card company side installments. |
| `SubscriptionPlan` | [`SubscriptionPlanSettings`](../../doc/models/subscription-plan-settings.md) | Optional | Configuration for limited-cycle subscriptions (Univapay side). |
| `FirstChargeAuthorizationOnly` | `bool?` | Optional | If true, the first charge will only be an authorization (Hold).<br><br>**Default**: `false` |
| `FirstChargeCaptureAfter` | `string` | Optional | ISO-8601 Duration for auto-capture if authorization only is true.  Allowed days: P1D to P6D. |
| `Metadata` | [`GenericMetadata`](../../doc/models/generic-metadata.md) | Optional | A free-form dictionary for custom metadata. |
| `ThreeDs` | [`ChargeCreateRequestThreeDs`](../../doc/models/charge-create-request-three-ds.md) | Optional | Charge Create Request Three Ds schema. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

SubscriptionCreateRequest subscriptionCreateRequest = new SubscriptionCreateRequest
{
    TransactionTokenId = new Guid("11ef32a7-3a71-8662-803f-1bc27702eeec"),
    Amount = 1250,
    Currency = "USD",
    InitialAmount = 194,
    Period = SubscriptionPeriod.Monthly,
    CyclicalPeriod = "cyclical_period4",
    ScheduleSettings = null,
    InstallmentPlan = null,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


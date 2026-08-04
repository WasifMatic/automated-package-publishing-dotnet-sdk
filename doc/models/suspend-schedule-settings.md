
# Suspend Schedule Settings

Schedule-related settings.

*This model accepts additional fields of type object.*

## Structure

`SuspendScheduleSettings`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TerminationMode` | [`SubscriptionTerminationMode?`](../../doc/models/subscription-termination-mode.md) | Optional | Subscription Termination Mode schema.<br><br>**Default**: `SubscriptionTerminationMode.immediate` |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

SuspendScheduleSettings suspendScheduleSettings = new SuspendScheduleSettings
{
    TerminationMode = SubscriptionTerminationMode.Immediate,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


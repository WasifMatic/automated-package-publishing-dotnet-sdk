
# Card Processor Installment Config

Card-processor capabilities available for installment payments.

*This model accepts additional fields of type object.*

## Structure

`CardProcessorInstallmentConfig`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Revolving` | `bool?` | Optional | Allows revolving payments through supported processors. |
| `FixedCycle` | `bool?` | Optional | Allows fixed-cycle installment payments through supported processors. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

CardProcessorInstallmentConfig cardProcessorInstallmentConfig = new CardProcessorInstallmentConfig
{
    Revolving = true,
    FixedCycle = true,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```



# Charge Create Request Three Ds Mode

3D-Secure authentication type. App Token Secret is required to use 'skip'.

## Enumeration

`ChargeCreateRequestThreeDsMode`

## Fields

| Name |
|  --- |
| `Normal` |
| `Require` |
| `Force` |
| `Skip` |

## Example

```csharp
using UnivaPay.Models;

ChargeCreateRequestThreeDsMode chargeCreateRequestThreeDsMode = ChargeCreateRequestThreeDsMode.Force;
```


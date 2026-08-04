
# Bank Transfer Event

Event type discriminator — always `bank_transfer_status_updated` for this callback.

## Enumeration

`BankTransferEvent`

## Fields

| Name |
|  --- |
| `BankTransferStatusUpdated` |

## Example

```csharp
using UnivaPay.Models;

BankTransferEvent bankTransferEvent = BankTransferEvent.BankTransferStatusUpdated;
```


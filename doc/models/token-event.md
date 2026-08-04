
# Token Event

Event type discriminator — `token_created`, `token_updated`, `token_three_d_s_updated`, `token_cvv_auth_updated`, `token_cvv_auth_check_updated`, `token_replaced`, or `recurring_token_deleted`.

## Enumeration

`TokenEvent`

## Fields

| Name |
|  --- |
| `TokenCreated` |
| `TokenUpdated` |
| `TokenThreeDSUpdated` |
| `TokenCvvAuthUpdated` |
| `TokenCvvAuthCheckUpdated` |
| `TokenReplaced` |
| `RecurringTokenDeleted` |

## Example

```csharp
using UnivaPay.Models;

TokenEvent tokenEvent = TokenEvent.TokenThreeDSUpdated;
```



# Refund Reason Request

The reason for the refund (merchant-settable values). `duplicate`: A duplicate charge was made. `fraud`: The charge is fraudulent. `customer_request`: The customer requested the refund.

## Enumeration

`RefundReasonRequest`

## Fields

| Name |
|  --- |
| `Duplicate` |
| `Fraud` |
| `CustomerRequest` |

## Example

```csharp
using UnivaPay.Models;

RefundReasonRequest refundReasonRequest = RefundReasonRequest.CustomerRequest;
```


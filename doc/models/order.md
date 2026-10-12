
# Order

## Structure

`Order`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `long?` | Optional | - |
| `PetId` | `long?` | Optional | - |
| `Quantity` | `int?` | Optional | - |
| `ShipDate` | `DateTime?` | Optional | - |
| `Status` | [`OrderStatusEnum?`](../../doc/models/order-status-enum.md) | Optional | Order Status |
| `Complete` | `bool?` | Optional | - |

## Example

```csharp
using SwaggerPetstoreOpenAPI310.Standard.Models;
using System.Globalization;

Order order = new Order
{
    Id = 144L,
    PetId = 184L,
    Quantity = 100,
    ShipDate = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    Status = OrderStatusEnum.Placed,
};
```


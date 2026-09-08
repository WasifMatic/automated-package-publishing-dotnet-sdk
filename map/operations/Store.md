<!-- Generated file — do not edit; regenerated with the SDK. -->

# Store — operations

Accessor: `client.Store` · Source: `Api/Store.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteOrder

- **Signature**: `DeleteOrder(long orderId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteOrderError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteOrderError` | `Errors/DeleteOrderError.cs` |

### GetInventory

- **Auth**: `options.ApiKey`
- **Signature**: `GetInventory(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IReadOnlyDictionary<string, int>`
- **Error**: `SdkException<RawError>` — **Case B**

### GetOrderById

- **Signature**: `GetOrderById(long orderId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Order`
- **Error**: `SdkException<GetOrderByIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Order` | `Models/Order.cs` |
| `GetOrderByIdError` | `Errors/GetOrderByIdError.cs` |

### PlaceOrder

- **Signature**: `PlaceOrder(long? id, long? petId, int? quantity, DateTimeOffset? shipDate, OrderStatus? status, bool? complete, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 6 params (`id` … `complete`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Returns**: `Order`
- **Error**: `SdkException<PlaceOrderError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `OrderStatus` | `Models/Enums/OrderStatus.cs` |
| `Order` | `Models/Order.cs` |
| `PlaceOrderError` | `Errors/PlaceOrderError.cs` |


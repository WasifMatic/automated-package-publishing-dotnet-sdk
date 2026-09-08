<!-- Generated file — do not edit; regenerated with the SDK. -->

# UserApi — operations

Accessor: `client.UserApi` · Source: `Api/UserApi.cs` · 7 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateUser

- **Signature**: `CreateUser(long? id, string? username, string? firstName, string? lastName, string? email, string? password, string? phone, int? userStatus, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 8 params (`id` … `userStatus`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Returns**: `User`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `User` | `Models/User.cs` |

### CreateUsersWithListInput

- **Signature**: `CreateUsersWithListInput(IReadOnlyList<User>? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `User`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `User` | `Models/User.cs` |

### DeleteUser

- **Signature**: `DeleteUser(string usersname, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteUserError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteUserError` | `Errors/DeleteUserError.cs` |

### GetUserByName

- **Signature**: `GetUserByName(string usersname, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `User`
- **Error**: `SdkException<GetUserByNameError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `User` | `Models/User.cs` |
| `GetUserByNameError` | `Errors/GetUserByNameError.cs` |

### LoginUser

- **Signature**: `LoginUser(string? username, string? password, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `username` — nullable, no default → **must pass explicitly**
  - `password` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `username` ← `username`, `password` ← `password`
- **Returns**: `void` (Task)
- **Error**: `SdkException<LoginUserError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `LoginUserError` | `Errors/LoginUserError.cs` |

### LogoutUser

- **Signature**: `LogoutUser(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RawError>` — **Case B**

### UpdateUser

- **Signature**: `UpdateUser(string usersname, long? id, string? username, string? firstName, string? lastName, string? email, string? password, string? phone, int? userStatus, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 8 params (`id` … `userStatus`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Returns**: `void` (Task)
- **Error**: `SdkException<UpdateUserError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateUserError` | `Errors/UpdateUserError.cs` |


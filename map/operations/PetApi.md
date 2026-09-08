<!-- Generated file — do not edit; regenerated with the SDK. -->

# PetApi — operations

Accessor: `client.PetApi` · Source: `Api/PetApi.cs` · 8 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AddPet

- **Auth**: `options.PetstoreAuth`
- **Signature**: `AddPet(string name, IReadOnlyList<string> photoUrls, long? id, Category? category, IReadOnlyList<Tag>? tags, PetStatus? status, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`id` … `status`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Returns**: `Pet`
- **Error**: `SdkException<AddPetError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Category` | `Models/Category.cs` |
| `Tag` | `Models/Tag.cs` |
| `PetStatus` | `Models/Enums/PetStatus.cs` |
| `Pet` | `Models/Pet.cs` |
| `AddPetError` | `Errors/AddPetError.cs` |

### DeletePet

- **Auth**: `options.PetstoreAuth`
- **Signature**: `DeletePet(long petId, string? apiKey, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `apiKey` — nullable, no default → **must pass explicitly**
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeletePetError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeletePetError` | `Errors/DeletePetError.cs` |

### FindPetsByStatus

- **Auth**: `options.PetstoreAuth`
- **Signature**: `FindPetsByStatus(PetStatus? status, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `status` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `status` ← `status`
- **Returns**: `IReadOnlyList<Pet>`
- **Error**: `SdkException<FindPetsByStatusError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PetStatus` | `Models/Enums/PetStatus.cs` |
| `Pet` | `Models/Pet.cs` |
| `FindPetsByStatusError` | `Errors/FindPetsByStatusError.cs` |

### FindPetsByTags

- **Auth**: `options.PetstoreAuth`
- **Signature**: `FindPetsByTags(IReadOnlyList<string>? tags, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `tags` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `tags` ← `tags`
- **Returns**: `IReadOnlyList<Pet>`
- **Error**: `SdkException<FindPetsByTagsError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Pet` | `Models/Pet.cs` |
| `FindPetsByTagsError` | `Errors/FindPetsByTagsError.cs` |

### GetPetById

- **Auth**: `options.ApiKey` OR `options.PetstoreAuth`
- **Signature**: `GetPetById(long petId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Pet`
- **Error**: `SdkException<GetPetByIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Pet` | `Models/Pet.cs` |
| `GetPetByIdError` | `Errors/GetPetByIdError.cs` |

### UpdatePet

- **Auth**: `options.PetstoreAuth`
- **Signature**: `UpdatePet(string name, IReadOnlyList<string> photoUrls, long? id, Category? category, IReadOnlyList<Tag>? tags, PetStatus? status, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`id` … `status`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Returns**: `Pet`
- **Error**: `SdkException<UpdatePetError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 404, 422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Category` | `Models/Category.cs` |
| `Tag` | `Models/Tag.cs` |
| `PetStatus` | `Models/Enums/PetStatus.cs` |
| `Pet` | `Models/Pet.cs` |
| `UpdatePetError` | `Errors/UpdatePetError.cs` |

### UpdatePetWithForm

- **Auth**: `options.PetstoreAuth`
- **Signature**: `UpdatePetWithForm(long petId, string? name, string? status, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `name` — nullable, no default → **must pass explicitly**
  - `status` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `name` ← `name`, `status` ← `status`
- **Returns**: `Pet`
- **Error**: `SdkException<UpdatePetWithFormError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Pet` | `Models/Pet.cs` |
| `UpdatePetWithFormError` | `Errors/UpdatePetWithFormError.cs` |

### UploadFile

- **Auth**: `options.PetstoreAuth`
- **Signature**: `UploadFile(long petId, string? additionalMetadata, BinaryContent? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `additionalMetadata` — nullable, no default → **must pass explicitly**
  - `body` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `additionalMetadata` ← `additionalMetadata`
- **Returns**: `ApiResponseModel`
- **Error**: `SdkException<UploadFileError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ApiResponseModel` | `Models/ApiResponseModel.cs` |
| `UploadFileError` | `Errors/UploadFileError.cs` |


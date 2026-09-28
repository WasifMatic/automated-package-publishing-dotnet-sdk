<!-- Generated file — do not edit; regenerated with the SDK. -->

# PortalArtifactsGenerationAsync — operations

Accessor: `client.PortalArtifactsGenerationAsync` · Source: `Api/PortalArtifactsGenerationAsync.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DownloadGeneratedPortalArtifacts

- **Auth**: `options.Authorization`
- **Signature**: `DownloadGeneratedPortalArtifacts(DownloadGeneratedPortalArtifactsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `void` (Task)
- **Error**: `ApiException<DownloadGeneratedPortalArtifactsError>` — **Case A (typed)**
- **Error accessors**: `TryGetProblemDetails(out ProblemDetails)` [400] · `TryGetUnauthorizedResponse(out UnauthorizedResponse)` [401] · `TryGetInternalServerErrorResponse(out InternalServerErrorResponse)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DownloadGeneratedPortalArtifactsRequest` | `Requests/PortalArtifactsGenerationAsync/DownloadGeneratedPortalArtifactsRequest.cs` |
| `DownloadGeneratedPortalArtifactsError` | `Errors/DownloadGeneratedPortalArtifactsError.cs` |
| `ProblemDetails` | `Models/ProblemDetails.cs` |
| `UnauthorizedResponse` | `Models/UnauthorizedResponse.cs` |
| `InternalServerErrorResponse` | `Models/InternalServerErrorResponse.cs` |

### DownloadPortalArtifactsBuildFile

- **Auth**: `options.Authorization`
- **Signature**: `DownloadPortalArtifactsBuildFile(DownloadPortalArtifactsBuildFileRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `void` (Task)
- **Error**: `ApiException<DownloadPortalArtifactsBuildFileError>` — **Case A (typed)**
- **Error accessors**: `TryGetProblemDetails(out ProblemDetails)` [400] · `TryGetUnauthorizedResponse(out UnauthorizedResponse)` [401] · `TryGetInternalServerErrorResponse(out InternalServerErrorResponse)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DownloadPortalArtifactsBuildFileRequest` | `Requests/PortalArtifactsGenerationAsync/DownloadPortalArtifactsBuildFileRequest.cs` |
| `DownloadPortalArtifactsBuildFileError` | `Errors/DownloadPortalArtifactsBuildFileError.cs` |
| `ProblemDetails` | `Models/ProblemDetails.cs` |
| `UnauthorizedResponse` | `Models/UnauthorizedResponse.cs` |
| `InternalServerErrorResponse` | `Models/InternalServerErrorResponse.cs` |

### GeneratePortalArtifactsAsync

- **Auth**: `options.Authorization`
- **Signature**: `GeneratePortalArtifactsAsync(GeneratePortalArtifactsAsyncRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `File`
- **Returns**: `PortalArtifactsGenerationAsyncResponse`
- **Error**: `ApiException<GeneratePortalArtifactsAsyncError>` — **Case A (typed)**
- **Error accessors**: `TryGetProblemDetails(out ProblemDetails)` [400, 403] · `TryGetUnauthorizedResponse(out UnauthorizedResponse)` [401] · `TryGetInternalServerErrorResponse(out InternalServerErrorResponse)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GeneratePortalArtifactsAsyncRequest` | `Requests/PortalArtifactsGenerationAsync/GeneratePortalArtifactsAsyncRequest.cs` |
| `PortalArtifactsGenerationAsyncResponse` | `Models/PortalArtifactsGenerationAsyncResponse.cs` |
| `GeneratePortalArtifactsAsyncError` | `Errors/GeneratePortalArtifactsAsyncError.cs` |
| `ProblemDetails` | `Models/ProblemDetails.cs` |
| `UnauthorizedResponse` | `Models/UnauthorizedResponse.cs` |
| `InternalServerErrorResponse` | `Models/InternalServerErrorResponse.cs` |

### GetPortalArtifactsGenerationStatus

- **Auth**: `options.Authorization`
- **Signature**: `GetPortalArtifactsGenerationStatus(GetPortalArtifactsGenerationStatusRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `PortalArtifactsGenerationStatusResponse`
- **Error**: `ApiException<GetPortalArtifactsGenerationStatusError>` — **Case A (typed)**
- **Error accessors**: `TryGetProblemDetails(out ProblemDetails)` [400] · `TryGetUnauthorizedResponse(out UnauthorizedResponse)` [401] · `TryGetInternalServerErrorResponse(out InternalServerErrorResponse)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetPortalArtifactsGenerationStatusRequest` | `Requests/PortalArtifactsGenerationAsync/GetPortalArtifactsGenerationStatusRequest.cs` |
| `PortalArtifactsGenerationStatusResponse` | `Models/PortalArtifactsGenerationStatusResponse.cs` |
| `GetPortalArtifactsGenerationStatusError` | `Errors/GetPortalArtifactsGenerationStatusError.cs` |
| `ProblemDetails` | `Models/ProblemDetails.cs` |
| `UnauthorizedResponse` | `Models/UnauthorizedResponse.cs` |
| `InternalServerErrorResponse` | `Models/InternalServerErrorResponse.cs` |


<!-- Generated file — do not edit; regenerated with the SDK. -->

# Internal — operations

Accessor: `client.Internal` · Source: `Api/Internal.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

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


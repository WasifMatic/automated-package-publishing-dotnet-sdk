# Reference

Every operation below is shown in its throwing form. On an error status it throws `ApiException<TError>` — the status code, headers, content type and the operation's error type, `RawError` (the raw body) when the spec declares none — and where an operation offers an `…AsResult` sibling, that sibling returns `ApiResult<TResponse, TError>` instead. A request that produces no usable response surfaces as `SdkConnectionException` or `SdkTimeoutException`, a body that does not match the documented response type as `ResponseDeserializationException`, and a credential that cannot be applied as `AuthSchemeException`; all of them derive from `SdkException` and name the failed call. See [README → Error Handling](README.md#error-handling).

> Source: [ApiMaticPortalArtifactsApiClient](ApiMaticPortalArtifactsApiClient.cs)

## PortalArtifactsGenerationAsync

> Source: [PortalArtifactsGenerationAsync](Api/PortalArtifactsGenerationAsync.cs)

<details>
<summary><code>Task DownloadGeneratedPortalArtifacts(DownloadGeneratedPortalArtifactsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Download the generated Portal Artifacts as a zip file. The zip file contains:

1. `sdk/<language>.zip`: the SDK for each configured language
2. `code-samples/<language>.json`: the code samples catalog for each configured language
3. `docs/<language>.json`: the getting started guide for each configured language
4. `plugin.zip`: the context plugin, only when the build input declares one

The artifacts are available only after generation completes. Until then, this endpoint returns `400`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.PortalArtifactsGenerationAsync.DownloadGeneratedPortalArtifacts(
        new DownloadGeneratedPortalArtifactsRequest { Id = Guid.Parse("019992a4-5c3e-7b21-9f0a-3d6e8c1b2a47") });
}
catch (ApiException<DownloadGeneratedPortalArtifactsError> ex)
{
    if (ex.Error.TryGetProblemDetails(out var error))
    {
        // TODO: Handle 'error' of type ProblemDetails
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DownloadGeneratedPortalArtifactsRequest](Requests/PortalArtifactsGenerationAsync/DownloadGeneratedPortalArtifactsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DownloadGeneratedPortalArtifactsError](Errors/DownloadGeneratedPortalArtifactsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DownloadPortalArtifactsBuildFile(DownloadPortalArtifactsBuildFileRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Download the build file that was uploaded for a Portal Artifacts generation request. Available to admin users only.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.PortalArtifactsGenerationAsync.DownloadPortalArtifactsBuildFile(
        new DownloadPortalArtifactsBuildFileRequest { Id = Guid.Parse("019992a4-5c3e-7b21-9f0a-3d6e8c1b2a47") });
}
catch (ApiException<DownloadPortalArtifactsBuildFileError> ex)
{
    if (ex.Error.TryGetProblemDetails(out var error))
    {
        // TODO: Handle 'error' of type ProblemDetails
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DownloadPortalArtifactsBuildFileRequest](Requests/PortalArtifactsGenerationAsync/DownloadPortalArtifactsBuildFileRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DownloadPortalArtifactsBuildFileError](Errors/DownloadPortalArtifactsBuildFileError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PortalArtifactsGenerationAsyncResponse&gt; GeneratePortalArtifactsAsync(GeneratePortalArtifactsAsyncRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Start an asynchronous generation of Portal Artifacts by uploading a Portal Build Input. The build input is your build directory (containing the `apimatic.json` file, your API specification and your content) compressed into a zip file.

For every language configured in the build input, the generated artifacts include:

1. An SDK
2. A code samples catalog
3. A getting started guide

A context plugin is also generated when the build input declares one.

The request returns immediately with an `id` and links to check the status and download the artifacts. Generation must finish within 25 minutes.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PortalArtifactsGenerationAsync.GeneratePortalArtifactsAsync(
        new GeneratePortalArtifactsAsyncRequest
        {
            XApiMaticCallbackUrl = "https://example.com/portal-artifacts-callback",
            File = Array.Empty<byte>(),
        });
    // TODO: Handle 'response' of type PortalArtifactsGenerationAsyncResponse
}
catch (ApiException<GeneratePortalArtifactsAsyncError> ex)
{
    if (ex.Error.TryGetProblemDetails(out var error))
    {
        // TODO: Handle 'error' of type ProblemDetails
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GeneratePortalArtifactsAsyncRequest](Requests/PortalArtifactsGenerationAsync/GeneratePortalArtifactsAsyncRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PortalArtifactsGenerationAsyncResponse](Models/PortalArtifactsGenerationAsyncResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GeneratePortalArtifactsAsyncError](Errors/GeneratePortalArtifactsAsyncError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PortalArtifactsGenerationStatusResponse&gt; GetPortalArtifactsGenerationStatus(GetPortalArtifactsGenerationStatusRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get the status of a Portal Artifacts generation request.

While generation is running or after it has failed, this endpoint returns `200` with the current status. Once generation completes, it returns a `302` redirect to the download endpoint. HTTP clients that follow redirects automatically will receive the artifacts zip file directly.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PortalArtifactsGenerationAsync.GetPortalArtifactsGenerationStatus(
        new GetPortalArtifactsGenerationStatusRequest { Id = Guid.Parse("019992a4-5c3e-7b21-9f0a-3d6e8c1b2a47") });
    // TODO: Handle 'response' of type PortalArtifactsGenerationStatusResponse
}
catch (ApiException<GetPortalArtifactsGenerationStatusError> ex)
{
    if (ex.Error.TryGetProblemDetails(out var error))
    {
        // TODO: Handle 'error' of type ProblemDetails
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetPortalArtifactsGenerationStatusRequest](Requests/PortalArtifactsGenerationAsync/GetPortalArtifactsGenerationStatusRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PortalArtifactsGenerationStatusResponse](Models/PortalArtifactsGenerationStatusResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetPortalArtifactsGenerationStatusError](Errors/GetPortalArtifactsGenerationStatusError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Internal

> Source: [Internal](Api/Internal.cs)

<details>
<summary><code>Task DownloadPortalArtifactsBuildFile(DownloadPortalArtifactsBuildFileRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Download the build file that was uploaded for a Portal Artifacts generation request. Available to admin users only.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.Internal.DownloadPortalArtifactsBuildFile(new DownloadPortalArtifactsBuildFileRequest
    {
        Id = Guid.Parse("019992a4-5c3e-7b21-9f0a-3d6e8c1b2a47"),
    });
}
catch (ApiException<DownloadPortalArtifactsBuildFileError> ex)
{
    if (ex.Error.TryGetProblemDetails(out var error))
    {
        // TODO: Handle 'error' of type ProblemDetails
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DownloadPortalArtifactsBuildFileRequest](Requests/PortalArtifactsGenerationAsync/DownloadPortalArtifactsBuildFileRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DownloadPortalArtifactsBuildFileError](Errors/DownloadPortalArtifactsBuildFileError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Public

> Source: [Public](Api/Public.cs)

<details>
<summary><code>Task DownloadGeneratedPortalArtifacts(DownloadGeneratedPortalArtifactsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Download the generated Portal Artifacts as a zip file. The zip file contains:

1. `sdk/<language>.zip`: the SDK for each configured language
2. `code-samples/<language>.json`: the code samples catalog for each configured language
3. `docs/<language>.json`: the getting started guide for each configured language
4. `plugin.zip`: the context plugin, only when the build input declares one

The artifacts are available only after generation completes. Until then, this endpoint returns `400`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.Public.DownloadGeneratedPortalArtifacts(new DownloadGeneratedPortalArtifactsRequest
    {
        Id = Guid.Parse("019992a4-5c3e-7b21-9f0a-3d6e8c1b2a47"),
    });
}
catch (ApiException<DownloadGeneratedPortalArtifactsError> ex)
{
    if (ex.Error.TryGetProblemDetails(out var error))
    {
        // TODO: Handle 'error' of type ProblemDetails
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DownloadGeneratedPortalArtifactsRequest](Requests/PortalArtifactsGenerationAsync/DownloadGeneratedPortalArtifactsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DownloadGeneratedPortalArtifactsError](Errors/DownloadGeneratedPortalArtifactsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PortalArtifactsGenerationAsyncResponse&gt; GeneratePortalArtifactsAsync(GeneratePortalArtifactsAsyncRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Start an asynchronous generation of Portal Artifacts by uploading a Portal Build Input. The build input is your build directory (containing the `apimatic.json` file, your API specification and your content) compressed into a zip file.

For every language configured in the build input, the generated artifacts include:

1. An SDK
2. A code samples catalog
3. A getting started guide

A context plugin is also generated when the build input declares one.

The request returns immediately with an `id` and links to check the status and download the artifacts. Generation must finish within 25 minutes.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Public.GeneratePortalArtifactsAsync(new GeneratePortalArtifactsAsyncRequest
    {
        XApiMaticCallbackUrl = "https://example.com/portal-artifacts-callback",
        File = Array.Empty<byte>(),
    });
    // TODO: Handle 'response' of type PortalArtifactsGenerationAsyncResponse
}
catch (ApiException<GeneratePortalArtifactsAsyncError> ex)
{
    if (ex.Error.TryGetProblemDetails(out var error))
    {
        // TODO: Handle 'error' of type ProblemDetails
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GeneratePortalArtifactsAsyncRequest](Requests/PortalArtifactsGenerationAsync/GeneratePortalArtifactsAsyncRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PortalArtifactsGenerationAsyncResponse](Models/PortalArtifactsGenerationAsyncResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GeneratePortalArtifactsAsyncError](Errors/GeneratePortalArtifactsAsyncError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PortalArtifactsGenerationStatusResponse&gt; GetPortalArtifactsGenerationStatus(GetPortalArtifactsGenerationStatusRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get the status of a Portal Artifacts generation request.

While generation is running or after it has failed, this endpoint returns `200` with the current status. Once generation completes, it returns a `302` redirect to the download endpoint. HTTP clients that follow redirects automatically will receive the artifacts zip file directly.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Public.GetPortalArtifactsGenerationStatus(new GetPortalArtifactsGenerationStatusRequest
    {
        Id = Guid.Parse("019992a4-5c3e-7b21-9f0a-3d6e8c1b2a47"),
    });
    // TODO: Handle 'response' of type PortalArtifactsGenerationStatusResponse
}
catch (ApiException<GetPortalArtifactsGenerationStatusError> ex)
{
    if (ex.Error.TryGetProblemDetails(out var error))
    {
        // TODO: Handle 'error' of type ProblemDetails
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetPortalArtifactsGenerationStatusRequest](Requests/PortalArtifactsGenerationAsync/GetPortalArtifactsGenerationStatusRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PortalArtifactsGenerationStatusResponse](Models/PortalArtifactsGenerationStatusResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetPortalArtifactsGenerationStatusError](Errors/GetPortalArtifactsGenerationStatusError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>


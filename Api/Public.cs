using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using ApiMaticPortalArtifactsApi.Core;
using ApiMaticPortalArtifactsApi.Core.Exceptions;
using ApiMaticPortalArtifactsApi.Core.Models;
using ApiMaticPortalArtifactsApi.Core.Request;
using ApiMaticPortalArtifactsApi.Core.Response;
using ApiMaticPortalArtifactsApi.Errors;
using ApiMaticPortalArtifactsApi.Models;
using ApiMaticPortalArtifactsApi.Requests.PortalArtifactsGenerationAsync;

namespace ApiMaticPortalArtifactsApi.Api;

/// <summary>
/// Endpoints shown in the public documentation.
/// </summary>
public sealed class Public
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Public(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Download Generated Portal Artifacts
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DownloadGeneratedPortalArtifactsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Download the generated Portal Artifacts as a zip file. The zip file contains:
    /// <list type="number">
    ///   <item><description><c>sdk/&lt;language&gt;.zip</c>: the SDK for each configured language</description></item>
    ///   <item><description><c>code-samples/&lt;language&gt;.json</c>: the code samples catalog for each configured language</description></item>
    ///   <item><description><c>docs/&lt;language&gt;.json</c>: the getting started guide for each configured language</description></item>
    ///   <item><description><c>plugin.zip</c>: the context plugin, only when the build input declares one</description></item>
    /// </list>
    /// <para>
    /// The artifacts are available only after generation completes. Until then, this endpoint returns <c>400</c>.
    /// </para>
    /// </remarks>
    public Task DownloadGeneratedPortalArtifacts(DownloadGeneratedPortalArtifactsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/portal-artifacts/{id}/download"),
            [new TemplateParam("id", request.Id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DownloadGeneratedPortalArtifactsError.Response,
            [_auth.Authorization],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Generate Portal Artifacts Async
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PortalArtifactsGenerationAsyncResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GeneratePortalArtifactsAsyncError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Start an asynchronous generation of Portal Artifacts by uploading a Portal Build Input. The build input is your build directory (containing the <c>apimatic.json</c> file, your API specification and your content) compressed into a zip file.
    /// <para>
    /// For every language configured in the build input, the generated artifacts include:
    /// </para>
    /// <list type="number">
    ///   <item><description>An SDK</description></item>
    ///   <item><description>A code samples catalog</description></item>
    ///   <item><description>A getting started guide</description></item>
    /// </list>
    /// <para>
    /// A context plugin is also generated when the build input declares one.
    /// </para>
    /// <para>
    /// The request returns immediately with an <c>id</c> and links to check the status and download the artifacts. Generation must finish within 25 minutes.
    /// </para>
    /// </remarks>
    public Task<PortalArtifactsGenerationAsyncResponse> GeneratePortalArtifactsAsync(GeneratePortalArtifactsAsyncRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/portal-artifacts"),
            [],
            [],
            [
                new HeaderParam("X-APIMatic-CallbackUrl", request.XApiMaticCallbackUrl),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            FormRequest.Create(new MultipartParam("file", request.File)),
            JsonResponse.Create<PortalArtifactsGenerationAsyncResponse>(),
            GeneratePortalArtifactsAsyncError.Response,
            [_auth.Authorization],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get Portal Artifacts Generation Status
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PortalArtifactsGenerationStatusResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetPortalArtifactsGenerationStatusError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get the status of a Portal Artifacts generation request.
    /// <para>
    /// While generation is running or after it has failed, this endpoint returns <c>200</c> with the current status. Once generation completes, it returns a <c>302</c> redirect to the download endpoint. HTTP clients that follow redirects automatically will receive the artifacts zip file directly.
    /// </para>
    /// </remarks>
    public Task<PortalArtifactsGenerationStatusResponse> GetPortalArtifactsGenerationStatus(GetPortalArtifactsGenerationStatusRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/portal-artifacts/{id}/status"),
            [new TemplateParam("id", request.Id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PortalArtifactsGenerationStatusResponse>(),
            GetPortalArtifactsGenerationStatusError.Response,
            [_auth.Authorization],
            requestOptions,
            cancellationToken);
}

using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using ApiMaticPortalArtifactsApi.Core;
using ApiMaticPortalArtifactsApi.Core.Exceptions;
using ApiMaticPortalArtifactsApi.Core.Models;
using ApiMaticPortalArtifactsApi.Core.Request;
using ApiMaticPortalArtifactsApi.Core.Response;
using ApiMaticPortalArtifactsApi.Errors;
using ApiMaticPortalArtifactsApi.Requests.PortalArtifactsGenerationAsync;

namespace ApiMaticPortalArtifactsApi.Api;

/// <summary>
/// Endpoints hidden from the public documentation.
/// </summary>
public sealed class Internal
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Internal(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Download Portal Artifacts Build File
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DownloadPortalArtifactsBuildFileError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Download the build file that was uploaded for a Portal Artifacts generation request. Available to admin users only.
    /// </remarks>
    public Task DownloadPortalArtifactsBuildFile(DownloadPortalArtifactsBuildFileRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/portal-artifacts/{id}/build/download"),
            [new TemplateParam("id", request.Id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DownloadPortalArtifactsBuildFileError.Response,
            [_auth.Authorization],
            requestOptions,
            cancellationToken);
}

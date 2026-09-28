using System.Net.Http;
using ApiMaticPortalArtifactsApi.Api;
using ApiMaticPortalArtifactsApi.Core;
using ApiMaticPortalArtifactsApi.Core.Logging;
using ApiMaticPortalArtifactsApi.Core.Models;

namespace ApiMaticPortalArtifactsApi;

/// <summary>
/// Generate the artifacts an APIMatic API Portal needs (SDKs, code samples, getting started guides and, optionally, a context plugin) from a Portal Build Input, asynchronously.
/// <para>
/// The generation flow is:
/// </para>
/// <list type="number">
///   <item><description>Upload your build directory as a zip file using <b>Generate Portal Artifacts Async</b>. You get back an <c>id</c> and links to check the status and download the artifacts.</description></item>
///   <item><description>Poll <b>Get Portal Artifacts Generation Status</b> until generation completes, or pass the <c>X-APIMatic-CallbackUrl</c> header in step 1 to be notified instead.</description></item>
///   <item><description>Download the generated artifacts using <b>Download Generated Portal Artifacts</b>.</description></item>
/// </list>
/// </summary>
public sealed class ApiMaticPortalArtifactsApiClient
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    public ApiMaticPortalArtifactsApiClient(HttpClient httpClient, ApiMaticPortalArtifactsApiClientOptions options)
    {
        _server = new Server(options.Environment, options.Server);
        var queryParameterFactory = new QueryParameterFactory([]);
        var templateParamsFactory = new TemplateParamsFactory([]);
        var urlFactory = new UriFactory(queryParameterFactory, templateParamsFactory);
        var httpStatusPolicy = new HttpStatusPolicy([]);
        var headersFactory = new HeadersFactory([
            new HeaderParam("User-Agent", "ApiMaticPortalArtifactsApiClient/3.0 CSharp"),
            new HeaderParam("X-APIMatic-Lang", "CSharp"),
            new HeaderParam("X-APIMatic-Package-Version", "3.0"),
            new HeaderParam("X-APIMatic-Gen-Version", "4.0.0"),
            new HeaderParam("X-APIMatic-OS", RuntimeEnvironment.Os),
            new HeaderParam("X-APIMatic-Runtime", RuntimeEnvironment.Runtime),
        ]);
        var resiliencePipelineFactory = new ResiliencePipelineFactory(options.Retry, options.TimeProvider);
        var httpLogger = new HttpLogger(options.Logging, "ApiMaticPortalArtifactsApiClient", options.TimeProvider);
        var responseContexts = new ResponseContextFactory(options.TimeProvider, options.StreamReadTimeout);
        _rawClient =
            new RawClient(
                httpClient,
                urlFactory,
                httpStatusPolicy,
                headersFactory,
                resiliencePipelineFactory,
                httpLogger,
                options.Hooks,
                responseContexts);
        _auth = new AuthSchemes(options);
    }

    /// <summary>
    /// Generate the SDKs, code samples, getting started guides and context plugin for an API Portal from a Portal Build Input, asynchronously.
    /// </summary>
    public PortalArtifactsGenerationAsync PortalArtifactsGenerationAsync =>
        field ??= new PortalArtifactsGenerationAsync(_rawClient, _server, _auth);

    /// <summary>
    /// Endpoints hidden from the public documentation.
    /// </summary>
    public Internal Internal => field ??= new Internal(_rawClient, _server, _auth);

    /// <summary>
    /// Endpoints shown in the public documentation.
    /// </summary>
    public Public Public => field ??= new Public(_rawClient, _server, _auth);
}

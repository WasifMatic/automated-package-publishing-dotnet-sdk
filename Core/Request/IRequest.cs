using System.Net.Http;

namespace ApiMaticPortalArtifactsApi.Core.Request;

internal interface IRequest
{
    HttpContent Get();

    bool CanRetry { get; }
}
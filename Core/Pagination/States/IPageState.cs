using System.Net.Http.Headers;

namespace ApiMaticPortalArtifactsApi.Core.Pagination.States;

internal interface IPageState<in TResponse, out TState>
{
    TState? Next(TResponse page, HttpResponseHeaders headers);
}

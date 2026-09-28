using System.Threading;
using System.Threading.Tasks;
using ApiMaticPortalArtifactsApi.Core.ErrorResponse;
using ApiMaticPortalArtifactsApi.Core.Models;

namespace ApiMaticPortalArtifactsApi.Core.Response;

internal sealed class RawErrorBodyResponse : IResponse<RawError>
{
    public static RawErrorBodyResponse Instance { get; } = new();

    private RawErrorBodyResponse() { }

    public ValueTask<RawError> Map(ResponseContext context, CancellationToken cancellationToken) =>
        new(RawError.Create(context.Response, cancellationToken));
}

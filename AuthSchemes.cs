using ApiMaticPortalArtifactsApi.Core.Authentication;
using ApiMaticPortalArtifactsApi.Core.Authentication.ApiKey;

namespace ApiMaticPortalArtifactsApi;

internal sealed class AuthSchemes
{
    public IAuthScheme Authorization { get; }

    public AuthSchemes(ApiMaticPortalArtifactsApiClientOptions options)
    {
        Authorization = ApiKeyHeaderScheme.Create("Authorization", options.Authorization);
    }
}

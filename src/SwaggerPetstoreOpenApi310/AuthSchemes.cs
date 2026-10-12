using SwaggerPetstoreOpenApi310.Core.Authentication;
using SwaggerPetstoreOpenApi310.Core.Authentication.ApiKey;

namespace SwaggerPetstoreOpenApi310;

internal sealed class AuthSchemes
{
    public IAuthScheme PetstoreAuth { get; }
    public IAuthScheme ApiKey { get; }

    public AuthSchemes(SwaggerPetstoreOpenApi310ClientOptions options)
    {
        PetstoreAuth = ApiKeyHeaderScheme.Create("Authorization", options.PetstoreAuth);
        ApiKey = ApiKeyHeaderScheme.Create("api_key", options.ApiKey);
    }
}

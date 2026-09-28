using System.Threading.Tasks;
using ApiMaticPortalArtifactsApi.Core.ErrorResponse;
using ApiMaticPortalArtifactsApi.Core.Models;
using ApiMaticPortalArtifactsApi.Models;

namespace ApiMaticPortalArtifactsApi.Errors;

public sealed class GeneratePortalArtifactsAsyncError : ApiError
{
    private readonly Optional<ProblemDetails> _problemDetailsValue;

    private readonly Optional<UnauthorizedResponse> _unauthorizedResponseValue;

    private readonly Optional<InternalServerErrorResponse> _internalServerErrorResponseValue;

    private GeneratePortalArtifactsAsyncError(Optional<ProblemDetails> problemDetailsValue,
        Optional<UnauthorizedResponse> unauthorizedResponseValue,
        Optional<InternalServerErrorResponse> internalServerErrorResponseValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _problemDetailsValue = problemDetailsValue;
        _unauthorizedResponseValue = unauthorizedResponseValue;
        _internalServerErrorResponseValue = internalServerErrorResponseValue;
    }

    private static GeneratePortalArtifactsAsyncError AsProblemDetails(ProblemDetails value) =>
        new(Optional<ProblemDetails>.Some(value), default, default, default);

    private static GeneratePortalArtifactsAsyncError AsUnauthorizedResponse(UnauthorizedResponse value) =>
        new(default, Optional<UnauthorizedResponse>.Some(value), default, default);

    private static GeneratePortalArtifactsAsyncError AsInternalServerErrorResponse(InternalServerErrorResponse value) =>
        new(default, default, Optional<InternalServerErrorResponse>.Some(value), default);

    private static GeneratePortalArtifactsAsyncError AsFallback(RawError value) =>
        new(default, default, default, Optional<RawError>.Some(value));

    public bool TryGetProblemDetails(out ProblemDetails value) => _problemDetailsValue.TryGetValue(out value);

    public bool TryGetUnauthorizedResponse(out UnauthorizedResponse value) =>
        _unauthorizedResponseValue.TryGetValue(out value);

    public bool TryGetInternalServerErrorResponse(out InternalServerErrorResponse value) =>
        _internalServerErrorResponseValue.TryGetValue(out value);

    private static Task<GeneratePortalArtifactsAsyncError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 or 403 => response.Json<ProblemDetails>().As(AsProblemDetails),
            401 => response.Json<UnauthorizedResponse>().As(AsUnauthorizedResponse),
            500 => response.Json<InternalServerErrorResponse>().As(AsInternalServerErrorResponse),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<GeneratePortalArtifactsAsyncError> Response { get; } = new(Create);
}

using System.Threading.Tasks;
using SwaggerPetstoreOpenApi310.Core.ErrorResponse;
using SwaggerPetstoreOpenApi310.Core.Models;

namespace SwaggerPetstoreOpenApi310.Errors;

public sealed class AddPetError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private AddPetError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static AddPetError AsNoContent(RawError value) => new(Optional<RawError>.Some(value), default);

    private static AddPetError AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    private static Task<AddPetError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 or 422 => response.RawBody().As(AsNoContent),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<AddPetError> Response { get; } = new(Create);
}

using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using SwaggerPetstoreOpenApi30.Core.Hooks;

namespace SwaggerPetstoreOpenApi30.Core;

public sealed record RequestOptions
{
    public LogLevel? LogLevel { get; init; }

    public IReadOnlyList<SdkHook>? Hooks { get; init; }
}

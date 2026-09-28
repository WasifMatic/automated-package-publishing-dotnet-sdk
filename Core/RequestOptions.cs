using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using ApiMaticPortalArtifactsApi.Core.Hooks;

namespace ApiMaticPortalArtifactsApi.Core;

public sealed record RequestOptions
{
    public LogLevel? LogLevel { get; init; }

    public IReadOnlyList<SdkHook>? Hooks { get; init; }
}

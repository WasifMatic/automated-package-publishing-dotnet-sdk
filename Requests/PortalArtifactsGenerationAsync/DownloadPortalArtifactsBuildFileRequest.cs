using System;

namespace ApiMaticPortalArtifactsApi.Requests.PortalArtifactsGenerationAsync;

/// <summary>
/// The inputs of the DownloadPortalArtifactsBuildFile operation.
/// </summary>
public sealed record DownloadPortalArtifactsBuildFileRequest
{
    /// <summary>
    /// The <c>id</c> returned by <b>Generate Portal Artifacts Async</b>.
    /// </summary>
    public required Guid Id { get; init; }
}

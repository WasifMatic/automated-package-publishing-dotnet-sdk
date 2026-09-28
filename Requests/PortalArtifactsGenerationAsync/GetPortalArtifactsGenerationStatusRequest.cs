using System;

namespace ApiMaticPortalArtifactsApi.Requests.PortalArtifactsGenerationAsync;

/// <summary>
/// The inputs of the GetPortalArtifactsGenerationStatus operation.
/// </summary>
public sealed record GetPortalArtifactsGenerationStatusRequest
{
    /// <summary>
    /// The <c>id</c> returned by <b>Generate Portal Artifacts Async</b>.
    /// </summary>
    public required Guid Id { get; init; }
}

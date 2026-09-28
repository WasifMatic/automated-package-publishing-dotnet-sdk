using System;
using System.Text.Json.Serialization;

namespace ApiMaticPortalArtifactsApi.Models;

/// <summary>
/// Details of an accepted Portal Artifacts generation request.
/// </summary>
public record PortalArtifactsGenerationAsyncResponse
{
    /// <summary>
    /// Unique identifier of the generation request.
    /// </summary>
    [JsonPropertyName("id")]
    public required Guid Id { get; init; }

    /// <summary>
    /// Links to check the status of a generation request and download its artifacts.
    /// </summary>
    [JsonPropertyName("links")]
    public required PortalArtifactsGenerationLinks Links { get; init; }
}

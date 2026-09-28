using System.Collections.Generic;
using System.Text.Json.Serialization;
using ApiMaticPortalArtifactsApi.Models.Enums;

namespace ApiMaticPortalArtifactsApi.Models;

/// <summary>
/// Current status of a Portal Artifacts generation request.
/// </summary>
public record PortalArtifactsGenerationStatusResponse
{
    /// <summary>
    /// Status of a Portal Artifacts generation request.
    /// </summary>
    [JsonPropertyName("status")]
    public required PortalArtifactsGenerationStatus Status { get; init; }

    /// <summary>
    /// Error messages grouped by the part of the build input they relate to. Returned only when <c>status</c> is <c>ValidationError</c> or <c>SubscriptionError</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyDictionary<string, object>? Errors { get; init; }
}

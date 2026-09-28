using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ApiMaticPortalArtifactsApi.Core.Validation;
using ApiMaticPortalArtifactsApi.Core.Validation.Attributes;
using ApiMaticPortalArtifactsApi.Models.Enums;

namespace ApiMaticPortalArtifactsApi.Models;

/// <summary>
/// Notification sent to the callback URL when a Portal Artifacts generation request finishes.
/// </summary>
public record PortalArtifactsCallbackPayload
{
    /// <summary>
    /// Unique identifier of the generation request.
    /// </summary>
    [JsonPropertyName("id")]
    public required Guid Id { get; init; }

    /// <summary>
    /// Final status of a Portal Artifacts generation request, sent in the callback notification.
    /// </summary>
    [JsonPropertyName("status")]
    public required PortalArtifactsCallbackStatus Status { get; init; }

    /// <summary>
    /// URL to download the generated artifacts. Present only when <c>status</c> is <c>GenerationCompleted</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("link")]
    [Format(FormatKind.Uri)]
    public string? Link { get; init; }

    /// <summary>
    /// Error messages grouped by the part of the build input they relate to. Present only when generation did not complete.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyDictionary<string, object>? Errors { get; init; }
}

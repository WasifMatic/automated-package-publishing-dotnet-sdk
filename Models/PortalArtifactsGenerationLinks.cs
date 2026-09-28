using System.Text.Json.Serialization;
using ApiMaticPortalArtifactsApi.Core.Validation;
using ApiMaticPortalArtifactsApi.Core.Validation.Attributes;

namespace ApiMaticPortalArtifactsApi.Models;

/// <summary>
/// Links to check the status of a generation request and download its artifacts.
/// </summary>
public record PortalArtifactsGenerationLinks
{
    /// <summary>
    /// URL to check the status of the generation request.
    /// </summary>
    [JsonPropertyName("status")]
    [Format(FormatKind.Uri)]
    public required string Status { get; init; }

    /// <summary>
    /// URL to download the generated artifacts once generation completes.
    /// </summary>
    [JsonPropertyName("download")]
    [Format(FormatKind.Uri)]
    public required string Download { get; init; }
}

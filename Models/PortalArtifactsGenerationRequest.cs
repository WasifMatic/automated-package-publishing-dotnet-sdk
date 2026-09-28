using System.Text.Json.Serialization;
using ApiMaticPortalArtifactsApi.Core.Models;

namespace ApiMaticPortalArtifactsApi.Models;

/// <summary>
/// Multipart form data for a Portal Artifacts generation request.
/// </summary>
public record PortalArtifactsGenerationRequest
{
    /// <summary>
    /// The Portal Build Input as a zip file (maximum 20 MB). The zip file must contain the build directory, including the <c>apimatic.json</c> file.
    /// </summary>
    [JsonPropertyName("file")]
    public required BinaryContent File { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

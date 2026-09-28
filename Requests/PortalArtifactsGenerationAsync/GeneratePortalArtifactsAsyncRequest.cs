using ApiMaticPortalArtifactsApi.Core.Models;
using ApiMaticPortalArtifactsApi.Core.Validation;
using ApiMaticPortalArtifactsApi.Core.Validation.Attributes;

namespace ApiMaticPortalArtifactsApi.Requests.PortalArtifactsGenerationAsync;

/// <summary>
/// The inputs of the GeneratePortalArtifactsAsync operation.
/// </summary>
public sealed record GeneratePortalArtifactsAsyncRequest
{
    /// <summary>
    /// Optional absolute HTTP or HTTPS URL. When provided, the server sends a <c>POST</c> request to this URL once generation finishes, with the generation status and, on success, the download link.
    /// </summary>
    [Format(FormatKind.Uri)]
    public string? XApiMaticCallbackUrl { get; init; }

    /// <summary>
    /// The Portal Build Input as a zip file (maximum 20 MB). The zip file must contain the build directory, including the <c>apimatic.json</c> file.
    /// </summary>
    public required BinaryContent File { get; init; }
}

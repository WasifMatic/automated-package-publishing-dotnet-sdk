using System.Text.Json.Serialization;
using ApiMaticPortalArtifactsApi.Core.Models;

namespace ApiMaticPortalArtifactsApi.Models;

/// <summary>
/// Error returned when the server encounters an unexpected error.
/// </summary>
public record InternalServerErrorResponse
{
    /// <summary>
    /// A message describing the error.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("message")]
    public string? Message { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

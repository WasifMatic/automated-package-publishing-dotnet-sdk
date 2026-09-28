using System.Text.Json.Serialization;
using ApiMaticPortalArtifactsApi.Core.Models;

namespace ApiMaticPortalArtifactsApi.Models;

/// <summary>
/// Error returned when the request is not authorized.
/// </summary>
public record UnauthorizedResponse
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

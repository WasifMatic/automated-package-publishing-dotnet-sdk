using System;
using System.Text.Json.Serialization;
using ApiMaticPortalArtifactsApi.Core.Enum;

namespace ApiMaticPortalArtifactsApi.Models.Enums;

/// <summary>
/// Status of a Portal Artifacts generation request.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PortalArtifactsGenerationStatus>))]
public sealed record PortalArtifactsGenerationStatus : OpenStringEnum<PortalArtifactsGenerationStatus>
{
    private PortalArtifactsGenerationStatus(string value) : base(value)
    {
    }

    /// <summary>
    /// Generation is queued or running.
    /// </summary>
    public static readonly PortalArtifactsGenerationStatus InProgress = new("InProgress");

    /// <summary>
    /// Generation failed due to an unexpected error.
    /// </summary>
    public static readonly PortalArtifactsGenerationStatus Failed = new("Failed");

    /// <summary>
    /// The build input is not valid. See <c>errors</c> for details.
    /// </summary>
    public static readonly PortalArtifactsGenerationStatus ValidationError = new("ValidationError");

    /// <summary>
    /// The build input requests features that your subscription does not include. See <c>errors</c> for details.
    /// </summary>
    public static readonly PortalArtifactsGenerationStatus SubscriptionError = new("SubscriptionError");

    public TResult Match<TResult>(Func<TResult> onInProgress,
        Func<TResult> onFailed,
        Func<TResult> onValidationError,
        Func<TResult> onSubscriptionError,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == InProgress => onInProgress(),
            _ when this == Failed => onFailed(),
            _ when this == ValidationError => onValidationError(),
            _ when this == SubscriptionError => onSubscriptionError(),
            _ => otherwise(Value)
        };

    public void Match(Action onInProgress,
        Action onFailed,
        Action onValidationError,
        Action onSubscriptionError,
        Action<string> otherwise)
    {
        if (this == InProgress) onInProgress();
        else if (this == Failed) onFailed();
        else if (this == ValidationError) onValidationError();
        else if (this == SubscriptionError) onSubscriptionError();
        else otherwise(Value);
    }
}

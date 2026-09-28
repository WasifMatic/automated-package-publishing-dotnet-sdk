using System;
using System.Text.Json.Serialization;
using ApiMaticPortalArtifactsApi.Core.Enum;

namespace ApiMaticPortalArtifactsApi.Models.Enums;

/// <summary>
/// Final status of a Portal Artifacts generation request, sent in the callback notification.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PortalArtifactsCallbackStatus>))]
public sealed record PortalArtifactsCallbackStatus : OpenStringEnum<PortalArtifactsCallbackStatus>
{
    private PortalArtifactsCallbackStatus(string value) : base(value)
    {
    }

    /// <summary>
    /// Generation completed. <c>link</c> contains the download URL.
    /// </summary>
    public static readonly PortalArtifactsCallbackStatus GenerationCompleted = new("GenerationCompleted");

    /// <summary>
    /// The build input is not valid. See <c>errors</c> for details.
    /// </summary>
    public static readonly PortalArtifactsCallbackStatus ValidationError = new("ValidationError");

    /// <summary>
    /// The build input requests features that your subscription does not include. See <c>errors</c> for details.
    /// </summary>
    public static readonly PortalArtifactsCallbackStatus SubscriptionError = new("SubscriptionError");

    /// <summary>
    /// Generation failed due to an unexpected error or did not finish within 25 minutes.
    /// </summary>
    public static readonly PortalArtifactsCallbackStatus InternalServerError = new("InternalServerError");

    public TResult Match<TResult>(Func<TResult> onGenerationCompleted,
        Func<TResult> onValidationError,
        Func<TResult> onSubscriptionError,
        Func<TResult> onInternalServerError,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == GenerationCompleted => onGenerationCompleted(),
            _ when this == ValidationError => onValidationError(),
            _ when this == SubscriptionError => onSubscriptionError(),
            _ when this == InternalServerError => onInternalServerError(),
            _ => otherwise(Value)
        };

    public void Match(Action onGenerationCompleted,
        Action onValidationError,
        Action onSubscriptionError,
        Action onInternalServerError,
        Action<string> otherwise)
    {
        if (this == GenerationCompleted) onGenerationCompleted();
        else if (this == ValidationError) onValidationError();
        else if (this == SubscriptionError) onSubscriptionError();
        else if (this == InternalServerError) onInternalServerError();
        else otherwise(Value);
    }
}

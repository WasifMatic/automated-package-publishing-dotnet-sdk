using System;
using System.Text.Json.Serialization;
using ApiMaticPortalArtifactsApi.Core.Enum;

namespace ApiMaticPortalArtifactsApi.Servers;

[JsonConverter(typeof(StringEnumConverter<ServerEnvironment>))]
public sealed record ServerEnvironment : ClosedStringEnum<ServerEnvironment>
{
    private ServerEnvironment(string value) : base(value)
    {
    }

    /// <summary>
    /// The APIMatic production environment.
    /// </summary>
    public static readonly ServerEnvironment Production = new("production");

    /// <summary>
    /// A testing environment with a custom domain.
    /// </summary>
    public static readonly ServerEnvironment Testing = new("testing");

    public static ServerEnvironment Default() => Production;

    internal TResult Match<TResult>(Func<TResult> onProduction, Func<TResult> onTesting) =>
        this switch
        {
            _ when this == Production => onProduction(),
            _ when this == Testing => onTesting(),
            _ => throw new InvalidOperationException($"{nameof(ServerEnvironment)} holds no known value.")
        };
}

using System.Net.Http;

namespace SwaggerPetstoreOpenApi30.Core.Extensions;

internal static class HttpContentExtension
{
    extension(HttpContent)
    {
        public static HttpContent None => null!;
    }
}

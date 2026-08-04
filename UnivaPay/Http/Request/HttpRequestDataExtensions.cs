// <copyright file="HttpRequestDataExtensions.cs" company="APIMatic">
// UnivaPay
//
// This file was automatically generated for Univapay by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core.Http.Abstractions;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UnivaPay.Http.Request
{
    internal static class HttpRequestDataExtensions
    {
        public static async Task<string> ReadBodyAsStringAsync(this IHttpRequestData request,
            CancellationToken cancellationToken = default)
        {
            if (request.Body == null)
                return string.Empty;
    
            if (request.Body.CanSeek)
                request.Body.Position = 0;
    
            cancellationToken.ThrowIfCancellationRequested();
    
            using (var reader = new StreamReader(request.Body, Encoding.UTF8, true, 1024, leaveOpen: true))
            {
                return await reader.ReadToEndAsync().ConfigureAwait(false);
            }
        }
    
        public static async Task<HttpRequestData> WithBufferedBody(this IHttpRequestData original,
            CancellationToken cancellationToken = default)
        {
            var body = await original.Body.ToBufferedStream(cancellationToken).ConfigureAwait(false);
            return HttpRequestData.Create(
                original.Method,
                original.Url,
                original.Headers,
                body,
                original.Query,
                original.Cookies,
                original.Protocol,
                original.ContentType,
                original.ContentLength
            );
        }
    
        private static async Task<MemoryStream> ToBufferedStream(this Stream stream,
            CancellationToken cancellationToken = default)
        {
            var memoryStream = new MemoryStream();
            await stream.CopyToAsync(memoryStream, 81920, cancellationToken).ConfigureAwait(false);
            memoryStream.Position = 0;
            return memoryStream;
        }
    }
}
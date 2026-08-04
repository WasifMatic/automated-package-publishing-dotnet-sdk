// <copyright file="HttpRequestData.cs" company="APIMatic">
// UnivaPay
//
// This file was automatically generated for Univapay by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core.Http.Abstractions;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.IO;
using System.Linq;

namespace UnivaPay.Http.Request
{
    /// <inheritdoc />
    public sealed class HttpRequestData : IHttpRequestData
    {
        /// <inheritdoc />
        public string Method { get; }
    
        /// <inheritdoc />
        public Uri Url { get; }
    
        /// <inheritdoc />
        public IReadOnlyDictionary<string, string[]> Headers { get; }
    
        /// <inheritdoc />
        public Stream Body { get; }
    
        /// <inheritdoc />
        public IReadOnlyDictionary<string, string[]> Query { get; }
    
        /// <inheritdoc />
        public IReadOnlyDictionary<string, string> Cookies { get; }
    
        /// <inheritdoc />
        public string Protocol { get; }
    
        /// <inheritdoc />
        public string ContentType { get; }
    
        /// <inheritdoc />
        public long? ContentLength { get; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="HttpRequestData"/> class with the specified HTTP request details.
        /// </summary>
        /// <param name="method">The HTTP method (e.g., GET, POST).</param>
        /// <param name="url">The request URL.</param>
        /// <param name="headers">The request headers.</param>
        /// <param name="body">The request body stream.</param>
        /// <param name="query">The query parameters.</param>
        /// <param name="cookies">The request cookies.</param>
        /// <param name="protocol">The HTTP protocol version.</param>
        /// <param name="contentType">The content type of the request.</param>
        /// <param name="contentLength">The length of the request body, if known.</param>
        private HttpRequestData(
            string method,
            Uri url,
            IReadOnlyDictionary<string, string[]> headers,
            Stream body,
            IReadOnlyDictionary<string, string[]> query,
            IReadOnlyDictionary<string, string> cookies,
            string protocol,
            string contentType,
            long? contentLength)
        {
            Method = method;
            Url = url;
            Headers = headers;
            Body = body;
            Query = query;
            Cookies = cookies;
            Protocol = protocol;
            ContentType = contentType;
            ContentLength = contentLength;
        }
    
        /// <summary>
        /// Creates a new <see cref="HttpRequestData"/> instance from ASP.NET Core-style request data.
        /// </summary>
        /// <param name="method">The HTTP method (e.g., GET, POST).</param>
        /// <param name="scheme">The URI scheme (e.g., http, https).</param>
        /// <param name="host">The request host (domain and port).</param>
        /// <param name="path">The request path.</param>
        /// <param name="queryString">The query string, including the leading '?'.</param>
        /// <param name="headers">The request headers.</param>
        /// <param name="body">The request body stream.</param>
        /// <param name="query">The query parameters.</param>
        /// <param name="cookies">The request cookies.</param>
        /// <param name="protocol">The HTTP protocol version\.</param>
        /// <param name="contentType">The content type of the request.</param>
        /// <param name="contentLength">The length of the request body, if known.</param>
        /// <returns>A new <see cref="HttpRequestData"/> instance.</returns>
        public static HttpRequestData FromAspNetCoreParams(
            string method,
            string scheme,
            string host,
            string path,
            string queryString,
            IDictionary<string, StringValues> headers,
            Stream body,
            IEnumerable<KeyValuePair<string, StringValues>> query,
            IEnumerable cookies,
            string protocol,
            string contentType,
            long? contentLength)
        {
            var url = new Uri($"{scheme}://{host}{path}{queryString}");
            var headersDict = headers.ToDictionary(
                h => h.Key,
                h => h.Value.ToArray(),
                StringComparer.OrdinalIgnoreCase);
            var queryDict = query.ToDictionary(
                h => h.Key,
                h => h.Value.ToArray(),
                StringComparer.OrdinalIgnoreCase);
            var cookiesDict = ParseCookiesToDictionary(cookies);
            
            return Create(
                method,
                url,
                headersDict,
                body,
                queryDict,
                cookiesDict,
                protocol,
                contentType,
                contentLength
            );
        }
    
        /// <summary>
        /// Creates a new <see cref="HttpRequestData"/> instance from ASP.NET-style request data.
        /// </summary>
        /// <param name="method">The HTTP method (e.g., GET, POST).</param>
        /// <param name="url">The request URL.</param>
        /// <param name="headers">The request headers as a <see cref="NameValueCollection"/>.</param>
        /// <param name="body">The request body stream.</param>
        /// <param name="query">The query parameters.</param>
        /// <param name="cookies">The request cookies.</param>
        /// <param name="protocol">The HTTP protocol version.</param>
        /// <param name="contentType">The content type of the request.</param>
        /// <param name="contentLength">The length of the request body, if known.</param>
        /// <returns>A new <see cref="HttpRequestData"/> instance.</returns>
        public static HttpRequestData FromAspNetParams(
            string method,
            Uri url,
            NameValueCollection headers,
            Stream body,
            NameValueCollection query,
            IDictionary<string, string> cookies,
            string protocol,
            string contentType,
            long? contentLength)
        {
            var headersDict = headers.AllKeys
                .Where(k => k != null)
                .ToDictionary(
                    k => k,
                    k => headers.GetValues(k) ?? Array.Empty<string>()
                );
    
            var queryDict = query.AllKeys
                .Where(k => k != null)
                .ToDictionary(
                    k => k,
                    k => query.GetValues(k) ?? Array.Empty<string>()
                );
    
            return new HttpRequestData(
                method,
                url,
                headersDict,
                body,
                queryDict,
                new ReadOnlyDictionary<string, string>(cookies),
                protocol,
                contentType,
                contentLength
            );
        }
    
        /// <summary>
        /// Creates a new <see cref="HttpRequestData"/> instance from raw request data.
        /// </summary>
        /// <param name="method">The HTTP method (e.g., GET, POST).</param>
        /// <param name="url">The request URL.</param>
        /// <param name="headers">The request headers as a dictionary.</param>
        /// <param name="body">The request body stream.</param>
        /// <param name="query">The query parameters as a dictionary.</param>
        /// <param name="cookies">The request cookies.</param>
        /// <param name="protocol">The HTTP protocol version.</param>
        /// <param name="contentType">The content type of the request.</param>
        /// <param name="contentLength">The length of the request body, if known.</param>
        /// <returns>A new <see cref="HttpRequestData"/> instance.</returns>
        public static HttpRequestData Create(
            string method,
            Uri url,
            IReadOnlyDictionary<string, string[]> headers,
            Stream body,
            IReadOnlyDictionary<string, string[]> query,
            IReadOnlyDictionary<string, string> cookies,
            string protocol,
            string contentType,
            long? contentLength)
        {
            return new HttpRequestData(
                method,
                url,
                headers,
                body,
                query,
                cookies,
                protocol,
                contentType,
                contentLength
            );
        }
        
        private static IReadOnlyDictionary<string, string> ParseCookiesToDictionary(IEnumerable cookies)
        {
            if (cookies is IEnumerable<KeyValuePair<string, string>> kvpEnumerable)
            {
                return kvpEnumerable.ToDictionary(
                    c => c.Key,
                    c => c.Value,
                    StringComparer.OrdinalIgnoreCase);
            }
            
            if (cookies is IEnumerable enumerable)
            {
                var dict = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
                foreach (var item in enumerable)
                {
                    if (item is KeyValuePair<string, string> kvp)
                        dict[kvp.Key] = kvp.Value;
                }
                return dict;
            }
    
            throw new ArgumentException("Unsupported cookies type");
        }
    }
}
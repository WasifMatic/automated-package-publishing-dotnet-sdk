// <copyright file="HttpRequestDataTestFactory.cs" company="APIMatic">
// UnivapayClientSdk.Tests
//
// This file was automatically generated for Univapay by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using UnivaPay.Http.Request;

namespace UnivaPay.Utilities
{
    public static class HttpRequestDataTestFactory
    {
        public static HttpRequestData CreatePostRequestWithBody(byte[] body)
        {
            var headers = new Dictionary<string, string[]>
            {
                { "Content-Type", new[] { "application/json" } }
            };
            
            return HttpRequestData.Create(
                "POST",
                new Uri("https://events.example.com/handle"),
                headers,
                new MemoryStream(body),
                query: null,
                cookies: null,
                protocol: "HTTP/1.1",
                contentType: "application/json",
                contentLength: body.Length);
        }
        
        public static async Task<HttpRequestData> WithSignatureAsync(
            this HttpRequestData requestData,
            Func<HttpRequestData, CancellationToken, Task<(string key, string value)>> computeSignatureFunc,
            CancellationToken cancellationToken = default)
        {
            var (key, value) = await computeSignatureFunc(requestData, cancellationToken).ConfigureAwait(false);
            var headers = new Dictionary<string, string[]>(requestData.Headers)
            {
                [key] = new[] { value }
            };
            
            if (requestData.Body.CanSeek) requestData.Body.Position = 0;
            
            return HttpRequestData.Create(
                requestData.Method,
                requestData.Url,
                headers,
                requestData.Body,
                requestData.Query,
                requestData.Cookies,
                requestData.Protocol,
                requestData.ContentType,
                requestData.ContentLength);
        }
        
        public static ControllerContext CreateControllerContext(this HttpRequestData requestData)
        {
            var context = new DefaultHttpContext
            {
                Request =
                {
                    Method = HttpMethods.Post,
                    Scheme = "https",
                    Host = new HostString("events.example.com"),
                    Path = "/handle",
                    ContentType = "application/json",
                    Body = requestData.Body,
                }
            };
        
            if (requestData.Headers != null && requestData.Headers.Count > 0)
            {
                var requestHeaders = context.Request.Headers;
                foreach (var header in requestData.Headers)
                {
                    requestHeaders[header.Key] = header.Value;
                }
            }
        
            return new ControllerContext { HttpContext = context };
        }
    }
}
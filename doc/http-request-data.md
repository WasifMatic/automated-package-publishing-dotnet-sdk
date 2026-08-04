
# HttpRequestData

HttpRequestData encapsulates all relevant information about an HTTP request in a strongly-typed, immutable structure.

## Properties

| Name | Description | Type |
|  --- | --- | --- |
| <code>Method</code> | The HTTP verb (e.g., GET, POST) for this request. | `string` |
| <code>Url</code> | The full URL for the HTTP request. | `Uri` |
| <code>Headers</code> | Collection of HTTP headers, where each header can have multiple values. | `IReadOnlyDictionary<string, string[]>` |
| <code>Body</code> | The raw request body as a stream. | `Stream` |
| <code>Query</code> | Query parameters, where each parameter can have multiple values. | `IReadOnlyDictionary<string, string[]>` |
| <code>Cookies</code> | Cookies sent with the request. | `IReadOnlyDictionary<string, string>` |
| <code>Protocol</code> | The HTTP protocol version (e.g., HTTP/1.1). | `string` |
| <code>ContentType</code> | The content type of the request body. | `string` |
| <code>ContentLength</code> | The length of the request body, if known. | `long?` |

## Factory Methods

| Name | Description |
|  --- | --- |
| `FromAspNetCore(string method, string scheme, string host, string path, string queryString, IDictionary<string, StringValues> headers, Stream body, IEnumerable<KeyValuePair<string, StringValues>> query, IEnumerable cookies, string protocol, string contentType, long? contentLength)` | Creates a new HttpRequestData instance from ASP.NET Core-style request parameters. |
| `FromAspNet(string method, Uri url, NameValueCollection headers, Stream body, NameValueCollection query, IDictionary<string, string> cookies, string protocol, string contentType, long? contentLength)` | Creates a new HttpRequestData instance from ASP.NET-style request parameters. |
| `Create(string method, Uri url, IReadOnlyDictionary<string, string[]> headers, Stream body, IReadOnlyDictionary<string, string[]> query, IReadOnlyDictionary<string, string> cookies, string protocol, string contentType, long? contentLength)` | Creates a new HttpRequestData instance from raw request data. |


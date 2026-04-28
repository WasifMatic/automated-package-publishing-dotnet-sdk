
# Client Class Documentation

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| Environment | [`Environment`](../README.md#environments) | The API environment. <br> **Default: `Environment.Token`** |
| Timeout | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(100)` |
| HttpClientConfiguration | [`Action<HttpClientConfiguration.Builder>`](../doc/http-client-configuration-builder.md) | Action delegate that configures the HTTP client by using the HttpClientConfiguration.Builder for customizing API call settings.<br>*Default*: `new HttpClient()` |
| BasicAuthCredentials | [`BasicAuthCredentials`](auth/basic-authentication.md) | The Credentials Setter for Basic Authentication |
| OauthBearerTokenCredentials | [`OauthBearerTokenCredentials`](auth/oauth-2-bearer-token.md) | The Credentials Setter for OAuth 2 Bearer token |

The API client can be initialized as follows:

## Code-Based Initialization

```csharp
using SwiftBankingAPIPortal.Standard;
using SwiftBankingAPIPortal.Standard.Authentication;

namespace ConsoleApp;

SwiftBankingAPIPortalClient client = new SwiftBankingAPIPortalClient.Builder()
    .BasicAuthCredentials(
        new BasicAuthModel.Builder(
            "Username",
            "Password"
        )
        .Build())
    .OauthBearerTokenCredentials(
        new OauthBearerTokenModel.Builder(
            "AccessToken"
        )
        .Build())
    .HttpClientConfig(httpClientConfig =>
        httpClientConfig.Timeout(TimeSpan.FromSeconds(100)))
    .Environment(SwiftBankingAPIPortal.Standard.Environment.Token)
    .Build();
```

## Configuration-Based Initialization

```csharp
using SwiftBankingAPIPortal.Standard;
using Microsoft.Extensions.Configuration;

namespace ConsoleApp;

// Build the IConfiguration using .NET conventions (JSON, environment, etc.)
var configuration = new ConfigurationBuilder()
    .AddJsonFile("config.json")
    .AddEnvironmentVariables() // [optional] read environment variables
    .Build();

// Instantiate your SDK and configure it from IConfiguration
var client = SwiftBankingAPIPortalClient
    .FromConfiguration(configuration.GetSection("SwiftBankingAPIPortal"));
```

See the [Configuration-Based Initialization](../doc/configuration-based-initialization.md) section for details.

## Swift Banking API PortalClient Class

The gateway for the SDK. This class acts as a factory for the Controllers and also holds the configuration of the SDK.

### Controllers

| Name | Description |
|  --- | --- |
| AuthorizationController | Gets AuthorizationController controller. |
| AccountInformationController | Gets AccountInformationController controller. |
| ReportingController | Gets ReportingController controller. |

### Properties

| Name | Description | Type |
|  --- | --- | --- |
| HttpClientConfiguration | Gets the configuration of the Http Client associated with this client. | [`IHttpClientConfiguration`](../doc/http-client-configuration.md) |
| Timeout | Http client timeout. | `TimeSpan` |
| Environment | Current API environment. | `Environment` |
| BasicAuthCredentials | Gets the credentials to use with BasicAuth. | [`IBasicAuthCredentials`](auth/basic-authentication.md) |
| OauthBearerTokenCredentials | Gets the credentials to use with OauthBearerToken. | [`IOauthBearerTokenCredentials`](auth/oauth-2-bearer-token.md) |

### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `GetBaseUri(Server alias = Server.OAuthServer)` | Gets the URL for a particular alias in the current environment and appends it with template parameters. | `string` |
| `ToBuilder()` | Creates an object of the Swift Banking API PortalClient using the values provided for the builder. | `Builder` |

## Swift Banking API PortalClient Builder Class

Class to build instances of Swift Banking API PortalClient.

### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `HttpClientConfiguration(Action<`[`HttpClientConfiguration.Builder`](../doc/http-client-configuration-builder.md)`> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `BasicAuthCredentials(Action<BasicAuthModel.Builder> action)` | Sets credentials for BasicAuth. | `Builder` |
| `OauthBearerTokenCredentials(Action<OauthBearerTokenModel.Builder> action)` | Sets credentials for OauthBearerToken. | `Builder` |



# Getting Started with PayPal Server

## Introduction

### Important Notes

- **Available Features:** This SDK currently contains only 5 of PayPal's API endpoints. Additional endpoints and functionality will be added in the future.

### Information

The PayPal Server SDK provides integration access to the PayPal REST APIs. The API endpoints are divided into distinct controllers:

- Orders Controller: [Orders API v2](https://developer.paypal.com/docs/api/orders/v2/)
- Payments Controller: [Payments API v2](https://developer.paypal.com/docs/api/payments/v2)
- Vault Controller: [Payment Method Tokens API v3](https://developer.paypal.com/docs/api/payment-tokens/v3/) *Available in the US only.*
- Transaction Search Controller: [Transaction Search API v1](https://developer.paypal.com/docs/api/transaction-search/v1/)
- Subscriptions Controller: [Subscriptions API v1](https://developer.paypal.com/docs/api/subscriptions/v1/)

## Install the Package

If you are building with .NET CLI tools then you can also use the following command:

```bash
dotnet add package AutomatedPackagePublishingSDK --version 0.7.0
```

You can also view the package at:
https://www.nuget.org/packages/AutomatedPackagePublishingSDK/0.7.0

## Initialize the API Client

**_Note:_** Documentation for the client can be found [here.](doc/client.md)

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| Environment | [`Environment`](README.md#environments) | The API environment. <br> **Default: `Environment.Sandbox`** |
| Timeout | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(100)` |
| HttpClientConfiguration | [`Action<HttpClientConfiguration.Builder>`](doc/http-client-configuration-builder.md) | Action delegate that configures the HTTP client by using the HttpClientConfiguration.Builder for customizing API call settings.<br>*Default*: `new HttpClient()` |
| LogBuilder | [`LogBuilder`](doc/log-builder.md) | Represents the logging configuration builder for API calls |
| ClientCredentialsAuth | [`ClientCredentialsAuth`](doc/auth/oauth-2-client-credentials-grant.md) | The Credentials Setter for OAuth 2 Client Credentials Grant |

The API client can be initialized as follows:

### Code-Based Initialization

```csharp
using Microsoft.Extensions.Logging;
using PaypalServer.Standard;
using PaypalServer.Standard.Authentication;

namespace ConsoleApp;

PaypalServerClient client = new PaypalServerClient.Builder()
    .ClientCredentialsAuth(
        new ClientCredentialsAuthModel.Builder(
            "OAuthClientId",
            "OAuthClientSecret"
        )
        .Build())
    .HttpClientConfig(httpClientConfig =>
        httpClientConfig.Timeout(TimeSpan.FromSeconds(100)))
    .Environment(PaypalServer.Standard.Environment.Sandbox)
    .LoggingConfig(config => config
        .LogLevel(LogLevel.Information)
        .RequestConfig(reqConfig => reqConfig.Body(true))
        .ResponseConfig(respConfig => respConfig.Headers(true))
    )
    .Build();
```

### Configuration-Based Initialization

```csharp
using PaypalServer.Standard;
using Microsoft.Extensions.Configuration;

namespace ConsoleApp;

// Build the IConfiguration using .NET conventions (JSON, environment, etc.)
var configuration = new ConfigurationBuilder()
    .AddJsonFile("config.json")
    .AddEnvironmentVariables() // [optional] read environment variables
    .Build();

// Instantiate your SDK and configure it from IConfiguration
var client = PaypalServerClient
    .FromConfiguration(configuration.GetSection("PaypalServer"));
```

See the [Configuration-Based Initialization](doc/configuration-based-initialization.md) section for details.

## Environments

The SDK can be configured to use a different environment for making API calls. Available environments are:

### Fields

| Name | Description |
|  --- | --- |
| Sandbox | **Default** PayPal Sandbox Environment |

## Authorization

This API uses the following authentication schemes.

* [`Oauth2 (OAuth 2 Client Credentials Grant)`](doc/auth/oauth-2-client-credentials-grant.md)

## List of APIs

* [Orders](doc/controllers/orders.md)
* [Payments](doc/controllers/payments.md)
* [Vault](doc/controllers/vault.md)
* [Transaction Search](doc/controllers/transaction-search.md)
* [Subscriptions](doc/controllers/subscriptions.md)

## SDK Infrastructure

### Configuration

* [Configuration-Based Initialization](doc/configuration-based-initialization.md)
* [HttpClientConfiguration](doc/http-client-configuration.md)
* [HttpClientConfigurationBuilder](doc/http-client-configuration-builder.md)
* [LogBuilder](doc/log-builder.md)
* [LogRequestBuilder](doc/log-request-builder.md)
* [LogResponseBuilder](doc/log-response-builder.md)
* [ProxyConfigurationBuilder](doc/proxy-configuration-builder.md)

### HTTP

* [HttpCallback](doc/http-callback.md)
* [HttpContext](doc/http-context.md)
* [HttpRequest](doc/http-request.md)
* [HttpResponse](doc/http-response.md)
* [HttpStringResponse](doc/http-string-response.md)

### Utilities

* [ApiException](doc/api-exception.md)
* [ApiResponse](doc/api-response.md)
* [ApiHelper](doc/api-helper.md)
* [JsonObject](doc/json-object.md)
* [JsonValue](doc/json-value.md)


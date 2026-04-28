
# Getting Started with Swift Banking API Portal

## Introduction

The API is used by the consumer to generate a token for OAuth

## Install the Package

If you are building with .NET CLI tools then you can also use the following command:

```bash
dotnet add package AutomatedPackagePublishingSDK --version 9.0.0
```

You can also view the package at:
https://www.nuget.org/packages/AutomatedPackagePublishingSDK/9.0.0

## Test the SDK

The generated SDK also contain one or more Tests, which are contained in the Tests project. In order to invoke these test cases, you will need `NUnit 3.0 Test Adapter Extension` for Visual Studio. Once the SDK is complied, the test cases should appear in the Test Explorer window. Here, you can click `Run All` to execute these test cases.

## Initialize the API Client

**_Note:_** Documentation for the client can be found [here.](doc/client.md)

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| Environment | [`Environment`](README.md#environments) | The API environment. <br> **Default: `Environment.Token`** |
| Timeout | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(100)` |
| HttpClientConfiguration | [`Action<HttpClientConfiguration.Builder>`](doc/http-client-configuration-builder.md) | Action delegate that configures the HTTP client by using the HttpClientConfiguration.Builder for customizing API call settings.<br>*Default*: `new HttpClient()` |
| BasicAuthCredentials | [`BasicAuthCredentials`](doc/auth/basic-authentication.md) | The Credentials Setter for Basic Authentication |
| OauthBearerTokenCredentials | [`OauthBearerTokenCredentials`](doc/auth/oauth-2-bearer-token.md) | The Credentials Setter for OAuth 2 Bearer token |

The API client can be initialized as follows:

### Code-Based Initialization

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

### Configuration-Based Initialization

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

See the [Configuration-Based Initialization](doc/configuration-based-initialization.md) section for details.

## Environments

The SDK can be configured to use a different environment for making API calls. Available environments are:

### Fields

| Name | Description |
|  --- | --- |
| Token | **Default** |
| Production | - |
| Pilot | - |
| Sandbox | - |
| AutoMock | - |

## Authorization

This API uses the following authentication schemes.

* [`basicAuth (Basic Authentication)`](doc/auth/basic-authentication.md)
* [`oauthBearerToken (OAuth 2 Bearer token)`](doc/auth/oauth-2-bearer-token.md)

## List of APIs

* [Account Information](doc/controllers/account-information.md)
* [Authorization](doc/controllers/authorization.md)
* [Reporting](doc/controllers/reporting.md)

## SDK Infrastructure

### Configuration

* [Configuration-Based Initialization](doc/configuration-based-initialization.md)
* [HttpClientConfiguration](doc/http-client-configuration.md)
* [HttpClientConfigurationBuilder](doc/http-client-configuration-builder.md)
* [ProxyConfigurationBuilder](doc/proxy-configuration-builder.md)

### HTTP

* [HttpCallback](doc/http-callback.md)
* [HttpContext](doc/http-context.md)
* [HttpRequest](doc/http-request.md)
* [HttpResponse](doc/http-response.md)
* [HttpStringResponse](doc/http-string-response.md)

### Utilities

* [ApiException](doc/api-exception.md)
* [ApiHelper](doc/api-helper.md)


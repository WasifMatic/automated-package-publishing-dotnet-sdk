
# Getting Started with Univapay Public API

## Introduction

OpenAPI specification for the Univapay Online Payment API.

### Authentication (JWT)

This API uses JWT (JSON Web Tokens) for authentication via the HTTP `Authorization` header. To authenticate, you must generate an **Application Token** in the Univapay dashboard.  This generates two components: 1. **Token (`{jwt}`)** 2. **Secret (`{secret}`)**

#### ⚠️ Security Warning

The **Secret** grants extensive privileges (e.g., creating charges, capturing authorized card charges, refunding).
**NEVER expose the `{secret}` in frontend application code** (e.g., consumer browsers) or public repositories. It is strictly for backend server-to-server communication.
*Univapay is not responsible for accidents caused by leaked secrets.*

#### Bearer Auth Formats

Depending on where you are calling the API from, the Bearer format changes:

* **Frontend / Browser (No Secret)**: `Bearer {jwt}`
  *(Used for Widgets or Inline Forms. You must register your allowed domains in the dashboard when creating the token).*
* **Backend / Server (With Secret)**: `Bearer {secret}.{jwt}`
  *(Required for all backend processing).*

We will assume that all requests are going to originate from a backend server thus, all requests will require the secret

#### Token Types

* **Store Token**: Grants full access to requests for that specific store.
* **Merchant Token**: Can't create transaction tokens but can access data from multiple stores.

## Install the Package

If you are building with .NET CLI tools then you can also use the following command:

```bash
dotnet add package AutomatedPackagePublishingSDK --version 9.1.0
```

You can also view the package at:
https://www.nuget.org/packages/AutomatedPackagePublishingSDK/9.1.0

## Test the SDK

The generated SDK also contain one or more Tests, which are contained in the Tests project. In order to invoke these test cases, you will need `NUnit 3.0 Test Adapter Extension` for Visual Studio. Once the SDK is complied, the test cases should appear in the Test Explorer window. Here, you can click `Run All` to execute these test cases.

## Initialize the API Client

**_Note:_** Documentation for the client can be found [here.](doc/client.md)

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| BaseUrl | `string` | Base URL for the API<br>*Default*: `"https://api.univapay.com"` |
| Environment | [`Environment`](README.md#environments) | The API environment. <br> **Default: `Environment.Production`** |
| Timeout | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(30)` |
| HttpClientConfiguration | [`Action<HttpClientConfiguration.Builder>`](doc/http-client-configuration-builder.md) | Action delegate that configures the HTTP client by using the HttpClientConfiguration.Builder for customizing API call settings.<br>*Default*: `new HttpClient()` |
| LogBuilder | [`LogBuilder`](doc/log-builder.md) | Represents the logging configuration builder for API calls |
| BearerAuthCredentials | [`BearerAuthCredentials`](doc/auth/oauth-2-bearer-token.md) | The Credentials Setter for OAuth 2 Bearer token |

The API client can be initialized as follows:

### Code-Based Initialization

```csharp
using Microsoft.Extensions.Logging;
using UnivaPay;
using UnivaPay.Authentication;

namespace ConsoleApp;

UnivapayClientSdkClient client = new UnivapayClientSdkClient.Builder()
    .BearerAuthCredentials(
        new BearerAuthModel.Builder(
            "AccessToken"
        )
        .Build())
    .HttpClientConfig(httpClientConfig =>
        httpClientConfig.Timeout(TimeSpan.FromSeconds(100)))
    .Environment(UnivaPay.Environment.Production)
    .BaseUrl("https://api.univapay.com")
    .LoggingConfig(config => config
        .LogLevel(LogLevel.Information)
        .RequestConfig(reqConfig => reqConfig.Body(true))
        .ResponseConfig(respConfig => respConfig.Headers(true))
    )
    .Build();
```

### Configuration-Based Initialization

```csharp
using UnivaPay;
using Microsoft.Extensions.Configuration;

namespace ConsoleApp;

// Build the IConfiguration using .NET conventions (JSON, environment, etc.)
var configuration = new ConfigurationBuilder()
    .AddJsonFile("config.json")
    .AddEnvironmentVariables() // [optional] read environment variables
    .Build();

// Instantiate your SDK and configure it from IConfiguration
var client = UnivapayClientSdkClient
    .FromConfiguration(configuration.GetSection("UnivapayClientSdk"));
```

See the [Configuration-Based Initialization](doc/configuration-based-initialization.md) section for details.

## Environments

The SDK can be configured to use a different environment for making API calls. Available environments are:

### Fields

| Name | Description |
|  --- | --- |
| Production | **Default** Production Server |

## Authorization

This API uses the following authentication schemes.

* [`JWT_TOKEN (OAuth 2 Bearer token)`](doc/auth/oauth-2-bearer-token.md)

## List of APIs

* [Transaction Tokens](doc/controllers/transaction-tokens.md)
* [Charges](doc/controllers/charges.md)
* [Refunds](doc/controllers/refunds.md)
* [Subscriptions](doc/controllers/subscriptions.md)
* [Cancels](doc/controllers/cancels.md)
* [Merchants](doc/controllers/merchants.md)
* [Stores](doc/controllers/stores.md)
* [Webhooks](doc/controllers/webhooks.md)

## Webhooks

* [Charge](doc/events/webhooks/charge-handler.md)
* [Token](doc/events/webhooks/token-handler.md)
* [Refund](doc/events/webhooks/refund-handler.md)
* [Cancel](doc/events/webhooks/cancel-handler.md)
* [Subscription](doc/events/webhooks/subscription-handler.md)
* [Bank-Transfer](doc/events/webhooks/bank-transfer-handler.md)
* [Customs](doc/events/webhooks/customs-handler.md)

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
* [HttpRequestData](doc/http-request-data.md)
* [HttpResponse](doc/http-response.md)
* [HttpStringResponse](doc/http-string-response.md)

### Utilities

* [ApiException](doc/api-exception.md)
* [ApiResponse](doc/api-response.md)
* [ApiHelper](doc/api-helper.md)
* [CustomDateTimeConverter](doc/custom-date-time-converter.md)
* [UnixDateTimeConverter](doc/unix-date-time-converter.md)


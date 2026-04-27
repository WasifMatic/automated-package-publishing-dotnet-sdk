
# Getting Started with APIMATIC Calculator

## Introduction

Simple calculator API hosted on APIMATIC

## Install the Package

If you are building with .NET CLI tools then you can also use the following command:

```bash
dotnet add package AutomatedPackagePublishingSDK --version 10.0.0
```

You can also view the package at:
https://www.nuget.org/packages/AutomatedPackagePublishingSDK/10.0.0

## Initialize the API Client

**_Note:_** Documentation for the client can be found [here.](https://www.github.com/WasifMatic/automated-package-publishing-dotnet-sdk/tree/10.0.0/doc/client.md)

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| Timeout | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(100)` |
| HttpClientConfiguration | [`Action<HttpClientConfiguration.Builder>`](https://www.github.com/WasifMatic/automated-package-publishing-dotnet-sdk/tree/10.0.0/doc/http-client-configuration-builder.md) | Action delegate that configures the HTTP client by using the HttpClientConfiguration.Builder for customizing API call settings.<br>*Default*: `new HttpClient()` |

The API client can be initialized as follows:

### Code-Based Initialization

```csharp
using APIMATICCalculator.Standard;

namespace ConsoleApp;

APIMATICCalculatorClient client = new APIMATICCalculatorClient.Builder()
    .HttpClientConfig(httpClientConfig =>
        httpClientConfig.Timeout(TimeSpan.FromSeconds(100)))
    .Build();
```

### Configuration-Based Initialization

```csharp
using APIMATICCalculator.Standard;
using Microsoft.Extensions.Configuration;

namespace ConsoleApp;

// Build the IConfiguration using .NET conventions (JSON, environment, etc.)
var configuration = new ConfigurationBuilder()
    .AddJsonFile("config.json")
    .AddEnvironmentVariables() // [optional] read environment variables
    .Build();

// Instantiate your SDK and configure it from IConfiguration
var client = APIMATICCalculatorClient
    .FromConfiguration(configuration.GetSection("APIMATICCalculator"));
```

See the [Configuration-Based Initialization](https://www.github.com/WasifMatic/automated-package-publishing-dotnet-sdk/tree/10.0.0/doc/configuration-based-initialization.md) section for details.

## List of APIs

* [Simple Calculator](https://www.github.com/WasifMatic/automated-package-publishing-dotnet-sdk/tree/10.0.0/doc/controllers/simple-calculator.md)

## SDK Infrastructure

### Configuration

* [Configuration-Based Initialization](https://www.github.com/WasifMatic/automated-package-publishing-dotnet-sdk/tree/10.0.0/doc/configuration-based-initialization.md)
* [HttpClientConfiguration](https://www.github.com/WasifMatic/automated-package-publishing-dotnet-sdk/tree/10.0.0/doc/http-client-configuration.md)
* [HttpClientConfigurationBuilder](https://www.github.com/WasifMatic/automated-package-publishing-dotnet-sdk/tree/10.0.0/doc/http-client-configuration-builder.md)
* [ProxyConfigurationBuilder](https://www.github.com/WasifMatic/automated-package-publishing-dotnet-sdk/tree/10.0.0/doc/proxy-configuration-builder.md)

### HTTP

* [HttpCallback](https://www.github.com/WasifMatic/automated-package-publishing-dotnet-sdk/tree/10.0.0/doc/http-callback.md)
* [HttpContext](https://www.github.com/WasifMatic/automated-package-publishing-dotnet-sdk/tree/10.0.0/doc/http-context.md)
* [HttpRequest](https://www.github.com/WasifMatic/automated-package-publishing-dotnet-sdk/tree/10.0.0/doc/http-request.md)
* [HttpResponse](https://www.github.com/WasifMatic/automated-package-publishing-dotnet-sdk/tree/10.0.0/doc/http-response.md)
* [HttpStringResponse](https://www.github.com/WasifMatic/automated-package-publishing-dotnet-sdk/tree/10.0.0/doc/http-string-response.md)

### Utilities

* [ApiException](https://www.github.com/WasifMatic/automated-package-publishing-dotnet-sdk/tree/10.0.0/doc/api-exception.md)
* [ApiHelper](https://www.github.com/WasifMatic/automated-package-publishing-dotnet-sdk/tree/10.0.0/doc/api-helper.md)


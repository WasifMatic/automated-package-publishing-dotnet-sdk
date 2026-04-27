
# Getting Started with Swagger Petstore - OpenAPI 3.1

## Introduction

This is a sample Pet Store Server based on the OpenAPI 3.1 specification.  You can find out more about
Swagger at [https://swagger.io](https://swagger.io). In the third iteration of the pet store, we've switched to the design first approach!
You can now help us improve the API whether it's by making changes to the definition itself or to the code.
That way, with time, we can improve the API in general, and expose some of the new features in OAS3.

Some useful links:

- [The Pet Store repository](https://github.com/swagger-api/swagger-petstore)
- [The source API definition for the Pet Store](https://github.com/swagger-api/swagger-petstore/blob/master/src/main/resources/openapi.yaml)

Find out more about Swagger: [https://swagger.io](https://swagger.io)

## Building

The generated code uses the Newtonsoft Json.NET NuGet Package. If the automatic NuGet package restore is enabled, these dependencies will be installed automatically. Therefore, you will need internet access for build.

* Open the solution (SwaggerPetstoreOpenApi31.sln) file.

Invoke the build process using Ctrl + Shift + B shortcut key or using the Build menu as shown below.

The build process generates a portable class library, which can be used like a normal class library. More information on how to use can be found at the MSDN Portable Class Libraries documentation.

The supported version is **.NET Standard 2.0**. For checking compatibility of your .NET implementation with the generated library, [click here](https://dotnet.microsoft.com/en-us/platform/dotnet-standard#versions).

## Installation

The following section explains how to use the SwaggerPetstoreOpenApi31.Standard library in a new project.

### 1. Starting a new project

For starting a new project, right click on the current solution from the solution explorer and choose `Add -> New Project`.

![Add a new project in Visual Studio](https://apidocs.io/illustration/cs?workspaceFolder=Swagger%20Petstore%20-%20OpenAPI%203.1-CSharp&workspaceName=SwaggerPetstoreOpenApi31&projectName=SwaggerPetstoreOpenApi31.Standard&rootNamespace=SwaggerPetstoreOpenApi31.Standard&step=addProject)

Next, choose `Console Application`, provide `TestConsoleProject` as the project name and click OK.

![Create a new Console Application in Visual Studio](https://apidocs.io/illustration/cs?workspaceFolder=Swagger%20Petstore%20-%20OpenAPI%203.1-CSharp&workspaceName=SwaggerPetstoreOpenApi31&projectName=SwaggerPetstoreOpenApi31.Standard&rootNamespace=SwaggerPetstoreOpenApi31.Standard&step=createProject)

### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the `TestConsoleProject` as the start-up project. To do this, right-click on the `TestConsoleProject` and choose `Set as StartUp Project` form the context menu.

![Adding a project reference](https://apidocs.io/illustration/cs?workspaceFolder=Swagger%20Petstore%20-%20OpenAPI%203.1-CSharp&workspaceName=SwaggerPetstoreOpenApi31&projectName=SwaggerPetstoreOpenApi31.Standard&rootNamespace=SwaggerPetstoreOpenApi31.Standard&step=setStartup)

### 3. Add reference of the library project

In order to use the `SwaggerPetstoreOpenApi31.Standard` library in the new project, first we must add a project reference to the `TestConsoleProject`. First, right click on the `References` node in the solution explorer and click `Add Reference...`

![Adding a project reference](https://apidocs.io/illustration/cs?workspaceFolder=Swagger%20Petstore%20-%20OpenAPI%203.1-CSharp&workspaceName=SwaggerPetstoreOpenApi31&projectName=SwaggerPetstoreOpenApi31.Standard&rootNamespace=SwaggerPetstoreOpenApi31.Standard&step=addReference)

Next, a window will be displayed where we must set the `checkbox` on `SwaggerPetstoreOpenApi31.Standard` and click `OK`. By doing this, we have added a reference of the `SwaggerPetstoreOpenApi31.Standard` project into the new `TestConsoleProject`.

![Creating a project reference](https://apidocs.io/illustration/cs?workspaceFolder=Swagger%20Petstore%20-%20OpenAPI%203.1-CSharp&workspaceName=SwaggerPetstoreOpenApi31&projectName=SwaggerPetstoreOpenApi31.Standard&rootNamespace=SwaggerPetstoreOpenApi31.Standard&step=createReference)

### 4. Write sample code

Once the `TestConsoleProject` is created, a file named `Program.cs` will be visible in the solution explorer with an empty `Main` method. This is the entry point for the execution of the entire solution. Here, you can add code to initialize the client library and acquire the instance of a Api class. Sample code to initialize the client library and using Api methods is given in the subsequent sections.

![Adding a project reference](https://apidocs.io/illustration/cs?workspaceFolder=Swagger%20Petstore%20-%20OpenAPI%203.1-CSharp&workspaceName=SwaggerPetstoreOpenApi31&projectName=SwaggerPetstoreOpenApi31.Standard&rootNamespace=SwaggerPetstoreOpenApi31.Standard&step=addCode)

## Initialize the API Client

**_Note:_** Documentation for the client can be found [here.](doc/client.md)

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| Environment | [`Environment`](README.md#environments) | The API environment. <br> **Default: `Environment.Production`** |
| Timeout | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(30)` |
| HttpClientConfiguration | [`Action<HttpClientConfiguration.Builder>`](doc/http-client-configuration-builder.md) | Action delegate that configures the HTTP client by using the HttpClientConfiguration.Builder for customizing API call settings.<br>*Default*: `new HttpClient()` |
| LogBuilder | [`LogBuilder`](doc/log-builder.md) | Represents the logging configuration builder for API calls |
| PetstoreAuthCredentials | [`PetstoreAuthCredentials`](doc/auth/oauth-2-implicit-grant.md) | The Credentials Setter for OAuth 2 Implicit Grant |
| ApiKeyCredentials | [`ApiKeyCredentials`](doc/auth/custom-header-signature.md) | The Credentials Setter for Custom Header Signature |

The API client can be initialized as follows:

### Code-Based Initialization

```csharp
using Microsoft.Extensions.Logging;
using SwaggerPetstoreOpenApi31.Standard;
using SwaggerPetstoreOpenApi31.Standard.Authentication;
using SwaggerPetstoreOpenApi31.Standard.Models;
using System.Collections.Generic;

namespace ConsoleApp;

SwaggerPetstoreOpenApi31Client client = new SwaggerPetstoreOpenApi31Client.Builder()
    .PetstoreAuthCredentials(
        new PetstoreAuthModel.Builder(
            "OAuthClientId",
            "OAuthRedirectUri"
        )
        .OauthScopes(
            new List<OauthScopePetstoreAuth>
            {
                OauthScopePetstoreAuth.Writepets,
                OauthScopePetstoreAuth.Readpets,
            })
        .Build())
    .ApiKeyCredentials(
        new ApiKeyModel.Builder(
            "api_key"
        )
        .Build())
    .HttpClientConfig(httpClientConfig =>
        httpClientConfig.Timeout(TimeSpan.FromSeconds(100)))
    .Environment(SwaggerPetstoreOpenApi31.Standard.Environment.Production)
    .LoggingConfig(config => config
        .LogLevel(LogLevel.Information)
        .RequestConfig(reqConfig => reqConfig.Body(true))
        .ResponseConfig(respConfig => respConfig.Headers(true))
    )
    .Build();
```

### Configuration-Based Initialization

```csharp
using SwaggerPetstoreOpenApi31.Standard;
using Microsoft.Extensions.Configuration;

namespace ConsoleApp;

// Build the IConfiguration using .NET conventions (JSON, environment, etc.)
var configuration = new ConfigurationBuilder()
    .AddJsonFile("config.json")
    .AddEnvironmentVariables() // [optional] read environment variables
    .Build();

// Instantiate your SDK and configure it from IConfiguration
var client = SwaggerPetstoreOpenApi31Client
    .FromConfiguration(configuration.GetSection("SwaggerPetstoreOpenApi31"));
```

See the [Configuration-Based Initialization](doc/configuration-based-initialization.md) section for details.

## Environments

The SDK can be configured to use a different environment for making API calls. Available environments are:

### Fields

| Name | Description |
|  --- | --- |
| Production | **Default** |

## Authorization

This API uses the following authentication schemes.

* [`petstore_auth (OAuth 2 Implicit Grant)`](doc/auth/oauth-2-implicit-grant.md)
* [`api_key (Custom Header Signature)`](doc/auth/custom-header-signature.md)

## List of APIs

* [Pet](doc/controllers/pet.md)
* [Store](doc/controllers/store.md)
* [User](doc/controllers/user.md)

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
* [CustomDateTimeConverter](doc/custom-date-time-converter.md)
* [UnixDateTimeConverter](doc/unix-date-time-converter.md)


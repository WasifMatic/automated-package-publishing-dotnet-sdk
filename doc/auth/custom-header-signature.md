
# Custom Header Signature



Documentation for accessing and setting credentials for api_key.

## Auth Credentials

| Name | Type | Description | Setter | Getter |
|  --- | --- | --- | --- | --- |
| ApiKey | `string` | - | `ApiKey` | `ApiKey` |



**Note:** Auth credentials can be set using `ApiKeyCredentials` in the client builder and accessed through `ApiKeyCredentials` method in the client instance.

## Usage Example

### Client Initialization

You must provide credentials in the client as shown in the following code snippet.

```csharp
using SwaggerPetstoreOpenAPI310.Standard;
using SwaggerPetstoreOpenAPI310.Standard.Authentication;

namespace ConsoleApp;

SwaggerPetstoreOpenAPI310Client client = new SwaggerPetstoreOpenAPI310Client.Builder()
    .ApiKeyCredentials(
        new ApiKeyModel.Builder(
            "api_key"
        )
        .Build())
    .Build();
```



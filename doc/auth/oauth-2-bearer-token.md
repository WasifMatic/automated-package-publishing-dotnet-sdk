
# OAuth 2 Bearer token



Documentation for accessing and setting credentials for JWT_TOKEN.

## Auth Credentials

| Name | Type | Description | Setter | Getter |
|  --- | --- | --- | --- | --- |
| AccessToken | `string` | The OAuth 2.0 Access Token to use for API requests. | `AccessToken` | `AccessToken` |



**Note:** Auth credentials can be set using `BearerAuthCredentials` in the client builder and accessed through `BearerAuthCredentials` method in the client instance.

## Usage Example

### Client Initialization

You must provide credentials in the client as shown in the following code snippet.

```csharp
using UnivaPay;
using UnivaPay.Authentication;

namespace ConsoleApp;

UnivapayClientSdkClient client = new UnivapayClientSdkClient.Builder()
    .BearerAuthCredentials(
        new BearerAuthModel.Builder(
            "AccessToken"
        )
        .Build())
    .Build();
```



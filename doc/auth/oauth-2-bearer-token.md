
# OAuth 2 Bearer token



Documentation for accessing and setting credentials for oauthBearerToken.

## Auth Credentials

| Name | Type | Description | Setter | Getter |
|  --- | --- | --- | --- | --- |
| AccessToken | `string` | The OAuth 2.0 Access Token to use for API requests. | `AccessToken` | `AccessToken` |



**Note:** Auth credentials can be set using `OauthBearerTokenCredentials` in the client builder and accessed through `OauthBearerTokenCredentials` method in the client instance.

## Usage Example

### Client Initialization

You must provide credentials in the client as shown in the following code snippet.

```csharp
using SwiftBankingAPIPortal.Standard;
using SwiftBankingAPIPortal.Standard.Authentication;

namespace ConsoleApp;

SwiftBankingAPIPortalClient client = new SwiftBankingAPIPortalClient.Builder()
    .OauthBearerTokenCredentials(
        new OauthBearerTokenModel.Builder(
            "AccessToken"
        )
        .Build())
    .Build();
```



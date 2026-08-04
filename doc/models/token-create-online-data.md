
# Token Create Online Data

Token Create Online Data schema.

*This model accepts additional fields of type object.*

## Structure

`TokenCreateOnlineData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Brand` | [`BaseOnlineDataBrand`](../../doc/models/base-online-data-brand.md) | Required | Base Online Data Brand schema. |
| `CallMethod` | [`BaseOnlineDataCallMethod`](../../doc/models/base-online-data-call-method.md) | Required | Base Online Data Call Method schema. |
| `OsType` | [`BaseOnlineDataOsType?`](../../doc/models/base-online-data-os-type.md) | Optional | Base Online Data Os Type schema. |
| `UserIdentifier` | `string` | Optional | Consumer specific identifier required by some gateways for fraud prevention. |
| `UserIdentifierSource` | [`BaseOnlineDataUserIdentifierSource?`](../../doc/models/base-online-data-user-identifier-source.md) | Optional | The source of the user identifier |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

TokenCreateOnlineData tokenCreateOnlineData = new TokenCreateOnlineData
{
    Brand = BaseOnlineDataBrand.WeChatOnline,
    CallMethod = BaseOnlineDataCallMethod.Web,
    OsType = BaseOnlineDataOsType.Android,
    UserIdentifier = "wechat_open_id_12345",
    UserIdentifierSource = BaseOnlineDataUserIdentifierSource.Provided,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


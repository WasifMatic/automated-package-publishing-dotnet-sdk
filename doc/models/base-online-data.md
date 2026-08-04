
# Base Online Data

Base Online Data schema.

*This model accepts additional fields of type object.*

## Structure

`BaseOnlineData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Brand` | [`BaseOnlineDataBrand?`](../../doc/models/base-online-data-brand.md) | Optional | Base Online Data Brand schema. |
| `CallMethod` | [`BaseOnlineDataCallMethod?`](../../doc/models/base-online-data-call-method.md) | Optional | Base Online Data Call Method schema. |
| `OsType` | [`BaseOnlineDataOsType?`](../../doc/models/base-online-data-os-type.md) | Optional | Base Online Data Os Type schema. |
| `UserIdentifier` | `string` | Optional | Consumer specific identifier required by some gateways for fraud prevention. |
| `UserIdentifierSource` | [`BaseOnlineDataUserIdentifierSource?`](../../doc/models/base-online-data-user-identifier-source.md) | Optional | The source of the user identifier |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

BaseOnlineData baseOnlineData = new BaseOnlineData
{
    Brand = BaseOnlineDataBrand.PayPayOnline,
    CallMethod = BaseOnlineDataCallMethod.Web,
    OsType = BaseOnlineDataOsType.Android,
    UserIdentifier = "user_identifier4",
    UserIdentifierSource = BaseOnlineDataUserIdentifierSource.Provided,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


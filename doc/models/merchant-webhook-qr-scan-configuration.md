
# Merchant Webhook Qr Scan Configuration

QR scan payment settings.

*This model accepts additional fields of type object.*

## Structure

`MerchantWebhookQrScanConfiguration`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Enabled` | `bool?` | Optional | Enables QR scan payments. |
| `ForbiddenQrScanGateways` | `List<string>` | Optional | QR scan gateways disabled for the merchant. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using System.Collections.Generic;
using UnivaPay.Models;
using UnivaPay.Utilities;

MerchantWebhookQrScanConfiguration merchantWebhookQrScanConfiguration = new MerchantWebhookQrScanConfiguration
{
    Enabled = true,
    ForbiddenQrScanGateways = new List<string>
    {
        "wechat",
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


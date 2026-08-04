
# Merchant Webhook Bank Transfer Configuration

Bank transfer payment settings.

*This model accepts additional fields of type object.*

## Structure

`MerchantWebhookBankTransferConfiguration`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Enabled` | `bool?` | Optional | Enables bank transfer payments. |
| `MatchAmount` | `bool?` | Optional | Requires the received deposit amount to exactly match the charge amount. |
| `Expiration` | `string` | Optional | ISO-8601 duration before the charge expires. |
| `VirtualBankAccountsThreshold` | `int?` | Optional | Threshold for provisioning additional virtual bank accounts. |
| `VirtualBankAccountsFetchCount` | `int?` | Optional | Number of virtual bank accounts fetched per replenishment batch. |
| `DefaultExtensionPeriod` | `string` | Optional | Default ISO-8601 extension period applied to eligible charges. |
| `MaximumExtensionPeriod` | `string` | Optional | Maximum ISO-8601 extension period allowed for a charge. |
| `AutomaticExtensionEnabled` | `bool?` | Optional | Automatically extends eligible bank transfer charges. |
| `ChargeRequestNotificationEnabled` | `bool?` | Optional | Sends notifications when a bank transfer charge is created. |
| `ChargeRequestCanceledNotificationEnabled` | `bool?` | Optional | Sends notifications when a bank transfer charge is canceled. |
| `ChargeExpiredNotificationEnabled` | `bool?` | Optional | Sends notifications when a bank transfer charge expires. |
| `DepositReceivedNotificationEnabled` | `bool?` | Optional | Sends notifications when a deposit is received. |
| `DepositInsufficientNotificationEnabled` | `bool?` | Optional | Sends notifications when a deposit is below the expected amount. |
| `DepositExceededNotificationEnabled` | `bool?` | Optional | Sends notifications when a deposit exceeds the expected amount. |
| `ExtensionNotificationEnabled` | `bool?` | Optional | Sends notifications when a bank transfer charge is extended. |
| `RemindNotificationPeriod` | `string` | Optional | ISO-8601 lead time for payment reminder notifications. |
| `RemindNotificationEnabled` | `bool?` | Optional | Sends reminder notifications before bank transfer expiry. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

MerchantWebhookBankTransferConfiguration merchantWebhookBankTransferConfiguration = new MerchantWebhookBankTransferConfiguration
{
    Enabled = true,
    MatchAmount = true,
    Expiration = "P7D",
    VirtualBankAccountsThreshold = 50,
    VirtualBankAccountsFetchCount = 25,
    DefaultExtensionPeriod = "P3D",
    MaximumExtensionPeriod = "P30D",
    AutomaticExtensionEnabled = true,
    ChargeRequestNotificationEnabled = true,
    DepositReceivedNotificationEnabled = true,
    RemindNotificationPeriod = "P2D",
    RemindNotificationEnabled = true,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


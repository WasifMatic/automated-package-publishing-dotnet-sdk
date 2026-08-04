
# Merchant

Merchant resource returned by the backend `FullMerchantWithGroupRoles` formatter for merchant-authenticated callers.

*This model accepts additional fields of type object.*

## Structure

`Merchant`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `Guid?` | Optional | Merchant identifier. |
| `VerificationDataId` | `Guid?` | Optional | Verification data identifier associated with the merchant. |
| `Name` | `string` | Optional | Merchant display name. |
| `Email` | `string` | Optional | Primary merchant email address. |
| `NotificationEmail` | `string` | Optional | Merchant notification email address. |
| `FinanceNotificationEmail` | `string` | Optional | Merchant finance notification email address. |
| `Verified` | `bool?` | Optional | Whether the merchant has completed verification. |
| `Configuration` | [`MerchantWebhookConfiguration`](../../doc/models/merchant-webhook-configuration.md) | Optional | Merchant configuration snapshot serialized by gyron-payments-api. |
| `CreatedOn` | `DateTime?` | Optional | Timestamp when the merchant was created. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using System.Collections.Generic;
using System.Globalization;
using UnivaPay.Models;
using UnivaPay.Utilities;

Merchant merchant = new Merchant
{
    Id = new Guid("11ef0000-0000-4000-8000-000000000020"),
    VerificationDataId = new Guid("11ef0000-0000-4000-8000-000000000021"),
    Name = "Example Merchant",
    Email = "owner@example.com",
    NotificationEmail = "alerts@example.com",
    FinanceNotificationEmail = "finance@example.com",
    Verified = true,
    Configuration = new MerchantWebhookConfiguration
    {
        PercentFee = 3.6,
        Country = "JP",
        Language = "ja",
        MinimumChargeAmounts = new List<MerchantWebhookMoneyAmount>
        {
            new MerchantWebhookMoneyAmount
            {
                Amount = 100,
                Currency = "JPY",
            },
        },
        MaximumChargeAmounts = new List<MerchantWebhookMoneyAmount>
        {
            new MerchantWebhookMoneyAmount
            {
                Amount = 100000,
                Currency = "JPY",
            },
        },
        UserTransactionsConfiguration = new MerchantWebhookUserTransactionsConfiguration
        {
            Enabled = true,
            NotifyCustomer = true,
            NotifyOnWebhookFailure = true,
        },
        CardConfiguration = new MerchantWebhookCardConfiguration
        {
            Enabled = true,
            DebitEnabled = true,
            PrepaidEnabled = false,
            ThreeDsRequired = true,
        },
        OnlineConfiguration = new MerchantWebhookOnlineConfiguration
        {
            Enabled = true,
        },
        BankTransferConfiguration = new MerchantWebhookBankTransferConfiguration
        {
            Enabled = true,
            MatchAmount = true,
            Expiration = "P7D",
        },
    },
    CreatedOn = DateTime.ParseExact("2026-04-09T07:35:50.000000Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


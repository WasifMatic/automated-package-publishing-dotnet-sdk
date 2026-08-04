
# Merchant Webhook Configuration

Merchant configuration object serialized by gyron-payments-api.

*This model accepts additional fields of type object.*

## Structure

`MerchantWebhookConfiguration`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PercentFee` | `double?` | Optional | Default percent fee applied when no card-brand override exists. |
| `FlatFees` | [`List<MerchantWebhookMoneyAmount>`](../../doc/models/merchant-webhook-money-amount.md) | Optional | Flat fee overrides by currency. |
| `LogoUrl` | `string` | Optional | Merchant logo URL. |
| `Country` | `string` | Optional | Merchant country code. |
| `Language` | `string` | Optional | Merchant default language. |
| `DisplayTimeZone` | `string` | Optional | Merchant display time zone. |
| `MinTransferPayout` | [`MerchantWebhookMoneyAmount`](../../doc/models/merchant-webhook-money-amount.md) | Optional | Monetary amount object serialized by backend config models. |
| `MinimumChargeAmounts` | [`List<MerchantWebhookMoneyAmount>`](../../doc/models/merchant-webhook-money-amount.md) | Optional | Minimum allowed charge amounts by currency. |
| `MaximumChargeAmounts` | [`List<MerchantWebhookMoneyAmount>`](../../doc/models/merchant-webhook-money-amount.md) | Optional | Maximum allowed charge amounts by currency. |
| `TransferSchedule` | [`MerchantWebhookTransferScheduleConfiguration`](../../doc/models/merchant-webhook-transfer-schedule-configuration.md) | Optional | Transfer schedule configuration inherited by the merchant. |
| `UserTransactionsConfiguration` | [`MerchantWebhookUserTransactionsConfiguration`](../../doc/models/merchant-webhook-user-transactions-configuration.md) | Optional | Merchant transaction notification settings. |
| `RecurringTokenConfiguration` | [`MerchantWebhookRecurringTokenConfiguration`](../../doc/models/merchant-webhook-recurring-token-configuration.md) | Optional | Recurring token configuration inherited by the merchant. |
| `SecurityConfiguration` | [`MerchantWebhookSecurityConfiguration`](../../doc/models/merchant-webhook-security-configuration.md) | Optional | Merchant-level fraud and refund safety settings. |
| `CheckoutConfiguration` | [`MerchantWebhookCheckoutConfiguration`](../../doc/models/merchant-webhook-checkout-configuration.md) | Optional | Checkout field collection settings. |
| `InstallmentsConfiguration` | [`MerchantWebhookInstallmentPlanConfiguration`](../../doc/models/merchant-webhook-installment-plan-configuration.md) | Optional | Installment plan configuration. |
| `SubscriptionPlanConfiguration` | [`MerchantWebhookSubscriptionPlanConfiguration`](../../doc/models/merchant-webhook-subscription-plan-configuration.md) | Optional | Subscription plan configuration. |
| `CardBrandPercentFees` | [`MerchantWebhookCardBrandPercentFees`](../../doc/models/merchant-webhook-card-brand-percent-fees.md) | Optional | Per-card-brand percent fee overrides. |
| `SubscriptionConfiguration` | [`MerchantWebhookSubscriptionConfiguration`](../../doc/models/merchant-webhook-subscription-configuration.md) | Optional | Subscription feature configuration. |
| `CustomerManagementConfiguration` | [`MerchantWebhookCustomerManagementConfiguration`](../../doc/models/merchant-webhook-customer-management-configuration.md) | Optional | Customer-management defaults. |
| `DescriptorProvidedConfiguration` | `bool?` | Optional | Whether statement descriptors can be provided by merchants. |
| `CardConfiguration` | [`MerchantWebhookCardConfiguration`](../../doc/models/merchant-webhook-card-configuration.md) | Optional | Card payment settings. |
| `QrScanConfiguration` | [`MerchantWebhookQrScanConfiguration`](../../doc/models/merchant-webhook-qr-scan-configuration.md) | Optional | QR scan payment settings. |
| `ConvenienceConfiguration` | [`MerchantWebhookConvenienceConfiguration`](../../doc/models/merchant-webhook-convenience-configuration.md) | Optional | Convenience-store payment settings. |
| `PaidyConfiguration` | [`MerchantWebhookPaidyConfiguration`](../../doc/models/merchant-webhook-paidy-configuration.md) | Optional | Paidy payment settings. |
| `QrMerchantConfiguration` | [`MerchantWebhookQrMerchantConfiguration`](../../doc/models/merchant-webhook-qr-merchant-configuration.md) | Optional | QR merchant payment settings. |
| `OnlineConfiguration` | [`MerchantWebhookOnlineConfiguration`](../../doc/models/merchant-webhook-online-configuration.md) | Optional | Online payment settings. |
| `BankTransferConfiguration` | [`MerchantWebhookBankTransferConfiguration`](../../doc/models/merchant-webhook-bank-transfer-configuration.md) | Optional | Bank transfer payment settings. |
| `PlatformCredentialsEnabled` | `bool?` | Optional | Whether platform credentials are enabled. |
| `TaggedPlatformCredentialsEnabled` | `bool?` | Optional | Whether tagged platform credentials are enabled. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using System.Collections.Generic;
using UnivaPay.Models;
using UnivaPay.Utilities;

MerchantWebhookConfiguration merchantWebhookConfiguration = new MerchantWebhookConfiguration
{
    PercentFee = 3.6,
    FlatFees = new List<MerchantWebhookMoneyAmount>
    {
        new MerchantWebhookMoneyAmount
        {
            Amount = 100,
            Currency = "JPY",
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
    },
    LogoUrl = "logo_url4",
    Country = "JP",
    Language = "ja",
    DisplayTimeZone = "Asia/Tokyo",
    MinTransferPayout = new MerchantWebhookMoneyAmount
    {
        Amount = 5000,
        Currency = "JPY",
    },
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
    TransferSchedule = new MerchantWebhookTransferScheduleConfiguration
    {
        WaitPeriod = "P7D",
        Period = "weekly",
        FullPeriodRequired = false,
        WeeklyClosingDay = "sunday",
        WeeklyPayoutDay = "friday",
    },
    UserTransactionsConfiguration = new MerchantWebhookUserTransactionsConfiguration
    {
        Enabled = true,
        NotifyCustomer = true,
        NotifyOnWebhookFailure = true,
        NotifyOnWebhookDisabled = true,
        NotifyOnSubscriptions = true,
    },
    RecurringTokenConfiguration = new MerchantWebhookRecurringTokenConfiguration
    {
        RecurringType = "infinite",
        ChargeWaitPeriod = "P7D",
        CardChargeCvvConfirmation = new MerchantWebhookRecurringCvvConfirmationConfig
        {
            Enabled = false,
        },
    },
    SecurityConfiguration = new MerchantWebhookSecurityConfiguration
    {
        CardChargeCooldown = "PT5M",
        SubscriptionCooldown = "PT10M",
        RestrictIpAfterFailedCharge = new RestrictIpAfterFailedChargeConfig
        {
            Enabled = true,
            Count = 5,
            Cooldown = "PT1H",
        },
        RefundPercentLimit = 100,
        ConfirmationRequired = false,
        MinRefundThreshold = 100,
        LimitRefundBySales = new MerchantWebhookLimitRefundBySalesConfiguration
        {
            Enabled = true,
            Period = "monthly",
            RollingWindow = true,
        },
    },
    CheckoutConfiguration = new MerchantWebhookCheckoutConfiguration
    {
        EcEmail = new MerchantWebhookCheckoutToggle
        {
            Enabled = true,
        },
        EcProducts = new MerchantWebhookCheckoutToggle
        {
            Enabled = true,
        },
    },
    InstallmentsConfiguration = new MerchantWebhookInstallmentPlanConfiguration
    {
        Enabled = true,
        CardProcessor = new CardProcessorInstallmentConfig
        {
            Revolving = true,
            FixedCycle = true,
        },
        SupportedPaymentTypes = new List<string>
        {
            "card",
        },
        MinChargeAmount = new MerchantWebhookMoneyAmount
        {
            Amount = 3000,
            Currency = "JPY",
        },
        MaxPayoutPeriod = "P12M",
        OnlyWithProcessor = true,
    },
    SubscriptionPlanConfiguration = new MerchantWebhookSubscriptionPlanConfiguration
    {
        Enabled = true,
        FixedCycle = true,
        FixedCycleAmount = true,
        SupportedPaymentTypes = new List<string>
        {
            "card",
        },
        MinChargeAmount = new MerchantWebhookMoneyAmount
        {
            Amount = 3000,
            Currency = "JPY",
        },
        MaxPayoutPeriod = "P12M",
    },
    CardBrandPercentFees = new MerchantWebhookCardBrandPercentFees
    {
        Visa = 3.6,
        Mastercard = 3.6,
        Jcb = 3.8,
    },
    SubscriptionConfiguration = new MerchantWebhookSubscriptionConfiguration
    {
        Enabled = true,
        FailedChargesToCancel = 3,
        SuspendOnCancel = true,
        AllowMerchantAmountPatch = false,
        AllowMerchantDueDatePatch = false,
    },
    CustomerManagementConfiguration = new MerchantWebhookCustomerManagementConfiguration
    {
        Enabled = true,
        DefaultRoles = new List<string>
        {
            "end_user",
        },
        DefaultMode = "live",
    },
    DescriptorProvidedConfiguration = false,
    CardConfiguration = new MerchantWebhookCardConfiguration
    {
        Enabled = true,
        DebitEnabled = true,
        PrepaidEnabled = false,
        ForeignCardsAllowed = false,
        ThreeDsRequired = true,
        AllowDirectTokenCreation = false,
    },
    QrScanConfiguration = new MerchantWebhookQrScanConfiguration
    {
        Enabled = true,
        ForbiddenQrScanGateways = new List<string>
        {
            "wechat",
        },
    },
    ConvenienceConfiguration = new MerchantWebhookConvenienceConfiguration
    {
        Enabled = true,
        Expiration = "P3D",
    },
    PaidyConfiguration = new MerchantWebhookPaidyConfiguration
    {
        Enabled = false,
    },
    QrMerchantConfiguration = new MerchantWebhookQrMerchantConfiguration
    {
        Enabled = false,
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
        VirtualBankAccountsThreshold = 50,
        VirtualBankAccountsFetchCount = 25,
        DefaultExtensionPeriod = "P3D",
        MaximumExtensionPeriod = "P30D",
        AutomaticExtensionEnabled = true,
        ChargeRequestNotificationEnabled = true,
        DepositReceivedNotificationEnabled = true,
        RemindNotificationPeriod = "P2D",
        RemindNotificationEnabled = true,
    },
    PlatformCredentialsEnabled = true,
    TaggedPlatformCredentialsEnabled = false,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```



# Customs Declaration Webhook Callback Extension

Customs-declaration-specific webhook payload extension.

*This model accepts additional fields of type object.*

## Structure

`CustomsDeclarationWebhookCallbackExtension`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`CustomsDeclarationWebhookData`](../../doc/models/customs-declaration-webhook-data.md) | Optional | Customs declaration payload delivered in `customs_declaration_finished` webhooks. Platform-level deliveries may include `platform_id` and `updated_on`. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using System.Globalization;
using UnivaPay.Models;
using UnivaPay.Utilities;

CustomsDeclarationWebhookCallbackExtension customsDeclarationWebhookCallbackExtension = new CustomsDeclarationWebhookCallbackExtension
{
    Data = new CustomsDeclarationWebhookData
    {
        Id = new Guid("11ef0000-0000-4000-8000-000000000040"),
        ChargeId = new Guid("11ef0000-0000-4000-8000-000000000001"),
        MerchantId = new Guid("11ef0000-0000-4000-8000-000000000020"),
        StoreId = new Guid("11ef0000-0000-4000-8000-000000000022"),
        PlatformId = new Guid("00000550-0000-0000-0000-000000000000"),
        Mode = "test",
        Gateway = "wechat_online",
        Declaration = new CustomsDeclarationWebhookDeclaration
        {
            Customs = "TOKYO",
            MerchantCustomsNo = "1234567890",
            CertificateId = "AB1234567",
            CertificateName = "TARO YAMADA",
        },
        DeclarationResult = new CustomsDeclarationWebhookResult
        {
            ApprovingAuthority = "TOKYO",
            TradeId = "wx_trade_12345",
            TransactionId = "wx_txn_12345",
            ChargeTransactionId = "wx_charge_12345",
        },
        Status = CustomsDeclarationWebhookStatus.Successful,
        CreatedOn = DateTime.ParseExact("2026-04-09T07:35:50.000000Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


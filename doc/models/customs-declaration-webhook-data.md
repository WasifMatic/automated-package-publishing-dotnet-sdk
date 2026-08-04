
# Customs Declaration Webhook Data

Customs declaration payload delivered in `customs_declaration_finished` webhooks. Platform-level deliveries may include `platform_id` and `updated_on`.

*This model accepts additional fields of type object.*

## Structure

`CustomsDeclarationWebhookData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `Guid?` | Optional | Customs declaration identifier. |
| `ChargeId` | `Guid?` | Optional | Charge identifier associated with the declaration. |
| `MerchantId` | `Guid?` | Optional | Merchant identifier. |
| `StoreId` | `Guid?` | Optional | Store identifier. |
| `PlatformId` | `Guid?` | Optional | Platform identifier, included on platform-level deliveries. |
| `Mode` | `string` | Optional | Processing mode. |
| `Gateway` | `string` | Optional | Gateway that processed the declaration. |
| `Declaration` | [`CustomsDeclarationWebhookDeclaration`](../../doc/models/customs-declaration-webhook-declaration.md) | Optional | WeChat customs declaration payload returned by the backend formatter. |
| `DeclarationResult` | [`CustomsDeclarationWebhookResult`](../../doc/models/customs-declaration-webhook-result.md) | Optional | Result payload returned by the customs declaration formatter. |
| `Status` | [`CustomsDeclarationWebhookStatus?`](../../doc/models/customs-declaration-webhook-status.md) | Optional | Customs declaration status returned by the backend. |
| `Error` | [`CustomsDeclarationWebhookError`](../../doc/models/customs-declaration-webhook-error.md) | Optional | Error payload returned when customs declaration processing fails. |
| `CreatedOn` | `DateTime?` | Optional | Timestamp when the declaration was created. |
| `UpdatedOn` | `DateTime?` | Optional | Timestamp when the declaration was last updated, included on platform-level deliveries. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using System.Globalization;
using UnivaPay.Models;
using UnivaPay.Utilities;

CustomsDeclarationWebhookData customsDeclarationWebhookData = new CustomsDeclarationWebhookData
{
    Id = new Guid("11ef0000-0000-4000-8000-000000000040"),
    ChargeId = new Guid("11ef0000-0000-4000-8000-000000000001"),
    MerchantId = new Guid("11ef0000-0000-4000-8000-000000000020"),
    StoreId = new Guid("11ef0000-0000-4000-8000-000000000022"),
    PlatformId = new Guid("00000082-0000-0000-0000-000000000000"),
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
    Error = null,
    CreatedOn = DateTime.ParseExact("2026-04-09T07:35:50.000000Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


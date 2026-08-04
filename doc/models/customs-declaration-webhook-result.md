
# Customs Declaration Webhook Result

Result payload returned by the customs declaration formatter.

*This model accepts additional fields of type object.*

## Structure

`CustomsDeclarationWebhookResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ApprovingAuthority` | `string` | Optional | Customs authority that approved the declaration. |
| `TradeId` | `string` | Optional | Gateway trade identifier. |
| `TransactionId` | `string` | Optional | Gateway transaction identifier for customs. |
| `ChargeTransactionId` | `string` | Optional | Gateway charge transaction identifier linked to the declaration. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

CustomsDeclarationWebhookResult customsDeclarationWebhookResult = new CustomsDeclarationWebhookResult
{
    ApprovingAuthority = "TOKYO",
    TradeId = "wx_trade_12345",
    TransactionId = "wx_txn_12345",
    ChargeTransactionId = "wx_charge_12345",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


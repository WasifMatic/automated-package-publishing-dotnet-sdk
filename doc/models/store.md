
# Store

Store resource returned by the backend `FullStore` formatter. It combines core store identity with the resolved configuration snapshot used for runtime policy evaluation.

*This model accepts additional fields of type object.*

## Structure

`Store`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `Guid?` | Optional | Store identifier. |
| `Name` | `string` | Optional | Store display name. |
| `CreatedOn` | `DateTime?` | Optional | Timestamp when the store was created. |
| `Configuration` | [`MerchantWebhookConfiguration`](../../doc/models/merchant-webhook-configuration.md) | Optional | Store-scoped configuration snapshot serialized by gyron-payments-api. It uses the same flattened serializer as merchant configuration, but omits `transfer_schedule`. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using System.Collections.Generic;
using System.Globalization;
using UnivaPay.Models;
using UnivaPay.Utilities;

Store store = new Store
{
    Id = new Guid("11ef0000-0000-4000-8000-000000000022"),
    Name = "Tokyo Store",
    CreatedOn = DateTime.ParseExact("2026-04-09T07:35:50.000000Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    Configuration = new MerchantWebhookConfiguration
    {
        PercentFee = 3.6,
        FlatFees = new List<MerchantWebhookMoneyAmount>
        {
            null,
        },
        LogoUrl = "logo_url4",
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
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


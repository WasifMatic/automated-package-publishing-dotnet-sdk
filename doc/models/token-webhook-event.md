
# Token Webhook Event

Webhook envelope for transaction token lifecycle events. Fired as `token_created` when a token is created, `token_updated` on metadata changes, `token_three_d_s_updated` on 3-D Secure data changes, `token_cvv_auth_updated` on CVV authorization changes, `token_cvv_auth_check_updated` on CVV auth check changes, `token_replaced` when a token is replaced by a new one (e.g., after a card update), and `recurring_token_deleted` when a recurring token is deleted. The `data` field contains the full TransactionToken object at the time of the event.

*This model accepts additional fields of type object.*

## Structure

`TokenWebhookEvent`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `Guid` | Required | Unique ID of this webhook delivery. |
| `Event` | [`TokenEvent`](../../doc/models/token-event.md) | Required | Event type discriminator — `token_created`, `token_updated`, `token_three_d_s_updated`, `token_cvv_auth_updated`, `token_cvv_auth_check_updated`, `token_replaced`, or `recurring_token_deleted`. |
| `Data` | [`TransactionToken`](../../doc/models/transaction-token.md) | Optional | Stored transaction token resource. |
| `CreatedOn` | `DateTime` | Required | Timestamp when the event was fired. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using System.Collections.Generic;
using System.Globalization;
using UnivaPay.Models;
using UnivaPay.Models.Containers;
using UnivaPay.Utilities;

TokenWebhookEvent tokenWebhookEvent = new TokenWebhookEvent
{
    Id = new Guid("11ef0000-0000-4000-8000-000000000001"),
    MEvent = TokenEvent.TokenCreated,
    CreatedOn = DateTime.ParseExact("2026-04-09T07:35:50.000000Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    Data = new TransactionToken
    {
        Id = new Guid("6426bbd2-17bd-41bf-883b-1fe970db48ee"),
        StoreId = new Guid("fc264608-9a9e-495e-844e-a08129a81af4"),
        Email = "test@univapay.com",
        PaymentType = TransactionTokenPaymentType.Card,
        Active = true,
        Mode = TransactionTokenMode.Live,
        Type = TransactionTokenType.Recurring,
        Confirmed = true,
        Metadata = new Dictionary<string, TransactionTokenMetadataAdditionalProperties>
        {
            ["customer_id"] = ,
        },
        CreatedOn = DateTime.ParseExact("2026-04-09T07:35:50.000000Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        UpdatedOn = DateTime.ParseExact("2026-04-09T07:35:50.000000Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


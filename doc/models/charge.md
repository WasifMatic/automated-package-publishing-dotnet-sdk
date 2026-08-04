
# Charge

Charge resource returned by the payments API.

*This model accepts additional fields of type object.*

## Structure

`Charge`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `Guid?` | Optional | Unique identifier. |
| `StoreId` | `Guid?` | Optional | Store identifier. |
| `TransactionTokenId` | `Guid?` | Optional | Transaction token identifier. |
| `TransactionTokenType` | [`ChargeTransactionTokenType?`](../../doc/models/charge-transaction-token-type.md) | Optional | Charge Transaction Token Type schema. |
| `SubscriptionId` | `Guid?` | Optional | Subscription identifier. |
| `MerchantTransactionId` | `string` | Optional | Merchant-defined transaction identifier. |
| `RequestedAmount` | `int?` | Optional | Requested amount in the smallest currency unit. |
| `RequestedCurrency` | `string` | Optional | Requested ISO-4217 currency code. |
| `RequestedAmountFormatted` | `double?` | Optional | Requested amount formatted for display. |
| `ChargedAmount` | `int?` | Optional | Charged amount in the smallest currency unit. |
| `ChargedCurrency` | `string` | Optional | Charged ISO-4217 currency code. |
| `ChargedAmountFormatted` | `double?` | Optional | Charged amount formatted for display. |
| `FeeAmount` | `int?` | Optional | Fee amount in the smallest currency unit. |
| `FeeCurrency` | `string` | Optional | Fee ISO-4217 currency code. |
| `FeeAmountFormatted` | `double?` | Optional | Fee amount formatted for display. |
| `OnlyDirectCurrency` | `bool?` | Optional | Whether only direct currency processing is allowed. |
| `CaptureAt` | `DateTime?` | Optional | Timestamp when capture should occur. |
| `Descriptor` | `string` | Optional | Billing descriptor. |
| `DescriptorPhoneNumber` | `string` | Optional | Billing descriptor phone number. |
| `Status` | [`ChargeStatus?`](../../doc/models/charge-status.md) | Optional | Charge Status schema. |
| `Error` | [`PaymentError`](../../doc/models/payment-error.md) | Optional | Payment error details, or null if successful. |
| `Metadata` | [`GenericMetadata`](../../doc/models/generic-metadata.md) | Optional | A free-form dictionary for custom metadata. |
| `Mode` | [`ChargeMode?`](../../doc/models/charge-mode.md) | Optional | Charge Mode schema. |
| `CreatedOn` | `DateTime?` | Optional | Timestamp when the resource was created. |
| `MerchantName` | `string` | Optional | Merchant display name. |
| `StoreName` | `string` | Optional | Store display name. |
| `Redirect` | [`ChargeRedirect`](../../doc/models/charge-redirect.md) | Optional | Charge Redirect schema. |
| `ThreeDs` | [`ChargeThreeDs`](../../doc/models/charge-three-ds.md) | Optional | Charge Three Ds schema. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using System.Globalization;
using UnivaPay.Models;
using UnivaPay.Utilities;

Charge charge = new Charge
{
    Id = new Guid("6efb4e5c-690a-40f3-a4f1-0e19c5f84e98"),
    StoreId = new Guid("76cf4a64-02bc-4cb3-9a28-74622e5928a1"),
    TransactionTokenId = new Guid("af834c88-7a8f-47ac-aee9-0386a0f98b0d"),
    TransactionTokenType = ChargeTransactionTokenType.OneTime,
    SubscriptionId = new Guid("11ef0000-0000-4000-8000-000000000001"),
    MerchantTransactionId = "ORD-998877",
    RequestedAmount = 1000,
    RequestedCurrency = "JPY",
    RequestedAmountFormatted = 1000,
    ChargedAmount = 1000,
    ChargedCurrency = "JPY",
    ChargedAmountFormatted = 1000,
    FeeAmount = 30,
    FeeCurrency = "JPY",
    FeeAmountFormatted = 30,
    OnlyDirectCurrency = false,
    CaptureAt = DateTime.ParseExact("2026-04-09T07:35:50.000000Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    Descriptor = "UNIVAPAY TEST",
    DescriptorPhoneNumber = "0312345678",
    Status = ChargeStatus.Pending,
    Error = new PaymentError
    {
        Code = 301,
        Message = "Card number error.",
        Detail = "The provided card number failed validation.",
    },
    Metadata = new GenericMetadata
    {
        OrderId = "12345",
    },
    Mode = ChargeMode.Live,
    CreatedOn = DateTime.ParseExact("2026-04-09T07:35:50Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    MerchantName = "Test Merchant",
    StoreName = "Tokyo Store",
    Redirect = new ChargeRedirect
    {
    },
    ThreeDs = new ChargeThreeDs
    {
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


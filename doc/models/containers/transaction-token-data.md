
# Transaction Token Data

Transaction token data payload. The actual structure depends on `payment_type` — card, konbini, online (QR / 3DS), or bank transfer.

## Class Name

`TransactionTokenData`

## Cases

| Type | Factory Method |
|  --- | --- |
| [`TokenResponseCardData`](../../../doc/models/token-response-card-data.md) | TransactionTokenData.FromTokenResponseCardData(TokenResponseCardData tokenResponseCardData) |
| [`TokenResponseKonbiniData`](../../../doc/models/token-response-konbini-data.md) | TransactionTokenData.FromTokenResponseKonbiniData(TokenResponseKonbiniData tokenResponseKonbiniData) |
| [`TokenResponseOnlineData`](../../../doc/models/token-response-online-data.md) | TransactionTokenData.FromTokenResponseOnlineData(TokenResponseOnlineData tokenResponseOnlineData) |
| [`TokenResponseBankTransferData`](../../../doc/models/token-response-bank-transfer-data.md) | TransactionTokenData.FromTokenResponseBankTransferData(TokenResponseBankTransferData tokenResponseBankTransferData) |

## TokenResponseCardData

### Initialization Code

#### Example

```csharp
TransactionTokenData value = TransactionTokenData.FromTokenResponseCardData(
    new TokenResponseCardData
    {
        Card = new TokenResponseCardDataCard
        {
            Cardholder = "TARO YAMADA",
            ExpMonth = 12,
            ExpYear = 2026,
            CardBin = "424242",
            LastFour = "4242",
            Brand = "visa",
            CardType = "credit",
            Country = "JP",
            Category = "standard",
            Issuer = null,
            SubBrand = "none",
        },
        Billing = new TokenResponseCardDataBilling
        {
            Line1 = "1-1-1",
            Line2 = "Shibakoen",
            State = "Tokyo",
            City = "Minato",
            Country = "JP",
            Zip = "105-0011",
            PhoneNumber = new TokenResponsePhoneNumber
            {
                CountryCode = 81,
                LocalNumber = "08012341234",
            },
        },
        CvvAuthorize = new TokenResponseCardDataCvvAuthorize
        {
            Enabled = true,
            Status = "successful",
            ChargeId = null,
            CredentialsId = null,
            Currency = "JPY",
        },
        CvvAuthorizeCheck = new TokenResponseCardDataCvvAuthorizeCheck
        {
            Status = "successful",
            ChargeId = null,
            Date = DateTime.ParseExact("2026-04-09T07:35:50Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
        },
        ThreeDs = new TokenResponseCardDataThreeDs
        {
            Enabled = true,
            Status = TokenResponseCardDataThreeDsStatus.Successful,
            RedirectEndpoint = null,
            RedirectId = null,
            Exempted = false,
            Error = null,
        },
    }
);
```

## TokenResponseKonbiniData

### Initialization Code

#### Example

```csharp
TransactionTokenData value = TransactionTokenData.FromTokenResponseKonbiniData(
    new TokenResponseKonbiniData
    {
        CustomerName = "Taro Yamada",
        ConvenienceStore = BaseKonbiniDataConvenienceStore.SevenEleven,
        ExpirationPeriod = "P7D",
        ExpirationTimeShift = null,
        PhoneNumber = new TokenResponsePhoneNumber
        {
            CountryCode = 81,
            LocalNumber = "08012341234",
        },
    }
);
```

## TokenResponseOnlineData

### Initialization Code

#### Example

```csharp
TransactionTokenData value = TransactionTokenData.FromTokenResponseOnlineData(
    new TokenResponseOnlineData
    {
        Brand = BaseOnlineDataBrand.WeChatOnline,
        CallMethod = BaseOnlineDataCallMethod.Web,
        UserIdentifier = "wechat_open_id_12345",
    }
);
```

## TokenResponseBankTransferData

### Initialization Code

#### Example

```csharp
TransactionTokenData value = TransactionTokenData.FromTokenResponseBankTransferData(
    new TokenResponseBankTransferData
    {
        Brand = "aozora_bank",
        ExpirationPeriod = "PT168H",
        ExpirationTimeShift = "23:59:59+09:00",
        BankCode = "0310",
        BankName = "GMOあおぞらネット銀行",
        BranchCode = "123",
        BranchName = "Test Branch",
        AccountNumber = "1234567",
        AccountHolderName = "TARO YAMADA",
    }
);
```



# Merchant Webhook User Transactions Configuration

Merchant transaction notification settings.

*This model accepts additional fields of type object.*

## Structure

`MerchantWebhookUserTransactionsConfiguration`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Enabled` | `bool?` | Optional | Enables merchant transaction notifications. |
| `NotifyCustomer` | `bool?` | Optional | Sends transaction notifications to the customer. |
| `NotifyOnTest` | `bool?` | Optional | Sends notifications for test-mode events. |
| `NotifyOnRecurringTokenCreation` | `bool?` | Optional | Sends notifications when a recurring token is created. |
| `NotifyOnRecurringTokenCvvFailed` | `bool?` | Optional | Sends notifications when recurring-token CVV confirmation fails. |
| `NotifyOnWebhookFailure` | `bool?` | Optional | Sends notifications after repeated webhook delivery failures. |
| `NotifyOnWebhookDisabled` | `bool?` | Optional | Sends notifications when webhook delivery is disabled. |
| `NotifyUserOnFailedTransactions` | `bool?` | Optional | Sends merchant notifications for failed transactions. |
| `NotifyCustomerOnFailedTransactions` | `bool?` | Optional | Sends customer notifications for failed transactions. |
| `NotifyUserOnConvenienceInstructions` | `bool?` | Optional | Sends merchant notifications with convenience-store payment instructions. |
| `NotifyOnSubscriptions` | `bool?` | Optional | Sends notifications for subscription lifecycle events. |
| `NotifyOnAuthorizations` | `bool?` | Optional | Sends notifications for authorization-only charges. |
| `NotifyOnCvvAuthorizations` | `bool?` | Optional | Sends notifications for CVV authorization events. |
| `NotifyOnCancels` | `bool?` | Optional | Sends notifications when charges are canceled. |
| `CustomerReferLinkEnabled` | `bool?` | Optional | Includes customer self-service links in supported notifications. |
| `NotifyOnConvenienceExpiry` | `bool?` | Optional | Sends notifications when convenience payments expire. |
| `NotifyOnRecurringTokenCreationWithThreeDs` | `bool?` | Optional | Sends notifications when recurring tokens are created through 3-D Secure. |
| `NotifyOnChargebacks` | `bool?` | Optional | Sends notifications for chargeback events. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

MerchantWebhookUserTransactionsConfiguration merchantWebhookUserTransactionsConfiguration = new MerchantWebhookUserTransactionsConfiguration
{
    Enabled = true,
    NotifyCustomer = true,
    NotifyOnTest = false,
    NotifyOnRecurringTokenCreation = false,
    NotifyOnRecurringTokenCvvFailed = false,
    NotifyOnWebhookFailure = true,
    NotifyOnWebhookDisabled = true,
    NotifyOnSubscriptions = true,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```


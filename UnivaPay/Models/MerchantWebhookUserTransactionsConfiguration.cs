// <copyright file="MerchantWebhookUserTransactionsConfiguration.cs" company="APIMatic">
// UnivaPay
//
// This file was automatically generated for Univapay by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnivaPay.Utilities;

namespace UnivaPay.Models
{
    /// <summary>
    /// MerchantWebhookUserTransactionsConfiguration.
    /// </summary>
    public class MerchantWebhookUserTransactionsConfiguration
    {
        [JsonExtensionData]
        private readonly IDictionary<string, JToken> additionalProperties;

        private readonly IEnumerable<string> propertyName;

        /// <summary>
        /// Get or set the value associated with the specified key in the AdditionalProperties dictionary.
        /// </summary>
        /// <param name="key">The key of the value to get or set. This must be a valid key that is not reserved for internal properties.</param>
        /// <returns>The object value associated with the specified key in the AdditionalProperties dictionary.</returns>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when <paramref name="key"/> is null or an empty string.
        /// </exception>
        /// <exception cref="System.ArgumentException">
        /// Thrown when the specified <paramref name="key"/> conflicts with an internal property of the object.
        /// </exception>
        /// <exception cref="KeyNotFoundException">
        /// Thrown when the specified <paramref name="key"/> does not exist in the AdditionalProperties dictionary.
        /// </exception>
        [IndexerName("AdditionalPropertiesIndexer")]
        public object this[string key]
        {
            get => additionalProperties.GetValue<object>(key);
            set => additionalProperties.SetValue(key, value, propertyName);
        }

        private bool? enabled;
        private bool? notifyCustomer;
        private bool? notifyOnTest;
        private bool? notifyOnRecurringTokenCreation;
        private bool? notifyOnRecurringTokenCvvFailed;
        private bool? notifyOnWebhookFailure;
        private bool? notifyOnWebhookDisabled;
        private bool? notifyUserOnFailedTransactions;
        private bool? notifyCustomerOnFailedTransactions;
        private bool? notifyUserOnConvenienceInstructions;
        private bool? notifyOnSubscriptions;
        private bool? notifyOnAuthorizations;
        private bool? notifyOnCvvAuthorizations;
        private bool? notifyOnCancels;
        private bool? customerReferLinkEnabled;
        private bool? notifyOnConvenienceExpiry;
        private bool? notifyOnRecurringTokenCreationWithThreeDs;
        private bool? notifyOnChargebacks;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "enabled", false },
            { "notify_customer", false },
            { "notify_on_test", false },
            { "notify_on_recurring_token_creation", false },
            { "notify_on_recurring_token_cvv_failed", false },
            { "notify_on_webhook_failure", false },
            { "notify_on_webhook_disabled", false },
            { "notify_user_on_failed_transactions", false },
            { "notify_customer_on_failed_transactions", false },
            { "notify_user_on_convenience_instructions", false },
            { "notify_on_subscriptions", false },
            { "notify_on_authorizations", false },
            { "notify_on_cvv_authorizations", false },
            { "notify_on_cancels", false },
            { "customer_refer_link_enabled", false },
            { "notify_on_convenience_expiry", false },
            { "notify_on_recurring_token_creation_with_three_ds", false },
            { "notify_on_chargebacks", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantWebhookUserTransactionsConfiguration"/> class.
        /// </summary>
        public MerchantWebhookUserTransactionsConfiguration()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantWebhookUserTransactionsConfiguration"/> class.
        /// </summary>
        /// <param name="enabled">enabled.</param>
        /// <param name="notifyCustomer">notify_customer.</param>
        /// <param name="notifyOnTest">notify_on_test.</param>
        /// <param name="notifyOnRecurringTokenCreation">notify_on_recurring_token_creation.</param>
        /// <param name="notifyOnRecurringTokenCvvFailed">notify_on_recurring_token_cvv_failed.</param>
        /// <param name="notifyOnWebhookFailure">notify_on_webhook_failure.</param>
        /// <param name="notifyOnWebhookDisabled">notify_on_webhook_disabled.</param>
        /// <param name="notifyUserOnFailedTransactions">notify_user_on_failed_transactions.</param>
        /// <param name="notifyCustomerOnFailedTransactions">notify_customer_on_failed_transactions.</param>
        /// <param name="notifyUserOnConvenienceInstructions">notify_user_on_convenience_instructions.</param>
        /// <param name="notifyOnSubscriptions">notify_on_subscriptions.</param>
        /// <param name="notifyOnAuthorizations">notify_on_authorizations.</param>
        /// <param name="notifyOnCvvAuthorizations">notify_on_cvv_authorizations.</param>
        /// <param name="notifyOnCancels">notify_on_cancels.</param>
        /// <param name="customerReferLinkEnabled">customer_refer_link_enabled.</param>
        /// <param name="notifyOnConvenienceExpiry">notify_on_convenience_expiry.</param>
        /// <param name="notifyOnRecurringTokenCreationWithThreeDs">notify_on_recurring_token_creation_with_three_ds.</param>
        /// <param name="notifyOnChargebacks">notify_on_chargebacks.</param>
        public MerchantWebhookUserTransactionsConfiguration(
            bool? enabled = null,
            bool? notifyCustomer = null,
            bool? notifyOnTest = null,
            bool? notifyOnRecurringTokenCreation = null,
            bool? notifyOnRecurringTokenCvvFailed = null,
            bool? notifyOnWebhookFailure = null,
            bool? notifyOnWebhookDisabled = null,
            bool? notifyUserOnFailedTransactions = null,
            bool? notifyCustomerOnFailedTransactions = null,
            bool? notifyUserOnConvenienceInstructions = null,
            bool? notifyOnSubscriptions = null,
            bool? notifyOnAuthorizations = null,
            bool? notifyOnCvvAuthorizations = null,
            bool? notifyOnCancels = null,
            bool? customerReferLinkEnabled = null,
            bool? notifyOnConvenienceExpiry = null,
            bool? notifyOnRecurringTokenCreationWithThreeDs = null,
            bool? notifyOnChargebacks = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();

            if (enabled != null)
            {
                this.Enabled = enabled;
            }

            if (notifyCustomer != null)
            {
                this.NotifyCustomer = notifyCustomer;
            }

            if (notifyOnTest != null)
            {
                this.NotifyOnTest = notifyOnTest;
            }

            if (notifyOnRecurringTokenCreation != null)
            {
                this.NotifyOnRecurringTokenCreation = notifyOnRecurringTokenCreation;
            }

            if (notifyOnRecurringTokenCvvFailed != null)
            {
                this.NotifyOnRecurringTokenCvvFailed = notifyOnRecurringTokenCvvFailed;
            }

            if (notifyOnWebhookFailure != null)
            {
                this.NotifyOnWebhookFailure = notifyOnWebhookFailure;
            }

            if (notifyOnWebhookDisabled != null)
            {
                this.NotifyOnWebhookDisabled = notifyOnWebhookDisabled;
            }

            if (notifyUserOnFailedTransactions != null)
            {
                this.NotifyUserOnFailedTransactions = notifyUserOnFailedTransactions;
            }

            if (notifyCustomerOnFailedTransactions != null)
            {
                this.NotifyCustomerOnFailedTransactions = notifyCustomerOnFailedTransactions;
            }

            if (notifyUserOnConvenienceInstructions != null)
            {
                this.NotifyUserOnConvenienceInstructions = notifyUserOnConvenienceInstructions;
            }

            if (notifyOnSubscriptions != null)
            {
                this.NotifyOnSubscriptions = notifyOnSubscriptions;
            }

            if (notifyOnAuthorizations != null)
            {
                this.NotifyOnAuthorizations = notifyOnAuthorizations;
            }

            if (notifyOnCvvAuthorizations != null)
            {
                this.NotifyOnCvvAuthorizations = notifyOnCvvAuthorizations;
            }

            if (notifyOnCancels != null)
            {
                this.NotifyOnCancels = notifyOnCancels;
            }

            if (customerReferLinkEnabled != null)
            {
                this.CustomerReferLinkEnabled = customerReferLinkEnabled;
            }

            if (notifyOnConvenienceExpiry != null)
            {
                this.NotifyOnConvenienceExpiry = notifyOnConvenienceExpiry;
            }

            if (notifyOnRecurringTokenCreationWithThreeDs != null)
            {
                this.NotifyOnRecurringTokenCreationWithThreeDs = notifyOnRecurringTokenCreationWithThreeDs;
            }

            if (notifyOnChargebacks != null)
            {
                this.NotifyOnChargebacks = notifyOnChargebacks;
            }
        }

        /// <summary>
        /// Enables merchant transaction notifications.
        /// </summary>
        [JsonProperty("enabled")]
        public bool? Enabled
        {
            get
            {
                return this.enabled;
            }

            set
            {
                this.shouldSerialize["enabled"] = true;
                this.enabled = value;
            }
        }

        /// <summary>
        /// Sends transaction notifications to the customer.
        /// </summary>
        [JsonProperty("notify_customer")]
        public bool? NotifyCustomer
        {
            get
            {
                return this.notifyCustomer;
            }

            set
            {
                this.shouldSerialize["notify_customer"] = true;
                this.notifyCustomer = value;
            }
        }

        /// <summary>
        /// Sends notifications for test-mode events.
        /// </summary>
        [JsonProperty("notify_on_test")]
        public bool? NotifyOnTest
        {
            get
            {
                return this.notifyOnTest;
            }

            set
            {
                this.shouldSerialize["notify_on_test"] = true;
                this.notifyOnTest = value;
            }
        }

        /// <summary>
        /// Sends notifications when a recurring token is created.
        /// </summary>
        [JsonProperty("notify_on_recurring_token_creation")]
        public bool? NotifyOnRecurringTokenCreation
        {
            get
            {
                return this.notifyOnRecurringTokenCreation;
            }

            set
            {
                this.shouldSerialize["notify_on_recurring_token_creation"] = true;
                this.notifyOnRecurringTokenCreation = value;
            }
        }

        /// <summary>
        /// Sends notifications when recurring-token CVV confirmation fails.
        /// </summary>
        [JsonProperty("notify_on_recurring_token_cvv_failed")]
        public bool? NotifyOnRecurringTokenCvvFailed
        {
            get
            {
                return this.notifyOnRecurringTokenCvvFailed;
            }

            set
            {
                this.shouldSerialize["notify_on_recurring_token_cvv_failed"] = true;
                this.notifyOnRecurringTokenCvvFailed = value;
            }
        }

        /// <summary>
        /// Sends notifications after repeated webhook delivery failures.
        /// </summary>
        [JsonProperty("notify_on_webhook_failure")]
        public bool? NotifyOnWebhookFailure
        {
            get
            {
                return this.notifyOnWebhookFailure;
            }

            set
            {
                this.shouldSerialize["notify_on_webhook_failure"] = true;
                this.notifyOnWebhookFailure = value;
            }
        }

        /// <summary>
        /// Sends notifications when webhook delivery is disabled.
        /// </summary>
        [JsonProperty("notify_on_webhook_disabled")]
        public bool? NotifyOnWebhookDisabled
        {
            get
            {
                return this.notifyOnWebhookDisabled;
            }

            set
            {
                this.shouldSerialize["notify_on_webhook_disabled"] = true;
                this.notifyOnWebhookDisabled = value;
            }
        }

        /// <summary>
        /// Sends merchant notifications for failed transactions.
        /// </summary>
        [JsonProperty("notify_user_on_failed_transactions")]
        public bool? NotifyUserOnFailedTransactions
        {
            get
            {
                return this.notifyUserOnFailedTransactions;
            }

            set
            {
                this.shouldSerialize["notify_user_on_failed_transactions"] = true;
                this.notifyUserOnFailedTransactions = value;
            }
        }

        /// <summary>
        /// Sends customer notifications for failed transactions.
        /// </summary>
        [JsonProperty("notify_customer_on_failed_transactions")]
        public bool? NotifyCustomerOnFailedTransactions
        {
            get
            {
                return this.notifyCustomerOnFailedTransactions;
            }

            set
            {
                this.shouldSerialize["notify_customer_on_failed_transactions"] = true;
                this.notifyCustomerOnFailedTransactions = value;
            }
        }

        /// <summary>
        /// Sends merchant notifications with convenience-store payment instructions.
        /// </summary>
        [JsonProperty("notify_user_on_convenience_instructions")]
        public bool? NotifyUserOnConvenienceInstructions
        {
            get
            {
                return this.notifyUserOnConvenienceInstructions;
            }

            set
            {
                this.shouldSerialize["notify_user_on_convenience_instructions"] = true;
                this.notifyUserOnConvenienceInstructions = value;
            }
        }

        /// <summary>
        /// Sends notifications for subscription lifecycle events.
        /// </summary>
        [JsonProperty("notify_on_subscriptions")]
        public bool? NotifyOnSubscriptions
        {
            get
            {
                return this.notifyOnSubscriptions;
            }

            set
            {
                this.shouldSerialize["notify_on_subscriptions"] = true;
                this.notifyOnSubscriptions = value;
            }
        }

        /// <summary>
        /// Sends notifications for authorization-only charges.
        /// </summary>
        [JsonProperty("notify_on_authorizations")]
        public bool? NotifyOnAuthorizations
        {
            get
            {
                return this.notifyOnAuthorizations;
            }

            set
            {
                this.shouldSerialize["notify_on_authorizations"] = true;
                this.notifyOnAuthorizations = value;
            }
        }

        /// <summary>
        /// Sends notifications for CVV authorization events.
        /// </summary>
        [JsonProperty("notify_on_cvv_authorizations")]
        public bool? NotifyOnCvvAuthorizations
        {
            get
            {
                return this.notifyOnCvvAuthorizations;
            }

            set
            {
                this.shouldSerialize["notify_on_cvv_authorizations"] = true;
                this.notifyOnCvvAuthorizations = value;
            }
        }

        /// <summary>
        /// Sends notifications when charges are canceled.
        /// </summary>
        [JsonProperty("notify_on_cancels")]
        public bool? NotifyOnCancels
        {
            get
            {
                return this.notifyOnCancels;
            }

            set
            {
                this.shouldSerialize["notify_on_cancels"] = true;
                this.notifyOnCancels = value;
            }
        }

        /// <summary>
        /// Includes customer self-service links in supported notifications.
        /// </summary>
        [JsonProperty("customer_refer_link_enabled")]
        public bool? CustomerReferLinkEnabled
        {
            get
            {
                return this.customerReferLinkEnabled;
            }

            set
            {
                this.shouldSerialize["customer_refer_link_enabled"] = true;
                this.customerReferLinkEnabled = value;
            }
        }

        /// <summary>
        /// Sends notifications when convenience payments expire.
        /// </summary>
        [JsonProperty("notify_on_convenience_expiry")]
        public bool? NotifyOnConvenienceExpiry
        {
            get
            {
                return this.notifyOnConvenienceExpiry;
            }

            set
            {
                this.shouldSerialize["notify_on_convenience_expiry"] = true;
                this.notifyOnConvenienceExpiry = value;
            }
        }

        /// <summary>
        /// Sends notifications when recurring tokens are created through 3-D Secure.
        /// </summary>
        [JsonProperty("notify_on_recurring_token_creation_with_three_ds")]
        public bool? NotifyOnRecurringTokenCreationWithThreeDs
        {
            get
            {
                return this.notifyOnRecurringTokenCreationWithThreeDs;
            }

            set
            {
                this.shouldSerialize["notify_on_recurring_token_creation_with_three_ds"] = true;
                this.notifyOnRecurringTokenCreationWithThreeDs = value;
            }
        }

        /// <summary>
        /// Sends notifications for chargeback events.
        /// </summary>
        [JsonProperty("notify_on_chargebacks")]
        public bool? NotifyOnChargebacks
        {
            get
            {
                return this.notifyOnChargebacks;
            }

            set
            {
                this.shouldSerialize["notify_on_chargebacks"] = true;
                this.notifyOnChargebacks = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"MerchantWebhookUserTransactionsConfiguration : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetEnabled()
        {
            this.shouldSerialize["enabled"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetNotifyCustomer()
        {
            this.shouldSerialize["notify_customer"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetNotifyOnTest()
        {
            this.shouldSerialize["notify_on_test"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetNotifyOnRecurringTokenCreation()
        {
            this.shouldSerialize["notify_on_recurring_token_creation"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetNotifyOnRecurringTokenCvvFailed()
        {
            this.shouldSerialize["notify_on_recurring_token_cvv_failed"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetNotifyOnWebhookFailure()
        {
            this.shouldSerialize["notify_on_webhook_failure"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetNotifyOnWebhookDisabled()
        {
            this.shouldSerialize["notify_on_webhook_disabled"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetNotifyUserOnFailedTransactions()
        {
            this.shouldSerialize["notify_user_on_failed_transactions"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetNotifyCustomerOnFailedTransactions()
        {
            this.shouldSerialize["notify_customer_on_failed_transactions"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetNotifyUserOnConvenienceInstructions()
        {
            this.shouldSerialize["notify_user_on_convenience_instructions"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetNotifyOnSubscriptions()
        {
            this.shouldSerialize["notify_on_subscriptions"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetNotifyOnAuthorizations()
        {
            this.shouldSerialize["notify_on_authorizations"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetNotifyOnCvvAuthorizations()
        {
            this.shouldSerialize["notify_on_cvv_authorizations"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetNotifyOnCancels()
        {
            this.shouldSerialize["notify_on_cancels"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCustomerReferLinkEnabled()
        {
            this.shouldSerialize["customer_refer_link_enabled"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetNotifyOnConvenienceExpiry()
        {
            this.shouldSerialize["notify_on_convenience_expiry"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetNotifyOnRecurringTokenCreationWithThreeDs()
        {
            this.shouldSerialize["notify_on_recurring_token_creation_with_three_ds"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetNotifyOnChargebacks()
        {
            this.shouldSerialize["notify_on_chargebacks"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeEnabled()
        {
            return this.shouldSerialize["enabled"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeNotifyCustomer()
        {
            return this.shouldSerialize["notify_customer"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeNotifyOnTest()
        {
            return this.shouldSerialize["notify_on_test"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeNotifyOnRecurringTokenCreation()
        {
            return this.shouldSerialize["notify_on_recurring_token_creation"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeNotifyOnRecurringTokenCvvFailed()
        {
            return this.shouldSerialize["notify_on_recurring_token_cvv_failed"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeNotifyOnWebhookFailure()
        {
            return this.shouldSerialize["notify_on_webhook_failure"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeNotifyOnWebhookDisabled()
        {
            return this.shouldSerialize["notify_on_webhook_disabled"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeNotifyUserOnFailedTransactions()
        {
            return this.shouldSerialize["notify_user_on_failed_transactions"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeNotifyCustomerOnFailedTransactions()
        {
            return this.shouldSerialize["notify_customer_on_failed_transactions"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeNotifyUserOnConvenienceInstructions()
        {
            return this.shouldSerialize["notify_user_on_convenience_instructions"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeNotifyOnSubscriptions()
        {
            return this.shouldSerialize["notify_on_subscriptions"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeNotifyOnAuthorizations()
        {
            return this.shouldSerialize["notify_on_authorizations"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeNotifyOnCvvAuthorizations()
        {
            return this.shouldSerialize["notify_on_cvv_authorizations"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeNotifyOnCancels()
        {
            return this.shouldSerialize["notify_on_cancels"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCustomerReferLinkEnabled()
        {
            return this.shouldSerialize["customer_refer_link_enabled"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeNotifyOnConvenienceExpiry()
        {
            return this.shouldSerialize["notify_on_convenience_expiry"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeNotifyOnRecurringTokenCreationWithThreeDs()
        {
            return this.shouldSerialize["notify_on_recurring_token_creation_with_three_ds"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeNotifyOnChargebacks()
        {
            return this.shouldSerialize["notify_on_chargebacks"];
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Enabled = {(this.Enabled == null ? "null" : this.Enabled.ToString())}");
            toStringOutput.Add($"NotifyCustomer = {(this.NotifyCustomer == null ? "null" : this.NotifyCustomer.ToString())}");
            toStringOutput.Add($"NotifyOnTest = {(this.NotifyOnTest == null ? "null" : this.NotifyOnTest.ToString())}");
            toStringOutput.Add($"NotifyOnRecurringTokenCreation = {(this.NotifyOnRecurringTokenCreation == null ? "null" : this.NotifyOnRecurringTokenCreation.ToString())}");
            toStringOutput.Add($"NotifyOnRecurringTokenCvvFailed = {(this.NotifyOnRecurringTokenCvvFailed == null ? "null" : this.NotifyOnRecurringTokenCvvFailed.ToString())}");
            toStringOutput.Add($"NotifyOnWebhookFailure = {(this.NotifyOnWebhookFailure == null ? "null" : this.NotifyOnWebhookFailure.ToString())}");
            toStringOutput.Add($"NotifyOnWebhookDisabled = {(this.NotifyOnWebhookDisabled == null ? "null" : this.NotifyOnWebhookDisabled.ToString())}");
            toStringOutput.Add($"NotifyUserOnFailedTransactions = {(this.NotifyUserOnFailedTransactions == null ? "null" : this.NotifyUserOnFailedTransactions.ToString())}");
            toStringOutput.Add($"NotifyCustomerOnFailedTransactions = {(this.NotifyCustomerOnFailedTransactions == null ? "null" : this.NotifyCustomerOnFailedTransactions.ToString())}");
            toStringOutput.Add($"NotifyUserOnConvenienceInstructions = {(this.NotifyUserOnConvenienceInstructions == null ? "null" : this.NotifyUserOnConvenienceInstructions.ToString())}");
            toStringOutput.Add($"NotifyOnSubscriptions = {(this.NotifyOnSubscriptions == null ? "null" : this.NotifyOnSubscriptions.ToString())}");
            toStringOutput.Add($"NotifyOnAuthorizations = {(this.NotifyOnAuthorizations == null ? "null" : this.NotifyOnAuthorizations.ToString())}");
            toStringOutput.Add($"NotifyOnCvvAuthorizations = {(this.NotifyOnCvvAuthorizations == null ? "null" : this.NotifyOnCvvAuthorizations.ToString())}");
            toStringOutput.Add($"NotifyOnCancels = {(this.NotifyOnCancels == null ? "null" : this.NotifyOnCancels.ToString())}");
            toStringOutput.Add($"CustomerReferLinkEnabled = {(this.CustomerReferLinkEnabled == null ? "null" : this.CustomerReferLinkEnabled.ToString())}");
            toStringOutput.Add($"NotifyOnConvenienceExpiry = {(this.NotifyOnConvenienceExpiry == null ? "null" : this.NotifyOnConvenienceExpiry.ToString())}");
            toStringOutput.Add($"NotifyOnRecurringTokenCreationWithThreeDs = {(this.NotifyOnRecurringTokenCreationWithThreeDs == null ? "null" : this.NotifyOnRecurringTokenCreationWithThreeDs.ToString())}");
            toStringOutput.Add($"NotifyOnChargebacks = {(this.NotifyOnChargebacks == null ? "null" : this.NotifyOnChargebacks.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}
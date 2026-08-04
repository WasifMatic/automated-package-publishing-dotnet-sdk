// <copyright file="MerchantWebhookBankTransferConfiguration.cs" company="APIMatic">
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
    /// MerchantWebhookBankTransferConfiguration.
    /// </summary>
    public class MerchantWebhookBankTransferConfiguration
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
        private bool? matchAmount;
        private string expiration;
        private int? virtualBankAccountsThreshold;
        private int? virtualBankAccountsFetchCount;
        private string defaultExtensionPeriod;
        private string maximumExtensionPeriod;
        private bool? automaticExtensionEnabled;
        private bool? chargeRequestNotificationEnabled;
        private bool? chargeRequestCanceledNotificationEnabled;
        private bool? chargeExpiredNotificationEnabled;
        private bool? depositReceivedNotificationEnabled;
        private bool? depositInsufficientNotificationEnabled;
        private bool? depositExceededNotificationEnabled;
        private bool? extensionNotificationEnabled;
        private string remindNotificationPeriod;
        private bool? remindNotificationEnabled;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "enabled", false },
            { "match_amount", false },
            { "expiration", false },
            { "virtual_bank_accounts_threshold", false },
            { "virtual_bank_accounts_fetch_count", false },
            { "default_extension_period", false },
            { "maximum_extension_period", false },
            { "automatic_extension_enabled", false },
            { "charge_request_notification_enabled", false },
            { "charge_request_canceled_notification_enabled", false },
            { "charge_expired_notification_enabled", false },
            { "deposit_received_notification_enabled", false },
            { "deposit_insufficient_notification_enabled", false },
            { "deposit_exceeded_notification_enabled", false },
            { "extension_notification_enabled", false },
            { "remind_notification_period", false },
            { "remind_notification_enabled", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantWebhookBankTransferConfiguration"/> class.
        /// </summary>
        public MerchantWebhookBankTransferConfiguration()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantWebhookBankTransferConfiguration"/> class.
        /// </summary>
        /// <param name="enabled">enabled.</param>
        /// <param name="matchAmount">match_amount.</param>
        /// <param name="expiration">expiration.</param>
        /// <param name="virtualBankAccountsThreshold">virtual_bank_accounts_threshold.</param>
        /// <param name="virtualBankAccountsFetchCount">virtual_bank_accounts_fetch_count.</param>
        /// <param name="defaultExtensionPeriod">default_extension_period.</param>
        /// <param name="maximumExtensionPeriod">maximum_extension_period.</param>
        /// <param name="automaticExtensionEnabled">automatic_extension_enabled.</param>
        /// <param name="chargeRequestNotificationEnabled">charge_request_notification_enabled.</param>
        /// <param name="chargeRequestCanceledNotificationEnabled">charge_request_canceled_notification_enabled.</param>
        /// <param name="chargeExpiredNotificationEnabled">charge_expired_notification_enabled.</param>
        /// <param name="depositReceivedNotificationEnabled">deposit_received_notification_enabled.</param>
        /// <param name="depositInsufficientNotificationEnabled">deposit_insufficient_notification_enabled.</param>
        /// <param name="depositExceededNotificationEnabled">deposit_exceeded_notification_enabled.</param>
        /// <param name="extensionNotificationEnabled">extension_notification_enabled.</param>
        /// <param name="remindNotificationPeriod">remind_notification_period.</param>
        /// <param name="remindNotificationEnabled">remind_notification_enabled.</param>
        public MerchantWebhookBankTransferConfiguration(
            bool? enabled = null,
            bool? matchAmount = null,
            string expiration = null,
            int? virtualBankAccountsThreshold = null,
            int? virtualBankAccountsFetchCount = null,
            string defaultExtensionPeriod = null,
            string maximumExtensionPeriod = null,
            bool? automaticExtensionEnabled = null,
            bool? chargeRequestNotificationEnabled = null,
            bool? chargeRequestCanceledNotificationEnabled = null,
            bool? chargeExpiredNotificationEnabled = null,
            bool? depositReceivedNotificationEnabled = null,
            bool? depositInsufficientNotificationEnabled = null,
            bool? depositExceededNotificationEnabled = null,
            bool? extensionNotificationEnabled = null,
            string remindNotificationPeriod = null,
            bool? remindNotificationEnabled = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();

            if (enabled != null)
            {
                this.Enabled = enabled;
            }

            if (matchAmount != null)
            {
                this.MatchAmount = matchAmount;
            }

            if (expiration != null)
            {
                this.Expiration = expiration;
            }

            if (virtualBankAccountsThreshold != null)
            {
                this.VirtualBankAccountsThreshold = virtualBankAccountsThreshold;
            }

            if (virtualBankAccountsFetchCount != null)
            {
                this.VirtualBankAccountsFetchCount = virtualBankAccountsFetchCount;
            }

            if (defaultExtensionPeriod != null)
            {
                this.DefaultExtensionPeriod = defaultExtensionPeriod;
            }

            if (maximumExtensionPeriod != null)
            {
                this.MaximumExtensionPeriod = maximumExtensionPeriod;
            }

            if (automaticExtensionEnabled != null)
            {
                this.AutomaticExtensionEnabled = automaticExtensionEnabled;
            }

            if (chargeRequestNotificationEnabled != null)
            {
                this.ChargeRequestNotificationEnabled = chargeRequestNotificationEnabled;
            }

            if (chargeRequestCanceledNotificationEnabled != null)
            {
                this.ChargeRequestCanceledNotificationEnabled = chargeRequestCanceledNotificationEnabled;
            }

            if (chargeExpiredNotificationEnabled != null)
            {
                this.ChargeExpiredNotificationEnabled = chargeExpiredNotificationEnabled;
            }

            if (depositReceivedNotificationEnabled != null)
            {
                this.DepositReceivedNotificationEnabled = depositReceivedNotificationEnabled;
            }

            if (depositInsufficientNotificationEnabled != null)
            {
                this.DepositInsufficientNotificationEnabled = depositInsufficientNotificationEnabled;
            }

            if (depositExceededNotificationEnabled != null)
            {
                this.DepositExceededNotificationEnabled = depositExceededNotificationEnabled;
            }

            if (extensionNotificationEnabled != null)
            {
                this.ExtensionNotificationEnabled = extensionNotificationEnabled;
            }

            if (remindNotificationPeriod != null)
            {
                this.RemindNotificationPeriod = remindNotificationPeriod;
            }

            if (remindNotificationEnabled != null)
            {
                this.RemindNotificationEnabled = remindNotificationEnabled;
            }
        }

        /// <summary>
        /// Enables bank transfer payments.
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
        /// Requires the received deposit amount to exactly match the charge amount.
        /// </summary>
        [JsonProperty("match_amount")]
        public bool? MatchAmount
        {
            get
            {
                return this.matchAmount;
            }

            set
            {
                this.shouldSerialize["match_amount"] = true;
                this.matchAmount = value;
            }
        }

        /// <summary>
        /// ISO-8601 duration before the charge expires.
        /// </summary>
        [JsonProperty("expiration")]
        public string Expiration
        {
            get
            {
                return this.expiration;
            }

            set
            {
                this.shouldSerialize["expiration"] = true;
                this.expiration = value;
            }
        }

        /// <summary>
        /// Threshold for provisioning additional virtual bank accounts.
        /// </summary>
        [JsonProperty("virtual_bank_accounts_threshold")]
        public int? VirtualBankAccountsThreshold
        {
            get
            {
                return this.virtualBankAccountsThreshold;
            }

            set
            {
                this.shouldSerialize["virtual_bank_accounts_threshold"] = true;
                this.virtualBankAccountsThreshold = value;
            }
        }

        /// <summary>
        /// Number of virtual bank accounts fetched per replenishment batch.
        /// </summary>
        [JsonProperty("virtual_bank_accounts_fetch_count")]
        public int? VirtualBankAccountsFetchCount
        {
            get
            {
                return this.virtualBankAccountsFetchCount;
            }

            set
            {
                this.shouldSerialize["virtual_bank_accounts_fetch_count"] = true;
                this.virtualBankAccountsFetchCount = value;
            }
        }

        /// <summary>
        /// Default ISO-8601 extension period applied to eligible charges.
        /// </summary>
        [JsonProperty("default_extension_period")]
        public string DefaultExtensionPeriod
        {
            get
            {
                return this.defaultExtensionPeriod;
            }

            set
            {
                this.shouldSerialize["default_extension_period"] = true;
                this.defaultExtensionPeriod = value;
            }
        }

        /// <summary>
        /// Maximum ISO-8601 extension period allowed for a charge.
        /// </summary>
        [JsonProperty("maximum_extension_period")]
        public string MaximumExtensionPeriod
        {
            get
            {
                return this.maximumExtensionPeriod;
            }

            set
            {
                this.shouldSerialize["maximum_extension_period"] = true;
                this.maximumExtensionPeriod = value;
            }
        }

        /// <summary>
        /// Automatically extends eligible bank transfer charges.
        /// </summary>
        [JsonProperty("automatic_extension_enabled")]
        public bool? AutomaticExtensionEnabled
        {
            get
            {
                return this.automaticExtensionEnabled;
            }

            set
            {
                this.shouldSerialize["automatic_extension_enabled"] = true;
                this.automaticExtensionEnabled = value;
            }
        }

        /// <summary>
        /// Sends notifications when a bank transfer charge is created.
        /// </summary>
        [JsonProperty("charge_request_notification_enabled")]
        public bool? ChargeRequestNotificationEnabled
        {
            get
            {
                return this.chargeRequestNotificationEnabled;
            }

            set
            {
                this.shouldSerialize["charge_request_notification_enabled"] = true;
                this.chargeRequestNotificationEnabled = value;
            }
        }

        /// <summary>
        /// Sends notifications when a bank transfer charge is canceled.
        /// </summary>
        [JsonProperty("charge_request_canceled_notification_enabled")]
        public bool? ChargeRequestCanceledNotificationEnabled
        {
            get
            {
                return this.chargeRequestCanceledNotificationEnabled;
            }

            set
            {
                this.shouldSerialize["charge_request_canceled_notification_enabled"] = true;
                this.chargeRequestCanceledNotificationEnabled = value;
            }
        }

        /// <summary>
        /// Sends notifications when a bank transfer charge expires.
        /// </summary>
        [JsonProperty("charge_expired_notification_enabled")]
        public bool? ChargeExpiredNotificationEnabled
        {
            get
            {
                return this.chargeExpiredNotificationEnabled;
            }

            set
            {
                this.shouldSerialize["charge_expired_notification_enabled"] = true;
                this.chargeExpiredNotificationEnabled = value;
            }
        }

        /// <summary>
        /// Sends notifications when a deposit is received.
        /// </summary>
        [JsonProperty("deposit_received_notification_enabled")]
        public bool? DepositReceivedNotificationEnabled
        {
            get
            {
                return this.depositReceivedNotificationEnabled;
            }

            set
            {
                this.shouldSerialize["deposit_received_notification_enabled"] = true;
                this.depositReceivedNotificationEnabled = value;
            }
        }

        /// <summary>
        /// Sends notifications when a deposit is below the expected amount.
        /// </summary>
        [JsonProperty("deposit_insufficient_notification_enabled")]
        public bool? DepositInsufficientNotificationEnabled
        {
            get
            {
                return this.depositInsufficientNotificationEnabled;
            }

            set
            {
                this.shouldSerialize["deposit_insufficient_notification_enabled"] = true;
                this.depositInsufficientNotificationEnabled = value;
            }
        }

        /// <summary>
        /// Sends notifications when a deposit exceeds the expected amount.
        /// </summary>
        [JsonProperty("deposit_exceeded_notification_enabled")]
        public bool? DepositExceededNotificationEnabled
        {
            get
            {
                return this.depositExceededNotificationEnabled;
            }

            set
            {
                this.shouldSerialize["deposit_exceeded_notification_enabled"] = true;
                this.depositExceededNotificationEnabled = value;
            }
        }

        /// <summary>
        /// Sends notifications when a bank transfer charge is extended.
        /// </summary>
        [JsonProperty("extension_notification_enabled")]
        public bool? ExtensionNotificationEnabled
        {
            get
            {
                return this.extensionNotificationEnabled;
            }

            set
            {
                this.shouldSerialize["extension_notification_enabled"] = true;
                this.extensionNotificationEnabled = value;
            }
        }

        /// <summary>
        /// ISO-8601 lead time for payment reminder notifications.
        /// </summary>
        [JsonProperty("remind_notification_period")]
        public string RemindNotificationPeriod
        {
            get
            {
                return this.remindNotificationPeriod;
            }

            set
            {
                this.shouldSerialize["remind_notification_period"] = true;
                this.remindNotificationPeriod = value;
            }
        }

        /// <summary>
        /// Sends reminder notifications before bank transfer expiry.
        /// </summary>
        [JsonProperty("remind_notification_enabled")]
        public bool? RemindNotificationEnabled
        {
            get
            {
                return this.remindNotificationEnabled;
            }

            set
            {
                this.shouldSerialize["remind_notification_enabled"] = true;
                this.remindNotificationEnabled = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"MerchantWebhookBankTransferConfiguration : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetMatchAmount()
        {
            this.shouldSerialize["match_amount"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetExpiration()
        {
            this.shouldSerialize["expiration"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetVirtualBankAccountsThreshold()
        {
            this.shouldSerialize["virtual_bank_accounts_threshold"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetVirtualBankAccountsFetchCount()
        {
            this.shouldSerialize["virtual_bank_accounts_fetch_count"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDefaultExtensionPeriod()
        {
            this.shouldSerialize["default_extension_period"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetMaximumExtensionPeriod()
        {
            this.shouldSerialize["maximum_extension_period"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAutomaticExtensionEnabled()
        {
            this.shouldSerialize["automatic_extension_enabled"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetChargeRequestNotificationEnabled()
        {
            this.shouldSerialize["charge_request_notification_enabled"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetChargeRequestCanceledNotificationEnabled()
        {
            this.shouldSerialize["charge_request_canceled_notification_enabled"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetChargeExpiredNotificationEnabled()
        {
            this.shouldSerialize["charge_expired_notification_enabled"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDepositReceivedNotificationEnabled()
        {
            this.shouldSerialize["deposit_received_notification_enabled"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDepositInsufficientNotificationEnabled()
        {
            this.shouldSerialize["deposit_insufficient_notification_enabled"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDepositExceededNotificationEnabled()
        {
            this.shouldSerialize["deposit_exceeded_notification_enabled"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetExtensionNotificationEnabled()
        {
            this.shouldSerialize["extension_notification_enabled"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetRemindNotificationPeriod()
        {
            this.shouldSerialize["remind_notification_period"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetRemindNotificationEnabled()
        {
            this.shouldSerialize["remind_notification_enabled"] = false;
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
        public bool ShouldSerializeMatchAmount()
        {
            return this.shouldSerialize["match_amount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeExpiration()
        {
            return this.shouldSerialize["expiration"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeVirtualBankAccountsThreshold()
        {
            return this.shouldSerialize["virtual_bank_accounts_threshold"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeVirtualBankAccountsFetchCount()
        {
            return this.shouldSerialize["virtual_bank_accounts_fetch_count"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDefaultExtensionPeriod()
        {
            return this.shouldSerialize["default_extension_period"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMaximumExtensionPeriod()
        {
            return this.shouldSerialize["maximum_extension_period"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAutomaticExtensionEnabled()
        {
            return this.shouldSerialize["automatic_extension_enabled"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeChargeRequestNotificationEnabled()
        {
            return this.shouldSerialize["charge_request_notification_enabled"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeChargeRequestCanceledNotificationEnabled()
        {
            return this.shouldSerialize["charge_request_canceled_notification_enabled"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeChargeExpiredNotificationEnabled()
        {
            return this.shouldSerialize["charge_expired_notification_enabled"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDepositReceivedNotificationEnabled()
        {
            return this.shouldSerialize["deposit_received_notification_enabled"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDepositInsufficientNotificationEnabled()
        {
            return this.shouldSerialize["deposit_insufficient_notification_enabled"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDepositExceededNotificationEnabled()
        {
            return this.shouldSerialize["deposit_exceeded_notification_enabled"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeExtensionNotificationEnabled()
        {
            return this.shouldSerialize["extension_notification_enabled"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRemindNotificationPeriod()
        {
            return this.shouldSerialize["remind_notification_period"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRemindNotificationEnabled()
        {
            return this.shouldSerialize["remind_notification_enabled"];
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Enabled = {(this.Enabled == null ? "null" : this.Enabled.ToString())}");
            toStringOutput.Add($"MatchAmount = {(this.MatchAmount == null ? "null" : this.MatchAmount.ToString())}");
            toStringOutput.Add($"Expiration = {this.Expiration ?? "null"}");
            toStringOutput.Add($"VirtualBankAccountsThreshold = {(this.VirtualBankAccountsThreshold == null ? "null" : this.VirtualBankAccountsThreshold.ToString())}");
            toStringOutput.Add($"VirtualBankAccountsFetchCount = {(this.VirtualBankAccountsFetchCount == null ? "null" : this.VirtualBankAccountsFetchCount.ToString())}");
            toStringOutput.Add($"DefaultExtensionPeriod = {this.DefaultExtensionPeriod ?? "null"}");
            toStringOutput.Add($"MaximumExtensionPeriod = {this.MaximumExtensionPeriod ?? "null"}");
            toStringOutput.Add($"AutomaticExtensionEnabled = {(this.AutomaticExtensionEnabled == null ? "null" : this.AutomaticExtensionEnabled.ToString())}");
            toStringOutput.Add($"ChargeRequestNotificationEnabled = {(this.ChargeRequestNotificationEnabled == null ? "null" : this.ChargeRequestNotificationEnabled.ToString())}");
            toStringOutput.Add($"ChargeRequestCanceledNotificationEnabled = {(this.ChargeRequestCanceledNotificationEnabled == null ? "null" : this.ChargeRequestCanceledNotificationEnabled.ToString())}");
            toStringOutput.Add($"ChargeExpiredNotificationEnabled = {(this.ChargeExpiredNotificationEnabled == null ? "null" : this.ChargeExpiredNotificationEnabled.ToString())}");
            toStringOutput.Add($"DepositReceivedNotificationEnabled = {(this.DepositReceivedNotificationEnabled == null ? "null" : this.DepositReceivedNotificationEnabled.ToString())}");
            toStringOutput.Add($"DepositInsufficientNotificationEnabled = {(this.DepositInsufficientNotificationEnabled == null ? "null" : this.DepositInsufficientNotificationEnabled.ToString())}");
            toStringOutput.Add($"DepositExceededNotificationEnabled = {(this.DepositExceededNotificationEnabled == null ? "null" : this.DepositExceededNotificationEnabled.ToString())}");
            toStringOutput.Add($"ExtensionNotificationEnabled = {(this.ExtensionNotificationEnabled == null ? "null" : this.ExtensionNotificationEnabled.ToString())}");
            toStringOutput.Add($"RemindNotificationPeriod = {this.RemindNotificationPeriod ?? "null"}");
            toStringOutput.Add($"RemindNotificationEnabled = {(this.RemindNotificationEnabled == null ? "null" : this.RemindNotificationEnabled.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}
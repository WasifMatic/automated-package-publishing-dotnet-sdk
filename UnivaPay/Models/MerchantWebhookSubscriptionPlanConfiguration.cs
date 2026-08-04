// <copyright file="MerchantWebhookSubscriptionPlanConfiguration.cs" company="APIMatic">
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
    /// MerchantWebhookSubscriptionPlanConfiguration.
    /// </summary>
    public class MerchantWebhookSubscriptionPlanConfiguration
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
        private bool? fixedCycle;
        private bool? fixedCycleAmount;
        private List<string> supportedPaymentTypes;
        private string maxPayoutPeriod;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "enabled", false },
            { "fixed_cycle", false },
            { "fixed_cycle_amount", false },
            { "supported_payment_types", false },
            { "max_payout_period", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantWebhookSubscriptionPlanConfiguration"/> class.
        /// </summary>
        public MerchantWebhookSubscriptionPlanConfiguration()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantWebhookSubscriptionPlanConfiguration"/> class.
        /// </summary>
        /// <param name="enabled">enabled.</param>
        /// <param name="fixedCycle">fixed_cycle.</param>
        /// <param name="fixedCycleAmount">fixed_cycle_amount.</param>
        /// <param name="supportedPaymentTypes">supported_payment_types.</param>
        /// <param name="minChargeAmount">min_charge_amount.</param>
        /// <param name="maxPayoutPeriod">max_payout_period.</param>
        public MerchantWebhookSubscriptionPlanConfiguration(
            bool? enabled = null,
            bool? fixedCycle = null,
            bool? fixedCycleAmount = null,
            List<string> supportedPaymentTypes = null,
            Models.MerchantWebhookMoneyAmount minChargeAmount = null,
            string maxPayoutPeriod = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();

            if (enabled != null)
            {
                this.Enabled = enabled;
            }

            if (fixedCycle != null)
            {
                this.FixedCycle = fixedCycle;
            }

            if (fixedCycleAmount != null)
            {
                this.FixedCycleAmount = fixedCycleAmount;
            }

            if (supportedPaymentTypes != null)
            {
                this.SupportedPaymentTypes = supportedPaymentTypes;
            }
            this.MinChargeAmount = minChargeAmount;

            if (maxPayoutPeriod != null)
            {
                this.MaxPayoutPeriod = maxPayoutPeriod;
            }
        }

        /// <summary>
        /// Enables limited-cycle subscription plans.
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
        /// Allows plans limited by a fixed number of cycles.
        /// </summary>
        [JsonProperty("fixed_cycle")]
        public bool? FixedCycle
        {
            get
            {
                return this.fixedCycle;
            }

            set
            {
                this.shouldSerialize["fixed_cycle"] = true;
                this.fixedCycle = value;
            }
        }

        /// <summary>
        /// Allows plans limited by a total target amount.
        /// </summary>
        [JsonProperty("fixed_cycle_amount")]
        public bool? FixedCycleAmount
        {
            get
            {
                return this.fixedCycleAmount;
            }

            set
            {
                this.shouldSerialize["fixed_cycle_amount"] = true;
                this.fixedCycleAmount = value;
            }
        }

        /// <summary>
        /// Payment types that can use subscription plans.
        /// </summary>
        [JsonProperty("supported_payment_types")]
        public List<string> SupportedPaymentTypes
        {
            get
            {
                return this.supportedPaymentTypes;
            }

            set
            {
                this.shouldSerialize["supported_payment_types"] = true;
                this.supportedPaymentTypes = value;
            }
        }

        /// <summary>
        /// Monetary amount object serialized by backend config models.
        /// </summary>
        [JsonProperty("min_charge_amount", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MerchantWebhookMoneyAmount MinChargeAmount { get; set; }

        /// <summary>
        /// Maximum payout delay allowed for subscription plan settlements.
        /// </summary>
        [JsonProperty("max_payout_period")]
        public string MaxPayoutPeriod
        {
            get
            {
                return this.maxPayoutPeriod;
            }

            set
            {
                this.shouldSerialize["max_payout_period"] = true;
                this.maxPayoutPeriod = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"MerchantWebhookSubscriptionPlanConfiguration : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetFixedCycle()
        {
            this.shouldSerialize["fixed_cycle"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetFixedCycleAmount()
        {
            this.shouldSerialize["fixed_cycle_amount"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetSupportedPaymentTypes()
        {
            this.shouldSerialize["supported_payment_types"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetMaxPayoutPeriod()
        {
            this.shouldSerialize["max_payout_period"] = false;
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
        public bool ShouldSerializeFixedCycle()
        {
            return this.shouldSerialize["fixed_cycle"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFixedCycleAmount()
        {
            return this.shouldSerialize["fixed_cycle_amount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSupportedPaymentTypes()
        {
            return this.shouldSerialize["supported_payment_types"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMaxPayoutPeriod()
        {
            return this.shouldSerialize["max_payout_period"];
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Enabled = {(this.Enabled == null ? "null" : this.Enabled.ToString())}");
            toStringOutput.Add($"FixedCycle = {(this.FixedCycle == null ? "null" : this.FixedCycle.ToString())}");
            toStringOutput.Add($"FixedCycleAmount = {(this.FixedCycleAmount == null ? "null" : this.FixedCycleAmount.ToString())}");
            toStringOutput.Add($"SupportedPaymentTypes = {(this.SupportedPaymentTypes == null ? "null" : $"[{string.Join(", ", this.SupportedPaymentTypes)} ]")}");
            toStringOutput.Add($"MinChargeAmount = {(this.MinChargeAmount == null ? "null" : this.MinChargeAmount.ToString())}");
            toStringOutput.Add($"MaxPayoutPeriod = {this.MaxPayoutPeriod ?? "null"}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}
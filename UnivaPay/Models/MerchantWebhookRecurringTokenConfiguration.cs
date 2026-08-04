// <copyright file="MerchantWebhookRecurringTokenConfiguration.cs" company="APIMatic">
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
    /// MerchantWebhookRecurringTokenConfiguration.
    /// </summary>
    public class MerchantWebhookRecurringTokenConfiguration
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

        private string recurringType;
        private string chargeWaitPeriod;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "recurring_type", false },
            { "charge_wait_period", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantWebhookRecurringTokenConfiguration"/> class.
        /// </summary>
        public MerchantWebhookRecurringTokenConfiguration()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantWebhookRecurringTokenConfiguration"/> class.
        /// </summary>
        /// <param name="recurringType">recurring_type.</param>
        /// <param name="chargeWaitPeriod">charge_wait_period.</param>
        /// <param name="cardChargeCvvConfirmation">card_charge_cvv_confirmation.</param>
        public MerchantWebhookRecurringTokenConfiguration(
            string recurringType = null,
            string chargeWaitPeriod = null,
            Models.MerchantWebhookRecurringCvvConfirmationConfig cardChargeCvvConfirmation = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();

            if (recurringType != null)
            {
                this.RecurringType = recurringType;
            }

            if (chargeWaitPeriod != null)
            {
                this.ChargeWaitPeriod = chargeWaitPeriod;
            }
            this.CardChargeCvvConfirmation = cardChargeCvvConfirmation;
        }

        /// <summary>
        /// Merchant recurring-token privilege.
        /// </summary>
        [JsonProperty("recurring_type")]
        public string RecurringType
        {
            get
            {
                return this.recurringType;
            }

            set
            {
                this.shouldSerialize["recurring_type"] = true;
                this.recurringType = value;
            }
        }

        /// <summary>
        /// ISO-8601 duration to wait before first recurring charge.
        /// </summary>
        [JsonProperty("charge_wait_period")]
        public string ChargeWaitPeriod
        {
            get
            {
                return this.chargeWaitPeriod;
            }

            set
            {
                this.shouldSerialize["charge_wait_period"] = true;
                this.chargeWaitPeriod = value;
            }
        }

        /// <summary>
        /// CVV confirmation rules for recurring token charges.
        /// </summary>
        [JsonProperty("card_charge_cvv_confirmation", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MerchantWebhookRecurringCvvConfirmationConfig CardChargeCvvConfirmation { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"MerchantWebhookRecurringTokenConfiguration : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetRecurringType()
        {
            this.shouldSerialize["recurring_type"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetChargeWaitPeriod()
        {
            this.shouldSerialize["charge_wait_period"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRecurringType()
        {
            return this.shouldSerialize["recurring_type"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeChargeWaitPeriod()
        {
            return this.shouldSerialize["charge_wait_period"];
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"RecurringType = {this.RecurringType ?? "null"}");
            toStringOutput.Add($"ChargeWaitPeriod = {this.ChargeWaitPeriod ?? "null"}");
            toStringOutput.Add($"CardChargeCvvConfirmation = {(this.CardChargeCvvConfirmation == null ? "null" : this.CardChargeCvvConfirmation.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}
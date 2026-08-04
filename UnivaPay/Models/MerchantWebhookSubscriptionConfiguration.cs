// <copyright file="MerchantWebhookSubscriptionConfiguration.cs" company="APIMatic">
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
    /// MerchantWebhookSubscriptionConfiguration.
    /// </summary>
    public class MerchantWebhookSubscriptionConfiguration
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
        private int? failedChargesToCancel;
        private bool? suspendOnCancel;
        private bool? allowMerchantAmountPatch;
        private bool? allowMerchantDueDatePatch;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "enabled", false },
            { "failed_charges_to_cancel", false },
            { "suspend_on_cancel", false },
            { "allow_merchant_amount_patch", false },
            { "allow_merchant_due_date_patch", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantWebhookSubscriptionConfiguration"/> class.
        /// </summary>
        public MerchantWebhookSubscriptionConfiguration()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantWebhookSubscriptionConfiguration"/> class.
        /// </summary>
        /// <param name="enabled">enabled.</param>
        /// <param name="failedChargesToCancel">failed_charges_to_cancel.</param>
        /// <param name="suspendOnCancel">suspend_on_cancel.</param>
        /// <param name="allowMerchantAmountPatch">allow_merchant_amount_patch.</param>
        /// <param name="allowMerchantDueDatePatch">allow_merchant_due_date_patch.</param>
        public MerchantWebhookSubscriptionConfiguration(
            bool? enabled = null,
            int? failedChargesToCancel = null,
            bool? suspendOnCancel = null,
            bool? allowMerchantAmountPatch = null,
            bool? allowMerchantDueDatePatch = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();

            if (enabled != null)
            {
                this.Enabled = enabled;
            }

            if (failedChargesToCancel != null)
            {
                this.FailedChargesToCancel = failedChargesToCancel;
            }

            if (suspendOnCancel != null)
            {
                this.SuspendOnCancel = suspendOnCancel;
            }

            if (allowMerchantAmountPatch != null)
            {
                this.AllowMerchantAmountPatch = allowMerchantAmountPatch;
            }

            if (allowMerchantDueDatePatch != null)
            {
                this.AllowMerchantDueDatePatch = allowMerchantDueDatePatch;
            }
        }

        /// <summary>
        /// Enables subscription payments.
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
        /// Number of failed charges allowed before cancellation.
        /// </summary>
        [JsonProperty("failed_charges_to_cancel")]
        public int? FailedChargesToCancel
        {
            get
            {
                return this.failedChargesToCancel;
            }

            set
            {
                this.shouldSerialize["failed_charges_to_cancel"] = true;
                this.failedChargesToCancel = value;
            }
        }

        /// <summary>
        /// Suspends the subscription when its latest charge is canceled.
        /// </summary>
        [JsonProperty("suspend_on_cancel")]
        public bool? SuspendOnCancel
        {
            get
            {
                return this.suspendOnCancel;
            }

            set
            {
                this.shouldSerialize["suspend_on_cancel"] = true;
                this.suspendOnCancel = value;
            }
        }

        /// <summary>
        /// Allows merchants to update scheduled subscription amounts.
        /// </summary>
        [JsonProperty("allow_merchant_amount_patch")]
        public bool? AllowMerchantAmountPatch
        {
            get
            {
                return this.allowMerchantAmountPatch;
            }

            set
            {
                this.shouldSerialize["allow_merchant_amount_patch"] = true;
                this.allowMerchantAmountPatch = value;
            }
        }

        /// <summary>
        /// Allows merchants to update scheduled subscription due dates.
        /// </summary>
        [JsonProperty("allow_merchant_due_date_patch")]
        public bool? AllowMerchantDueDatePatch
        {
            get
            {
                return this.allowMerchantDueDatePatch;
            }

            set
            {
                this.shouldSerialize["allow_merchant_due_date_patch"] = true;
                this.allowMerchantDueDatePatch = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"MerchantWebhookSubscriptionConfiguration : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetFailedChargesToCancel()
        {
            this.shouldSerialize["failed_charges_to_cancel"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetSuspendOnCancel()
        {
            this.shouldSerialize["suspend_on_cancel"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAllowMerchantAmountPatch()
        {
            this.shouldSerialize["allow_merchant_amount_patch"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAllowMerchantDueDatePatch()
        {
            this.shouldSerialize["allow_merchant_due_date_patch"] = false;
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
        public bool ShouldSerializeFailedChargesToCancel()
        {
            return this.shouldSerialize["failed_charges_to_cancel"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSuspendOnCancel()
        {
            return this.shouldSerialize["suspend_on_cancel"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAllowMerchantAmountPatch()
        {
            return this.shouldSerialize["allow_merchant_amount_patch"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAllowMerchantDueDatePatch()
        {
            return this.shouldSerialize["allow_merchant_due_date_patch"];
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Enabled = {(this.Enabled == null ? "null" : this.Enabled.ToString())}");
            toStringOutput.Add($"FailedChargesToCancel = {(this.FailedChargesToCancel == null ? "null" : this.FailedChargesToCancel.ToString())}");
            toStringOutput.Add($"SuspendOnCancel = {(this.SuspendOnCancel == null ? "null" : this.SuspendOnCancel.ToString())}");
            toStringOutput.Add($"AllowMerchantAmountPatch = {(this.AllowMerchantAmountPatch == null ? "null" : this.AllowMerchantAmountPatch.ToString())}");
            toStringOutput.Add($"AllowMerchantDueDatePatch = {(this.AllowMerchantDueDatePatch == null ? "null" : this.AllowMerchantDueDatePatch.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}
// <copyright file="MerchantWebhookLimitRefundBySalesConfiguration.cs" company="APIMatic">
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
    /// MerchantWebhookLimitRefundBySalesConfiguration.
    /// </summary>
    public class MerchantWebhookLimitRefundBySalesConfiguration
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
        private string period;
        private bool? rollingWindow;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "enabled", false },
            { "period", false },
            { "rolling_window", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantWebhookLimitRefundBySalesConfiguration"/> class.
        /// </summary>
        public MerchantWebhookLimitRefundBySalesConfiguration()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantWebhookLimitRefundBySalesConfiguration"/> class.
        /// </summary>
        /// <param name="enabled">enabled.</param>
        /// <param name="period">period.</param>
        /// <param name="rollingWindow">rolling_window.</param>
        public MerchantWebhookLimitRefundBySalesConfiguration(
            bool? enabled = null,
            string period = null,
            bool? rollingWindow = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();

            if (enabled != null)
            {
                this.Enabled = enabled;
            }

            if (period != null)
            {
                this.Period = period;
            }

            if (rollingWindow != null)
            {
                this.RollingWindow = rollingWindow;
            }
        }

        /// <summary>
        /// Enables sales-based refund limit checks.
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
        /// Sales aggregation period used to evaluate refund limits.
        /// </summary>
        [JsonProperty("period")]
        public string Period
        {
            get
            {
                return this.period;
            }

            set
            {
                this.shouldSerialize["period"] = true;
                this.period = value;
            }
        }

        /// <summary>
        /// Uses a rolling window instead of fixed calendar periods.
        /// </summary>
        [JsonProperty("rolling_window")]
        public bool? RollingWindow
        {
            get
            {
                return this.rollingWindow;
            }

            set
            {
                this.shouldSerialize["rolling_window"] = true;
                this.rollingWindow = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"MerchantWebhookLimitRefundBySalesConfiguration : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetPeriod()
        {
            this.shouldSerialize["period"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetRollingWindow()
        {
            this.shouldSerialize["rolling_window"] = false;
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
        public bool ShouldSerializePeriod()
        {
            return this.shouldSerialize["period"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRollingWindow()
        {
            return this.shouldSerialize["rolling_window"];
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Enabled = {(this.Enabled == null ? "null" : this.Enabled.ToString())}");
            toStringOutput.Add($"Period = {this.Period ?? "null"}");
            toStringOutput.Add($"RollingWindow = {(this.RollingWindow == null ? "null" : this.RollingWindow.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}
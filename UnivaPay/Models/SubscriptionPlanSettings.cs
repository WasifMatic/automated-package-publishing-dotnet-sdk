// <copyright file="SubscriptionPlanSettings.cs" company="APIMatic">
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
    /// SubscriptionPlanSettings.
    /// </summary>
    public class SubscriptionPlanSettings
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

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPlanSettings"/> class.
        /// </summary>
        public SubscriptionPlanSettings()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPlanSettings"/> class.
        /// </summary>
        /// <param name="planType">plan_type.</param>
        /// <param name="fixedCycles">fixed_cycles.</param>
        /// <param name="fixedCycleAmount">fixed_cycle_amount.</param>
        public SubscriptionPlanSettings(
            Models.PlanSettingsType? planType = null,
            int? fixedCycles = null,
            int? fixedCycleAmount = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.PlanType = planType;
            this.FixedCycles = fixedCycles;
            this.FixedCycleAmount = fixedCycleAmount;
        }

        /// <summary>
        /// Plan type selector.
        /// </summary>
        [JsonProperty("plan_type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PlanSettingsType? PlanType { get; set; }

        /// <summary>
        /// Number of cycles for fixed_cycles plan.
        /// </summary>
        [JsonProperty("fixed_cycles", NullValueHandling = NullValueHandling.Ignore)]
        public int? FixedCycles { get; set; }

        /// <summary>
        /// Total target amount for fixed_cycle_amount plan.
        /// </summary>
        [JsonProperty("fixed_cycle_amount", NullValueHandling = NullValueHandling.Ignore)]
        public int? FixedCycleAmount { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"SubscriptionPlanSettings : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"PlanType = {(this.PlanType == null ? "null" : this.PlanType.ToString())}");
            toStringOutput.Add($"FixedCycles = {(this.FixedCycles == null ? "null" : this.FixedCycles.ToString())}");
            toStringOutput.Add($"FixedCycleAmount = {(this.FixedCycleAmount == null ? "null" : this.FixedCycleAmount.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}
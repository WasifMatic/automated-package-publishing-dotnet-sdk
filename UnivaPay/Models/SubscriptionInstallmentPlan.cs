// <copyright file="SubscriptionInstallmentPlan.cs" company="APIMatic">
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
    /// SubscriptionInstallmentPlan.
    /// </summary>
    public class SubscriptionInstallmentPlan
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
        /// Initializes a new instance of the <see cref="SubscriptionInstallmentPlan"/> class.
        /// </summary>
        public SubscriptionInstallmentPlan()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionInstallmentPlan"/> class.
        /// </summary>
        /// <param name="planType">plan_type.</param>
        /// <param name="fixedCycles">fixed_cycles.</param>
        public SubscriptionInstallmentPlan(
            Models.InstallmentPlanType? planType = null,
            Models.InstallmentFixedCycles? fixedCycles = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.PlanType = planType;
            this.FixedCycles = fixedCycles;
        }

        /// <summary>
        /// Plan type selector.
        /// </summary>
        [JsonProperty("plan_type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.InstallmentPlanType? PlanType { get; set; }

        /// <summary>
        /// Required if plan_type is fixed_cycles.
        /// </summary>
        [JsonProperty("fixed_cycles", NullValueHandling = NullValueHandling.Ignore)]
        public Models.InstallmentFixedCycles? FixedCycles { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"SubscriptionInstallmentPlan : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"PlanType = {(this.PlanType == null ? "null" : this.PlanType.ToString())}");
            toStringOutput.Add($"FixedCycles = {(this.FixedCycles == null ? "null" : this.FixedCycles.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}
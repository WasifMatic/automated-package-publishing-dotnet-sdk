// <copyright file="CardProcessorInstallmentConfig.cs" company="APIMatic">
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
    /// CardProcessorInstallmentConfig.
    /// </summary>
    public class CardProcessorInstallmentConfig
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

        private bool? revolving;
        private bool? fixedCycle;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "revolving", false },
            { "fixed_cycle", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CardProcessorInstallmentConfig"/> class.
        /// </summary>
        public CardProcessorInstallmentConfig()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardProcessorInstallmentConfig"/> class.
        /// </summary>
        /// <param name="revolving">revolving.</param>
        /// <param name="fixedCycle">fixed_cycle.</param>
        public CardProcessorInstallmentConfig(
            bool? revolving = null,
            bool? fixedCycle = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();

            if (revolving != null)
            {
                this.Revolving = revolving;
            }

            if (fixedCycle != null)
            {
                this.FixedCycle = fixedCycle;
            }
        }

        /// <summary>
        /// Allows revolving payments through supported processors.
        /// </summary>
        [JsonProperty("revolving")]
        public bool? Revolving
        {
            get
            {
                return this.revolving;
            }

            set
            {
                this.shouldSerialize["revolving"] = true;
                this.revolving = value;
            }
        }

        /// <summary>
        /// Allows fixed-cycle installment payments through supported processors.
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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CardProcessorInstallmentConfig : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetRevolving()
        {
            this.shouldSerialize["revolving"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetFixedCycle()
        {
            this.shouldSerialize["fixed_cycle"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRevolving()
        {
            return this.shouldSerialize["revolving"];
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
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Revolving = {(this.Revolving == null ? "null" : this.Revolving.ToString())}");
            toStringOutput.Add($"FixedCycle = {(this.FixedCycle == null ? "null" : this.FixedCycle.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}
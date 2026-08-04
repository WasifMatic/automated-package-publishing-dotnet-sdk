// <copyright file="MerchantWebhookCheckoutConfiguration.cs" company="APIMatic">
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
    /// MerchantWebhookCheckoutConfiguration.
    /// </summary>
    public class MerchantWebhookCheckoutConfiguration
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
        /// Initializes a new instance of the <see cref="MerchantWebhookCheckoutConfiguration"/> class.
        /// </summary>
        public MerchantWebhookCheckoutConfiguration()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantWebhookCheckoutConfiguration"/> class.
        /// </summary>
        /// <param name="ecEmail">ec_email.</param>
        /// <param name="ecProducts">ec_products.</param>
        public MerchantWebhookCheckoutConfiguration(
            Models.MerchantWebhookCheckoutToggle ecEmail = null,
            Models.MerchantWebhookCheckoutToggle ecProducts = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.EcEmail = ecEmail;
            this.EcProducts = ecProducts;
        }

        /// <summary>
        /// Checkout feature toggle.
        /// </summary>
        [JsonProperty("ec_email", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MerchantWebhookCheckoutToggle EcEmail { get; set; }

        /// <summary>
        /// Checkout feature toggle.
        /// </summary>
        [JsonProperty("ec_products", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MerchantWebhookCheckoutToggle EcProducts { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"MerchantWebhookCheckoutConfiguration : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"EcEmail = {(this.EcEmail == null ? "null" : this.EcEmail.ToString())}");
            toStringOutput.Add($"EcProducts = {(this.EcProducts == null ? "null" : this.EcProducts.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}
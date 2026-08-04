// <copyright file="TransactionTokenCreateRequestMetadata.cs" company="APIMatic">
// UnivaPay
//
// This file was automatically generated for Univapay by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnivaPay.Models.Containers;
using UnivaPay.Utilities;

namespace UnivaPay.Models
{
    /// <summary>
    /// TransactionTokenCreateRequestMetadata.
    /// </summary>
    public class TransactionTokenCreateRequestMetadata
    {
        [JsonExtensionData]
        private readonly IDictionary<string, JToken> additionalProperties;

        private readonly IEnumerable<string> propertyName;

        /// <summary>
        /// Get or set the value associated with the specified key in the AdditionalProperties dictionary.
        /// </summary>
        /// <param name="key">The key of the value to get or set. This must be a valid key that is not reserved for internal properties.</param>
        /// <returns>The TransactionTokenCreateMetadataProps value associated with the specified key in the AdditionalProperties dictionary.</returns>
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
        public TransactionTokenCreateMetadataProps this[string key]
        {
            get => additionalProperties.GetValue<TransactionTokenCreateMetadataProps>(key);
            set => additionalProperties.SetValue(key, value, propertyName);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionTokenCreateRequestMetadata"/> class.
        /// </summary>
        public TransactionTokenCreateRequestMetadata()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionTokenCreateRequestMetadata"/> class.
        /// </summary>
        /// <param name="univapayReferenceId">univapay-reference-id.</param>
        /// <param name="univapayCustomerId">univapay-customer-id.</param>
        /// <param name="univapayName">univapay-name.</param>
        /// <param name="univapayPhoneNumber">univapay-phone-number.</param>
        public TransactionTokenCreateRequestMetadata(
            string univapayReferenceId = null,
            Guid? univapayCustomerId = null,
            string univapayName = null,
            string univapayPhoneNumber = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.UnivapayReferenceId = univapayReferenceId;
            this.UnivapayCustomerId = univapayCustomerId;
            this.UnivapayName = univapayName;
            this.UnivapayPhoneNumber = univapayPhoneNumber;
        }

        /// <summary>
        /// Any arbitrary value (Free format).
        /// </summary>
        [JsonProperty("univapay-reference-id", NullValueHandling = NullValueHandling.Ignore)]
        public string UnivapayReferenceId { get; set; }

        /// <summary>
        /// Customer ID.
        /// </summary>
        [JsonProperty("univapay-customer-id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? UnivapayCustomerId { get; set; }

        /// <summary>
        /// Consumer name passed to payment processors that require it (e.g., konbini, bank transfer).
        /// </summary>
        [JsonProperty("univapay-name", NullValueHandling = NullValueHandling.Ignore)]
        public string UnivapayName { get; set; }

        /// <summary>
        /// Consumer phone number passed to payment processors that require it.
        /// </summary>
        [JsonProperty("univapay-phone-number", NullValueHandling = NullValueHandling.Ignore)]
        public string UnivapayPhoneNumber { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"TransactionTokenCreateRequestMetadata : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"UnivapayReferenceId = {this.UnivapayReferenceId ?? "null"}");
            toStringOutput.Add($"UnivapayCustomerId = {(this.UnivapayCustomerId == null ? "null" : this.UnivapayCustomerId.ToString())}");
            toStringOutput.Add($"UnivapayName = {this.UnivapayName ?? "null"}");
            toStringOutput.Add($"UnivapayPhoneNumber = {this.UnivapayPhoneNumber ?? "null"}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {this[kvp.Key]}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}
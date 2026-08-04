// <copyright file="TokenResponseCardData.cs" company="APIMatic">
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
    /// TokenResponseCardData.
    /// </summary>
    public class TokenResponseCardData
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
        /// Initializes a new instance of the <see cref="TokenResponseCardData"/> class.
        /// </summary>
        public TokenResponseCardData()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenResponseCardData"/> class.
        /// </summary>
        /// <param name="card">card.</param>
        /// <param name="billing">billing.</param>
        /// <param name="cvvAuthorize">cvv_authorize.</param>
        /// <param name="cvvAuthorizeCheck">cvv_authorize_check.</param>
        /// <param name="threeDs">three_ds.</param>
        public TokenResponseCardData(
            Models.TokenResponseCardDataCard card = null,
            Models.TokenResponseCardDataBilling billing = null,
            Models.TokenResponseCardDataCvvAuthorize cvvAuthorize = null,
            Models.TokenResponseCardDataCvvAuthorizeCheck cvvAuthorizeCheck = null,
            Models.TokenResponseCardDataThreeDs threeDs = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.Card = card;
            this.Billing = billing;
            this.CvvAuthorize = cvvAuthorize;
            this.CvvAuthorizeCheck = cvvAuthorizeCheck;
            this.ThreeDs = threeDs;
        }

        /// <summary>
        /// Token Response Card Data Card schema.
        /// </summary>
        [JsonProperty("card", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TokenResponseCardDataCard Card { get; set; }

        /// <summary>
        /// Token Response Card Data Billing schema.
        /// </summary>
        [JsonProperty("billing", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TokenResponseCardDataBilling Billing { get; set; }

        /// <summary>
        /// Token Response Card Data Cvv Authorize schema.
        /// </summary>
        [JsonProperty("cvv_authorize", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TokenResponseCardDataCvvAuthorize CvvAuthorize { get; set; }

        /// <summary>
        /// Token Response Card Data Cvv Authorize Check schema.
        /// </summary>
        [JsonProperty("cvv_authorize_check", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TokenResponseCardDataCvvAuthorizeCheck CvvAuthorizeCheck { get; set; }

        /// <summary>
        /// Token Response Card Data Three Ds schema.
        /// </summary>
        [JsonProperty("three_ds", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TokenResponseCardDataThreeDs ThreeDs { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"TokenResponseCardData : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Card = {(this.Card == null ? "null" : this.Card.ToString())}");
            toStringOutput.Add($"Billing = {(this.Billing == null ? "null" : this.Billing.ToString())}");
            toStringOutput.Add($"CvvAuthorize = {(this.CvvAuthorize == null ? "null" : this.CvvAuthorize.ToString())}");
            toStringOutput.Add($"CvvAuthorizeCheck = {(this.CvvAuthorizeCheck == null ? "null" : this.CvvAuthorizeCheck.ToString())}");
            toStringOutput.Add($"ThreeDs = {(this.ThreeDs == null ? "null" : this.ThreeDs.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}
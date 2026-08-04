// <copyright file="TokenCreateKonbiniData.cs" company="APIMatic">
// UnivaPay
//
// This file was automatically generated for Univapay by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnivaPay.Utilities;

namespace UnivaPay.Models
{
    /// <summary>
    /// TokenCreateKonbiniData.
    /// </summary>
    public class TokenCreateKonbiniData
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
        /// Initializes a new instance of the <see cref="TokenCreateKonbiniData"/> class.
        /// </summary>
        public TokenCreateKonbiniData()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenCreateKonbiniData"/> class.
        /// </summary>
        /// <param name="customerName">customer_name.</param>
        /// <param name="convenienceStore">convenience_store.</param>
        /// <param name="phoneNumber">phone_number.</param>
        /// <param name="expirationPeriod">expiration_period.</param>
        /// <param name="expirationTimeShift">expiration_time_shift.</param>
        public TokenCreateKonbiniData(
            string customerName,
            Models.BaseKonbiniDataConvenienceStore convenienceStore,
            Models.TokenCreatePhoneNumber phoneNumber,
            string expirationPeriod = null,
            string expirationTimeShift = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.CustomerName = customerName;
            this.ConvenienceStore = convenienceStore;
            this.ExpirationPeriod = expirationPeriod;
            this.PhoneNumber = phoneNumber;
            this.ExpirationTimeShift = expirationTimeShift;
        }

        /// <summary>
        /// Customer name.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("customer_name")]
        [JsonRequired]
        public string CustomerName { get; set; }

        /// <summary>
        /// Base Konbini Data Convenience Store schema.
        /// </summary>
        [JsonProperty("convenience_store")]
        [JsonRequired]
        public Models.BaseKonbiniDataConvenienceStore ConvenienceStore { get; set; }

        /// <summary>
        /// ISO-8601 Duration (e.g., 'P7D'). Default is 30 days.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("expiration_period", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpirationPeriod { get; set; }

        /// <summary>
        /// Token Create Phone Number schema.
        /// </summary>
        [JsonProperty("phone_number")]
        [JsonRequired]
        public Models.TokenCreatePhoneNumber PhoneNumber { get; set; }

        /// <summary>
        /// Expiration time shift value.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("expiration_time_shift", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpirationTimeShift { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"TokenCreateKonbiniData : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"CustomerName = {this.CustomerName ?? "null"}");
            toStringOutput.Add($"ConvenienceStore = {this.ConvenienceStore}");
            toStringOutput.Add($"ExpirationPeriod = {this.ExpirationPeriod ?? "null"}");
            toStringOutput.Add($"PhoneNumber = {(this.PhoneNumber == null ? "null" : this.PhoneNumber.ToString())}");
            toStringOutput.Add($"ExpirationTimeShift = {this.ExpirationTimeShift ?? "null"}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}
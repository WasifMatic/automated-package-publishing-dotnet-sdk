// <copyright file="TokenResponseKonbiniData.cs" company="APIMatic">
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
    /// TokenResponseKonbiniData.
    /// </summary>
    public class TokenResponseKonbiniData
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

        private string expirationTimeShift;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "expiration_time_shift", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenResponseKonbiniData"/> class.
        /// </summary>
        public TokenResponseKonbiniData()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenResponseKonbiniData"/> class.
        /// </summary>
        /// <param name="customerName">customer_name.</param>
        /// <param name="convenienceStore">convenience_store.</param>
        /// <param name="expirationPeriod">expiration_period.</param>
        /// <param name="expirationTimeShift">expiration_time_shift.</param>
        /// <param name="phoneNumber">phone_number.</param>
        public TokenResponseKonbiniData(
            string customerName = null,
            Models.BaseKonbiniDataConvenienceStore? convenienceStore = null,
            string expirationPeriod = null,
            string expirationTimeShift = null,
            Models.TokenResponsePhoneNumber phoneNumber = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.CustomerName = customerName;
            this.ConvenienceStore = convenienceStore;
            this.ExpirationPeriod = expirationPeriod;

            if (expirationTimeShift != null)
            {
                this.ExpirationTimeShift = expirationTimeShift;
            }
            this.PhoneNumber = phoneNumber;
        }

        /// <summary>
        /// Customer name.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("customer_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerName { get; set; }

        /// <summary>
        /// Base Konbini Data Convenience Store schema.
        /// </summary>
        [JsonProperty("convenience_store", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BaseKonbiniDataConvenienceStore? ConvenienceStore { get; set; }

        /// <summary>
        /// ISO-8601 Duration (e.g., 'P7D'). Default is 30 days.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("expiration_period", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpirationPeriod { get; set; }

        /// <summary>
        /// Time shift applied to the expiration, typically pushing it to the end of the day in a specific timezone (e.g., '23:59:59.999999+09:00').
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("expiration_time_shift")]
        public string ExpirationTimeShift
        {
            get
            {
                return this.expirationTimeShift;
            }

            set
            {
                this.shouldSerialize["expiration_time_shift"] = true;
                this.expirationTimeShift = value;
            }
        }

        /// <summary>
        /// Token Response Phone Number schema.
        /// </summary>
        [JsonProperty("phone_number", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TokenResponsePhoneNumber PhoneNumber { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"TokenResponseKonbiniData : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetExpirationTimeShift()
        {
            this.shouldSerialize["expiration_time_shift"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeExpirationTimeShift()
        {
            return this.shouldSerialize["expiration_time_shift"];
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"CustomerName = {this.CustomerName ?? "null"}");
            toStringOutput.Add($"ConvenienceStore = {(this.ConvenienceStore == null ? "null" : this.ConvenienceStore.ToString())}");
            toStringOutput.Add($"ExpirationPeriod = {this.ExpirationPeriod ?? "null"}");
            toStringOutput.Add($"ExpirationTimeShift = {this.ExpirationTimeShift ?? "null"}");
            toStringOutput.Add($"PhoneNumber = {(this.PhoneNumber == null ? "null" : this.PhoneNumber.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}
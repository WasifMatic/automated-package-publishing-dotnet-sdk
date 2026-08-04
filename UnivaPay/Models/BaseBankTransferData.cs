// <copyright file="BaseBankTransferData.cs" company="APIMatic">
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
    /// BaseBankTransferData.
    /// </summary>
    public class BaseBankTransferData
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
        /// Initializes a new instance of the <see cref="BaseBankTransferData"/> class.
        /// </summary>
        public BaseBankTransferData()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseBankTransferData"/> class.
        /// </summary>
        /// <param name="brand">brand.</param>
        /// <param name="expirationPeriod">expiration_period.</param>
        /// <param name="expirationTimeShift">expiration_time_shift.</param>
        public BaseBankTransferData(
            string brand = null,
            string expirationPeriod = null,
            string expirationTimeShift = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.Brand = brand;
            this.ExpirationPeriod = expirationPeriod;
            this.ExpirationTimeShift = expirationTimeShift;
        }

        /// <summary>
        /// The bank brand identifier (e.g., 'aozora_bank').
        /// </summary>
        [JsonProperty("brand", NullValueHandling = NullValueHandling.Ignore)]
        public string Brand { get; set; }

        /// <summary>
        /// ISO 8601 duration format (e.g., 'PT168H').
        /// </summary>
        [JsonProperty("expiration_period", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpirationPeriod { get; set; }

        /// <summary>
        /// Time shift applied to the expiration, typically pushing it to the end of the day  in a specific timezone (e.g., '23:59:59+09:00').
        /// </summary>
        [JsonProperty("expiration_time_shift", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpirationTimeShift { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"BaseBankTransferData : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Brand = {this.Brand ?? "null"}");
            toStringOutput.Add($"ExpirationPeriod = {this.ExpirationPeriod ?? "null"}");
            toStringOutput.Add($"ExpirationTimeShift = {this.ExpirationTimeShift ?? "null"}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}
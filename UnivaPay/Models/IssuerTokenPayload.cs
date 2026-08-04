// <copyright file="IssuerTokenPayload.cs" company="APIMatic">
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
    /// IssuerTokenPayload.
    /// </summary>
    public class IssuerTokenPayload
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
        /// Initializes a new instance of the <see cref="IssuerTokenPayload"/> class.
        /// </summary>
        public IssuerTokenPayload()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuerTokenPayload"/> class.
        /// </summary>
        /// <param name="requestData">request_data.</param>
        /// <param name="sSpcd">sSpcd.</param>
        /// <param name="sCptok">sCptok.</param>
        /// <param name="sTerkn">sTerkn.</param>
        public IssuerTokenPayload(
            string requestData = null,
            string sSpcd = null,
            string sCptok = null,
            string sTerkn = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.RequestData = requestData;
            this.SSpcd = sSpcd;
            this.SCptok = sCptok;
            this.STerkn = sTerkn;
        }

        /// <summary>
        /// Generic payload key used by most payment providers.
        /// </summary>
        [JsonProperty("request_data", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestData { get; set; }

        /// <summary>
        /// d-barai payment service code.
        /// </summary>
        [JsonProperty("sSpcd", NullValueHandling = NullValueHandling.Ignore)]
        public string SSpcd { get; set; }

        /// <summary>
        /// d-barai coupon token.
        /// </summary>
        [JsonProperty("sCptok", NullValueHandling = NullValueHandling.Ignore)]
        public string SCptok { get; set; }

        /// <summary>
        /// d-barai terminal key.
        /// </summary>
        [JsonProperty("sTerkn", NullValueHandling = NullValueHandling.Ignore)]
        public string STerkn { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"IssuerTokenPayload : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"RequestData = {this.RequestData ?? "null"}");
            toStringOutput.Add($"SSpcd = {this.SSpcd ?? "null"}");
            toStringOutput.Add($"SCptok = {this.SCptok ?? "null"}");
            toStringOutput.Add($"STerkn = {this.STerkn ?? "null"}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}
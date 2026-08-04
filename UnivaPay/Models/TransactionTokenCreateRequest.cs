// <copyright file="TransactionTokenCreateRequest.cs" company="APIMatic">
// UnivaPay
//
// This file was automatically generated for Univapay by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnivaPay.Models.Containers;
using UnivaPay.Utilities;

namespace UnivaPay.Models
{
    /// <summary>
    /// TransactionTokenCreateRequest.
    /// </summary>
    public class TransactionTokenCreateRequest
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
        /// Initializes a new instance of the <see cref="TransactionTokenCreateRequest"/> class.
        /// </summary>
        public TransactionTokenCreateRequest()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionTokenCreateRequest"/> class.
        /// </summary>
        /// <param name="paymentType">payment_type.</param>
        /// <param name="type">type.</param>
        /// <param name="data">data.</param>
        /// <param name="email">email.</param>
        /// <param name="usageLimit">usage_limit.</param>
        /// <param name="ipAddress">ip_address.</param>
        /// <param name="metadata">metadata.</param>
        public TransactionTokenCreateRequest(
            Models.TransactionTokenCreateRequestPaymentType paymentType,
            Models.TransactionTokenCreateRequestType type,
            TransactionTokenCreateRequestData data,
            string email = null,
            string usageLimit = null,
            string ipAddress = null,
            Models.TransactionTokenCreateRequestMetadata metadata = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.PaymentType = paymentType;
            this.Type = type;
            this.Email = email;
            this.UsageLimit = usageLimit;
            this.IpAddress = ipAddress;
            this.Metadata = metadata;
            this.Data = data;
        }

        /// <summary>
        /// Transaction Token Create Request Payment Type schema.
        /// </summary>
        [JsonProperty("payment_type")]
        public Models.TransactionTokenCreateRequestPaymentType PaymentType { get; set; }

        /// <summary>
        /// Transaction Token Create Request Type schema.
        /// </summary>
        [JsonProperty("type")]
        public Models.TransactionTokenCreateRequestType Type { get; set; }

        /// <summary>
        /// Customer email address.
        /// </summary>
        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        /// <summary>
        /// Usage limit applied to the token.
        /// </summary>
        [JsonProperty("usage_limit", NullValueHandling = NullValueHandling.Ignore)]
        public string UsageLimit { get; set; }

        /// <summary>
        /// Consumer's IPv4 address. **Required** when `data.brand` is `we_chat_online` and `data.call_method` is `web` or `http_get`.
        /// </summary>
        [JsonProperty("ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string IpAddress { get; set; }

        /// <summary>
        /// A free-form dictionary for custom metadata.
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TransactionTokenCreateRequestMetadata Metadata { get; set; }

        /// <summary>
        /// Transaction Token Create Request Data schema.
        /// </summary>
        [JsonProperty("data")]
        public TransactionTokenCreateRequestData Data { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"TransactionTokenCreateRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"PaymentType = {this.PaymentType}");
            toStringOutput.Add($"Type = {this.Type}");
            toStringOutput.Add($"Email = {this.Email ?? "null"}");
            toStringOutput.Add($"UsageLimit = {this.UsageLimit ?? "null"}");
            toStringOutput.Add($"IpAddress = {this.IpAddress ?? "null"}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"Data = {(this.Data == null ? "null" : this.Data.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}
// <copyright file="ThreeDsIssuerToken.cs" company="APIMatic">
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
    /// ThreeDsIssuerToken.
    /// </summary>
    public class ThreeDsIssuerToken
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

        private Models.IssuerTokenPayload payload;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "payload", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreeDsIssuerToken"/> class.
        /// </summary>
        public ThreeDsIssuerToken()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreeDsIssuerToken"/> class.
        /// </summary>
        /// <param name="paymentType">payment_type.</param>
        /// <param name="issuerToken">issuer_token.</param>
        /// <param name="callMethod">call_method.</param>
        /// <param name="contentType">content_type.</param>
        /// <param name="payload">payload.</param>
        public ThreeDsIssuerToken(
            string paymentType,
            string issuerToken,
            string callMethod,
            string contentType,
            Models.IssuerTokenPayload payload = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.PaymentType = paymentType;
            this.IssuerToken = issuerToken;
            this.CallMethod = callMethod;

            if (payload != null)
            {
                this.Payload = payload;
            }
            this.ContentType = contentType;
        }

        /// <summary>
        /// Only 'card' is supported for 3-D Secure issuer tokens.
        /// </summary>
        [JsonProperty("payment_type")]
        public string PaymentType { get; set; }

        /// <summary>
        /// The 3-D Secure authentication URL to which the client must send the request.
        /// </summary>
        [JsonProperty("issuer_token")]
        public string IssuerToken { get; set; }

        /// <summary>
        /// Execution method. Currently, only 'http_post' is supported.
        /// </summary>
        [JsonProperty("call_method")]
        public string CallMethod { get; set; }

        /// <summary>
        /// Key-value pairs required to complete the payment action, or null if not applicable. Used when `call_method` is `http_post`. When present, this JSON must be converted by the client to match the expected `content_type` (e.g., transformed into an `application/x-www-form-urlencoded` string) before sending the POST request.
        /// </summary>
        [JsonProperty("payload")]
        public Models.IssuerTokenPayload Payload
        {
            get
            {
                return this.payload;
            }

            set
            {
                this.shouldSerialize["payload"] = true;
                this.payload = value;
            }
        }

        /// <summary>
        /// The expected content type of the payload required by the card issuer's endpoint  (e.g., 'application/x-www-form-urlencoded; charset=UTF-8').
        /// </summary>
        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ThreeDsIssuerToken : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPayload()
        {
            this.shouldSerialize["payload"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePayload()
        {
            return this.shouldSerialize["payload"];
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"PaymentType = {this.PaymentType ?? "null"}");
            toStringOutput.Add($"IssuerToken = {this.IssuerToken ?? "null"}");
            toStringOutput.Add($"CallMethod = {this.CallMethod ?? "null"}");
            toStringOutput.Add($"Payload = {(this.Payload == null ? "null" : this.Payload.ToString())}");
            toStringOutput.Add($"ContentType = {this.ContentType ?? "null"}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}
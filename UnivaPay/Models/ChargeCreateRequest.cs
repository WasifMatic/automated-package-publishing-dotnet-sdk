// <copyright file="ChargeCreateRequest.cs" company="APIMatic">
// UnivaPay
//
// This file was automatically generated for Univapay by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnivaPay.Utilities;

namespace UnivaPay.Models
{
    /// <summary>
    /// ChargeCreateRequest.
    /// </summary>
    public class ChargeCreateRequest
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
        /// Initializes a new instance of the <see cref="ChargeCreateRequest"/> class.
        /// </summary>
        public ChargeCreateRequest()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChargeCreateRequest"/> class.
        /// </summary>
        /// <param name="transactionTokenId">transaction_token_id.</param>
        /// <param name="amount">amount.</param>
        /// <param name="currency">currency.</param>
        /// <param name="capture">capture.</param>
        /// <param name="captureAt">capture_at.</param>
        /// <param name="merchantTransactionId">merchant_transaction_id.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="clientMetadata">client_metadata.</param>
        /// <param name="redirect">redirect.</param>
        /// <param name="threeDs">three_ds.</param>
        public ChargeCreateRequest(
            Guid transactionTokenId,
            int amount,
            string currency,
            bool? capture = true,
            DateTime? captureAt = null,
            string merchantTransactionId = null,
            Models.GenericMetadata metadata = null,
            Models.ChargeCreateRequestClientMetadata clientMetadata = null,
            Models.ChargeCreateRequestRedirect redirect = null,
            Models.ChargeCreateRequestThreeDs threeDs = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.TransactionTokenId = transactionTokenId;
            this.Amount = amount;
            this.Currency = currency;
            this.Capture = capture;
            this.CaptureAt = captureAt;
            this.MerchantTransactionId = merchantTransactionId;
            this.Metadata = metadata;
            this.ClientMetadata = clientMetadata;
            this.Redirect = redirect;
            this.ThreeDs = threeDs;
        }

        /// <summary>
        /// Transaction token identifier.
        /// </summary>
        [JsonProperty("transaction_token_id")]
        public Guid TransactionTokenId { get; set; }

        /// <summary>
        /// The charge amount.
        /// </summary>
        [JsonProperty("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// ISO-4217 currency code.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// If false, creates an Authorization only (Hold).
        /// </summary>
        [JsonProperty("capture", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Capture { get; set; }

        /// <summary>
        /// Auto-capture date for cards, or payment deadline for Konbini/Bank. Note: Time specification is ignored for 7-Eleven, Seicomart, and PayEasy.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("capture_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CaptureAt { get; set; }

        /// <summary>
        /// Unique transaction ID for the merchant.  Required/used by specific brands like we_chat, we_chat_mpm, and we_chat_online.
        /// </summary>
        [JsonProperty("merchant_transaction_id", NullValueHandling = NullValueHandling.Ignore)]
        public string MerchantTransactionId { get; set; }

        /// <summary>
        /// A free-form dictionary for custom metadata.
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Models.GenericMetadata Metadata { get; set; }

        /// <summary>
        /// Charge Create Request Client Metadata schema.
        /// </summary>
        [JsonProperty("client_metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ChargeCreateRequestClientMetadata ClientMetadata { get; set; }

        /// <summary>
        /// Charge Create Request Redirect schema.
        /// </summary>
        [JsonProperty("redirect", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ChargeCreateRequestRedirect Redirect { get; set; }

        /// <summary>
        /// Charge Create Request Three Ds schema.
        /// </summary>
        [JsonProperty("three_ds", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ChargeCreateRequestThreeDs ThreeDs { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ChargeCreateRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"TransactionTokenId = {this.TransactionTokenId}");
            toStringOutput.Add($"Amount = {this.Amount}");
            toStringOutput.Add($"Currency = {this.Currency ?? "null"}");
            toStringOutput.Add($"Capture = {(this.Capture == null ? "null" : this.Capture.ToString())}");
            toStringOutput.Add($"CaptureAt = {(this.CaptureAt == null ? "null" : this.CaptureAt.ToString())}");
            toStringOutput.Add($"MerchantTransactionId = {this.MerchantTransactionId ?? "null"}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"ClientMetadata = {(this.ClientMetadata == null ? "null" : this.ClientMetadata.ToString())}");
            toStringOutput.Add($"Redirect = {(this.Redirect == null ? "null" : this.Redirect.ToString())}");
            toStringOutput.Add($"ThreeDs = {(this.ThreeDs == null ? "null" : this.ThreeDs.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}
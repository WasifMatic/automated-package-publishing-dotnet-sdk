// <copyright file="TransactionToken.cs" company="APIMatic">
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
using UnivaPay.Models.Containers;
using UnivaPay.Utilities;

namespace UnivaPay.Models
{
    /// <summary>
    /// TransactionToken.
    /// </summary>
    public class TransactionToken
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

        private string email;
        private string usageLimit;
        private bool? confirmed;
        private DateTime? lastUsedOn;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "email", false },
            { "usage_limit", false },
            { "confirmed", false },
            { "last_used_on", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionToken"/> class.
        /// </summary>
        public TransactionToken()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionToken"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="storeId">store_id.</param>
        /// <param name="email">email.</param>
        /// <param name="paymentType">payment_type.</param>
        /// <param name="active">active.</param>
        /// <param name="mode">mode.</param>
        /// <param name="type">type.</param>
        /// <param name="usageLimit">usage_limit.</param>
        /// <param name="confirmed">confirmed.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="createdOn">created_on.</param>
        /// <param name="updatedOn">updated_on.</param>
        /// <param name="lastUsedOn">last_used_on.</param>
        /// <param name="data">data.</param>
        public TransactionToken(
            Guid? id = null,
            Guid? storeId = null,
            string email = null,
            Models.TransactionTokenPaymentType? paymentType = null,
            bool? active = null,
            Models.TransactionTokenMode? mode = null,
            Models.TransactionTokenType? type = null,
            string usageLimit = null,
            bool? confirmed = null,
            Dictionary<string, TransactionTokenMetadataAdditionalProperties> metadata = null,
            DateTime? createdOn = null,
            DateTime? updatedOn = null,
            DateTime? lastUsedOn = null,
            TransactionTokenData data = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.Id = id;
            this.StoreId = storeId;

            if (email != null)
            {
                this.Email = email;
            }
            this.PaymentType = paymentType;
            this.Active = active;
            this.Mode = mode;
            this.Type = type;

            if (usageLimit != null)
            {
                this.UsageLimit = usageLimit;
            }

            if (confirmed != null)
            {
                this.Confirmed = confirmed;
            }
            this.Metadata = metadata;
            this.CreatedOn = createdOn;
            this.UpdatedOn = updatedOn;

            if (lastUsedOn != null)
            {
                this.LastUsedOn = lastUsedOn;
            }
            this.Data = data;
        }

        /// <summary>
        /// Unique identifier.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Id { get; set; }

        /// <summary>
        /// Store identifier.
        /// </summary>
        [JsonProperty("store_id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? StoreId { get; set; }

        /// <summary>
        /// Customer email address.
        /// </summary>
        [JsonProperty("email")]
        public string Email
        {
            get
            {
                return this.email;
            }

            set
            {
                this.shouldSerialize["email"] = true;
                this.email = value;
            }
        }

        /// <summary>
        /// Transaction Token Payment Type schema.
        /// </summary>
        [JsonProperty("payment_type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TransactionTokenPaymentType? PaymentType { get; set; }

        /// <summary>
        /// Whether the resource is active.
        /// </summary>
        [JsonProperty("active", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active { get; set; }

        /// <summary>
        /// Transaction Token Mode schema.
        /// </summary>
        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TransactionTokenMode? Mode { get; set; }

        /// <summary>
        /// Transaction Token Type schema.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TransactionTokenType? Type { get; set; }

        /// <summary>
        /// Usage limit applied to the token.
        /// </summary>
        [JsonProperty("usage_limit")]
        public string UsageLimit
        {
            get
            {
                return this.usageLimit;
            }

            set
            {
                this.shouldSerialize["usage_limit"] = true;
                this.usageLimit = value;
            }
        }

        /// <summary>
        /// Whether the token has been confirmed.
        /// </summary>
        [JsonProperty("confirmed")]
        public bool? Confirmed
        {
            get
            {
                return this.confirmed;
            }

            set
            {
                this.shouldSerialize["confirmed"] = true;
                this.confirmed = value;
            }
        }

        /// <summary>
        /// Arbitrary key-value metadata.
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, TransactionTokenMetadataAdditionalProperties> Metadata { get; set; }

        /// <summary>
        /// Timestamp when the resource was created.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_on", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedOn { get; set; }

        /// <summary>
        /// Timestamp when the resource was last updated.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("updated_on", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdatedOn { get; set; }

        /// <summary>
        /// Timestamp when the token was last used.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("last_used_on")]
        public DateTime? LastUsedOn
        {
            get
            {
                return this.lastUsedOn;
            }

            set
            {
                this.shouldSerialize["last_used_on"] = true;
                this.lastUsedOn = value;
            }
        }

        /// <summary>
        /// Transaction token data payload. The actual structure depends on `payment_type` — card, konbini, online (QR / 3DS), or bank transfer.
        /// </summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public TransactionTokenData Data { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"TransactionToken : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetEmail()
        {
            this.shouldSerialize["email"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetUsageLimit()
        {
            this.shouldSerialize["usage_limit"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetConfirmed()
        {
            this.shouldSerialize["confirmed"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetLastUsedOn()
        {
            this.shouldSerialize["last_used_on"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeEmail()
        {
            return this.shouldSerialize["email"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeUsageLimit()
        {
            return this.shouldSerialize["usage_limit"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeConfirmed()
        {
            return this.shouldSerialize["confirmed"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLastUsedOn()
        {
            return this.shouldSerialize["last_used_on"];
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"StoreId = {(this.StoreId == null ? "null" : this.StoreId.ToString())}");
            toStringOutput.Add($"Email = {this.Email ?? "null"}");
            toStringOutput.Add($"PaymentType = {(this.PaymentType == null ? "null" : this.PaymentType.ToString())}");
            toStringOutput.Add($"Active = {(this.Active == null ? "null" : this.Active.ToString())}");
            toStringOutput.Add($"Mode = {(this.Mode == null ? "null" : this.Mode.ToString())}");
            toStringOutput.Add($"Type = {(this.Type == null ? "null" : this.Type.ToString())}");
            toStringOutput.Add($"UsageLimit = {this.UsageLimit ?? "null"}");
            toStringOutput.Add($"Confirmed = {(this.Confirmed == null ? "null" : this.Confirmed.ToString())}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"CreatedOn = {(this.CreatedOn == null ? "null" : this.CreatedOn.ToString())}");
            toStringOutput.Add($"UpdatedOn = {(this.UpdatedOn == null ? "null" : this.UpdatedOn.ToString())}");
            toStringOutput.Add($"LastUsedOn = {(this.LastUsedOn == null ? "null" : this.LastUsedOn.ToString())}");
            toStringOutput.Add($"Data = {(this.Data == null ? "null" : this.Data.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}
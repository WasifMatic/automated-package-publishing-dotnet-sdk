// <copyright file="Webhook.cs" company="APIMatic">
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
    /// Webhook.
    /// </summary>
    public class Webhook
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

        private Guid? storeId;
        private Guid? merchantId;
        private string authToken;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "store_id", false },
            { "merchant_id", false },
            { "auth_token", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Webhook"/> class.
        /// </summary>
        public Webhook()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Webhook"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="storeId">store_id.</param>
        /// <param name="merchantId">merchant_id.</param>
        /// <param name="triggers">triggers.</param>
        /// <param name="url">url.</param>
        /// <param name="authToken">auth_token.</param>
        /// <param name="active">active.</param>
        /// <param name="isIntegration">is_integration.</param>
        /// <param name="createdOn">created_on.</param>
        /// <param name="updatedOn">updated_on.</param>
        public Webhook(
            Guid? id = null,
            Guid? storeId = null,
            Guid? merchantId = null,
            List<Models.WebhookTrigger> triggers = null,
            string url = null,
            string authToken = null,
            bool? active = null,
            bool? isIntegration = null,
            DateTime? createdOn = null,
            DateTime? updatedOn = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.Id = id;

            if (storeId != null)
            {
                this.StoreId = storeId;
            }

            if (merchantId != null)
            {
                this.MerchantId = merchantId;
            }
            this.Triggers = triggers;
            this.Url = url;

            if (authToken != null)
            {
                this.AuthToken = authToken;
            }
            this.Active = active;
            this.IsIntegration = isIntegration;
            this.CreatedOn = createdOn;
            this.UpdatedOn = updatedOn;
        }

        /// <summary>
        /// Unique identifier for the webhook.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Id { get; set; }

        /// <summary>
        /// ID of the store this webhook belongs to (null for merchant-level webhooks).
        /// </summary>
        [JsonProperty("store_id")]
        public Guid? StoreId
        {
            get
            {
                return this.storeId;
            }

            set
            {
                this.shouldSerialize["store_id"] = true;
                this.storeId = value;
            }
        }

        /// <summary>
        /// ID of the merchant this webhook belongs to.
        /// </summary>
        [JsonProperty("merchant_id")]
        public Guid? MerchantId
        {
            get
            {
                return this.merchantId;
            }

            set
            {
                this.shouldSerialize["merchant_id"] = true;
                this.merchantId = value;
            }
        }

        /// <summary>
        /// List of event types that trigger this webhook.
        /// </summary>
        [JsonProperty("triggers", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.WebhookTrigger> Triggers { get; set; }

        /// <summary>
        /// The endpoint URL that receives webhook POST requests.
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// Optional bearer token included in the `Authorization` header of webhook requests. Used to authenticate the webhook receiver.
        /// </summary>
        [JsonProperty("auth_token")]
        public string AuthToken
        {
            get
            {
                return this.authToken;
            }

            set
            {
                this.shouldSerialize["auth_token"] = true;
                this.authToken = value;
            }
        }

        /// <summary>
        /// Whether this webhook is currently active and receiving events.
        /// </summary>
        [JsonProperty("active", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active { get; set; }

        /// <summary>
        /// Admin-only flag. Indicates this webhook is used for platform integration purposes. Not settable by merchants.
        /// </summary>
        [JsonProperty("is_integration", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsIntegration { get; set; }

        /// <summary>
        /// Timestamp when the webhook was created.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_on", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedOn { get; set; }

        /// <summary>
        /// Timestamp when the webhook was last updated.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("updated_on", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdatedOn { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"Webhook : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetStoreId()
        {
            this.shouldSerialize["store_id"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetMerchantId()
        {
            this.shouldSerialize["merchant_id"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAuthToken()
        {
            this.shouldSerialize["auth_token"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeStoreId()
        {
            return this.shouldSerialize["store_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMerchantId()
        {
            return this.shouldSerialize["merchant_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAuthToken()
        {
            return this.shouldSerialize["auth_token"];
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"StoreId = {(this.StoreId == null ? "null" : this.StoreId.ToString())}");
            toStringOutput.Add($"MerchantId = {(this.MerchantId == null ? "null" : this.MerchantId.ToString())}");
            toStringOutput.Add($"Triggers = {(this.Triggers == null ? "null" : $"[{string.Join(", ", this.Triggers)} ]")}");
            toStringOutput.Add($"Url = {this.Url ?? "null"}");
            toStringOutput.Add($"AuthToken = {this.AuthToken ?? "null"}");
            toStringOutput.Add($"Active = {(this.Active == null ? "null" : this.Active.ToString())}");
            toStringOutput.Add($"IsIntegration = {(this.IsIntegration == null ? "null" : this.IsIntegration.ToString())}");
            toStringOutput.Add($"CreatedOn = {(this.CreatedOn == null ? "null" : this.CreatedOn.ToString())}");
            toStringOutput.Add($"UpdatedOn = {(this.UpdatedOn == null ? "null" : this.UpdatedOn.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}
// <copyright file="TokenWebhookEvent.cs" company="APIMatic">
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
    /// TokenWebhookEvent.
    /// </summary>
    public class TokenWebhookEvent
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
        /// Initializes a new instance of the <see cref="TokenWebhookEvent"/> class.
        /// </summary>
        public TokenWebhookEvent()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenWebhookEvent"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="mEvent">event.</param>
        /// <param name="createdOn">created_on.</param>
        /// <param name="data">data.</param>
        public TokenWebhookEvent(
            Guid id,
            Models.TokenEvent mEvent,
            DateTime createdOn,
            Models.TransactionToken data = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.Id = id;
            this.MEvent = mEvent;
            this.Data = data;
            this.CreatedOn = createdOn;
        }

        /// <summary>
        /// Unique ID of this webhook delivery.
        /// </summary>
        [JsonProperty("id")]
        public Guid Id { get; set; }

        /// <summary>
        /// Event type discriminator — `token_created`, `token_updated`, `token_three_d_s_updated`, `token_cvv_auth_updated`, `token_cvv_auth_check_updated`, `token_replaced`, or `recurring_token_deleted`.
        /// </summary>
        [JsonProperty("event")]
        public Models.TokenEvent MEvent { get; set; }

        /// <summary>
        /// Stored transaction token resource.
        /// </summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TransactionToken Data { get; set; }

        /// <summary>
        /// Timestamp when the event was fired.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_on")]
        public DateTime CreatedOn { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"TokenWebhookEvent : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {this.Id}");
            toStringOutput.Add($"MEvent = {this.MEvent}");
            toStringOutput.Add($"Data = {(this.Data == null ? "null" : this.Data.ToString())}");
            toStringOutput.Add($"CreatedOn = {this.CreatedOn}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}
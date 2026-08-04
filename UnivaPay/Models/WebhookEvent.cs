// <copyright file="WebhookEvent.cs" company="APIMatic">
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
    /// WebhookEvent.
    /// </summary>
    public class WebhookEvent
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

        private string errorMessage;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "error_message", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookEvent"/> class.
        /// </summary>
        public WebhookEvent()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookEvent"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="webhookId">webhook_id.</param>
        /// <param name="mEvent">event.</param>
        /// <param name="data">data.</param>
        /// <param name="successful">successful.</param>
        /// <param name="firedOn">fired_on.</param>
        /// <param name="errorMessage">error_message.</param>
        /// <param name="createdOn">created_on.</param>
        public WebhookEvent(
            Guid? id = null,
            Guid? webhookId = null,
            Models.WebhookTrigger? mEvent = null,
            object data = null,
            bool? successful = null,
            DateTime? firedOn = null,
            string errorMessage = null,
            DateTime? createdOn = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.Id = id;
            this.WebhookId = webhookId;
            this.MEvent = mEvent;
            this.Data = data;
            this.Successful = successful;
            this.FiredOn = firedOn;

            if (errorMessage != null)
            {
                this.ErrorMessage = errorMessage;
            }
            this.CreatedOn = createdOn;
        }

        /// <summary>
        /// Unique identifier for the webhook event.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Id { get; set; }

        /// <summary>
        /// ID of the parent webhook.
        /// </summary>
        [JsonProperty("webhook_id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? WebhookId { get; set; }

        /// <summary>
        /// Event type that triggers a webhook notification.
        /// </summary>
        [JsonProperty("event", NullValueHandling = NullValueHandling.Ignore)]
        public Models.WebhookTrigger? MEvent { get; set; }

        /// <summary>
        /// Domain object payload for webhook deliveries. The actual structure depends on the event type — see each webhook callback schema for the specific payload shape.
        /// </summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public object Data { get; set; }

        /// <summary>
        /// Whether the webhook delivery was acknowledged (HTTP 2xx).
        /// </summary>
        [JsonProperty("successful", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Successful { get; set; }

        /// <summary>
        /// Timestamp when the webhook was dispatched.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("fired_on", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FiredOn { get; set; }

        /// <summary>
        /// Error message if delivery failed.
        /// </summary>
        [JsonProperty("error_message")]
        public string ErrorMessage
        {
            get
            {
                return this.errorMessage;
            }

            set
            {
                this.shouldSerialize["error_message"] = true;
                this.errorMessage = value;
            }
        }

        /// <summary>
        /// Timestamp when the event was created.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_on", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedOn { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"WebhookEvent : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetErrorMessage()
        {
            this.shouldSerialize["error_message"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeErrorMessage()
        {
            return this.shouldSerialize["error_message"];
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"WebhookId = {(this.WebhookId == null ? "null" : this.WebhookId.ToString())}");
            toStringOutput.Add($"MEvent = {(this.MEvent == null ? "null" : this.MEvent.ToString())}");
            toStringOutput.Add($"Data = {(this.Data == null ? "null" : this.Data.ToString())}");
            toStringOutput.Add($"Successful = {(this.Successful == null ? "null" : this.Successful.ToString())}");
            toStringOutput.Add($"FiredOn = {(this.FiredOn == null ? "null" : this.FiredOn.ToString())}");
            toStringOutput.Add($"ErrorMessage = {this.ErrorMessage ?? "null"}");
            toStringOutput.Add($"CreatedOn = {(this.CreatedOn == null ? "null" : this.CreatedOn.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}
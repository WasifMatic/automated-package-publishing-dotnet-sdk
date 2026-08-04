// <copyright file="WebhookCreateRequest.cs" company="APIMatic">
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
    /// WebhookCreateRequest.
    /// </summary>
    public class WebhookCreateRequest
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

        private string authToken;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "auth_token", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookCreateRequest"/> class.
        /// </summary>
        public WebhookCreateRequest()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookCreateRequest"/> class.
        /// </summary>
        /// <param name="triggers">triggers.</param>
        /// <param name="url">url.</param>
        /// <param name="authToken">auth_token.</param>
        public WebhookCreateRequest(
            List<Models.WebhookTrigger> triggers,
            string url,
            string authToken = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.Triggers = triggers;
            this.Url = url;

            if (authToken != null)
            {
                this.AuthToken = authToken;
            }
        }

        /// <summary>
        /// List of event types that trigger this webhook. Must be non-empty and contain only events valid for the store level.
        /// </summary>
        [JsonProperty("triggers")]
        public List<Models.WebhookTrigger> Triggers { get; set; }

        /// <summary>
        /// The URL to POST webhook payloads to.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// Optional bearer token sent in the `Authorization` header of webhook requests.
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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"WebhookCreateRequest : ({string.Join(", ", toStringOutput)})";
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
            toStringOutput.Add($"Triggers = {(this.Triggers == null ? "null" : $"[{string.Join(", ", this.Triggers)} ]")}");
            toStringOutput.Add($"Url = {this.Url ?? "null"}");
            toStringOutput.Add($"AuthToken = {this.AuthToken ?? "null"}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}
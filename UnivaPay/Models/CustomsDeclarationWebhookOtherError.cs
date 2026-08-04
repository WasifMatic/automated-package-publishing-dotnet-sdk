// <copyright file="CustomsDeclarationWebhookOtherError.cs" company="APIMatic">
// UnivaPay
//
// This file was automatically generated for Univapay by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnivaPay.Utilities;

namespace UnivaPay.Models
{
    /// <summary>
    /// CustomsDeclarationWebhookOtherError.
    /// </summary>
    public class CustomsDeclarationWebhookOtherError
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

        private Guid? credentialsId;
        private List<string> message;
        private string itemName;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "credentials_id", false },
            { "message", false },
            { "item_name", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomsDeclarationWebhookOtherError"/> class.
        /// </summary>
        public CustomsDeclarationWebhookOtherError()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomsDeclarationWebhookOtherError"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="credentialsId">credentials_id.</param>
        /// <param name="message">message.</param>
        /// <param name="itemName">item_name.</param>
        public CustomsDeclarationWebhookOtherError(
            string type = null,
            Guid? credentialsId = null,
            List<string> message = null,
            string itemName = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.Type = type;

            if (credentialsId != null)
            {
                this.CredentialsId = credentialsId;
            }

            if (message != null)
            {
                this.Message = message;
            }

            if (itemName != null)
            {
                this.ItemName = itemName;
            }
        }

        /// <summary>
        /// Backend other-error type.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// Gateway credentials involved in the error when applicable.
        /// </summary>
        [JsonProperty("credentials_id")]
        public Guid? CredentialsId
        {
            get
            {
                return this.credentialsId;
            }

            set
            {
                this.shouldSerialize["credentials_id"] = true;
                this.credentialsId = value;
            }
        }

        /// <summary>
        /// Additional reason values for `not_selected_reasons`.
        /// </summary>
        [JsonProperty("message")]
        public List<string> Message
        {
            get
            {
                return this.message;
            }

            set
            {
                this.shouldSerialize["message"] = true;
                this.message = value;
            }
        }

        /// <summary>
        /// Related item name for `related_item`.
        /// </summary>
        [JsonProperty("item_name")]
        public string ItemName
        {
            get
            {
                return this.itemName;
            }

            set
            {
                this.shouldSerialize["item_name"] = true;
                this.itemName = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CustomsDeclarationWebhookOtherError : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCredentialsId()
        {
            this.shouldSerialize["credentials_id"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetMessage()
        {
            this.shouldSerialize["message"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetItemName()
        {
            this.shouldSerialize["item_name"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCredentialsId()
        {
            return this.shouldSerialize["credentials_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMessage()
        {
            return this.shouldSerialize["message"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeItemName()
        {
            return this.shouldSerialize["item_name"];
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Type = {this.Type ?? "null"}");
            toStringOutput.Add($"CredentialsId = {(this.CredentialsId == null ? "null" : this.CredentialsId.ToString())}");
            toStringOutput.Add($"Message = {(this.Message == null ? "null" : $"[{string.Join(", ", this.Message)} ]")}");
            toStringOutput.Add($"ItemName = {this.ItemName ?? "null"}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}
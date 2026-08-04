// <copyright file="RefundUpdateRequest.cs" company="APIMatic">
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
    /// RefundUpdateRequest.
    /// </summary>
    public class RefundUpdateRequest
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

        private string message;
        private Models.RefundReasonRequest? reason;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "message", false },
            { "reason", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="RefundUpdateRequest"/> class.
        /// </summary>
        public RefundUpdateRequest()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RefundUpdateRequest"/> class.
        /// </summary>
        /// <param name="metadata">metadata.</param>
        /// <param name="message">message.</param>
        /// <param name="reason">reason.</param>
        public RefundUpdateRequest(
            Models.GenericMetadata metadata = null,
            string message = null,
            Models.RefundReasonRequest? reason = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.Metadata = metadata;

            if (message != null)
            {
                this.Message = message;
            }

            if (reason != null)
            {
                this.Reason = reason;
            }
        }

        /// <summary>
        /// A free-form dictionary for custom metadata.
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Models.GenericMetadata Metadata { get; set; }

        /// <summary>
        /// Update or clear the refund note. Send `null` to remove.
        /// </summary>
        [JsonProperty("message")]
        public string Message
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
        /// Merchant-settable refund reason, or `null` to remove it during update.
        /// </summary>
        [JsonProperty("reason")]
        public Models.RefundReasonRequest? Reason
        {
            get
            {
                return this.reason;
            }

            set
            {
                this.shouldSerialize["reason"] = true;
                this.reason = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"RefundUpdateRequest : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetReason()
        {
            this.shouldSerialize["reason"] = false;
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
        public bool ShouldSerializeReason()
        {
            return this.shouldSerialize["reason"];
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"Message = {this.Message ?? "null"}");
            toStringOutput.Add($"Reason = {(this.Reason == null ? "null" : this.Reason.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}
// <copyright file="CustomsDeclarationWebhookError.cs" company="APIMatic">
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
    /// CustomsDeclarationWebhookError.
    /// </summary>
    public class CustomsDeclarationWebhookError
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

        private string details;
        private List<Models.CustomsDeclarationWebhookOtherError> others;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "details", false },
            { "others", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomsDeclarationWebhookError"/> class.
        /// </summary>
        public CustomsDeclarationWebhookError()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomsDeclarationWebhookError"/> class.
        /// </summary>
        /// <param name="code">code.</param>
        /// <param name="message">message.</param>
        /// <param name="details">details.</param>
        /// <param name="others">others.</param>
        public CustomsDeclarationWebhookError(
            int? code = null,
            string message = null,
            string details = null,
            List<Models.CustomsDeclarationWebhookOtherError> others = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.Code = code;
            this.Message = message;

            if (details != null)
            {
                this.Details = details;
            }

            if (others != null)
            {
                this.Others = others;
            }
        }

        /// <summary>
        /// Backend customs declaration error code.
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public int? Code { get; set; }

        /// <summary>
        /// Human-readable backend error name.
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// Optional backend-provided detail string.
        /// </summary>
        [JsonProperty("details")]
        public string Details
        {
            get
            {
                return this.details;
            }

            set
            {
                this.shouldSerialize["details"] = true;
                this.details = value;
            }
        }

        /// <summary>
        /// Additional nested error records returned by the backend.
        /// </summary>
        [JsonProperty("others")]
        public List<Models.CustomsDeclarationWebhookOtherError> Others
        {
            get
            {
                return this.others;
            }

            set
            {
                this.shouldSerialize["others"] = true;
                this.others = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CustomsDeclarationWebhookError : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDetails()
        {
            this.shouldSerialize["details"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetOthers()
        {
            this.shouldSerialize["others"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDetails()
        {
            return this.shouldSerialize["details"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeOthers()
        {
            return this.shouldSerialize["others"];
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Code = {(this.Code == null ? "null" : this.Code.ToString())}");
            toStringOutput.Add($"Message = {this.Message ?? "null"}");
            toStringOutput.Add($"Details = {this.Details ?? "null"}");
            toStringOutput.Add($"Others = {(this.Others == null ? "null" : $"[{string.Join(", ", this.Others)} ]")}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}
// <copyright file="TokenResponseCardDataThreeDs.cs" company="APIMatic">
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
    /// TokenResponseCardDataThreeDs.
    /// </summary>
    public class TokenResponseCardDataThreeDs
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

        private string redirectEndpoint;
        private Guid? redirectId;
        private Models.PaymentError error;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "redirect_endpoint", false },
            { "redirect_id", false },
            { "error", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenResponseCardDataThreeDs"/> class.
        /// </summary>
        public TokenResponseCardDataThreeDs()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenResponseCardDataThreeDs"/> class.
        /// </summary>
        /// <param name="enabled">enabled.</param>
        /// <param name="status">status.</param>
        /// <param name="redirectEndpoint">redirect_endpoint.</param>
        /// <param name="redirectId">redirect_id.</param>
        /// <param name="exempted">exempted.</param>
        /// <param name="error">error.</param>
        public TokenResponseCardDataThreeDs(
            bool? enabled = null,
            Models.TokenResponseCardDataThreeDsStatus? status = null,
            string redirectEndpoint = null,
            Guid? redirectId = null,
            bool? exempted = null,
            Models.PaymentError error = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.Enabled = enabled;
            this.Status = status;

            if (redirectEndpoint != null)
            {
                this.RedirectEndpoint = redirectEndpoint;
            }

            if (redirectId != null)
            {
                this.RedirectId = redirectId;
            }
            this.Exempted = exempted;

            if (error != null)
            {
                this.Error = error;
            }
        }

        /// <summary>
        /// Enabled value.
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Token Response Card Data Three Ds Status schema.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TokenResponseCardDataThreeDsStatus? Status { get; set; }

        /// <summary>
        /// Redirect endpoint URL.
        /// </summary>
        [JsonProperty("redirect_endpoint")]
        public string RedirectEndpoint
        {
            get
            {
                return this.redirectEndpoint;
            }

            set
            {
                this.shouldSerialize["redirect_endpoint"] = true;
                this.redirectEndpoint = value;
            }
        }

        /// <summary>
        /// Redirect identifier.
        /// </summary>
        [JsonProperty("redirect_id")]
        public Guid? RedirectId
        {
            get
            {
                return this.redirectId;
            }

            set
            {
                this.shouldSerialize["redirect_id"] = true;
                this.redirectId = value;
            }
        }

        /// <summary>
        /// Indicates if the 3DS check was exempted. When creating charge 3DS check will not be required.
        /// </summary>
        [JsonProperty("exempted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Exempted { get; set; }

        /// <summary>
        /// Payment error details, or null if successful.
        /// </summary>
        [JsonProperty("error")]
        public Models.PaymentError Error
        {
            get
            {
                return this.error;
            }

            set
            {
                this.shouldSerialize["error"] = true;
                this.error = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"TokenResponseCardDataThreeDs : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetRedirectEndpoint()
        {
            this.shouldSerialize["redirect_endpoint"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetRedirectId()
        {
            this.shouldSerialize["redirect_id"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetError()
        {
            this.shouldSerialize["error"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRedirectEndpoint()
        {
            return this.shouldSerialize["redirect_endpoint"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRedirectId()
        {
            return this.shouldSerialize["redirect_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeError()
        {
            return this.shouldSerialize["error"];
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Enabled = {(this.Enabled == null ? "null" : this.Enabled.ToString())}");
            toStringOutput.Add($"Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"RedirectEndpoint = {this.RedirectEndpoint ?? "null"}");
            toStringOutput.Add($"RedirectId = {(this.RedirectId == null ? "null" : this.RedirectId.ToString())}");
            toStringOutput.Add($"Exempted = {(this.Exempted == null ? "null" : this.Exempted.ToString())}");
            toStringOutput.Add($"Error = {(this.Error == null ? "null" : this.Error.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}
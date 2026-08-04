// <copyright file="TokenResponseCardDataCvvAuthorizeCheck.cs" company="APIMatic">
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
    /// TokenResponseCardDataCvvAuthorizeCheck.
    /// </summary>
    public class TokenResponseCardDataCvvAuthorizeCheck
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

        private string status;
        private Guid? chargeId;
        private DateTime? date;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "status", false },
            { "charge_id", false },
            { "date", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenResponseCardDataCvvAuthorizeCheck"/> class.
        /// </summary>
        public TokenResponseCardDataCvvAuthorizeCheck()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenResponseCardDataCvvAuthorizeCheck"/> class.
        /// </summary>
        /// <param name="status">status.</param>
        /// <param name="chargeId">charge_id.</param>
        /// <param name="date">date.</param>
        public TokenResponseCardDataCvvAuthorizeCheck(
            string status = null,
            Guid? chargeId = null,
            DateTime? date = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();

            if (status != null)
            {
                this.Status = status;
            }

            if (chargeId != null)
            {
                this.ChargeId = chargeId;
            }

            if (date != null)
            {
                this.Date = date;
            }
        }

        /// <summary>
        /// Current status of the resource.
        /// </summary>
        [JsonProperty("status")]
        public string Status
        {
            get
            {
                return this.status;
            }

            set
            {
                this.shouldSerialize["status"] = true;
                this.status = value;
            }
        }

        /// <summary>
        /// Charge identifier.
        /// </summary>
        [JsonProperty("charge_id")]
        public Guid? ChargeId
        {
            get
            {
                return this.chargeId;
            }

            set
            {
                this.shouldSerialize["charge_id"] = true;
                this.chargeId = value;
            }
        }

        /// <summary>
        /// Date value.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("date")]
        public DateTime? Date
        {
            get
            {
                return this.date;
            }

            set
            {
                this.shouldSerialize["date"] = true;
                this.date = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"TokenResponseCardDataCvvAuthorizeCheck : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetStatus()
        {
            this.shouldSerialize["status"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetChargeId()
        {
            this.shouldSerialize["charge_id"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDate()
        {
            this.shouldSerialize["date"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeStatus()
        {
            return this.shouldSerialize["status"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeChargeId()
        {
            return this.shouldSerialize["charge_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDate()
        {
            return this.shouldSerialize["date"];
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Status = {this.Status ?? "null"}");
            toStringOutput.Add($"ChargeId = {(this.ChargeId == null ? "null" : this.ChargeId.ToString())}");
            toStringOutput.Add($"Date = {(this.Date == null ? "null" : this.Date.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}
// <copyright file="RestrictIpAfterFailedChargeConfig.cs" company="APIMatic">
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
    /// RestrictIpAfterFailedChargeConfig.
    /// </summary>
    public class RestrictIpAfterFailedChargeConfig
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

        private bool? enabled;
        private int? count;
        private string cooldown;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "enabled", false },
            { "count", false },
            { "cooldown", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="RestrictIpAfterFailedChargeConfig"/> class.
        /// </summary>
        public RestrictIpAfterFailedChargeConfig()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RestrictIpAfterFailedChargeConfig"/> class.
        /// </summary>
        /// <param name="enabled">enabled.</param>
        /// <param name="count">count.</param>
        /// <param name="cooldown">cooldown.</param>
        public RestrictIpAfterFailedChargeConfig(
            bool? enabled = null,
            int? count = null,
            string cooldown = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();

            if (enabled != null)
            {
                this.Enabled = enabled;
            }

            if (count != null)
            {
                this.Count = count;
            }

            if (cooldown != null)
            {
                this.Cooldown = cooldown;
            }
        }

        /// <summary>
        /// Enables temporary IP restrictions after repeated failures.
        /// </summary>
        [JsonProperty("enabled")]
        public bool? Enabled
        {
            get
            {
                return this.enabled;
            }

            set
            {
                this.shouldSerialize["enabled"] = true;
                this.enabled = value;
            }
        }

        /// <summary>
        /// Number of failed charges allowed before restriction starts.
        /// </summary>
        [JsonProperty("count")]
        public int? Count
        {
            get
            {
                return this.count;
            }

            set
            {
                this.shouldSerialize["count"] = true;
                this.count = value;
            }
        }

        /// <summary>
        /// ISO-8601 duration that the IP restriction remains active.
        /// </summary>
        [JsonProperty("cooldown")]
        public string Cooldown
        {
            get
            {
                return this.cooldown;
            }

            set
            {
                this.shouldSerialize["cooldown"] = true;
                this.cooldown = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"RestrictIpAfterFailedChargeConfig : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetEnabled()
        {
            this.shouldSerialize["enabled"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCount()
        {
            this.shouldSerialize["count"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCooldown()
        {
            this.shouldSerialize["cooldown"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeEnabled()
        {
            return this.shouldSerialize["enabled"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCount()
        {
            return this.shouldSerialize["count"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCooldown()
        {
            return this.shouldSerialize["cooldown"];
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Enabled = {(this.Enabled == null ? "null" : this.Enabled.ToString())}");
            toStringOutput.Add($"Count = {(this.Count == null ? "null" : this.Count.ToString())}");
            toStringOutput.Add($"Cooldown = {this.Cooldown ?? "null"}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}
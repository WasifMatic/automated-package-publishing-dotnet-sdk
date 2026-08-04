// <copyright file="MerchantWebhookCustomerManagementConfiguration.cs" company="APIMatic">
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
    /// MerchantWebhookCustomerManagementConfiguration.
    /// </summary>
    public class MerchantWebhookCustomerManagementConfiguration
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
        private List<string> defaultRoles;
        private string defaultMode;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "enabled", false },
            { "default_roles", false },
            { "default_mode", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantWebhookCustomerManagementConfiguration"/> class.
        /// </summary>
        public MerchantWebhookCustomerManagementConfiguration()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantWebhookCustomerManagementConfiguration"/> class.
        /// </summary>
        /// <param name="enabled">enabled.</param>
        /// <param name="defaultRoles">default_roles.</param>
        /// <param name="defaultMode">default_mode.</param>
        public MerchantWebhookCustomerManagementConfiguration(
            bool? enabled = null,
            List<string> defaultRoles = null,
            string defaultMode = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();

            if (enabled != null)
            {
                this.Enabled = enabled;
            }

            if (defaultRoles != null)
            {
                this.DefaultRoles = defaultRoles;
            }

            if (defaultMode != null)
            {
                this.DefaultMode = defaultMode;
            }
        }

        /// <summary>
        /// Enables customer-management features.
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
        /// Roles applied to newly created customers.
        /// </summary>
        [JsonProperty("default_roles")]
        public List<string> DefaultRoles
        {
            get
            {
                return this.defaultRoles;
            }

            set
            {
                this.shouldSerialize["default_roles"] = true;
                this.defaultRoles = value;
            }
        }

        /// <summary>
        /// Default processing mode assigned to new customer records.
        /// </summary>
        [JsonProperty("default_mode")]
        public string DefaultMode
        {
            get
            {
                return this.defaultMode;
            }

            set
            {
                this.shouldSerialize["default_mode"] = true;
                this.defaultMode = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"MerchantWebhookCustomerManagementConfiguration : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetDefaultRoles()
        {
            this.shouldSerialize["default_roles"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDefaultMode()
        {
            this.shouldSerialize["default_mode"] = false;
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
        public bool ShouldSerializeDefaultRoles()
        {
            return this.shouldSerialize["default_roles"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDefaultMode()
        {
            return this.shouldSerialize["default_mode"];
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Enabled = {(this.Enabled == null ? "null" : this.Enabled.ToString())}");
            toStringOutput.Add($"DefaultRoles = {(this.DefaultRoles == null ? "null" : $"[{string.Join(", ", this.DefaultRoles)} ]")}");
            toStringOutput.Add($"DefaultMode = {this.DefaultMode ?? "null"}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}
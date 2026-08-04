// <copyright file="BaseOnlineData.cs" company="APIMatic">
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
    /// BaseOnlineData.
    /// </summary>
    public class BaseOnlineData
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

        private Models.BaseOnlineDataOsType? osType;
        private string userIdentifier;
        private Models.BaseOnlineDataUserIdentifierSource? userIdentifierSource;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "os_type", false },
            { "user_identifier", false },
            { "user_identifier_source", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseOnlineData"/> class.
        /// </summary>
        public BaseOnlineData()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseOnlineData"/> class.
        /// </summary>
        /// <param name="brand">brand.</param>
        /// <param name="callMethod">call_method.</param>
        /// <param name="osType">os_type.</param>
        /// <param name="userIdentifier">user_identifier.</param>
        /// <param name="userIdentifierSource">user_identifier_source.</param>
        public BaseOnlineData(
            Models.BaseOnlineDataBrand? brand = null,
            Models.BaseOnlineDataCallMethod? callMethod = null,
            Models.BaseOnlineDataOsType? osType = null,
            string userIdentifier = null,
            Models.BaseOnlineDataUserIdentifierSource? userIdentifierSource = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.Brand = brand;
            this.CallMethod = callMethod;

            if (osType != null)
            {
                this.OsType = osType;
            }

            if (userIdentifier != null)
            {
                this.UserIdentifier = userIdentifier;
            }

            if (userIdentifierSource != null)
            {
                this.UserIdentifierSource = userIdentifierSource;
            }
        }

        /// <summary>
        /// Base Online Data Brand schema.
        /// </summary>
        [JsonProperty("brand", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BaseOnlineDataBrand? Brand { get; set; }

        /// <summary>
        /// Base Online Data Call Method schema.
        /// </summary>
        [JsonProperty("call_method", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BaseOnlineDataCallMethod? CallMethod { get; set; }

        /// <summary>
        /// Base Online Data Os Type schema.
        /// </summary>
        [JsonProperty("os_type")]
        public Models.BaseOnlineDataOsType? OsType
        {
            get
            {
                return this.osType;
            }

            set
            {
                this.shouldSerialize["os_type"] = true;
                this.osType = value;
            }
        }

        /// <summary>
        /// Consumer specific identifier required by some gateways for fraud prevention.
        /// </summary>
        [JsonProperty("user_identifier")]
        public string UserIdentifier
        {
            get
            {
                return this.userIdentifier;
            }

            set
            {
                this.shouldSerialize["user_identifier"] = true;
                this.userIdentifier = value;
            }
        }

        /// <summary>
        /// The source of the user identifier
        /// </summary>
        [JsonProperty("user_identifier_source")]
        public Models.BaseOnlineDataUserIdentifierSource? UserIdentifierSource
        {
            get
            {
                return this.userIdentifierSource;
            }

            set
            {
                this.shouldSerialize["user_identifier_source"] = true;
                this.userIdentifierSource = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"BaseOnlineData : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetOsType()
        {
            this.shouldSerialize["os_type"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetUserIdentifier()
        {
            this.shouldSerialize["user_identifier"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetUserIdentifierSource()
        {
            this.shouldSerialize["user_identifier_source"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeOsType()
        {
            return this.shouldSerialize["os_type"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeUserIdentifier()
        {
            return this.shouldSerialize["user_identifier"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeUserIdentifierSource()
        {
            return this.shouldSerialize["user_identifier_source"];
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Brand = {(this.Brand == null ? "null" : this.Brand.ToString())}");
            toStringOutput.Add($"CallMethod = {(this.CallMethod == null ? "null" : this.CallMethod.ToString())}");
            toStringOutput.Add($"OsType = {(this.OsType == null ? "null" : this.OsType.ToString())}");
            toStringOutput.Add($"UserIdentifier = {this.UserIdentifier ?? "null"}");
            toStringOutput.Add($"UserIdentifierSource = {(this.UserIdentifierSource == null ? "null" : this.UserIdentifierSource.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}
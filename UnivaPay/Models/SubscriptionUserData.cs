// <copyright file="SubscriptionUserData.cs" company="APIMatic">
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
    /// SubscriptionUserData.
    /// </summary>
    public class SubscriptionUserData
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

        private string cardholderName;
        private string email;
        private string brand;
        private string gateway;
        private string serviceProvider;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "cardholder_name", false },
            { "email", false },
            { "brand", false },
            { "gateway", false },
            { "service_provider", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionUserData"/> class.
        /// </summary>
        public SubscriptionUserData()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionUserData"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="cardholderName">cardholder_name.</param>
        /// <param name="email">email.</param>
        /// <param name="brand">brand.</param>
        /// <param name="gateway">gateway.</param>
        /// <param name="serviceProvider">service_provider.</param>
        public SubscriptionUserData(
            string type = null,
            string cardholderName = null,
            string email = null,
            string brand = null,
            string gateway = null,
            string serviceProvider = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.Type = type;

            if (cardholderName != null)
            {
                this.CardholderName = cardholderName;
            }

            if (email != null)
            {
                this.Email = email;
            }

            if (brand != null)
            {
                this.Brand = brand;
            }

            if (gateway != null)
            {
                this.Gateway = gateway;
            }

            if (serviceProvider != null)
            {
                this.ServiceProvider = serviceProvider;
            }
        }

        /// <summary>
        /// Type of the resource.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// Cardholder name value.
        /// </summary>
        [JsonProperty("cardholder_name")]
        public string CardholderName
        {
            get
            {
                return this.cardholderName;
            }

            set
            {
                this.shouldSerialize["cardholder_name"] = true;
                this.cardholderName = value;
            }
        }

        /// <summary>
        /// Customer email address.
        /// </summary>
        [JsonProperty("email")]
        public string Email
        {
            get
            {
                return this.email;
            }

            set
            {
                this.shouldSerialize["email"] = true;
                this.email = value;
            }
        }

        /// <summary>
        /// Brand or network name.
        /// </summary>
        [JsonProperty("brand")]
        public string Brand
        {
            get
            {
                return this.brand;
            }

            set
            {
                this.shouldSerialize["brand"] = true;
                this.brand = value;
            }
        }

        /// <summary>
        /// Gateway identifier.
        /// </summary>
        [JsonProperty("gateway")]
        public string Gateway
        {
            get
            {
                return this.gateway;
            }

            set
            {
                this.shouldSerialize["gateway"] = true;
                this.gateway = value;
            }
        }

        /// <summary>
        /// Service provider identifier.
        /// </summary>
        [JsonProperty("service_provider")]
        public string ServiceProvider
        {
            get
            {
                return this.serviceProvider;
            }

            set
            {
                this.shouldSerialize["service_provider"] = true;
                this.serviceProvider = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"SubscriptionUserData : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCardholderName()
        {
            this.shouldSerialize["cardholder_name"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetEmail()
        {
            this.shouldSerialize["email"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetBrand()
        {
            this.shouldSerialize["brand"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetGateway()
        {
            this.shouldSerialize["gateway"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetServiceProvider()
        {
            this.shouldSerialize["service_provider"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCardholderName()
        {
            return this.shouldSerialize["cardholder_name"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeEmail()
        {
            return this.shouldSerialize["email"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBrand()
        {
            return this.shouldSerialize["brand"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeGateway()
        {
            return this.shouldSerialize["gateway"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeServiceProvider()
        {
            return this.shouldSerialize["service_provider"];
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Type = {this.Type ?? "null"}");
            toStringOutput.Add($"CardholderName = {this.CardholderName ?? "null"}");
            toStringOutput.Add($"Email = {this.Email ?? "null"}");
            toStringOutput.Add($"Brand = {this.Brand ?? "null"}");
            toStringOutput.Add($"Gateway = {this.Gateway ?? "null"}");
            toStringOutput.Add($"ServiceProvider = {this.ServiceProvider ?? "null"}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}
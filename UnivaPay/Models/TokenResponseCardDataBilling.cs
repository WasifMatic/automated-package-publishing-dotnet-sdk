// <copyright file="TokenResponseCardDataBilling.cs" company="APIMatic">
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
    /// TokenResponseCardDataBilling.
    /// </summary>
    public class TokenResponseCardDataBilling
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

        private string line1;
        private string line2;
        private string state;
        private string city;
        private string country;
        private string zip;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "line1", false },
            { "line2", false },
            { "state", false },
            { "city", false },
            { "country", false },
            { "zip", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenResponseCardDataBilling"/> class.
        /// </summary>
        public TokenResponseCardDataBilling()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenResponseCardDataBilling"/> class.
        /// </summary>
        /// <param name="line1">line1.</param>
        /// <param name="line2">line2.</param>
        /// <param name="state">state.</param>
        /// <param name="city">city.</param>
        /// <param name="country">country.</param>
        /// <param name="zip">zip.</param>
        /// <param name="phoneNumber">phone_number.</param>
        public TokenResponseCardDataBilling(
            string line1 = null,
            string line2 = null,
            string state = null,
            string city = null,
            string country = null,
            string zip = null,
            Models.TokenResponsePhoneNumber phoneNumber = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();

            if (line1 != null)
            {
                this.Line1 = line1;
            }

            if (line2 != null)
            {
                this.Line2 = line2;
            }

            if (state != null)
            {
                this.State = state;
            }

            if (city != null)
            {
                this.City = city;
            }

            if (country != null)
            {
                this.Country = country;
            }

            if (zip != null)
            {
                this.Zip = zip;
            }
            this.PhoneNumber = phoneNumber;
        }

        /// <summary>
        /// Primary street address line.
        /// </summary>
        [JsonProperty("line1")]
        public string Line1
        {
            get
            {
                return this.line1;
            }

            set
            {
                this.shouldSerialize["line1"] = true;
                this.line1 = value;
            }
        }

        /// <summary>
        /// Secondary street address line.
        /// </summary>
        [JsonProperty("line2")]
        public string Line2
        {
            get
            {
                return this.line2;
            }

            set
            {
                this.shouldSerialize["line2"] = true;
                this.line2 = value;
            }
        }

        /// <summary>
        /// State or prefecture.
        /// </summary>
        [JsonProperty("state")]
        public string State
        {
            get
            {
                return this.state;
            }

            set
            {
                this.shouldSerialize["state"] = true;
                this.state = value;
            }
        }

        /// <summary>
        /// City or locality.
        /// </summary>
        [JsonProperty("city")]
        public string City
        {
            get
            {
                return this.city;
            }

            set
            {
                this.shouldSerialize["city"] = true;
                this.city = value;
            }
        }

        /// <summary>
        /// Country code.
        /// </summary>
        [JsonProperty("country")]
        public string Country
        {
            get
            {
                return this.country;
            }

            set
            {
                this.shouldSerialize["country"] = true;
                this.country = value;
            }
        }

        /// <summary>
        /// Postal code.
        /// </summary>
        [JsonProperty("zip")]
        public string Zip
        {
            get
            {
                return this.zip;
            }

            set
            {
                this.shouldSerialize["zip"] = true;
                this.zip = value;
            }
        }

        /// <summary>
        /// Token Response Phone Number schema.
        /// </summary>
        [JsonProperty("phone_number", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TokenResponsePhoneNumber PhoneNumber { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"TokenResponseCardDataBilling : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetLine1()
        {
            this.shouldSerialize["line1"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetLine2()
        {
            this.shouldSerialize["line2"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetState()
        {
            this.shouldSerialize["state"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCity()
        {
            this.shouldSerialize["city"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCountry()
        {
            this.shouldSerialize["country"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetZip()
        {
            this.shouldSerialize["zip"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLine1()
        {
            return this.shouldSerialize["line1"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLine2()
        {
            return this.shouldSerialize["line2"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeState()
        {
            return this.shouldSerialize["state"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCity()
        {
            return this.shouldSerialize["city"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCountry()
        {
            return this.shouldSerialize["country"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeZip()
        {
            return this.shouldSerialize["zip"];
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Line1 = {this.Line1 ?? "null"}");
            toStringOutput.Add($"Line2 = {this.Line2 ?? "null"}");
            toStringOutput.Add($"State = {this.State ?? "null"}");
            toStringOutput.Add($"City = {this.City ?? "null"}");
            toStringOutput.Add($"Country = {this.Country ?? "null"}");
            toStringOutput.Add($"Zip = {this.Zip ?? "null"}");
            toStringOutput.Add($"PhoneNumber = {(this.PhoneNumber == null ? "null" : this.PhoneNumber.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}
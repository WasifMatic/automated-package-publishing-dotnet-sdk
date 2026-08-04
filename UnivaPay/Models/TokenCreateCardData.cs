// <copyright file="TokenCreateCardData.cs" company="APIMatic">
// UnivaPay
//
// This file was automatically generated for Univapay by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnivaPay.Utilities;

namespace UnivaPay.Models
{
    /// <summary>
    /// TokenCreateCardData.
    /// </summary>
    public class TokenCreateCardData
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

        private string cvv;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "cvv", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenCreateCardData"/> class.
        /// </summary>
        public TokenCreateCardData()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenCreateCardData"/> class.
        /// </summary>
        /// <param name="cardNumber">card_number.</param>
        /// <param name="expMonth">exp_month.</param>
        /// <param name="expYear">exp_year.</param>
        /// <param name="cardholder">cardholder.</param>
        /// <param name="cvv">cvv.</param>
        /// <param name="line1">line1.</param>
        /// <param name="line2">line2.</param>
        /// <param name="state">state.</param>
        /// <param name="city">city.</param>
        /// <param name="country">country.</param>
        /// <param name="zip">zip.</param>
        /// <param name="phoneNumber">phone_number.</param>
        /// <param name="cvvAuthorize">cvv_authorize.</param>
        /// <param name="threeDs">three_ds.</param>
        public TokenCreateCardData(
            string cardNumber,
            string expMonth,
            string expYear,
            string cardholder = null,
            string cvv = null,
            string line1 = null,
            string line2 = null,
            string state = null,
            string city = null,
            string country = null,
            string zip = null,
            Models.TokenCreatePhoneNumber phoneNumber = null,
            Models.TokenCreateCardDataCvvAuthorize cvvAuthorize = null,
            Models.TokenCreateCardDataThreeDs threeDs = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.Cardholder = cardholder;
            this.CardNumber = cardNumber;
            this.ExpMonth = expMonth;
            this.ExpYear = expYear;

            if (cvv != null)
            {
                this.Cvv = cvv;
            }
            this.Line1 = line1;
            this.Line2 = line2;
            this.State = state;
            this.City = city;
            this.Country = country;
            this.Zip = zip;
            this.PhoneNumber = phoneNumber;
            this.CvvAuthorize = cvvAuthorize;
            this.ThreeDs = threeDs;
        }

        /// <summary>
        /// Cardholder name.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("cardholder", NullValueHandling = NullValueHandling.Ignore)]
        public string Cardholder { get; set; }

        /// <summary>
        /// Card number.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("card_number")]
        [JsonRequired]
        public string CardNumber { get; set; }

        /// <summary>
        /// Card expiration month.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("exp_month")]
        [JsonRequired]
        public string ExpMonth { get; set; }

        /// <summary>
        /// Card expiration year.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("exp_year")]
        [JsonRequired]
        public string ExpYear { get; set; }

        /// <summary>
        /// Card security code.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("cvv")]
        public string Cvv
        {
            get
            {
                return this.cvv;
            }

            set
            {
                this.shouldSerialize["cvv"] = true;
                this.cvv = value;
            }
        }

        /// <summary>
        /// Primary street address line.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("line1", NullValueHandling = NullValueHandling.Ignore)]
        public string Line1 { get; set; }

        /// <summary>
        /// Secondary street address line.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("line2", NullValueHandling = NullValueHandling.Ignore)]
        public string Line2 { get; set; }

        /// <summary>
        /// State or prefecture.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// City or locality.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("city", NullValueHandling = NullValueHandling.Ignore)]
        public string City { get; set; }

        /// <summary>
        /// Country code.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; }

        /// <summary>
        /// Postal code.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("zip", NullValueHandling = NullValueHandling.Ignore)]
        public string Zip { get; set; }

        /// <summary>
        /// Token Create Phone Number schema.
        /// </summary>
        [JsonProperty("phone_number", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TokenCreatePhoneNumber PhoneNumber { get; set; }

        /// <summary>
        /// Token Create Card Data Cvv Authorize schema.
        /// </summary>
        [JsonProperty("cvv_authorize", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TokenCreateCardDataCvvAuthorize CvvAuthorize { get; set; }

        /// <summary>
        /// Token Create Card Data Three Ds schema.
        /// </summary>
        [JsonProperty("three_ds", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TokenCreateCardDataThreeDs ThreeDs { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"TokenCreateCardData : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCvv()
        {
            this.shouldSerialize["cvv"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCvv()
        {
            return this.shouldSerialize["cvv"];
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Cardholder = {this.Cardholder ?? "null"}");
            toStringOutput.Add($"CardNumber = {this.CardNumber ?? "null"}");
            toStringOutput.Add($"ExpMonth = {this.ExpMonth ?? "null"}");
            toStringOutput.Add($"ExpYear = {this.ExpYear ?? "null"}");
            toStringOutput.Add($"Cvv = {this.Cvv ?? "null"}");
            toStringOutput.Add($"Line1 = {this.Line1 ?? "null"}");
            toStringOutput.Add($"Line2 = {this.Line2 ?? "null"}");
            toStringOutput.Add($"State = {this.State ?? "null"}");
            toStringOutput.Add($"City = {this.City ?? "null"}");
            toStringOutput.Add($"Country = {this.Country ?? "null"}");
            toStringOutput.Add($"Zip = {this.Zip ?? "null"}");
            toStringOutput.Add($"PhoneNumber = {(this.PhoneNumber == null ? "null" : this.PhoneNumber.ToString())}");
            toStringOutput.Add($"CvvAuthorize = {(this.CvvAuthorize == null ? "null" : this.CvvAuthorize.ToString())}");
            toStringOutput.Add($"ThreeDs = {(this.ThreeDs == null ? "null" : this.ThreeDs.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}
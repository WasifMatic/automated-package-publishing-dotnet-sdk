// <copyright file="TransactionTokenUpdateRequestData.cs" company="APIMatic">
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
    /// TransactionTokenUpdateRequestData.
    /// </summary>
    public class TransactionTokenUpdateRequestData
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

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionTokenUpdateRequestData"/> class.
        /// </summary>
        public TransactionTokenUpdateRequestData()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionTokenUpdateRequestData"/> class.
        /// </summary>
        /// <param name="cvv">cvv.</param>
        /// <param name="cardholder">cardholder.</param>
        /// <param name="cardNumber">card_number.</param>
        /// <param name="expMonth">exp_month.</param>
        /// <param name="expYear">exp_year.</param>
        /// <param name="line1">line1.</param>
        /// <param name="line2">line2.</param>
        /// <param name="state">state.</param>
        /// <param name="city">city.</param>
        /// <param name="country">country.</param>
        /// <param name="zip">zip.</param>
        /// <param name="phoneNumber">phone_number.</param>
        public TransactionTokenUpdateRequestData(
            string cvv = null,
            string cardholder = null,
            string cardNumber = null,
            int? expMonth = null,
            int? expYear = null,
            string line1 = null,
            string line2 = null,
            string state = null,
            string city = null,
            string country = null,
            string zip = null,
            Models.TransactionTokenUpdateRequestDataPhoneNumber phoneNumber = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.Cvv = cvv;
            this.Cardholder = cardholder;
            this.CardNumber = cardNumber;
            this.ExpMonth = expMonth;
            this.ExpYear = expYear;
            this.Line1 = line1;
            this.Line2 = line2;
            this.State = state;
            this.City = city;
            this.Country = country;
            this.Zip = zip;
            this.PhoneNumber = phoneNumber;
        }

        /// <summary>
        /// Update if RECURRING_USAGE_REQUIRES_CVV error occurs.
        /// </summary>
        [JsonProperty("cvv", NullValueHandling = NullValueHandling.Ignore)]
        public string Cvv { get; set; }

        /// <summary>
        /// Cardholder name.
        /// </summary>
        [JsonProperty("cardholder", NullValueHandling = NullValueHandling.Ignore)]
        public string Cardholder { get; set; }

        /// <summary>
        /// Card number.
        /// </summary>
        [JsonProperty("card_number", NullValueHandling = NullValueHandling.Ignore)]
        public string CardNumber { get; set; }

        /// <summary>
        /// Card expiration month.
        /// </summary>
        [JsonProperty("exp_month", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExpMonth { get; set; }

        /// <summary>
        /// Card expiration year.
        /// </summary>
        [JsonProperty("exp_year", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExpYear { get; set; }

        /// <summary>
        /// Primary street address line.
        /// </summary>
        [JsonProperty("line1", NullValueHandling = NullValueHandling.Ignore)]
        public string Line1 { get; set; }

        /// <summary>
        /// Secondary street address line.
        /// </summary>
        [JsonProperty("line2", NullValueHandling = NullValueHandling.Ignore)]
        public string Line2 { get; set; }

        /// <summary>
        /// State or prefecture.
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// City or locality.
        /// </summary>
        [JsonProperty("city", NullValueHandling = NullValueHandling.Ignore)]
        public string City { get; set; }

        /// <summary>
        /// Country code.
        /// </summary>
        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; }

        /// <summary>
        /// Postal code.
        /// </summary>
        [JsonProperty("zip", NullValueHandling = NullValueHandling.Ignore)]
        public string Zip { get; set; }

        /// <summary>
        /// Transaction Token Update Request Data Phone Number schema.
        /// </summary>
        [JsonProperty("phone_number", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TransactionTokenUpdateRequestDataPhoneNumber PhoneNumber { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"TransactionTokenUpdateRequestData : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Cvv = {this.Cvv ?? "null"}");
            toStringOutput.Add($"Cardholder = {this.Cardholder ?? "null"}");
            toStringOutput.Add($"CardNumber = {this.CardNumber ?? "null"}");
            toStringOutput.Add($"ExpMonth = {(this.ExpMonth == null ? "null" : this.ExpMonth.ToString())}");
            toStringOutput.Add($"ExpYear = {(this.ExpYear == null ? "null" : this.ExpYear.ToString())}");
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
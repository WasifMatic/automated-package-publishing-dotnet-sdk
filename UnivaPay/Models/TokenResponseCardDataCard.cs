// <copyright file="TokenResponseCardDataCard.cs" company="APIMatic">
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
    /// TokenResponseCardDataCard.
    /// </summary>
    public class TokenResponseCardDataCard
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

        private string category;
        private string issuer;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "category", false },
            { "issuer", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenResponseCardDataCard"/> class.
        /// </summary>
        public TokenResponseCardDataCard()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenResponseCardDataCard"/> class.
        /// </summary>
        /// <param name="cardholder">cardholder.</param>
        /// <param name="expMonth">exp_month.</param>
        /// <param name="expYear">exp_year.</param>
        /// <param name="cardBin">card_bin.</param>
        /// <param name="lastFour">last_four.</param>
        /// <param name="brand">brand.</param>
        /// <param name="cardType">card_type.</param>
        /// <param name="country">country.</param>
        /// <param name="category">category.</param>
        /// <param name="issuer">issuer.</param>
        /// <param name="subBrand">sub_brand.</param>
        public TokenResponseCardDataCard(
            string cardholder = null,
            int? expMonth = null,
            int? expYear = null,
            string cardBin = null,
            string lastFour = null,
            string brand = null,
            string cardType = null,
            string country = null,
            string category = null,
            string issuer = null,
            string subBrand = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.Cardholder = cardholder;
            this.ExpMonth = expMonth;
            this.ExpYear = expYear;
            this.CardBin = cardBin;
            this.LastFour = lastFour;
            this.Brand = brand;
            this.CardType = cardType;
            this.Country = country;

            if (category != null)
            {
                this.Category = category;
            }

            if (issuer != null)
            {
                this.Issuer = issuer;
            }
            this.SubBrand = subBrand;
        }

        /// <summary>
        /// Cardholder name.
        /// </summary>
        [JsonProperty("cardholder", NullValueHandling = NullValueHandling.Ignore)]
        public string Cardholder { get; set; }

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
        /// Card bin value.
        /// </summary>
        [JsonProperty("card_bin", NullValueHandling = NullValueHandling.Ignore)]
        public string CardBin { get; set; }

        /// <summary>
        /// Last four value.
        /// </summary>
        [JsonProperty("last_four", NullValueHandling = NullValueHandling.Ignore)]
        public string LastFour { get; set; }

        /// <summary>
        /// Brand or network name.
        /// </summary>
        [JsonProperty("brand", NullValueHandling = NullValueHandling.Ignore)]
        public string Brand { get; set; }

        /// <summary>
        /// Card type value.
        /// </summary>
        [JsonProperty("card_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CardType { get; set; }

        /// <summary>
        /// Country code.
        /// </summary>
        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; }

        /// <summary>
        /// Category value.
        /// </summary>
        [JsonProperty("category")]
        public string Category
        {
            get
            {
                return this.category;
            }

            set
            {
                this.shouldSerialize["category"] = true;
                this.category = value;
            }
        }

        /// <summary>
        /// Issuer value.
        /// </summary>
        [JsonProperty("issuer")]
        public string Issuer
        {
            get
            {
                return this.issuer;
            }

            set
            {
                this.shouldSerialize["issuer"] = true;
                this.issuer = value;
            }
        }

        /// <summary>
        /// Sub brand value.
        /// </summary>
        [JsonProperty("sub_brand", NullValueHandling = NullValueHandling.Ignore)]
        public string SubBrand { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"TokenResponseCardDataCard : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCategory()
        {
            this.shouldSerialize["category"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetIssuer()
        {
            this.shouldSerialize["issuer"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCategory()
        {
            return this.shouldSerialize["category"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeIssuer()
        {
            return this.shouldSerialize["issuer"];
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Cardholder = {this.Cardholder ?? "null"}");
            toStringOutput.Add($"ExpMonth = {(this.ExpMonth == null ? "null" : this.ExpMonth.ToString())}");
            toStringOutput.Add($"ExpYear = {(this.ExpYear == null ? "null" : this.ExpYear.ToString())}");
            toStringOutput.Add($"CardBin = {this.CardBin ?? "null"}");
            toStringOutput.Add($"LastFour = {this.LastFour ?? "null"}");
            toStringOutput.Add($"Brand = {this.Brand ?? "null"}");
            toStringOutput.Add($"CardType = {this.CardType ?? "null"}");
            toStringOutput.Add($"Country = {this.Country ?? "null"}");
            toStringOutput.Add($"Category = {this.Category ?? "null"}");
            toStringOutput.Add($"Issuer = {this.Issuer ?? "null"}");
            toStringOutput.Add($"SubBrand = {this.SubBrand ?? "null"}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}
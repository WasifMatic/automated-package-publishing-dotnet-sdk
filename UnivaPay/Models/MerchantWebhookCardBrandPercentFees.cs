// <copyright file="MerchantWebhookCardBrandPercentFees.cs" company="APIMatic">
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
    /// MerchantWebhookCardBrandPercentFees.
    /// </summary>
    public class MerchantWebhookCardBrandPercentFees
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

        private double? visa;
        private double? americanExpress;
        private double? mastercard;
        private double? maestro;
        private double? discover;
        private double? jcb;
        private double? dinersClub;
        private double? unionPay;
        private double? privateLabel;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "visa", false },
            { "american_express", false },
            { "mastercard", false },
            { "maestro", false },
            { "discover", false },
            { "jcb", false },
            { "diners_club", false },
            { "union_pay", false },
            { "private_label", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantWebhookCardBrandPercentFees"/> class.
        /// </summary>
        public MerchantWebhookCardBrandPercentFees()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantWebhookCardBrandPercentFees"/> class.
        /// </summary>
        /// <param name="visa">visa.</param>
        /// <param name="americanExpress">american_express.</param>
        /// <param name="mastercard">mastercard.</param>
        /// <param name="maestro">maestro.</param>
        /// <param name="discover">discover.</param>
        /// <param name="jcb">jcb.</param>
        /// <param name="dinersClub">diners_club.</param>
        /// <param name="unionPay">union_pay.</param>
        /// <param name="privateLabel">private_label.</param>
        public MerchantWebhookCardBrandPercentFees(
            double? visa = null,
            double? americanExpress = null,
            double? mastercard = null,
            double? maestro = null,
            double? discover = null,
            double? jcb = null,
            double? dinersClub = null,
            double? unionPay = null,
            double? privateLabel = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();

            if (visa != null)
            {
                this.Visa = visa;
            }

            if (americanExpress != null)
            {
                this.AmericanExpress = americanExpress;
            }

            if (mastercard != null)
            {
                this.Mastercard = mastercard;
            }

            if (maestro != null)
            {
                this.Maestro = maestro;
            }

            if (discover != null)
            {
                this.Discover = discover;
            }

            if (jcb != null)
            {
                this.Jcb = jcb;
            }

            if (dinersClub != null)
            {
                this.DinersClub = dinersClub;
            }

            if (unionPay != null)
            {
                this.UnionPay = unionPay;
            }

            if (privateLabel != null)
            {
                this.PrivateLabel = privateLabel;
            }
        }

        /// <summary>
        /// Percent fee override applied to Visa transactions.
        /// </summary>
        [JsonProperty("visa")]
        public double? Visa
        {
            get
            {
                return this.visa;
            }

            set
            {
                this.shouldSerialize["visa"] = true;
                this.visa = value;
            }
        }

        /// <summary>
        /// Percent fee override applied to American Express transactions.
        /// </summary>
        [JsonProperty("american_express")]
        public double? AmericanExpress
        {
            get
            {
                return this.americanExpress;
            }

            set
            {
                this.shouldSerialize["american_express"] = true;
                this.americanExpress = value;
            }
        }

        /// <summary>
        /// Percent fee override applied to Mastercard transactions.
        /// </summary>
        [JsonProperty("mastercard")]
        public double? Mastercard
        {
            get
            {
                return this.mastercard;
            }

            set
            {
                this.shouldSerialize["mastercard"] = true;
                this.mastercard = value;
            }
        }

        /// <summary>
        /// Percent fee override applied to Maestro transactions.
        /// </summary>
        [JsonProperty("maestro")]
        public double? Maestro
        {
            get
            {
                return this.maestro;
            }

            set
            {
                this.shouldSerialize["maestro"] = true;
                this.maestro = value;
            }
        }

        /// <summary>
        /// Percent fee override applied to Discover transactions.
        /// </summary>
        [JsonProperty("discover")]
        public double? Discover
        {
            get
            {
                return this.discover;
            }

            set
            {
                this.shouldSerialize["discover"] = true;
                this.discover = value;
            }
        }

        /// <summary>
        /// Percent fee override applied to JCB transactions.
        /// </summary>
        [JsonProperty("jcb")]
        public double? Jcb
        {
            get
            {
                return this.jcb;
            }

            set
            {
                this.shouldSerialize["jcb"] = true;
                this.jcb = value;
            }
        }

        /// <summary>
        /// Percent fee override applied to Diners Club transactions.
        /// </summary>
        [JsonProperty("diners_club")]
        public double? DinersClub
        {
            get
            {
                return this.dinersClub;
            }

            set
            {
                this.shouldSerialize["diners_club"] = true;
                this.dinersClub = value;
            }
        }

        /// <summary>
        /// Percent fee override applied to UnionPay transactions.
        /// </summary>
        [JsonProperty("union_pay")]
        public double? UnionPay
        {
            get
            {
                return this.unionPay;
            }

            set
            {
                this.shouldSerialize["union_pay"] = true;
                this.unionPay = value;
            }
        }

        /// <summary>
        /// Percent fee override applied to private-label card transactions.
        /// </summary>
        [JsonProperty("private_label")]
        public double? PrivateLabel
        {
            get
            {
                return this.privateLabel;
            }

            set
            {
                this.shouldSerialize["private_label"] = true;
                this.privateLabel = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"MerchantWebhookCardBrandPercentFees : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetVisa()
        {
            this.shouldSerialize["visa"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAmericanExpress()
        {
            this.shouldSerialize["american_express"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetMastercard()
        {
            this.shouldSerialize["mastercard"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetMaestro()
        {
            this.shouldSerialize["maestro"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDiscover()
        {
            this.shouldSerialize["discover"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetJcb()
        {
            this.shouldSerialize["jcb"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDinersClub()
        {
            this.shouldSerialize["diners_club"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetUnionPay()
        {
            this.shouldSerialize["union_pay"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPrivateLabel()
        {
            this.shouldSerialize["private_label"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeVisa()
        {
            return this.shouldSerialize["visa"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAmericanExpress()
        {
            return this.shouldSerialize["american_express"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMastercard()
        {
            return this.shouldSerialize["mastercard"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMaestro()
        {
            return this.shouldSerialize["maestro"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDiscover()
        {
            return this.shouldSerialize["discover"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeJcb()
        {
            return this.shouldSerialize["jcb"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDinersClub()
        {
            return this.shouldSerialize["diners_club"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeUnionPay()
        {
            return this.shouldSerialize["union_pay"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePrivateLabel()
        {
            return this.shouldSerialize["private_label"];
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Visa = {(this.Visa == null ? "null" : this.Visa.ToString())}");
            toStringOutput.Add($"AmericanExpress = {(this.AmericanExpress == null ? "null" : this.AmericanExpress.ToString())}");
            toStringOutput.Add($"Mastercard = {(this.Mastercard == null ? "null" : this.Mastercard.ToString())}");
            toStringOutput.Add($"Maestro = {(this.Maestro == null ? "null" : this.Maestro.ToString())}");
            toStringOutput.Add($"Discover = {(this.Discover == null ? "null" : this.Discover.ToString())}");
            toStringOutput.Add($"Jcb = {(this.Jcb == null ? "null" : this.Jcb.ToString())}");
            toStringOutput.Add($"DinersClub = {(this.DinersClub == null ? "null" : this.DinersClub.ToString())}");
            toStringOutput.Add($"UnionPay = {(this.UnionPay == null ? "null" : this.UnionPay.ToString())}");
            toStringOutput.Add($"PrivateLabel = {(this.PrivateLabel == null ? "null" : this.PrivateLabel.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}
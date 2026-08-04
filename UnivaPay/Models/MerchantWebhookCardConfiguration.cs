// <copyright file="MerchantWebhookCardConfiguration.cs" company="APIMatic">
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
    /// MerchantWebhookCardConfiguration.
    /// </summary>
    public class MerchantWebhookCardConfiguration
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
        private bool? debitEnabled;
        private bool? prepaidEnabled;
        private bool? debitAuthorizationEnabled;
        private bool? prepaidAuthorizationEnabled;
        private List<string> forbiddenCardBrands;
        private List<string> allowedCountriesByIp;
        private bool? foreignCardsAllowed;
        private bool? failOnNewEmail;
        private int? cardLimit;
        private bool? allowEmptyCvv;
        private bool? onlyDirectCurrency;
        private bool? threeDsRequired;
        private bool? threeDsAddressRequired;
        private bool? threeDsSkipEnabled;
        private bool? allowDirectTokenCreation;
        private bool? threeDsPhoneNumberRequired;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "enabled", false },
            { "debit_enabled", false },
            { "prepaid_enabled", false },
            { "debit_authorization_enabled", false },
            { "prepaid_authorization_enabled", false },
            { "forbidden_card_brands", false },
            { "allowed_countries_by_ip", false },
            { "foreign_cards_allowed", false },
            { "fail_on_new_email", false },
            { "card_limit", false },
            { "allow_empty_cvv", false },
            { "only_direct_currency", false },
            { "three_ds_required", false },
            { "three_ds_address_required", false },
            { "three_ds_skip_enabled", false },
            { "allow_direct_token_creation", false },
            { "three_ds_phone_number_required", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantWebhookCardConfiguration"/> class.
        /// </summary>
        public MerchantWebhookCardConfiguration()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantWebhookCardConfiguration"/> class.
        /// </summary>
        /// <param name="enabled">enabled.</param>
        /// <param name="debitEnabled">debit_enabled.</param>
        /// <param name="prepaidEnabled">prepaid_enabled.</param>
        /// <param name="debitAuthorizationEnabled">debit_authorization_enabled.</param>
        /// <param name="prepaidAuthorizationEnabled">prepaid_authorization_enabled.</param>
        /// <param name="forbiddenCardBrands">forbidden_card_brands.</param>
        /// <param name="allowedCountriesByIp">allowed_countries_by_ip.</param>
        /// <param name="foreignCardsAllowed">foreign_cards_allowed.</param>
        /// <param name="failOnNewEmail">fail_on_new_email.</param>
        /// <param name="cardLimit">card_limit.</param>
        /// <param name="allowEmptyCvv">allow_empty_cvv.</param>
        /// <param name="onlyDirectCurrency">only_direct_currency.</param>
        /// <param name="threeDsRequired">three_ds_required.</param>
        /// <param name="threeDsAddressRequired">three_ds_address_required.</param>
        /// <param name="threeDsSkipEnabled">three_ds_skip_enabled.</param>
        /// <param name="allowDirectTokenCreation">allow_direct_token_creation.</param>
        /// <param name="threeDsPhoneNumberRequired">three_ds_phone_number_required.</param>
        public MerchantWebhookCardConfiguration(
            bool? enabled = null,
            bool? debitEnabled = null,
            bool? prepaidEnabled = null,
            bool? debitAuthorizationEnabled = null,
            bool? prepaidAuthorizationEnabled = null,
            List<string> forbiddenCardBrands = null,
            List<string> allowedCountriesByIp = null,
            bool? foreignCardsAllowed = null,
            bool? failOnNewEmail = null,
            int? cardLimit = null,
            bool? allowEmptyCvv = null,
            bool? onlyDirectCurrency = null,
            bool? threeDsRequired = null,
            bool? threeDsAddressRequired = null,
            bool? threeDsSkipEnabled = null,
            bool? allowDirectTokenCreation = null,
            bool? threeDsPhoneNumberRequired = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();

            if (enabled != null)
            {
                this.Enabled = enabled;
            }

            if (debitEnabled != null)
            {
                this.DebitEnabled = debitEnabled;
            }

            if (prepaidEnabled != null)
            {
                this.PrepaidEnabled = prepaidEnabled;
            }

            if (debitAuthorizationEnabled != null)
            {
                this.DebitAuthorizationEnabled = debitAuthorizationEnabled;
            }

            if (prepaidAuthorizationEnabled != null)
            {
                this.PrepaidAuthorizationEnabled = prepaidAuthorizationEnabled;
            }

            if (forbiddenCardBrands != null)
            {
                this.ForbiddenCardBrands = forbiddenCardBrands;
            }

            if (allowedCountriesByIp != null)
            {
                this.AllowedCountriesByIp = allowedCountriesByIp;
            }

            if (foreignCardsAllowed != null)
            {
                this.ForeignCardsAllowed = foreignCardsAllowed;
            }

            if (failOnNewEmail != null)
            {
                this.FailOnNewEmail = failOnNewEmail;
            }

            if (cardLimit != null)
            {
                this.CardLimit = cardLimit;
            }

            if (allowEmptyCvv != null)
            {
                this.AllowEmptyCvv = allowEmptyCvv;
            }

            if (onlyDirectCurrency != null)
            {
                this.OnlyDirectCurrency = onlyDirectCurrency;
            }

            if (threeDsRequired != null)
            {
                this.ThreeDsRequired = threeDsRequired;
            }

            if (threeDsAddressRequired != null)
            {
                this.ThreeDsAddressRequired = threeDsAddressRequired;
            }

            if (threeDsSkipEnabled != null)
            {
                this.ThreeDsSkipEnabled = threeDsSkipEnabled;
            }

            if (allowDirectTokenCreation != null)
            {
                this.AllowDirectTokenCreation = allowDirectTokenCreation;
            }

            if (threeDsPhoneNumberRequired != null)
            {
                this.ThreeDsPhoneNumberRequired = threeDsPhoneNumberRequired;
            }
        }

        /// <summary>
        /// Enables card payments.
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
        /// Allows debit cards for payment flows.
        /// </summary>
        [JsonProperty("debit_enabled")]
        public bool? DebitEnabled
        {
            get
            {
                return this.debitEnabled;
            }

            set
            {
                this.shouldSerialize["debit_enabled"] = true;
                this.debitEnabled = value;
            }
        }

        /// <summary>
        /// Allows prepaid cards for payment flows.
        /// </summary>
        [JsonProperty("prepaid_enabled")]
        public bool? PrepaidEnabled
        {
            get
            {
                return this.prepaidEnabled;
            }

            set
            {
                this.shouldSerialize["prepaid_enabled"] = true;
                this.prepaidEnabled = value;
            }
        }

        /// <summary>
        /// Allows authorization-only flows for debit cards.
        /// </summary>
        [JsonProperty("debit_authorization_enabled")]
        public bool? DebitAuthorizationEnabled
        {
            get
            {
                return this.debitAuthorizationEnabled;
            }

            set
            {
                this.shouldSerialize["debit_authorization_enabled"] = true;
                this.debitAuthorizationEnabled = value;
            }
        }

        /// <summary>
        /// Allows authorization-only flows for prepaid cards.
        /// </summary>
        [JsonProperty("prepaid_authorization_enabled")]
        public bool? PrepaidAuthorizationEnabled
        {
            get
            {
                return this.prepaidAuthorizationEnabled;
            }

            set
            {
                this.shouldSerialize["prepaid_authorization_enabled"] = true;
                this.prepaidAuthorizationEnabled = value;
            }
        }

        /// <summary>
        /// Card brands rejected by merchant policy.
        /// </summary>
        [JsonProperty("forbidden_card_brands")]
        public List<string> ForbiddenCardBrands
        {
            get
            {
                return this.forbiddenCardBrands;
            }

            set
            {
                this.shouldSerialize["forbidden_card_brands"] = true;
                this.forbiddenCardBrands = value;
            }
        }

        /// <summary>
        /// Source IP country codes allowed for card payments.
        /// </summary>
        [JsonProperty("allowed_countries_by_ip")]
        public List<string> AllowedCountriesByIp
        {
            get
            {
                return this.allowedCountriesByIp;
            }

            set
            {
                this.shouldSerialize["allowed_countries_by_ip"] = true;
                this.allowedCountriesByIp = value;
            }
        }

        /// <summary>
        /// Allows cards issued outside the primary operating country.
        /// </summary>
        [JsonProperty("foreign_cards_allowed")]
        public bool? ForeignCardsAllowed
        {
            get
            {
                return this.foreignCardsAllowed;
            }

            set
            {
                this.shouldSerialize["foreign_cards_allowed"] = true;
                this.foreignCardsAllowed = value;
            }
        }

        /// <summary>
        /// Rejects card charges from previously unseen customer email addresses.
        /// </summary>
        [JsonProperty("fail_on_new_email")]
        public bool? FailOnNewEmail
        {
            get
            {
                return this.failOnNewEmail;
            }

            set
            {
                this.shouldSerialize["fail_on_new_email"] = true;
                this.failOnNewEmail = value;
            }
        }

        /// <summary>
        /// Maximum number of cards allowed per customer context.
        /// </summary>
        [JsonProperty("card_limit")]
        public int? CardLimit
        {
            get
            {
                return this.cardLimit;
            }

            set
            {
                this.shouldSerialize["card_limit"] = true;
                this.cardLimit = value;
            }
        }

        /// <summary>
        /// Allows card flows without providing a CVV.
        /// </summary>
        [JsonProperty("allow_empty_cvv")]
        public bool? AllowEmptyCvv
        {
            get
            {
                return this.allowEmptyCvv;
            }

            set
            {
                this.shouldSerialize["allow_empty_cvv"] = true;
                this.allowEmptyCvv = value;
            }
        }

        /// <summary>
        /// Limits card processing to direct-settlement currencies only.
        /// </summary>
        [JsonProperty("only_direct_currency")]
        public bool? OnlyDirectCurrency
        {
            get
            {
                return this.onlyDirectCurrency;
            }

            set
            {
                this.shouldSerialize["only_direct_currency"] = true;
                this.onlyDirectCurrency = value;
            }
        }

        /// <summary>
        /// Requires 3-D Secure for eligible card flows.
        /// </summary>
        [JsonProperty("three_ds_required")]
        public bool? ThreeDsRequired
        {
            get
            {
                return this.threeDsRequired;
            }

            set
            {
                this.shouldSerialize["three_ds_required"] = true;
                this.threeDsRequired = value;
            }
        }

        /// <summary>
        /// Requires billing address data when running 3-D Secure.
        /// </summary>
        [JsonProperty("three_ds_address_required")]
        public bool? ThreeDsAddressRequired
        {
            get
            {
                return this.threeDsAddressRequired;
            }

            set
            {
                this.shouldSerialize["three_ds_address_required"] = true;
                this.threeDsAddressRequired = value;
            }
        }

        /// <summary>
        /// Allows privileged callers to request 3-D Secure skip mode.
        /// </summary>
        [JsonProperty("three_ds_skip_enabled")]
        public bool? ThreeDsSkipEnabled
        {
            get
            {
                return this.threeDsSkipEnabled;
            }

            set
            {
                this.shouldSerialize["three_ds_skip_enabled"] = true;
                this.threeDsSkipEnabled = value;
            }
        }

        /// <summary>
        /// Allows direct card token creation without hosted capture flows.
        /// </summary>
        [JsonProperty("allow_direct_token_creation")]
        public bool? AllowDirectTokenCreation
        {
            get
            {
                return this.allowDirectTokenCreation;
            }

            set
            {
                this.shouldSerialize["allow_direct_token_creation"] = true;
                this.allowDirectTokenCreation = value;
            }
        }

        /// <summary>
        /// Requires a phone number when running 3-D Secure.
        /// </summary>
        [JsonProperty("three_ds_phone_number_required")]
        public bool? ThreeDsPhoneNumberRequired
        {
            get
            {
                return this.threeDsPhoneNumberRequired;
            }

            set
            {
                this.shouldSerialize["three_ds_phone_number_required"] = true;
                this.threeDsPhoneNumberRequired = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"MerchantWebhookCardConfiguration : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetDebitEnabled()
        {
            this.shouldSerialize["debit_enabled"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPrepaidEnabled()
        {
            this.shouldSerialize["prepaid_enabled"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDebitAuthorizationEnabled()
        {
            this.shouldSerialize["debit_authorization_enabled"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPrepaidAuthorizationEnabled()
        {
            this.shouldSerialize["prepaid_authorization_enabled"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetForbiddenCardBrands()
        {
            this.shouldSerialize["forbidden_card_brands"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAllowedCountriesByIp()
        {
            this.shouldSerialize["allowed_countries_by_ip"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetForeignCardsAllowed()
        {
            this.shouldSerialize["foreign_cards_allowed"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetFailOnNewEmail()
        {
            this.shouldSerialize["fail_on_new_email"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCardLimit()
        {
            this.shouldSerialize["card_limit"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAllowEmptyCvv()
        {
            this.shouldSerialize["allow_empty_cvv"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetOnlyDirectCurrency()
        {
            this.shouldSerialize["only_direct_currency"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetThreeDsRequired()
        {
            this.shouldSerialize["three_ds_required"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetThreeDsAddressRequired()
        {
            this.shouldSerialize["three_ds_address_required"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetThreeDsSkipEnabled()
        {
            this.shouldSerialize["three_ds_skip_enabled"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAllowDirectTokenCreation()
        {
            this.shouldSerialize["allow_direct_token_creation"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetThreeDsPhoneNumberRequired()
        {
            this.shouldSerialize["three_ds_phone_number_required"] = false;
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
        public bool ShouldSerializeDebitEnabled()
        {
            return this.shouldSerialize["debit_enabled"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePrepaidEnabled()
        {
            return this.shouldSerialize["prepaid_enabled"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDebitAuthorizationEnabled()
        {
            return this.shouldSerialize["debit_authorization_enabled"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePrepaidAuthorizationEnabled()
        {
            return this.shouldSerialize["prepaid_authorization_enabled"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeForbiddenCardBrands()
        {
            return this.shouldSerialize["forbidden_card_brands"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAllowedCountriesByIp()
        {
            return this.shouldSerialize["allowed_countries_by_ip"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeForeignCardsAllowed()
        {
            return this.shouldSerialize["foreign_cards_allowed"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFailOnNewEmail()
        {
            return this.shouldSerialize["fail_on_new_email"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCardLimit()
        {
            return this.shouldSerialize["card_limit"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAllowEmptyCvv()
        {
            return this.shouldSerialize["allow_empty_cvv"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeOnlyDirectCurrency()
        {
            return this.shouldSerialize["only_direct_currency"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeThreeDsRequired()
        {
            return this.shouldSerialize["three_ds_required"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeThreeDsAddressRequired()
        {
            return this.shouldSerialize["three_ds_address_required"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeThreeDsSkipEnabled()
        {
            return this.shouldSerialize["three_ds_skip_enabled"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAllowDirectTokenCreation()
        {
            return this.shouldSerialize["allow_direct_token_creation"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeThreeDsPhoneNumberRequired()
        {
            return this.shouldSerialize["three_ds_phone_number_required"];
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Enabled = {(this.Enabled == null ? "null" : this.Enabled.ToString())}");
            toStringOutput.Add($"DebitEnabled = {(this.DebitEnabled == null ? "null" : this.DebitEnabled.ToString())}");
            toStringOutput.Add($"PrepaidEnabled = {(this.PrepaidEnabled == null ? "null" : this.PrepaidEnabled.ToString())}");
            toStringOutput.Add($"DebitAuthorizationEnabled = {(this.DebitAuthorizationEnabled == null ? "null" : this.DebitAuthorizationEnabled.ToString())}");
            toStringOutput.Add($"PrepaidAuthorizationEnabled = {(this.PrepaidAuthorizationEnabled == null ? "null" : this.PrepaidAuthorizationEnabled.ToString())}");
            toStringOutput.Add($"ForbiddenCardBrands = {(this.ForbiddenCardBrands == null ? "null" : $"[{string.Join(", ", this.ForbiddenCardBrands)} ]")}");
            toStringOutput.Add($"AllowedCountriesByIp = {(this.AllowedCountriesByIp == null ? "null" : $"[{string.Join(", ", this.AllowedCountriesByIp)} ]")}");
            toStringOutput.Add($"ForeignCardsAllowed = {(this.ForeignCardsAllowed == null ? "null" : this.ForeignCardsAllowed.ToString())}");
            toStringOutput.Add($"FailOnNewEmail = {(this.FailOnNewEmail == null ? "null" : this.FailOnNewEmail.ToString())}");
            toStringOutput.Add($"CardLimit = {(this.CardLimit == null ? "null" : this.CardLimit.ToString())}");
            toStringOutput.Add($"AllowEmptyCvv = {(this.AllowEmptyCvv == null ? "null" : this.AllowEmptyCvv.ToString())}");
            toStringOutput.Add($"OnlyDirectCurrency = {(this.OnlyDirectCurrency == null ? "null" : this.OnlyDirectCurrency.ToString())}");
            toStringOutput.Add($"ThreeDsRequired = {(this.ThreeDsRequired == null ? "null" : this.ThreeDsRequired.ToString())}");
            toStringOutput.Add($"ThreeDsAddressRequired = {(this.ThreeDsAddressRequired == null ? "null" : this.ThreeDsAddressRequired.ToString())}");
            toStringOutput.Add($"ThreeDsSkipEnabled = {(this.ThreeDsSkipEnabled == null ? "null" : this.ThreeDsSkipEnabled.ToString())}");
            toStringOutput.Add($"AllowDirectTokenCreation = {(this.AllowDirectTokenCreation == null ? "null" : this.AllowDirectTokenCreation.ToString())}");
            toStringOutput.Add($"ThreeDsPhoneNumberRequired = {(this.ThreeDsPhoneNumberRequired == null ? "null" : this.ThreeDsPhoneNumberRequired.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}
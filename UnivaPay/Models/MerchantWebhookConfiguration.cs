// <copyright file="MerchantWebhookConfiguration.cs" company="APIMatic">
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
    /// MerchantWebhookConfiguration.
    /// </summary>
    public class MerchantWebhookConfiguration
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

        private double? percentFee;
        private string logoUrl;
        private string country;
        private string language;
        private string displayTimeZone;
        private bool? descriptorProvidedConfiguration;
        private bool? platformCredentialsEnabled;
        private bool? taggedPlatformCredentialsEnabled;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "percent_fee", false },
            { "logo_url", false },
            { "country", false },
            { "language", false },
            { "display_time_zone", false },
            { "descriptor_provided_configuration", false },
            { "platform_credentials_enabled", false },
            { "tagged_platform_credentials_enabled", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantWebhookConfiguration"/> class.
        /// </summary>
        public MerchantWebhookConfiguration()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantWebhookConfiguration"/> class.
        /// </summary>
        /// <param name="percentFee">percent_fee.</param>
        /// <param name="flatFees">flat_fees.</param>
        /// <param name="logoUrl">logo_url.</param>
        /// <param name="country">country.</param>
        /// <param name="language">language.</param>
        /// <param name="displayTimeZone">display_time_zone.</param>
        /// <param name="minTransferPayout">min_transfer_payout.</param>
        /// <param name="minimumChargeAmounts">minimum_charge_amounts.</param>
        /// <param name="maximumChargeAmounts">maximum_charge_amounts.</param>
        /// <param name="transferSchedule">transfer_schedule.</param>
        /// <param name="userTransactionsConfiguration">user_transactions_configuration.</param>
        /// <param name="recurringTokenConfiguration">recurring_token_configuration.</param>
        /// <param name="securityConfiguration">security_configuration.</param>
        /// <param name="checkoutConfiguration">checkout_configuration.</param>
        /// <param name="installmentsConfiguration">installments_configuration.</param>
        /// <param name="subscriptionPlanConfiguration">subscription_plan_configuration.</param>
        /// <param name="cardBrandPercentFees">card_brand_percent_fees.</param>
        /// <param name="subscriptionConfiguration">subscription_configuration.</param>
        /// <param name="customerManagementConfiguration">customer_management_configuration.</param>
        /// <param name="descriptorProvidedConfiguration">descriptor_provided_configuration.</param>
        /// <param name="cardConfiguration">card_configuration.</param>
        /// <param name="qrScanConfiguration">qr_scan_configuration.</param>
        /// <param name="convenienceConfiguration">convenience_configuration.</param>
        /// <param name="paidyConfiguration">paidy_configuration.</param>
        /// <param name="qrMerchantConfiguration">qr_merchant_configuration.</param>
        /// <param name="onlineConfiguration">online_configuration.</param>
        /// <param name="bankTransferConfiguration">bank_transfer_configuration.</param>
        /// <param name="platformCredentialsEnabled">platform_credentials_enabled.</param>
        /// <param name="taggedPlatformCredentialsEnabled">tagged_platform_credentials_enabled.</param>
        public MerchantWebhookConfiguration(
            double? percentFee = null,
            List<Models.MerchantWebhookMoneyAmount> flatFees = null,
            string logoUrl = null,
            string country = null,
            string language = null,
            string displayTimeZone = null,
            Models.MerchantWebhookMoneyAmount minTransferPayout = null,
            List<Models.MerchantWebhookMoneyAmount> minimumChargeAmounts = null,
            List<Models.MerchantWebhookMoneyAmount> maximumChargeAmounts = null,
            Models.MerchantWebhookTransferScheduleConfiguration transferSchedule = null,
            Models.MerchantWebhookUserTransactionsConfiguration userTransactionsConfiguration = null,
            Models.MerchantWebhookRecurringTokenConfiguration recurringTokenConfiguration = null,
            Models.MerchantWebhookSecurityConfiguration securityConfiguration = null,
            Models.MerchantWebhookCheckoutConfiguration checkoutConfiguration = null,
            Models.MerchantWebhookInstallmentPlanConfiguration installmentsConfiguration = null,
            Models.MerchantWebhookSubscriptionPlanConfiguration subscriptionPlanConfiguration = null,
            Models.MerchantWebhookCardBrandPercentFees cardBrandPercentFees = null,
            Models.MerchantWebhookSubscriptionConfiguration subscriptionConfiguration = null,
            Models.MerchantWebhookCustomerManagementConfiguration customerManagementConfiguration = null,
            bool? descriptorProvidedConfiguration = null,
            Models.MerchantWebhookCardConfiguration cardConfiguration = null,
            Models.MerchantWebhookQrScanConfiguration qrScanConfiguration = null,
            Models.MerchantWebhookConvenienceConfiguration convenienceConfiguration = null,
            Models.MerchantWebhookPaidyConfiguration paidyConfiguration = null,
            Models.MerchantWebhookQrMerchantConfiguration qrMerchantConfiguration = null,
            Models.MerchantWebhookOnlineConfiguration onlineConfiguration = null,
            Models.MerchantWebhookBankTransferConfiguration bankTransferConfiguration = null,
            bool? platformCredentialsEnabled = null,
            bool? taggedPlatformCredentialsEnabled = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();

            if (percentFee != null)
            {
                this.PercentFee = percentFee;
            }
            this.FlatFees = flatFees;

            if (logoUrl != null)
            {
                this.LogoUrl = logoUrl;
            }

            if (country != null)
            {
                this.Country = country;
            }

            if (language != null)
            {
                this.Language = language;
            }

            if (displayTimeZone != null)
            {
                this.DisplayTimeZone = displayTimeZone;
            }
            this.MinTransferPayout = minTransferPayout;
            this.MinimumChargeAmounts = minimumChargeAmounts;
            this.MaximumChargeAmounts = maximumChargeAmounts;
            this.TransferSchedule = transferSchedule;
            this.UserTransactionsConfiguration = userTransactionsConfiguration;
            this.RecurringTokenConfiguration = recurringTokenConfiguration;
            this.SecurityConfiguration = securityConfiguration;
            this.CheckoutConfiguration = checkoutConfiguration;
            this.InstallmentsConfiguration = installmentsConfiguration;
            this.SubscriptionPlanConfiguration = subscriptionPlanConfiguration;
            this.CardBrandPercentFees = cardBrandPercentFees;
            this.SubscriptionConfiguration = subscriptionConfiguration;
            this.CustomerManagementConfiguration = customerManagementConfiguration;

            if (descriptorProvidedConfiguration != null)
            {
                this.DescriptorProvidedConfiguration = descriptorProvidedConfiguration;
            }
            this.CardConfiguration = cardConfiguration;
            this.QrScanConfiguration = qrScanConfiguration;
            this.ConvenienceConfiguration = convenienceConfiguration;
            this.PaidyConfiguration = paidyConfiguration;
            this.QrMerchantConfiguration = qrMerchantConfiguration;
            this.OnlineConfiguration = onlineConfiguration;
            this.BankTransferConfiguration = bankTransferConfiguration;

            if (platformCredentialsEnabled != null)
            {
                this.PlatformCredentialsEnabled = platformCredentialsEnabled;
            }

            if (taggedPlatformCredentialsEnabled != null)
            {
                this.TaggedPlatformCredentialsEnabled = taggedPlatformCredentialsEnabled;
            }
        }

        /// <summary>
        /// Default percent fee applied when no card-brand override exists.
        /// </summary>
        [JsonProperty("percent_fee")]
        public double? PercentFee
        {
            get
            {
                return this.percentFee;
            }

            set
            {
                this.shouldSerialize["percent_fee"] = true;
                this.percentFee = value;
            }
        }

        /// <summary>
        /// Flat fee overrides by currency.
        /// </summary>
        [JsonProperty("flat_fees", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.MerchantWebhookMoneyAmount> FlatFees { get; set; }

        /// <summary>
        /// Merchant logo URL.
        /// </summary>
        [JsonProperty("logo_url")]
        public string LogoUrl
        {
            get
            {
                return this.logoUrl;
            }

            set
            {
                this.shouldSerialize["logo_url"] = true;
                this.logoUrl = value;
            }
        }

        /// <summary>
        /// Merchant country code.
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
        /// Merchant default language.
        /// </summary>
        [JsonProperty("language")]
        public string Language
        {
            get
            {
                return this.language;
            }

            set
            {
                this.shouldSerialize["language"] = true;
                this.language = value;
            }
        }

        /// <summary>
        /// Merchant display time zone.
        /// </summary>
        [JsonProperty("display_time_zone")]
        public string DisplayTimeZone
        {
            get
            {
                return this.displayTimeZone;
            }

            set
            {
                this.shouldSerialize["display_time_zone"] = true;
                this.displayTimeZone = value;
            }
        }

        /// <summary>
        /// Monetary amount object serialized by backend config models.
        /// </summary>
        [JsonProperty("min_transfer_payout", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MerchantWebhookMoneyAmount MinTransferPayout { get; set; }

        /// <summary>
        /// Minimum allowed charge amounts by currency.
        /// </summary>
        [JsonProperty("minimum_charge_amounts", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.MerchantWebhookMoneyAmount> MinimumChargeAmounts { get; set; }

        /// <summary>
        /// Maximum allowed charge amounts by currency.
        /// </summary>
        [JsonProperty("maximum_charge_amounts", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.MerchantWebhookMoneyAmount> MaximumChargeAmounts { get; set; }

        /// <summary>
        /// Transfer schedule configuration inherited by the merchant.
        /// </summary>
        [JsonProperty("transfer_schedule", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MerchantWebhookTransferScheduleConfiguration TransferSchedule { get; set; }

        /// <summary>
        /// Merchant transaction notification settings.
        /// </summary>
        [JsonProperty("user_transactions_configuration", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MerchantWebhookUserTransactionsConfiguration UserTransactionsConfiguration { get; set; }

        /// <summary>
        /// Recurring token configuration inherited by the merchant.
        /// </summary>
        [JsonProperty("recurring_token_configuration", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MerchantWebhookRecurringTokenConfiguration RecurringTokenConfiguration { get; set; }

        /// <summary>
        /// Merchant-level fraud and refund safety settings.
        /// </summary>
        [JsonProperty("security_configuration", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MerchantWebhookSecurityConfiguration SecurityConfiguration { get; set; }

        /// <summary>
        /// Checkout field collection settings.
        /// </summary>
        [JsonProperty("checkout_configuration", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MerchantWebhookCheckoutConfiguration CheckoutConfiguration { get; set; }

        /// <summary>
        /// Installment plan configuration.
        /// </summary>
        [JsonProperty("installments_configuration", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MerchantWebhookInstallmentPlanConfiguration InstallmentsConfiguration { get; set; }

        /// <summary>
        /// Subscription plan configuration.
        /// </summary>
        [JsonProperty("subscription_plan_configuration", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MerchantWebhookSubscriptionPlanConfiguration SubscriptionPlanConfiguration { get; set; }

        /// <summary>
        /// Per-card-brand percent fee overrides.
        /// </summary>
        [JsonProperty("card_brand_percent_fees", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MerchantWebhookCardBrandPercentFees CardBrandPercentFees { get; set; }

        /// <summary>
        /// Subscription feature configuration.
        /// </summary>
        [JsonProperty("subscription_configuration", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MerchantWebhookSubscriptionConfiguration SubscriptionConfiguration { get; set; }

        /// <summary>
        /// Customer-management defaults.
        /// </summary>
        [JsonProperty("customer_management_configuration", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MerchantWebhookCustomerManagementConfiguration CustomerManagementConfiguration { get; set; }

        /// <summary>
        /// Whether statement descriptors can be provided by merchants.
        /// </summary>
        [JsonProperty("descriptor_provided_configuration")]
        public bool? DescriptorProvidedConfiguration
        {
            get
            {
                return this.descriptorProvidedConfiguration;
            }

            set
            {
                this.shouldSerialize["descriptor_provided_configuration"] = true;
                this.descriptorProvidedConfiguration = value;
            }
        }

        /// <summary>
        /// Card payment settings.
        /// </summary>
        [JsonProperty("card_configuration", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MerchantWebhookCardConfiguration CardConfiguration { get; set; }

        /// <summary>
        /// QR scan payment settings.
        /// </summary>
        [JsonProperty("qr_scan_configuration", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MerchantWebhookQrScanConfiguration QrScanConfiguration { get; set; }

        /// <summary>
        /// Convenience-store payment settings.
        /// </summary>
        [JsonProperty("convenience_configuration", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MerchantWebhookConvenienceConfiguration ConvenienceConfiguration { get; set; }

        /// <summary>
        /// Paidy payment settings.
        /// </summary>
        [JsonProperty("paidy_configuration", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MerchantWebhookPaidyConfiguration PaidyConfiguration { get; set; }

        /// <summary>
        /// QR merchant payment settings.
        /// </summary>
        [JsonProperty("qr_merchant_configuration", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MerchantWebhookQrMerchantConfiguration QrMerchantConfiguration { get; set; }

        /// <summary>
        /// Online payment settings.
        /// </summary>
        [JsonProperty("online_configuration", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MerchantWebhookOnlineConfiguration OnlineConfiguration { get; set; }

        /// <summary>
        /// Bank transfer payment settings.
        /// </summary>
        [JsonProperty("bank_transfer_configuration", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MerchantWebhookBankTransferConfiguration BankTransferConfiguration { get; set; }

        /// <summary>
        /// Whether platform credentials are enabled.
        /// </summary>
        [JsonProperty("platform_credentials_enabled")]
        public bool? PlatformCredentialsEnabled
        {
            get
            {
                return this.platformCredentialsEnabled;
            }

            set
            {
                this.shouldSerialize["platform_credentials_enabled"] = true;
                this.platformCredentialsEnabled = value;
            }
        }

        /// <summary>
        /// Whether tagged platform credentials are enabled.
        /// </summary>
        [JsonProperty("tagged_platform_credentials_enabled")]
        public bool? TaggedPlatformCredentialsEnabled
        {
            get
            {
                return this.taggedPlatformCredentialsEnabled;
            }

            set
            {
                this.shouldSerialize["tagged_platform_credentials_enabled"] = true;
                this.taggedPlatformCredentialsEnabled = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"MerchantWebhookConfiguration : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPercentFee()
        {
            this.shouldSerialize["percent_fee"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetLogoUrl()
        {
            this.shouldSerialize["logo_url"] = false;
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
        public void UnsetLanguage()
        {
            this.shouldSerialize["language"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDisplayTimeZone()
        {
            this.shouldSerialize["display_time_zone"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDescriptorProvidedConfiguration()
        {
            this.shouldSerialize["descriptor_provided_configuration"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPlatformCredentialsEnabled()
        {
            this.shouldSerialize["platform_credentials_enabled"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetTaggedPlatformCredentialsEnabled()
        {
            this.shouldSerialize["tagged_platform_credentials_enabled"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePercentFee()
        {
            return this.shouldSerialize["percent_fee"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLogoUrl()
        {
            return this.shouldSerialize["logo_url"];
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
        public bool ShouldSerializeLanguage()
        {
            return this.shouldSerialize["language"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDisplayTimeZone()
        {
            return this.shouldSerialize["display_time_zone"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDescriptorProvidedConfiguration()
        {
            return this.shouldSerialize["descriptor_provided_configuration"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePlatformCredentialsEnabled()
        {
            return this.shouldSerialize["platform_credentials_enabled"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTaggedPlatformCredentialsEnabled()
        {
            return this.shouldSerialize["tagged_platform_credentials_enabled"];
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"PercentFee = {(this.PercentFee == null ? "null" : this.PercentFee.ToString())}");
            toStringOutput.Add($"FlatFees = {(this.FlatFees == null ? "null" : $"[{string.Join(", ", this.FlatFees)} ]")}");
            toStringOutput.Add($"LogoUrl = {this.LogoUrl ?? "null"}");
            toStringOutput.Add($"Country = {this.Country ?? "null"}");
            toStringOutput.Add($"Language = {this.Language ?? "null"}");
            toStringOutput.Add($"DisplayTimeZone = {this.DisplayTimeZone ?? "null"}");
            toStringOutput.Add($"MinTransferPayout = {(this.MinTransferPayout == null ? "null" : this.MinTransferPayout.ToString())}");
            toStringOutput.Add($"MinimumChargeAmounts = {(this.MinimumChargeAmounts == null ? "null" : $"[{string.Join(", ", this.MinimumChargeAmounts)} ]")}");
            toStringOutput.Add($"MaximumChargeAmounts = {(this.MaximumChargeAmounts == null ? "null" : $"[{string.Join(", ", this.MaximumChargeAmounts)} ]")}");
            toStringOutput.Add($"TransferSchedule = {(this.TransferSchedule == null ? "null" : this.TransferSchedule.ToString())}");
            toStringOutput.Add($"UserTransactionsConfiguration = {(this.UserTransactionsConfiguration == null ? "null" : this.UserTransactionsConfiguration.ToString())}");
            toStringOutput.Add($"RecurringTokenConfiguration = {(this.RecurringTokenConfiguration == null ? "null" : this.RecurringTokenConfiguration.ToString())}");
            toStringOutput.Add($"SecurityConfiguration = {(this.SecurityConfiguration == null ? "null" : this.SecurityConfiguration.ToString())}");
            toStringOutput.Add($"CheckoutConfiguration = {(this.CheckoutConfiguration == null ? "null" : this.CheckoutConfiguration.ToString())}");
            toStringOutput.Add($"InstallmentsConfiguration = {(this.InstallmentsConfiguration == null ? "null" : this.InstallmentsConfiguration.ToString())}");
            toStringOutput.Add($"SubscriptionPlanConfiguration = {(this.SubscriptionPlanConfiguration == null ? "null" : this.SubscriptionPlanConfiguration.ToString())}");
            toStringOutput.Add($"CardBrandPercentFees = {(this.CardBrandPercentFees == null ? "null" : this.CardBrandPercentFees.ToString())}");
            toStringOutput.Add($"SubscriptionConfiguration = {(this.SubscriptionConfiguration == null ? "null" : this.SubscriptionConfiguration.ToString())}");
            toStringOutput.Add($"CustomerManagementConfiguration = {(this.CustomerManagementConfiguration == null ? "null" : this.CustomerManagementConfiguration.ToString())}");
            toStringOutput.Add($"DescriptorProvidedConfiguration = {(this.DescriptorProvidedConfiguration == null ? "null" : this.DescriptorProvidedConfiguration.ToString())}");
            toStringOutput.Add($"CardConfiguration = {(this.CardConfiguration == null ? "null" : this.CardConfiguration.ToString())}");
            toStringOutput.Add($"QrScanConfiguration = {(this.QrScanConfiguration == null ? "null" : this.QrScanConfiguration.ToString())}");
            toStringOutput.Add($"ConvenienceConfiguration = {(this.ConvenienceConfiguration == null ? "null" : this.ConvenienceConfiguration.ToString())}");
            toStringOutput.Add($"PaidyConfiguration = {(this.PaidyConfiguration == null ? "null" : this.PaidyConfiguration.ToString())}");
            toStringOutput.Add($"QrMerchantConfiguration = {(this.QrMerchantConfiguration == null ? "null" : this.QrMerchantConfiguration.ToString())}");
            toStringOutput.Add($"OnlineConfiguration = {(this.OnlineConfiguration == null ? "null" : this.OnlineConfiguration.ToString())}");
            toStringOutput.Add($"BankTransferConfiguration = {(this.BankTransferConfiguration == null ? "null" : this.BankTransferConfiguration.ToString())}");
            toStringOutput.Add($"PlatformCredentialsEnabled = {(this.PlatformCredentialsEnabled == null ? "null" : this.PlatformCredentialsEnabled.ToString())}");
            toStringOutput.Add($"TaggedPlatformCredentialsEnabled = {(this.TaggedPlatformCredentialsEnabled == null ? "null" : this.TaggedPlatformCredentialsEnabled.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}
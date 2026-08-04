// <copyright file="Merchant.cs" company="APIMatic">
// UnivaPay
//
// This file was automatically generated for Univapay by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnivaPay.Utilities;

namespace UnivaPay.Models
{
    /// <summary>
    /// Merchant.
    /// </summary>
    public class Merchant
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

        private Guid? verificationDataId;
        private string notificationEmail;
        private string financeNotificationEmail;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "verification_data_id", false },
            { "notification_email", false },
            { "finance_notification_email", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Merchant"/> class.
        /// </summary>
        public Merchant()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Merchant"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="verificationDataId">verification_data_id.</param>
        /// <param name="name">name.</param>
        /// <param name="email">email.</param>
        /// <param name="notificationEmail">notification_email.</param>
        /// <param name="financeNotificationEmail">finance_notification_email.</param>
        /// <param name="verified">verified.</param>
        /// <param name="configuration">configuration.</param>
        /// <param name="createdOn">created_on.</param>
        public Merchant(
            Guid? id = null,
            Guid? verificationDataId = null,
            string name = null,
            string email = null,
            string notificationEmail = null,
            string financeNotificationEmail = null,
            bool? verified = null,
            Models.MerchantWebhookConfiguration configuration = null,
            DateTime? createdOn = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.Id = id;

            if (verificationDataId != null)
            {
                this.VerificationDataId = verificationDataId;
            }
            this.Name = name;
            this.Email = email;

            if (notificationEmail != null)
            {
                this.NotificationEmail = notificationEmail;
            }

            if (financeNotificationEmail != null)
            {
                this.FinanceNotificationEmail = financeNotificationEmail;
            }
            this.Verified = verified;
            this.Configuration = configuration;
            this.CreatedOn = createdOn;
        }

        /// <summary>
        /// Merchant identifier.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Id { get; set; }

        /// <summary>
        /// Verification data identifier associated with the merchant.
        /// </summary>
        [JsonProperty("verification_data_id")]
        public Guid? VerificationDataId
        {
            get
            {
                return this.verificationDataId;
            }

            set
            {
                this.shouldSerialize["verification_data_id"] = true;
                this.verificationDataId = value;
            }
        }

        /// <summary>
        /// Merchant display name.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Primary merchant email address.
        /// </summary>
        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        /// <summary>
        /// Merchant notification email address.
        /// </summary>
        [JsonProperty("notification_email")]
        public string NotificationEmail
        {
            get
            {
                return this.notificationEmail;
            }

            set
            {
                this.shouldSerialize["notification_email"] = true;
                this.notificationEmail = value;
            }
        }

        /// <summary>
        /// Merchant finance notification email address.
        /// </summary>
        [JsonProperty("finance_notification_email")]
        public string FinanceNotificationEmail
        {
            get
            {
                return this.financeNotificationEmail;
            }

            set
            {
                this.shouldSerialize["finance_notification_email"] = true;
                this.financeNotificationEmail = value;
            }
        }

        /// <summary>
        /// Whether the merchant has completed verification.
        /// </summary>
        [JsonProperty("verified", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Verified { get; set; }

        /// <summary>
        /// Merchant configuration snapshot serialized by gyron-payments-api.
        /// </summary>
        [JsonProperty("configuration", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MerchantWebhookConfiguration Configuration { get; set; }

        /// <summary>
        /// Timestamp when the merchant was created.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_on", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedOn { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"Merchant : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetVerificationDataId()
        {
            this.shouldSerialize["verification_data_id"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetNotificationEmail()
        {
            this.shouldSerialize["notification_email"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetFinanceNotificationEmail()
        {
            this.shouldSerialize["finance_notification_email"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeVerificationDataId()
        {
            return this.shouldSerialize["verification_data_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeNotificationEmail()
        {
            return this.shouldSerialize["notification_email"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFinanceNotificationEmail()
        {
            return this.shouldSerialize["finance_notification_email"];
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"VerificationDataId = {(this.VerificationDataId == null ? "null" : this.VerificationDataId.ToString())}");
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
            toStringOutput.Add($"Email = {this.Email ?? "null"}");
            toStringOutput.Add($"NotificationEmail = {this.NotificationEmail ?? "null"}");
            toStringOutput.Add($"FinanceNotificationEmail = {this.FinanceNotificationEmail ?? "null"}");
            toStringOutput.Add($"Verified = {(this.Verified == null ? "null" : this.Verified.ToString())}");
            toStringOutput.Add($"Configuration = {(this.Configuration == null ? "null" : this.Configuration.ToString())}");
            toStringOutput.Add($"CreatedOn = {(this.CreatedOn == null ? "null" : this.CreatedOn.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}
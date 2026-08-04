// <copyright file="MerchantWebhookSecurityConfiguration.cs" company="APIMatic">
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
    /// MerchantWebhookSecurityConfiguration.
    /// </summary>
    public class MerchantWebhookSecurityConfiguration
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

        private string cardChargeCooldown;
        private string subscriptionCooldown;
        private string idempotentCardChargeCooldown;
        private string idempotentSubscriptionCooldown;
        private string inspectSuspiciousLoginAfter;
        private double? refundPercentLimit;
        private bool? confirmationRequired;
        private int? minRefundThreshold;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "card_charge_cooldown", false },
            { "subscription_cooldown", false },
            { "idempotent_card_charge_cooldown", false },
            { "idempotent_subscription_cooldown", false },
            { "inspect_suspicious_login_after", false },
            { "refund_percent_limit", false },
            { "confirmation_required", false },
            { "min_refund_threshold", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantWebhookSecurityConfiguration"/> class.
        /// </summary>
        public MerchantWebhookSecurityConfiguration()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantWebhookSecurityConfiguration"/> class.
        /// </summary>
        /// <param name="cardChargeCooldown">card_charge_cooldown.</param>
        /// <param name="subscriptionCooldown">subscription_cooldown.</param>
        /// <param name="idempotentCardChargeCooldown">idempotent_card_charge_cooldown.</param>
        /// <param name="idempotentSubscriptionCooldown">idempotent_subscription_cooldown.</param>
        /// <param name="restrictIpAfterFailedCharge">restrict_ip_after_failed_charge.</param>
        /// <param name="inspectSuspiciousLoginAfter">inspect_suspicious_login_after.</param>
        /// <param name="refundPercentLimit">refund_percent_limit.</param>
        /// <param name="limitChargeByCardConfiguration">limit_charge_by_card_configuration.</param>
        /// <param name="confirmationRequired">confirmation_required.</param>
        /// <param name="minRefundThreshold">min_refund_threshold.</param>
        /// <param name="limitRefundBySales">limit_refund_by_sales.</param>
        public MerchantWebhookSecurityConfiguration(
            string cardChargeCooldown = null,
            string subscriptionCooldown = null,
            string idempotentCardChargeCooldown = null,
            string idempotentSubscriptionCooldown = null,
            Models.RestrictIpAfterFailedChargeConfig restrictIpAfterFailedCharge = null,
            string inspectSuspiciousLoginAfter = null,
            double? refundPercentLimit = null,
            Models.MerchantWebhookLimitChargeByCardConfiguration limitChargeByCardConfiguration = null,
            bool? confirmationRequired = null,
            int? minRefundThreshold = null,
            Models.MerchantWebhookLimitRefundBySalesConfiguration limitRefundBySales = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();

            if (cardChargeCooldown != null)
            {
                this.CardChargeCooldown = cardChargeCooldown;
            }

            if (subscriptionCooldown != null)
            {
                this.SubscriptionCooldown = subscriptionCooldown;
            }

            if (idempotentCardChargeCooldown != null)
            {
                this.IdempotentCardChargeCooldown = idempotentCardChargeCooldown;
            }

            if (idempotentSubscriptionCooldown != null)
            {
                this.IdempotentSubscriptionCooldown = idempotentSubscriptionCooldown;
            }
            this.RestrictIpAfterFailedCharge = restrictIpAfterFailedCharge;

            if (inspectSuspiciousLoginAfter != null)
            {
                this.InspectSuspiciousLoginAfter = inspectSuspiciousLoginAfter;
            }

            if (refundPercentLimit != null)
            {
                this.RefundPercentLimit = refundPercentLimit;
            }
            this.LimitChargeByCardConfiguration = limitChargeByCardConfiguration;

            if (confirmationRequired != null)
            {
                this.ConfirmationRequired = confirmationRequired;
            }

            if (minRefundThreshold != null)
            {
                this.MinRefundThreshold = minRefundThreshold;
            }
            this.LimitRefundBySales = limitRefundBySales;
        }

        /// <summary>
        /// ISO-8601 duration between card charge attempts.
        /// </summary>
        [JsonProperty("card_charge_cooldown")]
        public string CardChargeCooldown
        {
            get
            {
                return this.cardChargeCooldown;
            }

            set
            {
                this.shouldSerialize["card_charge_cooldown"] = true;
                this.cardChargeCooldown = value;
            }
        }

        /// <summary>
        /// ISO-8601 duration between subscription charge attempts.
        /// </summary>
        [JsonProperty("subscription_cooldown")]
        public string SubscriptionCooldown
        {
            get
            {
                return this.subscriptionCooldown;
            }

            set
            {
                this.shouldSerialize["subscription_cooldown"] = true;
                this.subscriptionCooldown = value;
            }
        }

        /// <summary>
        /// ISO-8601 duration for reusing an idempotent card charge key.
        /// </summary>
        [JsonProperty("idempotent_card_charge_cooldown")]
        public string IdempotentCardChargeCooldown
        {
            get
            {
                return this.idempotentCardChargeCooldown;
            }

            set
            {
                this.shouldSerialize["idempotent_card_charge_cooldown"] = true;
                this.idempotentCardChargeCooldown = value;
            }
        }

        /// <summary>
        /// ISO-8601 duration for reusing an idempotent subscription key.
        /// </summary>
        [JsonProperty("idempotent_subscription_cooldown")]
        public string IdempotentSubscriptionCooldown
        {
            get
            {
                return this.idempotentSubscriptionCooldown;
            }

            set
            {
                this.shouldSerialize["idempotent_subscription_cooldown"] = true;
                this.idempotentSubscriptionCooldown = value;
            }
        }

        /// <summary>
        /// IP restriction policy applied after repeated failed charges.
        /// </summary>
        [JsonProperty("restrict_ip_after_failed_charge", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RestrictIpAfterFailedChargeConfig RestrictIpAfterFailedCharge { get; set; }

        /// <summary>
        /// Look-back period used to review suspicious login activity.
        /// </summary>
        [JsonProperty("inspect_suspicious_login_after")]
        public string InspectSuspiciousLoginAfter
        {
            get
            {
                return this.inspectSuspiciousLoginAfter;
            }

            set
            {
                this.shouldSerialize["inspect_suspicious_login_after"] = true;
                this.inspectSuspiciousLoginAfter = value;
            }
        }

        /// <summary>
        /// Maximum refund-to-sales percentage allowed before restriction.
        /// </summary>
        [JsonProperty("refund_percent_limit")]
        public double? RefundPercentLimit
        {
            get
            {
                return this.refundPercentLimit;
            }

            set
            {
                this.shouldSerialize["refund_percent_limit"] = true;
                this.refundPercentLimit = value;
            }
        }

        /// <summary>
        /// Per-card velocity limit configuration.
        /// </summary>
        [JsonProperty("limit_charge_by_card_configuration", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MerchantWebhookLimitChargeByCardConfiguration LimitChargeByCardConfiguration { get; set; }

        /// <summary>
        /// Requires confirmation before protected refund actions proceed.
        /// </summary>
        [JsonProperty("confirmation_required")]
        public bool? ConfirmationRequired
        {
            get
            {
                return this.confirmationRequired;
            }

            set
            {
                this.shouldSerialize["confirmation_required"] = true;
                this.confirmationRequired = value;
            }
        }

        /// <summary>
        /// Minimum refund amount, in minor units, subject to confirmation checks.
        /// </summary>
        [JsonProperty("min_refund_threshold")]
        public int? MinRefundThreshold
        {
            get
            {
                return this.minRefundThreshold;
            }

            set
            {
                this.shouldSerialize["min_refund_threshold"] = true;
                this.minRefundThreshold = value;
            }
        }

        /// <summary>
        /// Refund-limiting configuration based on sales history.
        /// </summary>
        [JsonProperty("limit_refund_by_sales", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MerchantWebhookLimitRefundBySalesConfiguration LimitRefundBySales { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"MerchantWebhookSecurityConfiguration : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCardChargeCooldown()
        {
            this.shouldSerialize["card_charge_cooldown"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetSubscriptionCooldown()
        {
            this.shouldSerialize["subscription_cooldown"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetIdempotentCardChargeCooldown()
        {
            this.shouldSerialize["idempotent_card_charge_cooldown"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetIdempotentSubscriptionCooldown()
        {
            this.shouldSerialize["idempotent_subscription_cooldown"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetInspectSuspiciousLoginAfter()
        {
            this.shouldSerialize["inspect_suspicious_login_after"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetRefundPercentLimit()
        {
            this.shouldSerialize["refund_percent_limit"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetConfirmationRequired()
        {
            this.shouldSerialize["confirmation_required"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetMinRefundThreshold()
        {
            this.shouldSerialize["min_refund_threshold"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCardChargeCooldown()
        {
            return this.shouldSerialize["card_charge_cooldown"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSubscriptionCooldown()
        {
            return this.shouldSerialize["subscription_cooldown"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeIdempotentCardChargeCooldown()
        {
            return this.shouldSerialize["idempotent_card_charge_cooldown"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeIdempotentSubscriptionCooldown()
        {
            return this.shouldSerialize["idempotent_subscription_cooldown"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeInspectSuspiciousLoginAfter()
        {
            return this.shouldSerialize["inspect_suspicious_login_after"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRefundPercentLimit()
        {
            return this.shouldSerialize["refund_percent_limit"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeConfirmationRequired()
        {
            return this.shouldSerialize["confirmation_required"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMinRefundThreshold()
        {
            return this.shouldSerialize["min_refund_threshold"];
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"CardChargeCooldown = {this.CardChargeCooldown ?? "null"}");
            toStringOutput.Add($"SubscriptionCooldown = {this.SubscriptionCooldown ?? "null"}");
            toStringOutput.Add($"IdempotentCardChargeCooldown = {this.IdempotentCardChargeCooldown ?? "null"}");
            toStringOutput.Add($"IdempotentSubscriptionCooldown = {this.IdempotentSubscriptionCooldown ?? "null"}");
            toStringOutput.Add($"RestrictIpAfterFailedCharge = {(this.RestrictIpAfterFailedCharge == null ? "null" : this.RestrictIpAfterFailedCharge.ToString())}");
            toStringOutput.Add($"InspectSuspiciousLoginAfter = {this.InspectSuspiciousLoginAfter ?? "null"}");
            toStringOutput.Add($"RefundPercentLimit = {(this.RefundPercentLimit == null ? "null" : this.RefundPercentLimit.ToString())}");
            toStringOutput.Add($"LimitChargeByCardConfiguration = {(this.LimitChargeByCardConfiguration == null ? "null" : this.LimitChargeByCardConfiguration.ToString())}");
            toStringOutput.Add($"ConfirmationRequired = {(this.ConfirmationRequired == null ? "null" : this.ConfirmationRequired.ToString())}");
            toStringOutput.Add($"MinRefundThreshold = {(this.MinRefundThreshold == null ? "null" : this.MinRefundThreshold.ToString())}");
            toStringOutput.Add($"LimitRefundBySales = {(this.LimitRefundBySales == null ? "null" : this.LimitRefundBySales.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}
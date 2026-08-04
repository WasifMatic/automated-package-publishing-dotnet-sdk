// <copyright file="SubscriptionCreateRequest.cs" company="APIMatic">
// UnivaPay
//
// This file was automatically generated for Univapay by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnivaPay.Utilities;

namespace UnivaPay.Models
{
    /// <summary>
    /// SubscriptionCreateRequest.
    /// </summary>
    public class SubscriptionCreateRequest
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
        /// Initializes a new instance of the <see cref="SubscriptionCreateRequest"/> class.
        /// </summary>
        public SubscriptionCreateRequest()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionCreateRequest"/> class.
        /// </summary>
        /// <param name="transactionTokenId">transaction_token_id.</param>
        /// <param name="amount">amount.</param>
        /// <param name="currency">currency.</param>
        /// <param name="initialAmount">initial_amount.</param>
        /// <param name="period">period.</param>
        /// <param name="cyclicalPeriod">cyclical_period.</param>
        /// <param name="scheduleSettings">schedule_settings.</param>
        /// <param name="installmentPlan">installment_plan.</param>
        /// <param name="subscriptionPlan">subscription_plan.</param>
        /// <param name="firstChargeAuthorizationOnly">first_charge_authorization_only.</param>
        /// <param name="firstChargeCaptureAfter">first_charge_capture_after.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="threeDs">three_ds.</param>
        public SubscriptionCreateRequest(
            Guid transactionTokenId,
            int amount,
            string currency,
            int? initialAmount = null,
            Models.SubscriptionPeriod? period = null,
            string cyclicalPeriod = null,
            Models.SubscriptionScheduleSettings scheduleSettings = null,
            Models.SubscriptionInstallmentPlan installmentPlan = null,
            Models.SubscriptionPlanSettings subscriptionPlan = null,
            bool? firstChargeAuthorizationOnly = false,
            string firstChargeCaptureAfter = null,
            Models.GenericMetadata metadata = null,
            Models.ChargeCreateRequestThreeDs threeDs = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.TransactionTokenId = transactionTokenId;
            this.Amount = amount;
            this.Currency = currency;
            this.InitialAmount = initialAmount;
            this.Period = period;
            this.CyclicalPeriod = cyclicalPeriod;
            this.ScheduleSettings = scheduleSettings;
            this.InstallmentPlan = installmentPlan;
            this.SubscriptionPlan = subscriptionPlan;
            this.FirstChargeAuthorizationOnly = firstChargeAuthorizationOnly;
            this.FirstChargeCaptureAfter = firstChargeCaptureAfter;
            this.Metadata = metadata;
            this.ThreeDs = threeDs;
        }

        /// <summary>
        /// Transaction token ID authorized for recurring payments.
        /// </summary>
        [JsonProperty("transaction_token_id")]
        public Guid TransactionTokenId { get; set; }

        /// <summary>
        /// Amount to be charged in each cycle.
        /// </summary>
        [JsonProperty("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// ISO-4217 currency code.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Optional different amount for the first charge.
        /// </summary>
        [JsonProperty("initial_amount", NullValueHandling = NullValueHandling.Ignore)]
        public int? InitialAmount { get; set; }

        /// <summary>
        /// Subscription Period schema.
        /// </summary>
        [JsonProperty("period", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SubscriptionPeriod? Period { get; set; }

        /// <summary>
        /// ISO-8601 Duration for custom frequency (e.g., P3D, P2M).  Cannot be used if 'period' is specified.
        /// </summary>
        [JsonProperty("cyclical_period", NullValueHandling = NullValueHandling.Ignore)]
        public string CyclicalPeriod { get; set; }

        /// <summary>
        /// Schedule settings applied to a subscription.
        /// </summary>
        [JsonProperty("schedule_settings", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SubscriptionScheduleSettings ScheduleSettings { get; set; }

        /// <summary>
        /// Configuration for credit card company side installments.
        /// </summary>
        [JsonProperty("installment_plan", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SubscriptionInstallmentPlan InstallmentPlan { get; set; }

        /// <summary>
        /// Configuration for limited-cycle subscriptions (Univapay side).
        /// </summary>
        [JsonProperty("subscription_plan", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SubscriptionPlanSettings SubscriptionPlan { get; set; }

        /// <summary>
        /// If true, the first charge will only be an authorization (Hold).
        /// </summary>
        [JsonProperty("first_charge_authorization_only", NullValueHandling = NullValueHandling.Ignore)]
        public bool? FirstChargeAuthorizationOnly { get; set; }

        /// <summary>
        /// ISO-8601 Duration for auto-capture if authorization only is true.  Allowed days: P1D to P6D.
        /// </summary>
        [JsonProperty("first_charge_capture_after", NullValueHandling = NullValueHandling.Ignore)]
        public string FirstChargeCaptureAfter { get; set; }

        /// <summary>
        /// A free-form dictionary for custom metadata.
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Models.GenericMetadata Metadata { get; set; }

        /// <summary>
        /// Charge Create Request Three Ds schema.
        /// </summary>
        [JsonProperty("three_ds", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ChargeCreateRequestThreeDs ThreeDs { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"SubscriptionCreateRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"TransactionTokenId = {this.TransactionTokenId}");
            toStringOutput.Add($"Amount = {this.Amount}");
            toStringOutput.Add($"Currency = {this.Currency ?? "null"}");
            toStringOutput.Add($"InitialAmount = {(this.InitialAmount == null ? "null" : this.InitialAmount.ToString())}");
            toStringOutput.Add($"Period = {(this.Period == null ? "null" : this.Period.ToString())}");
            toStringOutput.Add($"CyclicalPeriod = {this.CyclicalPeriod ?? "null"}");
            toStringOutput.Add($"ScheduleSettings = {(this.ScheduleSettings == null ? "null" : this.ScheduleSettings.ToString())}");
            toStringOutput.Add($"InstallmentPlan = {(this.InstallmentPlan == null ? "null" : this.InstallmentPlan.ToString())}");
            toStringOutput.Add($"SubscriptionPlan = {(this.SubscriptionPlan == null ? "null" : this.SubscriptionPlan.ToString())}");
            toStringOutput.Add($"FirstChargeAuthorizationOnly = {(this.FirstChargeAuthorizationOnly == null ? "null" : this.FirstChargeAuthorizationOnly.ToString())}");
            toStringOutput.Add($"FirstChargeCaptureAfter = {this.FirstChargeCaptureAfter ?? "null"}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"ThreeDs = {(this.ThreeDs == null ? "null" : this.ThreeDs.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}
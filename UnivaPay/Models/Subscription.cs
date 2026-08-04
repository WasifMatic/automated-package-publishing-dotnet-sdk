// <copyright file="Subscription.cs" company="APIMatic">
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
    /// Subscription.
    /// </summary>
    public class Subscription
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

        private int? initialAmount;
        private double? initialAmountFormatted;
        private DateTime? subsequentCyclesStart;
        private string firstChargeCaptureAfter;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "initial_amount", false },
            { "initial_amount_formatted", false },
            { "subsequent_cycles_start", false },
            { "first_charge_capture_after", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Subscription"/> class.
        /// </summary>
        public Subscription()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Subscription"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="storeId">store_id.</param>
        /// <param name="transactionTokenId">transaction_token_id.</param>
        /// <param name="amount">amount.</param>
        /// <param name="currency">currency.</param>
        /// <param name="amountFormatted">amount_formatted.</param>
        /// <param name="initialAmount">initial_amount.</param>
        /// <param name="initialAmountFormatted">initial_amount_formatted.</param>
        /// <param name="subsequentCyclesStart">subsequent_cycles_start.</param>
        /// <param name="scheduleSettings">schedule_settings.</param>
        /// <param name="onlyDirectCurrency">only_direct_currency.</param>
        /// <param name="firstChargeCaptureAfter">first_charge_capture_after.</param>
        /// <param name="firstChargeAuthorizationOnly">first_charge_authorization_only.</param>
        /// <param name="status">status.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="mode">mode.</param>
        /// <param name="createdOn">created_on.</param>
        /// <param name="period">period.</param>
        /// <param name="nextPayment">next_payment.</param>
        public Subscription(
            Guid? id = null,
            Guid? storeId = null,
            Guid? transactionTokenId = null,
            int? amount = null,
            string currency = null,
            double? amountFormatted = null,
            int? initialAmount = null,
            double? initialAmountFormatted = null,
            DateTime? subsequentCyclesStart = null,
            Models.SubscriptionScheduleSettings scheduleSettings = null,
            bool? onlyDirectCurrency = null,
            string firstChargeCaptureAfter = null,
            bool? firstChargeAuthorizationOnly = null,
            Models.SubscriptionStatus? status = null,
            Models.GenericMetadata metadata = null,
            Models.ChargeMode? mode = null,
            DateTime? createdOn = null,
            Models.SubscriptionPeriod? period = null,
            Models.SubscriptionNextPayment nextPayment = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.Id = id;
            this.StoreId = storeId;
            this.TransactionTokenId = transactionTokenId;
            this.Amount = amount;
            this.Currency = currency;
            this.AmountFormatted = amountFormatted;

            if (initialAmount != null)
            {
                this.InitialAmount = initialAmount;
            }

            if (initialAmountFormatted != null)
            {
                this.InitialAmountFormatted = initialAmountFormatted;
            }

            if (subsequentCyclesStart != null)
            {
                this.SubsequentCyclesStart = subsequentCyclesStart;
            }
            this.ScheduleSettings = scheduleSettings;
            this.OnlyDirectCurrency = onlyDirectCurrency;

            if (firstChargeCaptureAfter != null)
            {
                this.FirstChargeCaptureAfter = firstChargeCaptureAfter;
            }
            this.FirstChargeAuthorizationOnly = firstChargeAuthorizationOnly;
            this.Status = status;
            this.Metadata = metadata;
            this.Mode = mode;
            this.CreatedOn = createdOn;
            this.Period = period;
            this.NextPayment = nextPayment;
        }

        /// <summary>
        /// Unique identifier.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Id { get; set; }

        /// <summary>
        /// Store identifier.
        /// </summary>
        [JsonProperty("store_id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? StoreId { get; set; }

        /// <summary>
        /// Transaction token identifier.
        /// </summary>
        [JsonProperty("transaction_token_id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? TransactionTokenId { get; set; }

        /// <summary>
        /// Amount in the smallest currency unit.
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public int? Amount { get; set; }

        /// <summary>
        /// ISO-4217 currency code.
        /// </summary>
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        /// <summary>
        /// Amount formatted for display.
        /// </summary>
        [JsonProperty("amount_formatted", NullValueHandling = NullValueHandling.Ignore)]
        public double? AmountFormatted { get; set; }

        /// <summary>
        /// Initial amount in the smallest currency unit.
        /// </summary>
        [JsonProperty("initial_amount")]
        public int? InitialAmount
        {
            get
            {
                return this.initialAmount;
            }

            set
            {
                this.shouldSerialize["initial_amount"] = true;
                this.initialAmount = value;
            }
        }

        /// <summary>
        /// Initial amount formatted for display.
        /// </summary>
        [JsonProperty("initial_amount_formatted")]
        public double? InitialAmountFormatted
        {
            get
            {
                return this.initialAmountFormatted;
            }

            set
            {
                this.shouldSerialize["initial_amount_formatted"] = true;
                this.initialAmountFormatted = value;
            }
        }

        /// <summary>
        /// Timestamp when recurring cycles begin.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("subsequent_cycles_start")]
        public DateTime? SubsequentCyclesStart
        {
            get
            {
                return this.subsequentCyclesStart;
            }

            set
            {
                this.shouldSerialize["subsequent_cycles_start"] = true;
                this.subsequentCyclesStart = value;
            }
        }

        /// <summary>
        /// Schedule settings applied to a subscription.
        /// </summary>
        [JsonProperty("schedule_settings", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SubscriptionScheduleSettings ScheduleSettings { get; set; }

        /// <summary>
        /// Whether only direct currency processing is allowed.
        /// </summary>
        [JsonProperty("only_direct_currency", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OnlyDirectCurrency { get; set; }

        /// <summary>
        /// ISO-8601 Duration (e.g., P3D).
        /// </summary>
        [JsonProperty("first_charge_capture_after")]
        public string FirstChargeCaptureAfter
        {
            get
            {
                return this.firstChargeCaptureAfter;
            }

            set
            {
                this.shouldSerialize["first_charge_capture_after"] = true;
                this.firstChargeCaptureAfter = value;
            }
        }

        /// <summary>
        /// Whether the first charge is authorization-only.
        /// </summary>
        [JsonProperty("first_charge_authorization_only", NullValueHandling = NullValueHandling.Ignore)]
        public bool? FirstChargeAuthorizationOnly { get; set; }

        /// <summary>
        /// Subscription Status schema.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SubscriptionStatus? Status { get; set; }

        /// <summary>
        /// A free-form dictionary for custom metadata.
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Models.GenericMetadata Metadata { get; set; }

        /// <summary>
        /// Charge Mode schema.
        /// </summary>
        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ChargeMode? Mode { get; set; }

        /// <summary>
        /// Timestamp when the resource was created.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_on", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedOn { get; set; }

        /// <summary>
        /// Subscription Period schema.
        /// </summary>
        [JsonProperty("period", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SubscriptionPeriod? Period { get; set; }

        /// <summary>
        /// Next scheduled payment details for a subscription.
        /// </summary>
        [JsonProperty("next_payment", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SubscriptionNextPayment NextPayment { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"Subscription : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetInitialAmount()
        {
            this.shouldSerialize["initial_amount"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetInitialAmountFormatted()
        {
            this.shouldSerialize["initial_amount_formatted"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetSubsequentCyclesStart()
        {
            this.shouldSerialize["subsequent_cycles_start"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetFirstChargeCaptureAfter()
        {
            this.shouldSerialize["first_charge_capture_after"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeInitialAmount()
        {
            return this.shouldSerialize["initial_amount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeInitialAmountFormatted()
        {
            return this.shouldSerialize["initial_amount_formatted"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSubsequentCyclesStart()
        {
            return this.shouldSerialize["subsequent_cycles_start"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFirstChargeCaptureAfter()
        {
            return this.shouldSerialize["first_charge_capture_after"];
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"StoreId = {(this.StoreId == null ? "null" : this.StoreId.ToString())}");
            toStringOutput.Add($"TransactionTokenId = {(this.TransactionTokenId == null ? "null" : this.TransactionTokenId.ToString())}");
            toStringOutput.Add($"Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"Currency = {this.Currency ?? "null"}");
            toStringOutput.Add($"AmountFormatted = {(this.AmountFormatted == null ? "null" : this.AmountFormatted.ToString())}");
            toStringOutput.Add($"InitialAmount = {(this.InitialAmount == null ? "null" : this.InitialAmount.ToString())}");
            toStringOutput.Add($"InitialAmountFormatted = {(this.InitialAmountFormatted == null ? "null" : this.InitialAmountFormatted.ToString())}");
            toStringOutput.Add($"SubsequentCyclesStart = {(this.SubsequentCyclesStart == null ? "null" : this.SubsequentCyclesStart.ToString())}");
            toStringOutput.Add($"ScheduleSettings = {(this.ScheduleSettings == null ? "null" : this.ScheduleSettings.ToString())}");
            toStringOutput.Add($"OnlyDirectCurrency = {(this.OnlyDirectCurrency == null ? "null" : this.OnlyDirectCurrency.ToString())}");
            toStringOutput.Add($"FirstChargeCaptureAfter = {this.FirstChargeCaptureAfter ?? "null"}");
            toStringOutput.Add($"FirstChargeAuthorizationOnly = {(this.FirstChargeAuthorizationOnly == null ? "null" : this.FirstChargeAuthorizationOnly.ToString())}");
            toStringOutput.Add($"Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"Mode = {(this.Mode == null ? "null" : this.Mode.ToString())}");
            toStringOutput.Add($"CreatedOn = {(this.CreatedOn == null ? "null" : this.CreatedOn.ToString())}");
            toStringOutput.Add($"Period = {(this.Period == null ? "null" : this.Period.ToString())}");
            toStringOutput.Add($"NextPayment = {(this.NextPayment == null ? "null" : this.NextPayment.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}
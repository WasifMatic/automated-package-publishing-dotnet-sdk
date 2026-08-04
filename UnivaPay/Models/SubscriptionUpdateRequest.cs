// <copyright file="SubscriptionUpdateRequest.cs" company="APIMatic">
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
    /// SubscriptionUpdateRequest.
    /// </summary>
    public class SubscriptionUpdateRequest
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
        /// Initializes a new instance of the <see cref="SubscriptionUpdateRequest"/> class.
        /// </summary>
        public SubscriptionUpdateRequest()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionUpdateRequest"/> class.
        /// </summary>
        /// <param name="transactionTokenId">transaction_token_id.</param>
        /// <param name="amount">amount.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="status">status.</param>
        /// <param name="scheduleSettings">schedule_settings.</param>
        /// <param name="nextPayment">next_payment.</param>
        public SubscriptionUpdateRequest(
            Guid? transactionTokenId = null,
            int? amount = null,
            Models.GenericMetadata metadata = null,
            Models.SubscriptionUpdateStatus? status = null,
            Models.SubscriptionUpdateScheduleSettings scheduleSettings = null,
            Models.SubscriptionUpdateNextPayment nextPayment = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.TransactionTokenId = transactionTokenId;
            this.Amount = amount;
            this.Metadata = metadata;
            this.Status = status;
            this.ScheduleSettings = scheduleSettings;
            this.NextPayment = nextPayment;
        }

        /// <summary>
        /// Transaction token ID used for the subscription.  Can be changed to update the payment method (e.g., when a card expires).  Allowed only when the status is `unconfirmed`, `unpaid`, `current`, or `suspended`.
        /// </summary>
        [JsonProperty("transaction_token_id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? TransactionTokenId { get; set; }

        /// <summary>
        /// The recurring charge amount (applied to the cycle after the next one).  Not available for limited-cycle subscriptions.  To change the immediate next payment amount, update `next_payment.amount` instead.
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public int? Amount { get; set; }

        /// <summary>
        /// A free-form dictionary for custom metadata.
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Models.GenericMetadata Metadata { get; set; }

        /// <summary>
        /// Update the subscription status.  `suspended`: Pause the subscription.  `unpaid`: Resume a suspended subscription.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SubscriptionUpdateStatus? Status { get; set; }

        /// <summary>
        /// Schedule settings that can be updated on a subscription.
        /// </summary>
        [JsonProperty("schedule_settings", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SubscriptionUpdateScheduleSettings ScheduleSettings { get; set; }

        /// <summary>
        /// Fields that can be updated on the next scheduled payment.
        /// </summary>
        [JsonProperty("next_payment", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SubscriptionUpdateNextPayment NextPayment { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"SubscriptionUpdateRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"TransactionTokenId = {(this.TransactionTokenId == null ? "null" : this.TransactionTokenId.ToString())}");
            toStringOutput.Add($"Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"ScheduleSettings = {(this.ScheduleSettings == null ? "null" : this.ScheduleSettings.ToString())}");
            toStringOutput.Add($"NextPayment = {(this.NextPayment == null ? "null" : this.NextPayment.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}
// <copyright file="SubscriptionNextPayment.cs" company="APIMatic">
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
    /// SubscriptionNextPayment.
    /// </summary>
    public class SubscriptionNextPayment
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

        private DateTime? retryDate;
        private Models.SubscriptionTerminateWithStatus? terminateWithStatus;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "retry_date", false },
            { "terminate_with_status", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionNextPayment"/> class.
        /// </summary>
        public SubscriptionNextPayment()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionNextPayment"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="dueDate">due_date.</param>
        /// <param name="zoneId">zone_id.</param>
        /// <param name="amount">amount.</param>
        /// <param name="currency">currency.</param>
        /// <param name="amountFormatted">amount_formatted.</param>
        /// <param name="isPaid">is_paid.</param>
        /// <param name="isLastPayment">is_last_payment.</param>
        /// <param name="createdOn">created_on.</param>
        /// <param name="updatedOn">updated_on.</param>
        /// <param name="retryDate">retry_date.</param>
        /// <param name="terminateWithStatus">terminate_with_status.</param>
        public SubscriptionNextPayment(
            Guid? id = null,
            DateTime? dueDate = null,
            string zoneId = null,
            int? amount = null,
            string currency = null,
            double? amountFormatted = null,
            bool? isPaid = null,
            bool? isLastPayment = null,
            DateTime? createdOn = null,
            DateTime? updatedOn = null,
            DateTime? retryDate = null,
            Models.SubscriptionTerminateWithStatus? terminateWithStatus = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.Id = id;
            this.DueDate = dueDate;
            this.ZoneId = zoneId;
            this.Amount = amount;
            this.Currency = currency;
            this.AmountFormatted = amountFormatted;
            this.IsPaid = isPaid;
            this.IsLastPayment = isLastPayment;
            this.CreatedOn = createdOn;
            this.UpdatedOn = updatedOn;

            if (retryDate != null)
            {
                this.RetryDate = retryDate;
            }

            if (terminateWithStatus != null)
            {
                this.TerminateWithStatus = terminateWithStatus;
            }
        }

        /// <summary>
        /// Unique identifier.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Id { get; set; }

        /// <summary>
        /// Scheduled due date.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("due_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// IANA timezone identifier.
        /// </summary>
        [JsonProperty("zone_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ZoneId { get; set; }

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
        /// Whether the payment has been paid.
        /// </summary>
        [JsonProperty("is_paid", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsPaid { get; set; }

        /// <summary>
        /// Whether this is the final payment in the schedule.
        /// </summary>
        [JsonProperty("is_last_payment", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsLastPayment { get; set; }

        /// <summary>
        /// Timestamp when the resource was created.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_on", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedOn { get; set; }

        /// <summary>
        /// Timestamp when the resource was last updated.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("updated_on", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdatedOn { get; set; }

        /// <summary>
        /// Scheduled retry date.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("retry_date")]
        public DateTime? RetryDate
        {
            get
            {
                return this.retryDate;
            }

            set
            {
                this.shouldSerialize["retry_date"] = true;
                this.retryDate = value;
            }
        }

        /// <summary>
        /// Schedule a status transition on a payment's due date. Set to `suspended` or `canceled` to schedule termination. Send `null` to cancel a previously scheduled transition.
        /// </summary>
        [JsonProperty("terminate_with_status")]
        public Models.SubscriptionTerminateWithStatus? TerminateWithStatus
        {
            get
            {
                return this.terminateWithStatus;
            }

            set
            {
                this.shouldSerialize["terminate_with_status"] = true;
                this.terminateWithStatus = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"SubscriptionNextPayment : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetRetryDate()
        {
            this.shouldSerialize["retry_date"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetTerminateWithStatus()
        {
            this.shouldSerialize["terminate_with_status"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRetryDate()
        {
            return this.shouldSerialize["retry_date"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTerminateWithStatus()
        {
            return this.shouldSerialize["terminate_with_status"];
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"DueDate = {(this.DueDate == null ? "null" : this.DueDate.ToString())}");
            toStringOutput.Add($"ZoneId = {this.ZoneId ?? "null"}");
            toStringOutput.Add($"Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"Currency = {this.Currency ?? "null"}");
            toStringOutput.Add($"AmountFormatted = {(this.AmountFormatted == null ? "null" : this.AmountFormatted.ToString())}");
            toStringOutput.Add($"IsPaid = {(this.IsPaid == null ? "null" : this.IsPaid.ToString())}");
            toStringOutput.Add($"IsLastPayment = {(this.IsLastPayment == null ? "null" : this.IsLastPayment.ToString())}");
            toStringOutput.Add($"CreatedOn = {(this.CreatedOn == null ? "null" : this.CreatedOn.ToString())}");
            toStringOutput.Add($"UpdatedOn = {(this.UpdatedOn == null ? "null" : this.UpdatedOn.ToString())}");
            toStringOutput.Add($"RetryDate = {(this.RetryDate == null ? "null" : this.RetryDate.ToString())}");
            toStringOutput.Add($"TerminateWithStatus = {(this.TerminateWithStatus == null ? "null" : this.TerminateWithStatus.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}
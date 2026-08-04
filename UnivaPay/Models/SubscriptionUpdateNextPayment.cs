// <copyright file="SubscriptionUpdateNextPayment.cs" company="APIMatic">
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
    /// SubscriptionUpdateNextPayment.
    /// </summary>
    public class SubscriptionUpdateNextPayment
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

        private Models.SubscriptionTerminateWithStatus? terminateWithStatus;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "terminate_with_status", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionUpdateNextPayment"/> class.
        /// </summary>
        public SubscriptionUpdateNextPayment()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionUpdateNextPayment"/> class.
        /// </summary>
        /// <param name="dueDate">due_date.</param>
        /// <param name="amount">amount.</param>
        /// <param name="terminateWithStatus">terminate_with_status.</param>
        public SubscriptionUpdateNextPayment(
            DateTime? dueDate = null,
            int? amount = null,
            Models.SubscriptionTerminateWithStatus? terminateWithStatus = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.DueDate = dueDate;
            this.Amount = amount;

            if (terminateWithStatus != null)
            {
                this.TerminateWithStatus = terminateWithStatus;
            }
        }

        /// <summary>
        /// Next payment date (YYYY-MM-DD).  Note: Only available for merchants permitted to edit next payment dates.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("due_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// Next payment amount. Not available for limited-cycle subscriptions.  Only available for permitted merchants.  This does not change subsequent cycle amounts.
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public int? Amount { get; set; }

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
            return $"SubscriptionUpdateNextPayment : ({string.Join(", ", toStringOutput)})";
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
            toStringOutput.Add($"DueDate = {(this.DueDate == null ? "null" : this.DueDate.ToString())}");
            toStringOutput.Add($"Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"TerminateWithStatus = {(this.TerminateWithStatus == null ? "null" : this.TerminateWithStatus.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}
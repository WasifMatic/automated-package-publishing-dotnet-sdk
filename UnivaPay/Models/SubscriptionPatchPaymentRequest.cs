// <copyright file="SubscriptionPatchPaymentRequest.cs" company="APIMatic">
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
    /// SubscriptionPatchPaymentRequest.
    /// </summary>
    public class SubscriptionPatchPaymentRequest
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
        private string retryInterval;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "terminate_with_status", false },
            { "retry_interval", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPatchPaymentRequest"/> class.
        /// </summary>
        public SubscriptionPatchPaymentRequest()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPatchPaymentRequest"/> class.
        /// </summary>
        /// <param name="dueDate">due_date.</param>
        /// <param name="isPaid">is_paid.</param>
        /// <param name="terminateWithStatus">terminate_with_status.</param>
        /// <param name="retryInterval">retry_interval.</param>
        public SubscriptionPatchPaymentRequest(
            DateTime? dueDate = null,
            bool? isPaid = null,
            Models.SubscriptionTerminateWithStatus? terminateWithStatus = null,
            string retryInterval = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.DueDate = dueDate;
            this.IsPaid = isPaid;

            if (terminateWithStatus != null)
            {
                this.TerminateWithStatus = terminateWithStatus;
            }

            if (retryInterval != null)
            {
                this.RetryInterval = retryInterval;
            }
        }

        /// <summary>
        /// New due date for this payment (YYYY-MM-DD).  Only available to merchants with permission to edit payment dates.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("due_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// Mark this payment as paid. Setting to `true` will trigger scheduling  of the next payment in the cycle.
        /// </summary>
        [JsonProperty("is_paid", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsPaid { get; set; }

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

        /// <summary>
        /// ISO-8601 Duration override for the retry interval on a scheduled payment (for example `P3D`). Send `null` to clear.
        /// </summary>
        [JsonProperty("retry_interval")]
        public string RetryInterval
        {
            get
            {
                return this.retryInterval;
            }

            set
            {
                this.shouldSerialize["retry_interval"] = true;
                this.retryInterval = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"SubscriptionPatchPaymentRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetTerminateWithStatus()
        {
            this.shouldSerialize["terminate_with_status"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetRetryInterval()
        {
            this.shouldSerialize["retry_interval"] = false;
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
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRetryInterval()
        {
            return this.shouldSerialize["retry_interval"];
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"DueDate = {(this.DueDate == null ? "null" : this.DueDate.ToString())}");
            toStringOutput.Add($"IsPaid = {(this.IsPaid == null ? "null" : this.IsPaid.ToString())}");
            toStringOutput.Add($"TerminateWithStatus = {(this.TerminateWithStatus == null ? "null" : this.TerminateWithStatus.ToString())}");
            toStringOutput.Add($"RetryInterval = {this.RetryInterval ?? "null"}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}
// <copyright file="Refund.cs" company="APIMatic">
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
    /// Refund.
    /// </summary>
    public class Refund
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

        private Models.RefundReasonResponse? reason;
        private string message;
        private Models.PaymentError error;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "reason", false },
            { "message", false },
            { "error", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Refund"/> class.
        /// </summary>
        public Refund()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Refund"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="storeId">store_id.</param>
        /// <param name="chargeId">charge_id.</param>
        /// <param name="status">status.</param>
        /// <param name="amount">amount.</param>
        /// <param name="currency">currency.</param>
        /// <param name="amountFormatted">amount_formatted.</param>
        /// <param name="reason">reason.</param>
        /// <param name="message">message.</param>
        /// <param name="error">error.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="mode">mode.</param>
        /// <param name="createdOn">created_on.</param>
        /// <param name="updatedOn">updated_on.</param>
        public Refund(
            Guid? id = null,
            Guid? storeId = null,
            Guid? chargeId = null,
            Models.RefundStatus? status = null,
            int? amount = null,
            string currency = null,
            double? amountFormatted = null,
            Models.RefundReasonResponse? reason = null,
            string message = null,
            Models.PaymentError error = null,
            Models.GenericMetadata metadata = null,
            Models.ChargeMode? mode = null,
            DateTime? createdOn = null,
            DateTime? updatedOn = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.Id = id;
            this.StoreId = storeId;
            this.ChargeId = chargeId;
            this.Status = status;
            this.Amount = amount;
            this.Currency = currency;
            this.AmountFormatted = amountFormatted;

            if (reason != null)
            {
                this.Reason = reason;
            }

            if (message != null)
            {
                this.Message = message;
            }

            if (error != null)
            {
                this.Error = error;
            }
            this.Metadata = metadata;
            this.Mode = mode;
            this.CreatedOn = createdOn;
            this.UpdatedOn = updatedOn;
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
        /// Charge identifier.
        /// </summary>
        [JsonProperty("charge_id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? ChargeId { get; set; }

        /// <summary>
        /// Current status of the refund. `pending`: The refund has been created and is being processed. `successful`: The refund was processed successfully. `failed`: The refund was rejected by the gateway. `error`: An unexpected error occurred during processing.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RefundStatus? Status { get; set; }

        /// <summary>
        /// Refund amount in the smallest currency unit (e.g., cents for USD, yen for JPY).
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public int? Amount { get; set; }

        /// <summary>
        /// ISO-4217 currency code. Must match the charged currency.
        /// </summary>
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        /// <summary>
        /// Refund amount formatted for display.
        /// </summary>
        [JsonProperty("amount_formatted", NullValueHandling = NullValueHandling.Ignore)]
        public double? AmountFormatted { get; set; }

        /// <summary>
        /// Refund reason returned by the API, or `null` when unset.
        /// </summary>
        [JsonProperty("reason")]
        public Models.RefundReasonResponse? Reason
        {
            get
            {
                return this.reason;
            }

            set
            {
                this.shouldSerialize["reason"] = true;
                this.reason = value;
            }
        }

        /// <summary>
        /// Optional free-text note about the refund.
        /// </summary>
        [JsonProperty("message")]
        public string Message
        {
            get
            {
                return this.message;
            }

            set
            {
                this.shouldSerialize["message"] = true;
                this.message = value;
            }
        }

        /// <summary>
        /// Payment error details, or null if successful.
        /// </summary>
        [JsonProperty("error")]
        public Models.PaymentError Error
        {
            get
            {
                return this.error;
            }

            set
            {
                this.shouldSerialize["error"] = true;
                this.error = value;
            }
        }

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
        /// Timestamp when the resource was last updated.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("updated_on", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdatedOn { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"Refund : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetReason()
        {
            this.shouldSerialize["reason"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetMessage()
        {
            this.shouldSerialize["message"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetError()
        {
            this.shouldSerialize["error"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeReason()
        {
            return this.shouldSerialize["reason"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMessage()
        {
            return this.shouldSerialize["message"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeError()
        {
            return this.shouldSerialize["error"];
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"StoreId = {(this.StoreId == null ? "null" : this.StoreId.ToString())}");
            toStringOutput.Add($"ChargeId = {(this.ChargeId == null ? "null" : this.ChargeId.ToString())}");
            toStringOutput.Add($"Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"Currency = {this.Currency ?? "null"}");
            toStringOutput.Add($"AmountFormatted = {(this.AmountFormatted == null ? "null" : this.AmountFormatted.ToString())}");
            toStringOutput.Add($"Reason = {(this.Reason == null ? "null" : this.Reason.ToString())}");
            toStringOutput.Add($"Message = {this.Message ?? "null"}");
            toStringOutput.Add($"Error = {(this.Error == null ? "null" : this.Error.ToString())}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"Mode = {(this.Mode == null ? "null" : this.Mode.ToString())}");
            toStringOutput.Add($"CreatedOn = {(this.CreatedOn == null ? "null" : this.CreatedOn.ToString())}");
            toStringOutput.Add($"UpdatedOn = {(this.UpdatedOn == null ? "null" : this.UpdatedOn.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}
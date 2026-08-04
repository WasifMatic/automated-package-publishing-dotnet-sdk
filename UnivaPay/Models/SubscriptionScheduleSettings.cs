// <copyright file="SubscriptionScheduleSettings.cs" company="APIMatic">
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
    /// SubscriptionScheduleSettings.
    /// </summary>
    public class SubscriptionScheduleSettings
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
        /// Initializes a new instance of the <see cref="SubscriptionScheduleSettings"/> class.
        /// </summary>
        public SubscriptionScheduleSettings()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionScheduleSettings"/> class.
        /// </summary>
        /// <param name="startOn">start_on.</param>
        /// <param name="zoneId">zone_id.</param>
        /// <param name="preserveEndOfMonth">preserve_end_of_month.</param>
        /// <param name="retryInterval">retry_interval.</param>
        /// <param name="terminationMode">termination_mode.</param>
        public SubscriptionScheduleSettings(
            DateTime? startOn = null,
            string zoneId = null,
            bool? preserveEndOfMonth = null,
            string retryInterval = null,
            Models.SubscriptionTerminationMode? terminationMode = Models.SubscriptionTerminationMode.Immediate)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.StartOn = startOn;
            this.ZoneId = zoneId;
            this.PreserveEndOfMonth = preserveEndOfMonth;
            this.RetryInterval = retryInterval;
            this.TerminationMode = terminationMode;
        }

        /// <summary>
        /// Date when the recurring schedule starts (YYYY-MM-DD).
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("start_on", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? StartOn { get; set; }

        /// <summary>
        /// IANA Timezone ID.
        /// </summary>
        [JsonProperty("zone_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ZoneId { get; set; }

        /// <summary>
        /// If true, subsequent charges will always occur on the last day of the month.
        /// </summary>
        [JsonProperty("preserve_end_of_month", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PreserveEndOfMonth { get; set; }

        /// <summary>
        /// ISO-8601 Duration for retry interval if payment fails (e.g., P5D).
        /// </summary>
        [JsonProperty("retry_interval", NullValueHandling = NullValueHandling.Ignore)]
        public string RetryInterval { get; set; }

        /// <summary>
        /// Subscription Termination Mode schema.
        /// </summary>
        [JsonProperty("termination_mode", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SubscriptionTerminationMode? TerminationMode { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"SubscriptionScheduleSettings : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"StartOn = {(this.StartOn == null ? "null" : this.StartOn.ToString())}");
            toStringOutput.Add($"ZoneId = {this.ZoneId ?? "null"}");
            toStringOutput.Add($"PreserveEndOfMonth = {(this.PreserveEndOfMonth == null ? "null" : this.PreserveEndOfMonth.ToString())}");
            toStringOutput.Add($"RetryInterval = {this.RetryInterval ?? "null"}");
            toStringOutput.Add($"TerminationMode = {(this.TerminationMode == null ? "null" : this.TerminationMode.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}
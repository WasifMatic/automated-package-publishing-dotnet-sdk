// <copyright file="SubscriptionUpdateScheduleSettings.cs" company="APIMatic">
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
    /// SubscriptionUpdateScheduleSettings.
    /// </summary>
    public class SubscriptionUpdateScheduleSettings
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
        /// Initializes a new instance of the <see cref="SubscriptionUpdateScheduleSettings"/> class.
        /// </summary>
        public SubscriptionUpdateScheduleSettings()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionUpdateScheduleSettings"/> class.
        /// </summary>
        /// <param name="terminationMode">termination_mode.</param>
        /// <param name="startOn">start_on.</param>
        /// <param name="retryInterval">retry_interval.</param>
        public SubscriptionUpdateScheduleSettings(
            Models.SubscriptionTerminationMode? terminationMode = Models.SubscriptionTerminationMode.Immediate,
            DateTime? startOn = null,
            string retryInterval = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.TerminationMode = terminationMode;
            this.StartOn = startOn;
            this.RetryInterval = retryInterval;
        }

        /// <summary>
        /// Subscription Termination Mode schema.
        /// </summary>
        [JsonProperty("termination_mode", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SubscriptionTerminationMode? TerminationMode { get; set; }

        /// <summary>
        /// Subscription start date. Used to change the first actual charge date  for subscriptions that initially only registered a payment method.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("start_on", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? StartOn { get; set; }

        /// <summary>
        /// ISO-8601 Duration for retry interval if payment fails  (e.g., P3D for 3 days, PT48H for 48 hours).
        /// </summary>
        [JsonProperty("retry_interval", NullValueHandling = NullValueHandling.Ignore)]
        public string RetryInterval { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"SubscriptionUpdateScheduleSettings : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"TerminationMode = {(this.TerminationMode == null ? "null" : this.TerminationMode.ToString())}");
            toStringOutput.Add($"StartOn = {(this.StartOn == null ? "null" : this.StartOn.ToString())}");
            toStringOutput.Add($"RetryInterval = {this.RetryInterval ?? "null"}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}
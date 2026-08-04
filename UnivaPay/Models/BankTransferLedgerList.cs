// <copyright file="BankTransferLedgerList.cs" company="APIMatic">
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
    /// BankTransferLedgerList.
    /// </summary>
    public class BankTransferLedgerList
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
        /// Initializes a new instance of the <see cref="BankTransferLedgerList"/> class.
        /// </summary>
        public BankTransferLedgerList()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BankTransferLedgerList"/> class.
        /// </summary>
        /// <param name="items">items.</param>
        /// <param name="hasMore">has_more.</param>
        /// <param name="totalHits">total_hits.</param>
        public BankTransferLedgerList(
            List<Models.BankTransferLedger> items = null,
            bool? hasMore = null,
            int? totalHits = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.Items = items;
            this.HasMore = hasMore;
            this.TotalHits = totalHits;
        }

        /// <summary>
        /// List of resources.
        /// </summary>
        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.BankTransferLedger> Items { get; set; }

        /// <summary>
        /// Whether more results are available.
        /// </summary>
        [JsonProperty("has_more", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// Total number of matching resources.
        /// </summary>
        [JsonProperty("total_hits", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalHits { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"BankTransferLedgerList : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Items = {(this.Items == null ? "null" : $"[{string.Join(", ", this.Items)} ]")}");
            toStringOutput.Add($"HasMore = {(this.HasMore == null ? "null" : this.HasMore.ToString())}");
            toStringOutput.Add($"TotalHits = {(this.TotalHits == null ? "null" : this.TotalHits.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}
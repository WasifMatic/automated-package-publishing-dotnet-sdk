// <copyright file="CustomsDeclarationWebhookResult.cs" company="APIMatic">
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
    /// CustomsDeclarationWebhookResult.
    /// </summary>
    public class CustomsDeclarationWebhookResult
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

        private string approvingAuthority;
        private string tradeId;
        private string transactionId;
        private string chargeTransactionId;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "approving_authority", false },
            { "trade_id", false },
            { "transaction_id", false },
            { "charge_transaction_id", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomsDeclarationWebhookResult"/> class.
        /// </summary>
        public CustomsDeclarationWebhookResult()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomsDeclarationWebhookResult"/> class.
        /// </summary>
        /// <param name="approvingAuthority">approving_authority.</param>
        /// <param name="tradeId">trade_id.</param>
        /// <param name="transactionId">transaction_id.</param>
        /// <param name="chargeTransactionId">charge_transaction_id.</param>
        public CustomsDeclarationWebhookResult(
            string approvingAuthority = null,
            string tradeId = null,
            string transactionId = null,
            string chargeTransactionId = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();

            if (approvingAuthority != null)
            {
                this.ApprovingAuthority = approvingAuthority;
            }

            if (tradeId != null)
            {
                this.TradeId = tradeId;
            }

            if (transactionId != null)
            {
                this.TransactionId = transactionId;
            }

            if (chargeTransactionId != null)
            {
                this.ChargeTransactionId = chargeTransactionId;
            }
        }

        /// <summary>
        /// Customs authority that approved the declaration.
        /// </summary>
        [JsonProperty("approving_authority")]
        public string ApprovingAuthority
        {
            get
            {
                return this.approvingAuthority;
            }

            set
            {
                this.shouldSerialize["approving_authority"] = true;
                this.approvingAuthority = value;
            }
        }

        /// <summary>
        /// Gateway trade identifier.
        /// </summary>
        [JsonProperty("trade_id")]
        public string TradeId
        {
            get
            {
                return this.tradeId;
            }

            set
            {
                this.shouldSerialize["trade_id"] = true;
                this.tradeId = value;
            }
        }

        /// <summary>
        /// Gateway transaction identifier for customs.
        /// </summary>
        [JsonProperty("transaction_id")]
        public string TransactionId
        {
            get
            {
                return this.transactionId;
            }

            set
            {
                this.shouldSerialize["transaction_id"] = true;
                this.transactionId = value;
            }
        }

        /// <summary>
        /// Gateway charge transaction identifier linked to the declaration.
        /// </summary>
        [JsonProperty("charge_transaction_id")]
        public string ChargeTransactionId
        {
            get
            {
                return this.chargeTransactionId;
            }

            set
            {
                this.shouldSerialize["charge_transaction_id"] = true;
                this.chargeTransactionId = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CustomsDeclarationWebhookResult : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetApprovingAuthority()
        {
            this.shouldSerialize["approving_authority"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetTradeId()
        {
            this.shouldSerialize["trade_id"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetTransactionId()
        {
            this.shouldSerialize["transaction_id"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetChargeTransactionId()
        {
            this.shouldSerialize["charge_transaction_id"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeApprovingAuthority()
        {
            return this.shouldSerialize["approving_authority"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTradeId()
        {
            return this.shouldSerialize["trade_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTransactionId()
        {
            return this.shouldSerialize["transaction_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeChargeTransactionId()
        {
            return this.shouldSerialize["charge_transaction_id"];
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"ApprovingAuthority = {this.ApprovingAuthority ?? "null"}");
            toStringOutput.Add($"TradeId = {this.TradeId ?? "null"}");
            toStringOutput.Add($"TransactionId = {this.TransactionId ?? "null"}");
            toStringOutput.Add($"ChargeTransactionId = {this.ChargeTransactionId ?? "null"}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}
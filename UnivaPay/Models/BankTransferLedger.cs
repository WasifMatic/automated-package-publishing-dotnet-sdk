// <copyright file="BankTransferLedger.cs" company="APIMatic">
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
    /// BankTransferLedger.
    /// </summary>
    public class BankTransferLedger
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
        /// Initializes a new instance of the <see cref="BankTransferLedger"/> class.
        /// </summary>
        public BankTransferLedger()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BankTransferLedger"/> class.
        /// </summary>
        /// <param name="bankLedgerType">bank_ledger_type.</param>
        /// <param name="amount">amount.</param>
        /// <param name="balance">balance.</param>
        /// <param name="virtualBankAccountHolderName">virtual_bank_account_holder_name.</param>
        /// <param name="virtualBankAccountNumber">virtual_bank_account_number.</param>
        /// <param name="virtualAccountId">virtual_account_id.</param>
        /// <param name="transactionDate">transaction_date.</param>
        /// <param name="transactionTimestamp">transaction_timestamp.</param>
        /// <param name="mode">mode.</param>
        /// <param name="createdOn">created_on.</param>
        public BankTransferLedger(
            Models.BankTransferLedgerBankLedgerType? bankLedgerType = null,
            int? amount = null,
            int? balance = null,
            string virtualBankAccountHolderName = null,
            string virtualBankAccountNumber = null,
            string virtualAccountId = null,
            DateTime? transactionDate = null,
            DateTime? transactionTimestamp = null,
            Models.BankTransferLedgerMode? mode = null,
            DateTime? createdOn = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.BankLedgerType = bankLedgerType;
            this.Amount = amount;
            this.Balance = balance;
            this.VirtualBankAccountHolderName = virtualBankAccountHolderName;
            this.VirtualBankAccountNumber = virtualBankAccountNumber;
            this.VirtualAccountId = virtualAccountId;
            this.TransactionDate = transactionDate;
            this.TransactionTimestamp = transactionTimestamp;
            this.Mode = mode;
            this.CreatedOn = createdOn;
        }

        /// <summary>
        /// Bank Transfer Ledger Bank Ledger Type schema.
        /// </summary>
        [JsonProperty("bank_ledger_type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BankTransferLedgerBankLedgerType? BankLedgerType { get; set; }

        /// <summary>
        /// Amount in the smallest currency unit.
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public int? Amount { get; set; }

        /// <summary>
        /// Current balance in the smallest currency unit.
        /// </summary>
        [JsonProperty("balance", NullValueHandling = NullValueHandling.Ignore)]
        public int? Balance { get; set; }

        /// <summary>
        /// Virtual bank account holder name.
        /// </summary>
        [JsonProperty("virtual_bank_account_holder_name", NullValueHandling = NullValueHandling.Ignore)]
        public string VirtualBankAccountHolderName { get; set; }

        /// <summary>
        /// Virtual bank account number.
        /// </summary>
        [JsonProperty("virtual_bank_account_number", NullValueHandling = NullValueHandling.Ignore)]
        public string VirtualBankAccountNumber { get; set; }

        /// <summary>
        /// Virtual account id value.
        /// </summary>
        [JsonProperty("virtual_account_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VirtualAccountId { get; set; }

        /// <summary>
        /// Transaction date.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("transaction_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? TransactionDate { get; set; }

        /// <summary>
        /// Transaction timestamp.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("transaction_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? TransactionTimestamp { get; set; }

        /// <summary>
        /// Bank Transfer Ledger Mode schema.
        /// </summary>
        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BankTransferLedgerMode? Mode { get; set; }

        /// <summary>
        /// Timestamp when the resource was created.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_on", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedOn { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"BankTransferLedger : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"BankLedgerType = {(this.BankLedgerType == null ? "null" : this.BankLedgerType.ToString())}");
            toStringOutput.Add($"Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"Balance = {(this.Balance == null ? "null" : this.Balance.ToString())}");
            toStringOutput.Add($"VirtualBankAccountHolderName = {this.VirtualBankAccountHolderName ?? "null"}");
            toStringOutput.Add($"VirtualBankAccountNumber = {this.VirtualBankAccountNumber ?? "null"}");
            toStringOutput.Add($"VirtualAccountId = {this.VirtualAccountId ?? "null"}");
            toStringOutput.Add($"TransactionDate = {(this.TransactionDate == null ? "null" : this.TransactionDate.ToString())}");
            toStringOutput.Add($"TransactionTimestamp = {(this.TransactionTimestamp == null ? "null" : this.TransactionTimestamp.ToString())}");
            toStringOutput.Add($"Mode = {(this.Mode == null ? "null" : this.Mode.ToString())}");
            toStringOutput.Add($"CreatedOn = {(this.CreatedOn == null ? "null" : this.CreatedOn.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}
// <copyright file="BankTransferStatusData.cs" company="APIMatic">
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
    /// BankTransferStatusData.
    /// </summary>
    public class BankTransferStatusData
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

        private Guid? id;
        private DateTime? latestDepositDate;
        private DateTime? createdOn;
        private int? latestDepositAmount;
        private int? balance;
        private int? amountDifference;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "id", false },
            { "latest_deposit_date", false },
            { "created_on", false },
            { "latest_deposit_amount", false },
            { "balance", false },
            { "amount_difference", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="BankTransferStatusData"/> class.
        /// </summary>
        public BankTransferStatusData()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BankTransferStatusData"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="chargeId">charge_id.</param>
        /// <param name="paymentStatus">payment_status.</param>
        /// <param name="latestDepositDate">latest_deposit_date.</param>
        /// <param name="createdOn">created_on.</param>
        /// <param name="latestDepositAmount">latest_deposit_amount.</param>
        /// <param name="balance">balance.</param>
        /// <param name="currency">currency.</param>
        /// <param name="amount">amount.</param>
        /// <param name="amountDifference">amount_difference.</param>
        /// <param name="tokenMetadata">token_metadata.</param>
        /// <param name="chargeMetadata">charge_metadata.</param>
        public BankTransferStatusData(
            Guid? id = null,
            Guid? chargeId = null,
            Models.BankTransferPaymentStatus? paymentStatus = null,
            DateTime? latestDepositDate = null,
            DateTime? createdOn = null,
            int? latestDepositAmount = null,
            int? balance = null,
            string currency = null,
            int? amount = null,
            int? amountDifference = null,
            Models.GenericMetadata tokenMetadata = null,
            Models.GenericMetadata chargeMetadata = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();

            if (id != null)
            {
                this.Id = id;
            }
            this.ChargeId = chargeId;
            this.PaymentStatus = paymentStatus;

            if (latestDepositDate != null)
            {
                this.LatestDepositDate = latestDepositDate;
            }

            if (createdOn != null)
            {
                this.CreatedOn = createdOn;
            }

            if (latestDepositAmount != null)
            {
                this.LatestDepositAmount = latestDepositAmount;
            }

            if (balance != null)
            {
                this.Balance = balance;
            }
            this.Currency = currency;
            this.Amount = amount;

            if (amountDifference != null)
            {
                this.AmountDifference = amountDifference;
            }
            this.TokenMetadata = tokenMetadata;
            this.ChargeMetadata = chargeMetadata;
        }

        /// <summary>
        /// Bank transfer charge extension ID.
        /// </summary>
        [JsonProperty("id")]
        public Guid? Id
        {
            get
            {
                return this.id;
            }

            set
            {
                this.shouldSerialize["id"] = true;
                this.id = value;
            }
        }

        /// <summary>
        /// ID of the associated charge.
        /// </summary>
        [JsonProperty("charge_id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? ChargeId { get; set; }

        /// <summary>
        /// Payment status of a bank transfer charge.
        /// </summary>
        [JsonProperty("payment_status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BankTransferPaymentStatus? PaymentStatus { get; set; }

        /// <summary>
        /// Date of the most recent deposit.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("latest_deposit_date")]
        public DateTime? LatestDepositDate
        {
            get
            {
                return this.latestDepositDate;
            }

            set
            {
                this.shouldSerialize["latest_deposit_date"] = true;
                this.latestDepositDate = value;
            }
        }

        /// <summary>
        /// When the bank transfer extension record was created.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_on")]
        public DateTime? CreatedOn
        {
            get
            {
                return this.createdOn;
            }

            set
            {
                this.shouldSerialize["created_on"] = true;
                this.createdOn = value;
            }
        }

        /// <summary>
        /// Amount of the most recent deposit in minor currency units.
        /// </summary>
        [JsonProperty("latest_deposit_amount")]
        public int? LatestDepositAmount
        {
            get
            {
                return this.latestDepositAmount;
            }

            set
            {
                this.shouldSerialize["latest_deposit_amount"] = true;
                this.latestDepositAmount = value;
            }
        }

        /// <summary>
        /// Current outstanding balance in minor currency units.
        /// </summary>
        [JsonProperty("balance")]
        public int? Balance
        {
            get
            {
                return this.balance;
            }

            set
            {
                this.shouldSerialize["balance"] = true;
                this.balance = value;
            }
        }

        /// <summary>
        /// ISO 4217 currency code.
        /// </summary>
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        /// <summary>
        /// Total charge amount in minor currency units.
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public int? Amount { get; set; }

        /// <summary>
        /// Difference between paid and expected amount (positive = over, negative = under).
        /// </summary>
        [JsonProperty("amount_difference")]
        public int? AmountDifference
        {
            get
            {
                return this.amountDifference;
            }

            set
            {
                this.shouldSerialize["amount_difference"] = true;
                this.amountDifference = value;
            }
        }

        /// <summary>
        /// A free-form dictionary for custom metadata.
        /// </summary>
        [JsonProperty("token_metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Models.GenericMetadata TokenMetadata { get; set; }

        /// <summary>
        /// A free-form dictionary for custom metadata.
        /// </summary>
        [JsonProperty("charge_metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Models.GenericMetadata ChargeMetadata { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"BankTransferStatusData : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetId()
        {
            this.shouldSerialize["id"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetLatestDepositDate()
        {
            this.shouldSerialize["latest_deposit_date"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCreatedOn()
        {
            this.shouldSerialize["created_on"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetLatestDepositAmount()
        {
            this.shouldSerialize["latest_deposit_amount"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetBalance()
        {
            this.shouldSerialize["balance"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAmountDifference()
        {
            this.shouldSerialize["amount_difference"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeId()
        {
            return this.shouldSerialize["id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLatestDepositDate()
        {
            return this.shouldSerialize["latest_deposit_date"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCreatedOn()
        {
            return this.shouldSerialize["created_on"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLatestDepositAmount()
        {
            return this.shouldSerialize["latest_deposit_amount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBalance()
        {
            return this.shouldSerialize["balance"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAmountDifference()
        {
            return this.shouldSerialize["amount_difference"];
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"ChargeId = {(this.ChargeId == null ? "null" : this.ChargeId.ToString())}");
            toStringOutput.Add($"PaymentStatus = {(this.PaymentStatus == null ? "null" : this.PaymentStatus.ToString())}");
            toStringOutput.Add($"LatestDepositDate = {(this.LatestDepositDate == null ? "null" : this.LatestDepositDate.ToString())}");
            toStringOutput.Add($"CreatedOn = {(this.CreatedOn == null ? "null" : this.CreatedOn.ToString())}");
            toStringOutput.Add($"LatestDepositAmount = {(this.LatestDepositAmount == null ? "null" : this.LatestDepositAmount.ToString())}");
            toStringOutput.Add($"Balance = {(this.Balance == null ? "null" : this.Balance.ToString())}");
            toStringOutput.Add($"Currency = {this.Currency ?? "null"}");
            toStringOutput.Add($"Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"AmountDifference = {(this.AmountDifference == null ? "null" : this.AmountDifference.ToString())}");
            toStringOutput.Add($"TokenMetadata = {(this.TokenMetadata == null ? "null" : this.TokenMetadata.ToString())}");
            toStringOutput.Add($"ChargeMetadata = {(this.ChargeMetadata == null ? "null" : this.ChargeMetadata.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}
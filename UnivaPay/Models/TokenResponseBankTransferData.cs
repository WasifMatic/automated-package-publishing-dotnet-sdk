// <copyright file="TokenResponseBankTransferData.cs" company="APIMatic">
// UnivaPay
//
// This file was automatically generated for Univapay by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnivaPay.Utilities;

namespace UnivaPay.Models
{
    /// <summary>
    /// TokenResponseBankTransferData.
    /// </summary>
    public class TokenResponseBankTransferData
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

        private string bankCode;
        private string bankName;
        private string branchCode;
        private string branchName;
        private string accountNumber;
        private string accountHolderName;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "bank_code", false },
            { "bank_name", false },
            { "branch_code", false },
            { "branch_name", false },
            { "account_number", false },
            { "account_holder_name", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenResponseBankTransferData"/> class.
        /// </summary>
        public TokenResponseBankTransferData()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenResponseBankTransferData"/> class.
        /// </summary>
        /// <param name="brand">brand.</param>
        /// <param name="expirationPeriod">expiration_period.</param>
        /// <param name="expirationTimeShift">expiration_time_shift.</param>
        /// <param name="bankCode">bank_code.</param>
        /// <param name="bankName">bank_name.</param>
        /// <param name="branchCode">branch_code.</param>
        /// <param name="branchName">branch_name.</param>
        /// <param name="accountNumber">account_number.</param>
        /// <param name="accountHolderName">account_holder_name.</param>
        public TokenResponseBankTransferData(
            string brand = null,
            string expirationPeriod = null,
            string expirationTimeShift = null,
            string bankCode = null,
            string bankName = null,
            string branchCode = null,
            string branchName = null,
            string accountNumber = null,
            string accountHolderName = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.Brand = brand;
            this.ExpirationPeriod = expirationPeriod;
            this.ExpirationTimeShift = expirationTimeShift;

            if (bankCode != null)
            {
                this.BankCode = bankCode;
            }

            if (bankName != null)
            {
                this.BankName = bankName;
            }

            if (branchCode != null)
            {
                this.BranchCode = branchCode;
            }

            if (branchName != null)
            {
                this.BranchName = branchName;
            }

            if (accountNumber != null)
            {
                this.AccountNumber = accountNumber;
            }

            if (accountHolderName != null)
            {
                this.AccountHolderName = accountHolderName;
            }
        }

        /// <summary>
        /// The bank brand identifier (e.g., 'aozora_bank').
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("brand", NullValueHandling = NullValueHandling.Ignore)]
        public string Brand { get; set; }

        /// <summary>
        /// ISO 8601 duration format (e.g., 'PT168H').
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("expiration_period", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpirationPeriod { get; set; }

        /// <summary>
        /// Time shift applied to the expiration, typically pushing it to the end of the day  in a specific timezone (e.g., '23:59:59+09:00').
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("expiration_time_shift", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpirationTimeShift { get; set; }

        /// <summary>
        /// Bank code value.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("bank_code")]
        public string BankCode
        {
            get
            {
                return this.bankCode;
            }

            set
            {
                this.shouldSerialize["bank_code"] = true;
                this.bankCode = value;
            }
        }

        /// <summary>
        /// Bank name value.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("bank_name")]
        public string BankName
        {
            get
            {
                return this.bankName;
            }

            set
            {
                this.shouldSerialize["bank_name"] = true;
                this.bankName = value;
            }
        }

        /// <summary>
        /// Bank branch code.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("branch_code")]
        public string BranchCode
        {
            get
            {
                return this.branchCode;
            }

            set
            {
                this.shouldSerialize["branch_code"] = true;
                this.branchCode = value;
            }
        }

        /// <summary>
        /// Bank branch name.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("branch_name")]
        public string BranchName
        {
            get
            {
                return this.branchName;
            }

            set
            {
                this.shouldSerialize["branch_name"] = true;
                this.branchName = value;
            }
        }

        /// <summary>
        /// Bank account number.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("account_number")]
        public string AccountNumber
        {
            get
            {
                return this.accountNumber;
            }

            set
            {
                this.shouldSerialize["account_number"] = true;
                this.accountNumber = value;
            }
        }

        /// <summary>
        /// Bank account holder name.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("account_holder_name")]
        public string AccountHolderName
        {
            get
            {
                return this.accountHolderName;
            }

            set
            {
                this.shouldSerialize["account_holder_name"] = true;
                this.accountHolderName = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"TokenResponseBankTransferData : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetBankCode()
        {
            this.shouldSerialize["bank_code"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetBankName()
        {
            this.shouldSerialize["bank_name"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetBranchCode()
        {
            this.shouldSerialize["branch_code"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetBranchName()
        {
            this.shouldSerialize["branch_name"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAccountNumber()
        {
            this.shouldSerialize["account_number"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAccountHolderName()
        {
            this.shouldSerialize["account_holder_name"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBankCode()
        {
            return this.shouldSerialize["bank_code"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBankName()
        {
            return this.shouldSerialize["bank_name"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBranchCode()
        {
            return this.shouldSerialize["branch_code"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBranchName()
        {
            return this.shouldSerialize["branch_name"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAccountNumber()
        {
            return this.shouldSerialize["account_number"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAccountHolderName()
        {
            return this.shouldSerialize["account_holder_name"];
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Brand = {this.Brand ?? "null"}");
            toStringOutput.Add($"ExpirationPeriod = {this.ExpirationPeriod ?? "null"}");
            toStringOutput.Add($"ExpirationTimeShift = {this.ExpirationTimeShift ?? "null"}");
            toStringOutput.Add($"BankCode = {this.BankCode ?? "null"}");
            toStringOutput.Add($"BankName = {this.BankName ?? "null"}");
            toStringOutput.Add($"BranchCode = {this.BranchCode ?? "null"}");
            toStringOutput.Add($"BranchName = {this.BranchName ?? "null"}");
            toStringOutput.Add($"AccountNumber = {this.AccountNumber ?? "null"}");
            toStringOutput.Add($"AccountHolderName = {this.AccountHolderName ?? "null"}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}
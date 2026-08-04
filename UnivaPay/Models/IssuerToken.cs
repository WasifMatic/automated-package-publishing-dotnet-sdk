// <copyright file="IssuerToken.cs" company="APIMatic">
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
    /// IssuerToken.
    /// </summary>
    public class IssuerToken
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

        private string issuerTokenProp;
        private Models.IssuerTokenCallMethod? callMethod;
        private Models.IssuerTokenPayload payload;
        private string accountId;
        private string branchCode;
        private string branchName;
        private string accountHolderName;
        private string accountNumber;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "issuer_token", false },
            { "call_method", false },
            { "payload", false },
            { "account_id", false },
            { "branch_code", false },
            { "branch_name", false },
            { "account_holder_name", false },
            { "account_number", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuerToken"/> class.
        /// </summary>
        public IssuerToken()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuerToken"/> class.
        /// </summary>
        /// <param name="paymentType">payment_type.</param>
        /// <param name="issuerTokenProp">issuer_token.</param>
        /// <param name="callMethod">call_method.</param>
        /// <param name="payload">payload.</param>
        /// <param name="accountId">account_id.</param>
        /// <param name="branchCode">branch_code.</param>
        /// <param name="branchName">branch_name.</param>
        /// <param name="accountHolderName">account_holder_name.</param>
        /// <param name="accountNumber">account_number.</param>
        public IssuerToken(
            Models.IssuerTokenPaymentType paymentType,
            string issuerTokenProp = null,
            Models.IssuerTokenCallMethod? callMethod = null,
            Models.IssuerTokenPayload payload = null,
            string accountId = null,
            string branchCode = null,
            string branchName = null,
            string accountHolderName = null,
            string accountNumber = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.PaymentType = paymentType;

            if (issuerTokenProp != null)
            {
                this.IssuerTokenProp = issuerTokenProp;
            }

            if (callMethod != null)
            {
                this.CallMethod = callMethod;
            }

            if (payload != null)
            {
                this.Payload = payload;
            }

            if (accountId != null)
            {
                this.AccountId = accountId;
            }

            if (branchCode != null)
            {
                this.BranchCode = branchCode;
            }

            if (branchName != null)
            {
                this.BranchName = branchName;
            }

            if (accountHolderName != null)
            {
                this.AccountHolderName = accountHolderName;
            }

            if (accountNumber != null)
            {
                this.AccountNumber = accountNumber;
            }
        }

        /// <summary>
        /// The type of payment method for the charge.
        /// </summary>
        [JsonProperty("payment_type")]
        public Models.IssuerTokenPaymentType PaymentType { get; set; }

        /// <summary>
        /// (Online) The token or payment URL provided by the payment provider for the consumer to execute.
        /// </summary>
        [JsonProperty("issuer_token")]
        public string IssuerTokenProp
        {
            get
            {
                return this.issuerTokenProp;
            }

            set
            {
                this.shouldSerialize["issuer_token"] = true;
                this.issuerTokenProp = value;
            }
        }

        /// <summary>
        /// (Online) How the client should execute the token.  - `sdk` / `app`: Direct use in native app environments/SDKs. - `web`: Direct use in special extended browser environments. - `http_get` / `http_post`: Execute directly in a new browser window or iframe.
        /// </summary>
        [JsonProperty("call_method")]
        public Models.IssuerTokenCallMethod? CallMethod
        {
            get
            {
                return this.callMethod;
            }

            set
            {
                this.shouldSerialize["call_method"] = true;
                this.callMethod = value;
            }
        }

        /// <summary>
        /// Key-value pairs required to complete the payment action, or null if not applicable. Used when `call_method` is `http_post`. When present, this JSON must be converted by the client to match the expected `content_type` (e.g., transformed into an `application/x-www-form-urlencoded` string) before sending the POST request.
        /// </summary>
        [JsonProperty("payload")]
        public Models.IssuerTokenPayload Payload
        {
            get
            {
                return this.payload;
            }

            set
            {
                this.shouldSerialize["payload"] = true;
                this.payload = value;
            }
        }

        /// <summary>
        /// (Bank Transfer) Unique ID of the bank account issued by the connected system.
        /// </summary>
        [JsonProperty("account_id")]
        public string AccountId
        {
            get
            {
                return this.accountId;
            }

            set
            {
                this.shouldSerialize["account_id"] = true;
                this.accountId = value;
            }
        }

        /// <summary>
        /// (Bank Transfer) Branch code.
        /// </summary>
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
        /// (Bank Transfer) Branch name.
        /// </summary>
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
        /// (Bank Transfer) Account holder name.
        /// </summary>
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

        /// <summary>
        /// (Bank Transfer) Account number.
        /// </summary>
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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"IssuerToken : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetIssuerToken()
        {
            this.shouldSerialize["issuer_token"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCallMethod()
        {
            this.shouldSerialize["call_method"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPayload()
        {
            this.shouldSerialize["payload"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAccountId()
        {
            this.shouldSerialize["account_id"] = false;
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
        public void UnsetAccountHolderName()
        {
            this.shouldSerialize["account_holder_name"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAccountNumber()
        {
            this.shouldSerialize["account_number"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeIssuerToken()
        {
            return this.shouldSerialize["issuer_token"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCallMethod()
        {
            return this.shouldSerialize["call_method"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePayload()
        {
            return this.shouldSerialize["payload"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAccountId()
        {
            return this.shouldSerialize["account_id"];
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
        public bool ShouldSerializeAccountHolderName()
        {
            return this.shouldSerialize["account_holder_name"];
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
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"PaymentType = {this.PaymentType}");
            toStringOutput.Add($"IssuerTokenProp = {this.IssuerTokenProp ?? "null"}");
            toStringOutput.Add($"CallMethod = {(this.CallMethod == null ? "null" : this.CallMethod.ToString())}");
            toStringOutput.Add($"Payload = {(this.Payload == null ? "null" : this.Payload.ToString())}");
            toStringOutput.Add($"AccountId = {this.AccountId ?? "null"}");
            toStringOutput.Add($"BranchCode = {this.BranchCode ?? "null"}");
            toStringOutput.Add($"BranchName = {this.BranchName ?? "null"}");
            toStringOutput.Add($"AccountHolderName = {this.AccountHolderName ?? "null"}");
            toStringOutput.Add($"AccountNumber = {this.AccountNumber ?? "null"}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}
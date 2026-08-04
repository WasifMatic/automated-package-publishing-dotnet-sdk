// <copyright file="Charge.cs" company="APIMatic">
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
    /// Charge.
    /// </summary>
    public class Charge
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

        private Guid? subscriptionId;
        private string merchantTransactionId;
        private int? chargedAmount;
        private string chargedCurrency;
        private double? chargedAmountFormatted;
        private int? feeAmount;
        private string feeCurrency;
        private double? feeAmountFormatted;
        private DateTime? captureAt;
        private string descriptor;
        private string descriptorPhoneNumber;
        private Models.PaymentError error;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "subscription_id", false },
            { "merchant_transaction_id", false },
            { "charged_amount", false },
            { "charged_currency", false },
            { "charged_amount_formatted", false },
            { "fee_amount", false },
            { "fee_currency", false },
            { "fee_amount_formatted", false },
            { "capture_at", false },
            { "descriptor", false },
            { "descriptor_phone_number", false },
            { "error", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Charge"/> class.
        /// </summary>
        public Charge()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Charge"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="storeId">store_id.</param>
        /// <param name="transactionTokenId">transaction_token_id.</param>
        /// <param name="transactionTokenType">transaction_token_type.</param>
        /// <param name="subscriptionId">subscription_id.</param>
        /// <param name="merchantTransactionId">merchant_transaction_id.</param>
        /// <param name="requestedAmount">requested_amount.</param>
        /// <param name="requestedCurrency">requested_currency.</param>
        /// <param name="requestedAmountFormatted">requested_amount_formatted.</param>
        /// <param name="chargedAmount">charged_amount.</param>
        /// <param name="chargedCurrency">charged_currency.</param>
        /// <param name="chargedAmountFormatted">charged_amount_formatted.</param>
        /// <param name="feeAmount">fee_amount.</param>
        /// <param name="feeCurrency">fee_currency.</param>
        /// <param name="feeAmountFormatted">fee_amount_formatted.</param>
        /// <param name="onlyDirectCurrency">only_direct_currency.</param>
        /// <param name="captureAt">capture_at.</param>
        /// <param name="descriptor">descriptor.</param>
        /// <param name="descriptorPhoneNumber">descriptor_phone_number.</param>
        /// <param name="status">status.</param>
        /// <param name="error">error.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="mode">mode.</param>
        /// <param name="createdOn">created_on.</param>
        /// <param name="merchantName">merchant_name.</param>
        /// <param name="storeName">store_name.</param>
        /// <param name="redirect">redirect.</param>
        /// <param name="threeDs">three_ds.</param>
        public Charge(
            Guid? id = null,
            Guid? storeId = null,
            Guid? transactionTokenId = null,
            Models.ChargeTransactionTokenType? transactionTokenType = null,
            Guid? subscriptionId = null,
            string merchantTransactionId = null,
            int? requestedAmount = null,
            string requestedCurrency = null,
            double? requestedAmountFormatted = null,
            int? chargedAmount = null,
            string chargedCurrency = null,
            double? chargedAmountFormatted = null,
            int? feeAmount = null,
            string feeCurrency = null,
            double? feeAmountFormatted = null,
            bool? onlyDirectCurrency = null,
            DateTime? captureAt = null,
            string descriptor = null,
            string descriptorPhoneNumber = null,
            Models.ChargeStatus? status = null,
            Models.PaymentError error = null,
            Models.GenericMetadata metadata = null,
            Models.ChargeMode? mode = null,
            DateTime? createdOn = null,
            string merchantName = null,
            string storeName = null,
            Models.ChargeRedirect redirect = null,
            Models.ChargeThreeDs threeDs = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.Id = id;
            this.StoreId = storeId;
            this.TransactionTokenId = transactionTokenId;
            this.TransactionTokenType = transactionTokenType;

            if (subscriptionId != null)
            {
                this.SubscriptionId = subscriptionId;
            }

            if (merchantTransactionId != null)
            {
                this.MerchantTransactionId = merchantTransactionId;
            }
            this.RequestedAmount = requestedAmount;
            this.RequestedCurrency = requestedCurrency;
            this.RequestedAmountFormatted = requestedAmountFormatted;

            if (chargedAmount != null)
            {
                this.ChargedAmount = chargedAmount;
            }

            if (chargedCurrency != null)
            {
                this.ChargedCurrency = chargedCurrency;
            }

            if (chargedAmountFormatted != null)
            {
                this.ChargedAmountFormatted = chargedAmountFormatted;
            }

            if (feeAmount != null)
            {
                this.FeeAmount = feeAmount;
            }

            if (feeCurrency != null)
            {
                this.FeeCurrency = feeCurrency;
            }

            if (feeAmountFormatted != null)
            {
                this.FeeAmountFormatted = feeAmountFormatted;
            }
            this.OnlyDirectCurrency = onlyDirectCurrency;

            if (captureAt != null)
            {
                this.CaptureAt = captureAt;
            }

            if (descriptor != null)
            {
                this.Descriptor = descriptor;
            }

            if (descriptorPhoneNumber != null)
            {
                this.DescriptorPhoneNumber = descriptorPhoneNumber;
            }
            this.Status = status;

            if (error != null)
            {
                this.Error = error;
            }
            this.Metadata = metadata;
            this.Mode = mode;
            this.CreatedOn = createdOn;
            this.MerchantName = merchantName;
            this.StoreName = storeName;
            this.Redirect = redirect;
            this.ThreeDs = threeDs;
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
        /// Transaction token identifier.
        /// </summary>
        [JsonProperty("transaction_token_id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? TransactionTokenId { get; set; }

        /// <summary>
        /// Charge Transaction Token Type schema.
        /// </summary>
        [JsonProperty("transaction_token_type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ChargeTransactionTokenType? TransactionTokenType { get; set; }

        /// <summary>
        /// Subscription identifier.
        /// </summary>
        [JsonProperty("subscription_id")]
        public Guid? SubscriptionId
        {
            get
            {
                return this.subscriptionId;
            }

            set
            {
                this.shouldSerialize["subscription_id"] = true;
                this.subscriptionId = value;
            }
        }

        /// <summary>
        /// Merchant-defined transaction identifier.
        /// </summary>
        [JsonProperty("merchant_transaction_id")]
        public string MerchantTransactionId
        {
            get
            {
                return this.merchantTransactionId;
            }

            set
            {
                this.shouldSerialize["merchant_transaction_id"] = true;
                this.merchantTransactionId = value;
            }
        }

        /// <summary>
        /// Requested amount in the smallest currency unit.
        /// </summary>
        [JsonProperty("requested_amount", NullValueHandling = NullValueHandling.Ignore)]
        public int? RequestedAmount { get; set; }

        /// <summary>
        /// Requested ISO-4217 currency code.
        /// </summary>
        [JsonProperty("requested_currency", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestedCurrency { get; set; }

        /// <summary>
        /// Requested amount formatted for display.
        /// </summary>
        [JsonProperty("requested_amount_formatted", NullValueHandling = NullValueHandling.Ignore)]
        public double? RequestedAmountFormatted { get; set; }

        /// <summary>
        /// Charged amount in the smallest currency unit.
        /// </summary>
        [JsonProperty("charged_amount")]
        public int? ChargedAmount
        {
            get
            {
                return this.chargedAmount;
            }

            set
            {
                this.shouldSerialize["charged_amount"] = true;
                this.chargedAmount = value;
            }
        }

        /// <summary>
        /// Charged ISO-4217 currency code.
        /// </summary>
        [JsonProperty("charged_currency")]
        public string ChargedCurrency
        {
            get
            {
                return this.chargedCurrency;
            }

            set
            {
                this.shouldSerialize["charged_currency"] = true;
                this.chargedCurrency = value;
            }
        }

        /// <summary>
        /// Charged amount formatted for display.
        /// </summary>
        [JsonProperty("charged_amount_formatted")]
        public double? ChargedAmountFormatted
        {
            get
            {
                return this.chargedAmountFormatted;
            }

            set
            {
                this.shouldSerialize["charged_amount_formatted"] = true;
                this.chargedAmountFormatted = value;
            }
        }

        /// <summary>
        /// Fee amount in the smallest currency unit.
        /// </summary>
        [JsonProperty("fee_amount")]
        public int? FeeAmount
        {
            get
            {
                return this.feeAmount;
            }

            set
            {
                this.shouldSerialize["fee_amount"] = true;
                this.feeAmount = value;
            }
        }

        /// <summary>
        /// Fee ISO-4217 currency code.
        /// </summary>
        [JsonProperty("fee_currency")]
        public string FeeCurrency
        {
            get
            {
                return this.feeCurrency;
            }

            set
            {
                this.shouldSerialize["fee_currency"] = true;
                this.feeCurrency = value;
            }
        }

        /// <summary>
        /// Fee amount formatted for display.
        /// </summary>
        [JsonProperty("fee_amount_formatted")]
        public double? FeeAmountFormatted
        {
            get
            {
                return this.feeAmountFormatted;
            }

            set
            {
                this.shouldSerialize["fee_amount_formatted"] = true;
                this.feeAmountFormatted = value;
            }
        }

        /// <summary>
        /// Whether only direct currency processing is allowed.
        /// </summary>
        [JsonProperty("only_direct_currency", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OnlyDirectCurrency { get; set; }

        /// <summary>
        /// Timestamp when capture should occur.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("capture_at")]
        public DateTime? CaptureAt
        {
            get
            {
                return this.captureAt;
            }

            set
            {
                this.shouldSerialize["capture_at"] = true;
                this.captureAt = value;
            }
        }

        /// <summary>
        /// Billing descriptor.
        /// </summary>
        [JsonProperty("descriptor")]
        public string Descriptor
        {
            get
            {
                return this.descriptor;
            }

            set
            {
                this.shouldSerialize["descriptor"] = true;
                this.descriptor = value;
            }
        }

        /// <summary>
        /// Billing descriptor phone number.
        /// </summary>
        [JsonProperty("descriptor_phone_number")]
        public string DescriptorPhoneNumber
        {
            get
            {
                return this.descriptorPhoneNumber;
            }

            set
            {
                this.shouldSerialize["descriptor_phone_number"] = true;
                this.descriptorPhoneNumber = value;
            }
        }

        /// <summary>
        /// Charge Status schema.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ChargeStatus? Status { get; set; }

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
        /// Merchant display name.
        /// </summary>
        [JsonProperty("merchant_name", NullValueHandling = NullValueHandling.Ignore)]
        public string MerchantName { get; set; }

        /// <summary>
        /// Store display name.
        /// </summary>
        [JsonProperty("store_name", NullValueHandling = NullValueHandling.Ignore)]
        public string StoreName { get; set; }

        /// <summary>
        /// Charge Redirect schema.
        /// </summary>
        [JsonProperty("redirect", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ChargeRedirect Redirect { get; set; }

        /// <summary>
        /// Charge Three Ds schema.
        /// </summary>
        [JsonProperty("three_ds", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ChargeThreeDs ThreeDs { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"Charge : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetSubscriptionId()
        {
            this.shouldSerialize["subscription_id"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetMerchantTransactionId()
        {
            this.shouldSerialize["merchant_transaction_id"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetChargedAmount()
        {
            this.shouldSerialize["charged_amount"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetChargedCurrency()
        {
            this.shouldSerialize["charged_currency"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetChargedAmountFormatted()
        {
            this.shouldSerialize["charged_amount_formatted"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetFeeAmount()
        {
            this.shouldSerialize["fee_amount"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetFeeCurrency()
        {
            this.shouldSerialize["fee_currency"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetFeeAmountFormatted()
        {
            this.shouldSerialize["fee_amount_formatted"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCaptureAt()
        {
            this.shouldSerialize["capture_at"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDescriptor()
        {
            this.shouldSerialize["descriptor"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDescriptorPhoneNumber()
        {
            this.shouldSerialize["descriptor_phone_number"] = false;
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
        public bool ShouldSerializeSubscriptionId()
        {
            return this.shouldSerialize["subscription_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMerchantTransactionId()
        {
            return this.shouldSerialize["merchant_transaction_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeChargedAmount()
        {
            return this.shouldSerialize["charged_amount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeChargedCurrency()
        {
            return this.shouldSerialize["charged_currency"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeChargedAmountFormatted()
        {
            return this.shouldSerialize["charged_amount_formatted"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFeeAmount()
        {
            return this.shouldSerialize["fee_amount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFeeCurrency()
        {
            return this.shouldSerialize["fee_currency"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFeeAmountFormatted()
        {
            return this.shouldSerialize["fee_amount_formatted"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCaptureAt()
        {
            return this.shouldSerialize["capture_at"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDescriptor()
        {
            return this.shouldSerialize["descriptor"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDescriptorPhoneNumber()
        {
            return this.shouldSerialize["descriptor_phone_number"];
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
            toStringOutput.Add($"TransactionTokenId = {(this.TransactionTokenId == null ? "null" : this.TransactionTokenId.ToString())}");
            toStringOutput.Add($"TransactionTokenType = {(this.TransactionTokenType == null ? "null" : this.TransactionTokenType.ToString())}");
            toStringOutput.Add($"SubscriptionId = {(this.SubscriptionId == null ? "null" : this.SubscriptionId.ToString())}");
            toStringOutput.Add($"MerchantTransactionId = {this.MerchantTransactionId ?? "null"}");
            toStringOutput.Add($"RequestedAmount = {(this.RequestedAmount == null ? "null" : this.RequestedAmount.ToString())}");
            toStringOutput.Add($"RequestedCurrency = {this.RequestedCurrency ?? "null"}");
            toStringOutput.Add($"RequestedAmountFormatted = {(this.RequestedAmountFormatted == null ? "null" : this.RequestedAmountFormatted.ToString())}");
            toStringOutput.Add($"ChargedAmount = {(this.ChargedAmount == null ? "null" : this.ChargedAmount.ToString())}");
            toStringOutput.Add($"ChargedCurrency = {this.ChargedCurrency ?? "null"}");
            toStringOutput.Add($"ChargedAmountFormatted = {(this.ChargedAmountFormatted == null ? "null" : this.ChargedAmountFormatted.ToString())}");
            toStringOutput.Add($"FeeAmount = {(this.FeeAmount == null ? "null" : this.FeeAmount.ToString())}");
            toStringOutput.Add($"FeeCurrency = {this.FeeCurrency ?? "null"}");
            toStringOutput.Add($"FeeAmountFormatted = {(this.FeeAmountFormatted == null ? "null" : this.FeeAmountFormatted.ToString())}");
            toStringOutput.Add($"OnlyDirectCurrency = {(this.OnlyDirectCurrency == null ? "null" : this.OnlyDirectCurrency.ToString())}");
            toStringOutput.Add($"CaptureAt = {(this.CaptureAt == null ? "null" : this.CaptureAt.ToString())}");
            toStringOutput.Add($"Descriptor = {this.Descriptor ?? "null"}");
            toStringOutput.Add($"DescriptorPhoneNumber = {this.DescriptorPhoneNumber ?? "null"}");
            toStringOutput.Add($"Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"Error = {(this.Error == null ? "null" : this.Error.ToString())}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"Mode = {(this.Mode == null ? "null" : this.Mode.ToString())}");
            toStringOutput.Add($"CreatedOn = {(this.CreatedOn == null ? "null" : this.CreatedOn.ToString())}");
            toStringOutput.Add($"MerchantName = {this.MerchantName ?? "null"}");
            toStringOutput.Add($"StoreName = {this.StoreName ?? "null"}");
            toStringOutput.Add($"Redirect = {(this.Redirect == null ? "null" : this.Redirect.ToString())}");
            toStringOutput.Add($"ThreeDs = {(this.ThreeDs == null ? "null" : this.ThreeDs.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}
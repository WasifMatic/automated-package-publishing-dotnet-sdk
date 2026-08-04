// <copyright file="CustomsDeclarationWebhookData.cs" company="APIMatic">
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
    /// CustomsDeclarationWebhookData.
    /// </summary>
    public class CustomsDeclarationWebhookData
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

        private Guid? platformId;
        private Models.CustomsDeclarationWebhookResult declarationResult;
        private Models.CustomsDeclarationWebhookError error;
        private DateTime? updatedOn;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "platform_id", false },
            { "declaration_result", false },
            { "error", false },
            { "updated_on", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomsDeclarationWebhookData"/> class.
        /// </summary>
        public CustomsDeclarationWebhookData()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomsDeclarationWebhookData"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="chargeId">charge_id.</param>
        /// <param name="merchantId">merchant_id.</param>
        /// <param name="storeId">store_id.</param>
        /// <param name="platformId">platform_id.</param>
        /// <param name="mode">mode.</param>
        /// <param name="gateway">gateway.</param>
        /// <param name="declaration">declaration.</param>
        /// <param name="declarationResult">declaration_result.</param>
        /// <param name="status">status.</param>
        /// <param name="error">error.</param>
        /// <param name="createdOn">created_on.</param>
        /// <param name="updatedOn">updated_on.</param>
        public CustomsDeclarationWebhookData(
            Guid? id = null,
            Guid? chargeId = null,
            Guid? merchantId = null,
            Guid? storeId = null,
            Guid? platformId = null,
            string mode = null,
            string gateway = null,
            Models.CustomsDeclarationWebhookDeclaration declaration = null,
            Models.CustomsDeclarationWebhookResult declarationResult = null,
            Models.CustomsDeclarationWebhookStatus? status = null,
            Models.CustomsDeclarationWebhookError error = null,
            DateTime? createdOn = null,
            DateTime? updatedOn = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.Id = id;
            this.ChargeId = chargeId;
            this.MerchantId = merchantId;
            this.StoreId = storeId;

            if (platformId != null)
            {
                this.PlatformId = platformId;
            }
            this.Mode = mode;
            this.Gateway = gateway;
            this.Declaration = declaration;

            if (declarationResult != null)
            {
                this.DeclarationResult = declarationResult;
            }
            this.Status = status;

            if (error != null)
            {
                this.Error = error;
            }
            this.CreatedOn = createdOn;

            if (updatedOn != null)
            {
                this.UpdatedOn = updatedOn;
            }
        }

        /// <summary>
        /// Customs declaration identifier.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Id { get; set; }

        /// <summary>
        /// Charge identifier associated with the declaration.
        /// </summary>
        [JsonProperty("charge_id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? ChargeId { get; set; }

        /// <summary>
        /// Merchant identifier.
        /// </summary>
        [JsonProperty("merchant_id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? MerchantId { get; set; }

        /// <summary>
        /// Store identifier.
        /// </summary>
        [JsonProperty("store_id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? StoreId { get; set; }

        /// <summary>
        /// Platform identifier, included on platform-level deliveries.
        /// </summary>
        [JsonProperty("platform_id")]
        public Guid? PlatformId
        {
            get
            {
                return this.platformId;
            }

            set
            {
                this.shouldSerialize["platform_id"] = true;
                this.platformId = value;
            }
        }

        /// <summary>
        /// Processing mode.
        /// </summary>
        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public string Mode { get; set; }

        /// <summary>
        /// Gateway that processed the declaration.
        /// </summary>
        [JsonProperty("gateway", NullValueHandling = NullValueHandling.Ignore)]
        public string Gateway { get; set; }

        /// <summary>
        /// WeChat customs declaration payload returned by the backend formatter.
        /// </summary>
        [JsonProperty("declaration", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CustomsDeclarationWebhookDeclaration Declaration { get; set; }

        /// <summary>
        /// Result payload returned by the customs declaration formatter.
        /// </summary>
        [JsonProperty("declaration_result")]
        public Models.CustomsDeclarationWebhookResult DeclarationResult
        {
            get
            {
                return this.declarationResult;
            }

            set
            {
                this.shouldSerialize["declaration_result"] = true;
                this.declarationResult = value;
            }
        }

        /// <summary>
        /// Customs declaration status returned by the backend.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CustomsDeclarationWebhookStatus? Status { get; set; }

        /// <summary>
        /// Error payload returned when customs declaration processing fails.
        /// </summary>
        [JsonProperty("error")]
        public Models.CustomsDeclarationWebhookError Error
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
        /// Timestamp when the declaration was created.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_on", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedOn { get; set; }

        /// <summary>
        /// Timestamp when the declaration was last updated, included on platform-level deliveries.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("updated_on")]
        public DateTime? UpdatedOn
        {
            get
            {
                return this.updatedOn;
            }

            set
            {
                this.shouldSerialize["updated_on"] = true;
                this.updatedOn = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CustomsDeclarationWebhookData : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPlatformId()
        {
            this.shouldSerialize["platform_id"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDeclarationResult()
        {
            this.shouldSerialize["declaration_result"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetError()
        {
            this.shouldSerialize["error"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetUpdatedOn()
        {
            this.shouldSerialize["updated_on"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePlatformId()
        {
            return this.shouldSerialize["platform_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDeclarationResult()
        {
            return this.shouldSerialize["declaration_result"];
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
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeUpdatedOn()
        {
            return this.shouldSerialize["updated_on"];
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"ChargeId = {(this.ChargeId == null ? "null" : this.ChargeId.ToString())}");
            toStringOutput.Add($"MerchantId = {(this.MerchantId == null ? "null" : this.MerchantId.ToString())}");
            toStringOutput.Add($"StoreId = {(this.StoreId == null ? "null" : this.StoreId.ToString())}");
            toStringOutput.Add($"PlatformId = {(this.PlatformId == null ? "null" : this.PlatformId.ToString())}");
            toStringOutput.Add($"Mode = {this.Mode ?? "null"}");
            toStringOutput.Add($"Gateway = {this.Gateway ?? "null"}");
            toStringOutput.Add($"Declaration = {(this.Declaration == null ? "null" : this.Declaration.ToString())}");
            toStringOutput.Add($"DeclarationResult = {(this.DeclarationResult == null ? "null" : this.DeclarationResult.ToString())}");
            toStringOutput.Add($"Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"Error = {(this.Error == null ? "null" : this.Error.ToString())}");
            toStringOutput.Add($"CreatedOn = {(this.CreatedOn == null ? "null" : this.CreatedOn.ToString())}");
            toStringOutput.Add($"UpdatedOn = {(this.UpdatedOn == null ? "null" : this.UpdatedOn.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}
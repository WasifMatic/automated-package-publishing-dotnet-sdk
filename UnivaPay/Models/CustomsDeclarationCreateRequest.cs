// <copyright file="CustomsDeclarationCreateRequest.cs" company="APIMatic">
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
    /// CustomsDeclarationCreateRequest.
    /// </summary>
    public class CustomsDeclarationCreateRequest
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
        /// Initializes a new instance of the <see cref="CustomsDeclarationCreateRequest"/> class.
        /// </summary>
        public CustomsDeclarationCreateRequest()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomsDeclarationCreateRequest"/> class.
        /// </summary>
        /// <param name="customs">customs.</param>
        /// <param name="merchantCustomsNo">merchant_customs_no.</param>
        /// <param name="certificateId">certificate_id.</param>
        /// <param name="certificateName">certificate_name.</param>
        public CustomsDeclarationCreateRequest(
            string customs,
            string merchantCustomsNo,
            string certificateId,
            string certificateName)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.Customs = customs;
            this.MerchantCustomsNo = merchantCustomsNo;
            this.CertificateId = certificateId;
            this.CertificateName = certificateName;
        }

        /// <summary>
        /// WeChat customs authority code used for the declaration.
        /// </summary>
        [JsonProperty("customs")]
        public string Customs { get; set; }

        /// <summary>
        /// Merchant customs registration number.
        /// </summary>
        [JsonProperty("merchant_customs_no")]
        public string MerchantCustomsNo { get; set; }

        /// <summary>
        /// Customer certificate or passport identifier used by customs.
        /// </summary>
        [JsonProperty("certificate_id")]
        public string CertificateId { get; set; }

        /// <summary>
        /// Customer name exactly as shown on the certificate.
        /// </summary>
        [JsonProperty("certificate_name")]
        public string CertificateName { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CustomsDeclarationCreateRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Customs = {this.Customs ?? "null"}");
            toStringOutput.Add($"MerchantCustomsNo = {this.MerchantCustomsNo ?? "null"}");
            toStringOutput.Add($"CertificateId = {this.CertificateId ?? "null"}");
            toStringOutput.Add($"CertificateName = {this.CertificateName ?? "null"}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}
// <copyright file="PaymentError.cs" company="APIMatic">
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
    /// PaymentError.
    /// </summary>
    public class PaymentError
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
        /// Initializes a new instance of the <see cref="PaymentError"/> class.
        /// </summary>
        public PaymentError()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentError"/> class.
        /// </summary>
        /// <param name="code">code.</param>
        /// <param name="message">message.</param>
        /// <param name="detail">detail.</param>
        public PaymentError(
            int? code = null,
            string message = null,
            string detail = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.Code = code;
            this.Message = message;
            this.Detail = detail;
        }

        /// <summary>
        /// Payment Error Codes.
        /// | Code | Description |
        /// | :--- | :--- |
        /// | 301 | Card number error. |
        /// | 302 | Invalid expiration month. |
        /// | 303 | Invalid expiration year. |
        /// | 304 | Card expired. |
        /// | 305 | Security code (CVV) error. |
        /// | 306 | Card declined (authorization screening error). |
        /// | 307 | Invalid card. |
        /// | 308 | This card has not been approved by the card company. |
        /// | 309 | General error occurred. Detailed information can be confirmed in the dashboard. |
        /// | 310 | Invalid consumer data (invalid request data). |
        /// | 311 | Too many charges on the same card in a short period. Please wait and try again. |
        /// | 312 | This charge cannot be canceled. |
        /// | 313 | Authorization expired (during charge capture). |
        /// | 314 | This card has been reported stolen or invalidated by the issuer. |
        /// | 315 | Please contact the card issuer. |
        /// | 316 | Cardholder's last name is required. |
        /// | 317 | Partial capture is not supported. |
        /// | 318 | Partial refund is not supported. |
        /// | 319 | Suspected fraud (security restriction). |
        /// | 320 | An error occurred in the bank's system. |
        /// | 321 | Dynamic descriptor is not supported. |
        /// | 322 | Barcode/QR code is invalid. |
        /// | 323 | Barcode/QR code has expired. |
        /// | 324 | This barcode/QR code has already been processed. |
        /// | 325 | This barcode/QR code is currently being processed. |
        /// | 326 | Rejected due to a high-risk profile. |
        /// | 327 | Payment deadline (5-minute timeout) has expired. |
        /// | 328 | Recovery failed. Manual intervention is required. |
        /// | 329 | Refund failed. |
        /// | 330 | Insufficient funds. |
        /// | 331 | Metadata field value is invalid or missing. |
        /// | 332 | Cross-border transaction not permitted: missing ID. |
        /// | 333 | Cross-border transaction not permitted: missing phone number. |
        /// | 334 | Cross-border transaction not permitted: unauthorized payment method. |
        /// | 335 | Cross-border transaction not permitted: missing name. |
        /// | 336 | Exceeded the payment limit for this payment method. |
        /// | 337 | Exceeded the payment limit for this merchant. |
        /// | 338 | Payment information not found. |
        /// | 339 | Duplicate payment information. |
        /// | 340 | This consumer's retail QR account was rejected by the gateway. |
        /// | 341 | This merchant lacks the necessary information for this gateway. |
        /// | 342 | Cross-border transaction not permitted: unauthorized currency. |
        /// | 343 | Payment could not be processed due to a server error at the gateway. |
        /// | 344 | The selected payment method is temporarily unavailable from the gateway. |
        /// | 345 | The payment has already been canceled. |
        /// | 346 | Payment processing timed out due to system delay and was canceled. |
        /// | 351 | Invalid transaction. |
        /// | 355 | The card does not support the specified payment division (e.g., installments). |
        /// | 356 | The card is not registered for 3D Secure. |
        /// | 358 | 3D Secure authentication failed (consumer reason, e.g., wrong password). |
        /// | 359 | 3D Secure authentication failed (card company reason). |
        /// | 500 | A pre-processing error occurred during the request execution. |
        /// | 501 | An internal error occurred. Please contact support. |
        /// | 502 | The request timed out waiting for a response. |
        /// | 601 | A system-released error occurred in this service. Check details. |
        /// | 602 | The payment processor rejected the submitted request. Check details. |
        /// | 603 | The submitted customer identity verification was rejected by customs. |
        /// | 604 | The required customer ID information was not submitted by the merchant. |
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public int? Code { get; set; }

        /// <summary>
        /// A brief message detailing why the payment failed.
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// Further specific details regarding the payment failure, if available.
        /// </summary>
        [JsonProperty("detail", NullValueHandling = NullValueHandling.Ignore)]
        public string Detail { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"PaymentError : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Code = {(this.Code == null ? "null" : this.Code.ToString())}");
            toStringOutput.Add($"Message = {this.Message ?? "null"}");
            toStringOutput.Add($"Detail = {this.Detail ?? "null"}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}
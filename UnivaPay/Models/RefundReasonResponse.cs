// <copyright file="RefundReasonResponse.cs" company="APIMatic">
// UnivaPay
//
// This file was automatically generated for Univapay by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace UnivaPay.Models
{
    /// <summary>
    /// RefundReasonResponse.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum RefundReasonResponse
    {
        /// <summary>
        /// Duplicate.
        /// </summary>
        [EnumMember(Value = "duplicate")]
        Duplicate,

        /// <summary>
        /// Fraud.
        /// </summary>
        [EnumMember(Value = "fraud")]
        Fraud,

        /// <summary>
        /// CustomerRequest.
        /// </summary>
        [EnumMember(Value = "customer_request")]
        CustomerRequest,

        /// <summary>
        /// SystemFailure.
        /// </summary>
        [EnumMember(Value = "system_failure")]
        SystemFailure,

        /// <summary>
        /// Chargeback.
        /// </summary>
        [EnumMember(Value = "chargeback")]
        Chargeback,

        /// <summary>
        /// ChargebackFeeExempt.
        /// </summary>
        [EnumMember(Value = "chargeback_fee_exempt")]
        ChargebackFeeExempt,

        /// <summary>
        /// ChargebackReverse.
        /// </summary>
        [EnumMember(Value = "chargeback_reverse")]
        ChargebackReverse
    }
}
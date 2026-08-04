// <copyright file="RefundReasonRequest.cs" company="APIMatic">
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
    /// RefundReasonRequest.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum RefundReasonRequest
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
        CustomerRequest
    }
}
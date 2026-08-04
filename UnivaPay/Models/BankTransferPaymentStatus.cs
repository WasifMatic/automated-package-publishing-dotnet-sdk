// <copyright file="BankTransferPaymentStatus.cs" company="APIMatic">
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
    /// BankTransferPaymentStatus.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum BankTransferPaymentStatus
    {
        /// <summary>
        /// Unpaid.
        /// </summary>
        [EnumMember(Value = "unpaid")]
        Unpaid,

        /// <summary>
        /// Insufficient.
        /// </summary>
        [EnumMember(Value = "insufficient")]
        Insufficient,

        /// <summary>
        /// Exact.
        /// </summary>
        [EnumMember(Value = "exact")]
        Exact,

        /// <summary>
        /// Exceeded.
        /// </summary>
        [EnumMember(Value = "exceeded")]
        Exceeded
    }
}
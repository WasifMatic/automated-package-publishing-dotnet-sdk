// <copyright file="TransactionTokenPaymentType.cs" company="APIMatic">
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
    /// TransactionTokenPaymentType.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum TransactionTokenPaymentType
    {
        /// <summary>
        /// Card.
        /// </summary>
        [EnumMember(Value = "card")]
        Card,

        /// <summary>
        /// Paidy.
        /// </summary>
        [EnumMember(Value = "paidy")]
        Paidy,

        /// <summary>
        /// Online.
        /// </summary>
        [EnumMember(Value = "online")]
        Online,

        /// <summary>
        /// Konbini.
        /// </summary>
        [EnumMember(Value = "konbini")]
        Konbini,

        /// <summary>
        /// BankTransfer.
        /// </summary>
        [EnumMember(Value = "bank_transfer")]
        BankTransfer
    }
}
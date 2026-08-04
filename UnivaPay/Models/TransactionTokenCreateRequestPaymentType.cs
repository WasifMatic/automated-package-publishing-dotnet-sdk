// <copyright file="TransactionTokenCreateRequestPaymentType.cs" company="APIMatic">
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
    /// TransactionTokenCreateRequestPaymentType.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum TransactionTokenCreateRequestPaymentType
    {
        /// <summary>
        /// Card.
        /// </summary>
        [EnumMember(Value = "card")]
        Card,

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
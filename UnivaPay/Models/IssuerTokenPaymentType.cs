// <copyright file="IssuerTokenPaymentType.cs" company="APIMatic">
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
    /// IssuerTokenPaymentType.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum IssuerTokenPaymentType
    {
        /// <summary>
        /// Online.
        /// </summary>
        [EnumMember(Value = "online")]
        Online,

        /// <summary>
        /// BankTransfer.
        /// </summary>
        [EnumMember(Value = "bank_transfer")]
        BankTransfer
    }
}
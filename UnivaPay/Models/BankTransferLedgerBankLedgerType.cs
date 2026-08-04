// <copyright file="BankTransferLedgerBankLedgerType.cs" company="APIMatic">
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
    /// BankTransferLedgerBankLedgerType.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum BankTransferLedgerBankLedgerType
    {
        /// <summary>
        /// Deposit.
        /// </summary>
        [EnumMember(Value = "deposit")]
        Deposit,

        /// <summary>
        /// Payment.
        /// </summary>
        [EnumMember(Value = "payment")]
        Payment
    }
}
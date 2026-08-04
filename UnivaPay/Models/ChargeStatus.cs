// <copyright file="ChargeStatus.cs" company="APIMatic">
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
    /// ChargeStatus.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ChargeStatus
    {
        /// <summary>
        /// Pending.
        /// </summary>
        [EnumMember(Value = "pending")]
        Pending,

        /// <summary>
        /// Awaiting.
        /// </summary>
        [EnumMember(Value = "awaiting")]
        Awaiting,

        /// <summary>
        /// Authorized.
        /// </summary>
        [EnumMember(Value = "authorized")]
        Authorized,

        /// <summary>
        /// Successful.
        /// </summary>
        [EnumMember(Value = "successful")]
        Successful,

        /// <summary>
        /// Failed.
        /// </summary>
        [EnumMember(Value = "failed")]
        Failed,

        /// <summary>
        /// Error.
        /// </summary>
        [EnumMember(Value = "error")]
        Error,

        /// <summary>
        /// Canceled.
        /// </summary>
        [EnumMember(Value = "canceled")]
        Canceled
    }
}
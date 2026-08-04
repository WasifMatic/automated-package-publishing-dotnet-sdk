// <copyright file="TokenResponseCardDataThreeDsStatus.cs" company="APIMatic">
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
    /// TokenResponseCardDataThreeDsStatus.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum TokenResponseCardDataThreeDsStatus
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
        Error
    }
}
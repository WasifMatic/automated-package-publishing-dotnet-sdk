// <copyright file="SubscriptionStatus.cs" company="APIMatic">
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
    /// SubscriptionStatus.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SubscriptionStatus
    {
        /// <summary>
        /// Unverified.
        /// </summary>
        [EnumMember(Value = "unverified")]
        Unverified,

        /// <summary>
        /// Unconfirmed.
        /// </summary>
        [EnumMember(Value = "unconfirmed")]
        Unconfirmed,

        /// <summary>
        /// Canceled.
        /// </summary>
        [EnumMember(Value = "canceled")]
        Canceled,

        /// <summary>
        /// Unpaid.
        /// </summary>
        [EnumMember(Value = "unpaid")]
        Unpaid,

        /// <summary>
        /// Current.
        /// </summary>
        [EnumMember(Value = "current")]
        Current,

        /// <summary>
        /// Suspended.
        /// </summary>
        [EnumMember(Value = "suspended")]
        Suspended,

        /// <summary>
        /// Completed.
        /// </summary>
        [EnumMember(Value = "completed")]
        Completed
    }
}
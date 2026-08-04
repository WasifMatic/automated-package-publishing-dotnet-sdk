// <copyright file="SubscriptionUpdateStatus.cs" company="APIMatic">
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
    /// SubscriptionUpdateStatus.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SubscriptionUpdateStatus
    {
        /// <summary>
        /// Suspended.
        /// </summary>
        [EnumMember(Value = "suspended")]
        Suspended,

        /// <summary>
        /// Unpaid.
        /// </summary>
        [EnumMember(Value = "unpaid")]
        Unpaid
    }
}
// <copyright file="TransactionTokenCreateRequestType.cs" company="APIMatic">
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
    /// TransactionTokenCreateRequestType.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum TransactionTokenCreateRequestType
    {
        /// <summary>
        /// OneTime.
        /// </summary>
        [EnumMember(Value = "one_time")]
        OneTime,

        /// <summary>
        /// Subscription.
        /// </summary>
        [EnumMember(Value = "subscription")]
        Subscription,

        /// <summary>
        /// Recurring.
        /// </summary>
        [EnumMember(Value = "recurring")]
        Recurring
    }
}
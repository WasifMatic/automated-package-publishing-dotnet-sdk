// <copyright file="SubscriptionPeriod.cs" company="APIMatic">
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
    /// SubscriptionPeriod.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SubscriptionPeriod
    {
        /// <summary>
        /// Daily.
        /// </summary>
        [EnumMember(Value = "daily")]
        Daily,

        /// <summary>
        /// Weekly.
        /// </summary>
        [EnumMember(Value = "weekly")]
        Weekly,

        /// <summary>
        /// Biweekly.
        /// </summary>
        [EnumMember(Value = "biweekly")]
        Biweekly,

        /// <summary>
        /// Monthly.
        /// </summary>
        [EnumMember(Value = "monthly")]
        Monthly,

        /// <summary>
        /// Quarterly.
        /// </summary>
        [EnumMember(Value = "quarterly")]
        Quarterly,

        /// <summary>
        /// Semiannually.
        /// </summary>
        [EnumMember(Value = "semiannually")]
        Semiannually,

        /// <summary>
        /// Annually.
        /// </summary>
        [EnumMember(Value = "annually")]
        Annually
    }
}
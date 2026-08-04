// <copyright file="SubscriptionTerminationMode.cs" company="APIMatic">
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
    /// SubscriptionTerminationMode.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SubscriptionTerminationMode
    {
        /// <summary>
        /// Immediate.
        /// </summary>
        [EnumMember(Value = "immediate")]
        Immediate,

        /// <summary>
        /// OnNextPayment.
        /// </summary>
        [EnumMember(Value = "on_next_payment")]
        OnNextPayment
    }
}
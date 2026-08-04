// <copyright file="ChargeEvent.cs" company="APIMatic">
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
    /// ChargeEvent.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ChargeEvent
    {
        /// <summary>
        /// ChargeUpdated.
        /// </summary>
        [EnumMember(Value = "charge_updated")]
        ChargeUpdated,

        /// <summary>
        /// ChargeFinished.
        /// </summary>
        [EnumMember(Value = "charge_finished")]
        ChargeFinished
    }
}
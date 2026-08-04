// <copyright file="CancelEvent.cs" company="APIMatic">
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
    /// CancelEvent.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum CancelEvent
    {
        /// <summary>
        /// CancelFinished.
        /// </summary>
        [EnumMember(Value = "cancel_finished")]
        CancelFinished
    }
}
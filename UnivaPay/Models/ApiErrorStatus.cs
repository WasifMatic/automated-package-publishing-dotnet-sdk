// <copyright file="ApiErrorStatus.cs" company="APIMatic">
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
    /// ApiErrorStatus.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ApiErrorStatus
    {
        /// <summary>
        /// Error.
        /// </summary>
        [EnumMember(Value = "error")]
        Error
    }
}
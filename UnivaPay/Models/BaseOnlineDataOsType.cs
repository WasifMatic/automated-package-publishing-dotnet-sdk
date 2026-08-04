// <copyright file="BaseOnlineDataOsType.cs" company="APIMatic">
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
    /// BaseOnlineDataOsType.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum BaseOnlineDataOsType
    {
        /// <summary>
        /// Android.
        /// </summary>
        [EnumMember(Value = "android")]
        Android,

        /// <summary>
        /// Ios.
        /// </summary>
        [EnumMember(Value = "ios")]
        Ios
    }
}
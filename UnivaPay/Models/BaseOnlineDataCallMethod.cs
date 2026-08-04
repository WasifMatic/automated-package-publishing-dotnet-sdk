// <copyright file="BaseOnlineDataCallMethod.cs" company="APIMatic">
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
    /// BaseOnlineDataCallMethod.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum BaseOnlineDataCallMethod
    {
        /// <summary>
        /// HttpGet.
        /// </summary>
        [EnumMember(Value = "http_get")]
        HttpGet,

        /// <summary>
        /// HttpPost.
        /// </summary>
        [EnumMember(Value = "http_post")]
        HttpPost,

        /// <summary>
        /// HttpGetMobile.
        /// </summary>
        [EnumMember(Value = "http_get_mobile")]
        HttpGetMobile,

        /// <summary>
        /// Sdk.
        /// </summary>
        [EnumMember(Value = "sdk")]
        Sdk,

        /// <summary>
        /// Web.
        /// </summary>
        [EnumMember(Value = "web")]
        Web,

        /// <summary>
        /// App.
        /// </summary>
        [EnumMember(Value = "app")]
        App
    }
}
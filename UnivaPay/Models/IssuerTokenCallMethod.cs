// <copyright file="IssuerTokenCallMethod.cs" company="APIMatic">
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
    /// IssuerTokenCallMethod.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum IssuerTokenCallMethod
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
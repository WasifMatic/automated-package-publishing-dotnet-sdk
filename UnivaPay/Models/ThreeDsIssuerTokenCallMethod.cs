// <copyright file="ThreeDsIssuerTokenCallMethod.cs" company="APIMatic">
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
    /// ThreeDsIssuerTokenCallMethod.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ThreeDsIssuerTokenCallMethod
    {
        /// <summary>
        /// HttpPost.
        /// </summary>
        [EnumMember(Value = "http_post")]
        HttpPost
    }
}
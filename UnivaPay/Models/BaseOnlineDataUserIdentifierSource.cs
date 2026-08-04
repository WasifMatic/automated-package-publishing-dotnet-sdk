// <copyright file="BaseOnlineDataUserIdentifierSource.cs" company="APIMatic">
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
    /// BaseOnlineDataUserIdentifierSource.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum BaseOnlineDataUserIdentifierSource
    {
        /// <summary>
        /// Provided.
        /// </summary>
        [EnumMember(Value = "provided")]
        Provided,

        /// <summary>
        /// Internal.
        /// </summary>
        [EnumMember(Value = "internal")]
        Internal
    }
}
// <copyright file="ModeQuery.cs" company="APIMatic">
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
    /// ModeQuery.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ModeQuery
    {
        /// <summary>
        /// Live.
        /// </summary>
        [EnumMember(Value = "live")]
        Live,

        /// <summary>
        /// Test.
        /// </summary>
        [EnumMember(Value = "test")]
        Test
    }
}
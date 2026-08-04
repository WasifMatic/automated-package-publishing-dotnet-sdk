// <copyright file="InstallmentPlanType.cs" company="APIMatic">
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
    /// InstallmentPlanType.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum InstallmentPlanType
    {
        /// <summary>
        /// Revolving.
        /// </summary>
        [EnumMember(Value = "revolving")]
        Revolving,

        /// <summary>
        /// FixedCycles.
        /// </summary>
        [EnumMember(Value = "fixed_cycles")]
        FixedCycles
    }
}
// <copyright file="CustomsDeclarationWebhookStatus.cs" company="APIMatic">
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
    /// CustomsDeclarationWebhookStatus.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum CustomsDeclarationWebhookStatus
    {
        /// <summary>
        /// Pending.
        /// </summary>
        [EnumMember(Value = "pending")]
        Pending,

        /// <summary>
        /// Successful.
        /// </summary>
        [EnumMember(Value = "successful")]
        Successful,

        /// <summary>
        /// Failed.
        /// </summary>
        [EnumMember(Value = "failed")]
        Failed,

        /// <summary>
        /// Error.
        /// </summary>
        [EnumMember(Value = "error")]
        Error
    }
}
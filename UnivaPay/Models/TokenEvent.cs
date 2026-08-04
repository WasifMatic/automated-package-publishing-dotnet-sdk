// <copyright file="TokenEvent.cs" company="APIMatic">
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
    /// TokenEvent.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum TokenEvent
    {
        /// <summary>
        /// TokenCreated.
        /// </summary>
        [EnumMember(Value = "token_created")]
        TokenCreated,

        /// <summary>
        /// TokenUpdated.
        /// </summary>
        [EnumMember(Value = "token_updated")]
        TokenUpdated,

        /// <summary>
        /// TokenThreeDSUpdated.
        /// </summary>
        [EnumMember(Value = "token_three_d_s_updated")]
        TokenThreeDSUpdated,

        /// <summary>
        /// TokenCvvAuthUpdated.
        /// </summary>
        [EnumMember(Value = "token_cvv_auth_updated")]
        TokenCvvAuthUpdated,

        /// <summary>
        /// TokenCvvAuthCheckUpdated.
        /// </summary>
        [EnumMember(Value = "token_cvv_auth_check_updated")]
        TokenCvvAuthCheckUpdated,

        /// <summary>
        /// TokenReplaced.
        /// </summary>
        [EnumMember(Value = "token_replaced")]
        TokenReplaced,

        /// <summary>
        /// RecurringTokenDeleted.
        /// </summary>
        [EnumMember(Value = "recurring_token_deleted")]
        RecurringTokenDeleted
    }
}
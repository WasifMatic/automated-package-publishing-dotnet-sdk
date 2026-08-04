// <copyright file="SubscriptionEvent.cs" company="APIMatic">
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
    /// SubscriptionEvent.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SubscriptionEvent
    {
        /// <summary>
        /// SubscriptionCreated.
        /// </summary>
        [EnumMember(Value = "subscription_created")]
        SubscriptionCreated,

        /// <summary>
        /// SubscriptionPayment.
        /// </summary>
        [EnumMember(Value = "subscription_payment")]
        SubscriptionPayment,

        /// <summary>
        /// SubscriptionCompleted.
        /// </summary>
        [EnumMember(Value = "subscription_completed")]
        SubscriptionCompleted,

        /// <summary>
        /// SubscriptionFailure.
        /// </summary>
        [EnumMember(Value = "subscription_failure")]
        SubscriptionFailure,

        /// <summary>
        /// SubscriptionCanceled.
        /// </summary>
        [EnumMember(Value = "subscription_canceled")]
        SubscriptionCanceled,

        /// <summary>
        /// SubscriptionSuspended.
        /// </summary>
        [EnumMember(Value = "subscription_suspended")]
        SubscriptionSuspended
    }
}
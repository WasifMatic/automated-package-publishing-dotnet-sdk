// <copyright file="WebhookTrigger.cs" company="APIMatic">
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
    /// WebhookTrigger.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum WebhookTrigger
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
        /// ChargeUpdated.
        /// </summary>
        [EnumMember(Value = "charge_updated")]
        ChargeUpdated,

        /// <summary>
        /// ChargeFinished.
        /// </summary>
        [EnumMember(Value = "charge_finished")]
        ChargeFinished,

        /// <summary>
        /// RefundFinished.
        /// </summary>
        [EnumMember(Value = "refund_finished")]
        RefundFinished,

        /// <summary>
        /// CancelFinished.
        /// </summary>
        [EnumMember(Value = "cancel_finished")]
        CancelFinished,

        /// <summary>
        /// CustomsDeclarationFinished.
        /// </summary>
        [EnumMember(Value = "customs_declaration_finished")]
        CustomsDeclarationFinished,

        /// <summary>
        /// RecurringTokenDeleted.
        /// </summary>
        [EnumMember(Value = "recurring_token_deleted")]
        RecurringTokenDeleted,

        /// <summary>
        /// BankTransferStatusUpdated.
        /// </summary>
        [EnumMember(Value = "bank_transfer_status_updated")]
        BankTransferStatusUpdated,

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
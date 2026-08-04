// <copyright file="SubscriptionParsingResult.cs" company="APIMatic">
// UnivaPay
//
// This file was automatically generated for Univapay by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System;
using UnivaPay.Models;

namespace UnivaPay.Events.Webhooks
{
    /// <summary>
    /// This is an event class for SubscriptionParsingResult.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<SubscriptionParsingResult>),
        new[] {
            typeof(SubscriptionCreatedCase),
            typeof(SubscriptionPaymentCase),
            typeof(SubscriptionCompletedCase),
            typeof(SubscriptionFailureCase),
            typeof(SubscriptionCanceledCase),
            typeof(SubscriptionSuspendedCase)
        },
        new[] {
            "subscription_created",
            "subscription_payment",
            "subscription_completed",
            "subscription_failure",
            "subscription_canceled",
            "subscription_suspended"
        },
        "event",
        true
    )]
    public abstract class SubscriptionParsingResult
    {

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(
            Func<SubscriptionWebhookEvent, T> subscriptionCreated,
            Func<SubscriptionWebhookEvent, T> subscriptionPayment,
            Func<SubscriptionWebhookEvent, T> subscriptionCompleted,
            Func<SubscriptionWebhookEvent, T> subscriptionFailure,
            Func<SubscriptionWebhookEvent, T> subscriptionCanceled,
            Func<SubscriptionWebhookEvent, T> subscriptionSuspended,
            Func<T> unknown);

        /// <summary>
        /// Method to match from the provided one-of cases. The parameters represent
        /// optional callback functions for one-of type cases. You may provide only
        /// the callbacks you are interested in; others can be left as <c>null</c>. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function, or the default value if no callback is provided for the matched case.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public T MatchSome<T>(
            Func<SubscriptionWebhookEvent, T> subscriptionCreated = null,
            Func<SubscriptionWebhookEvent, T> subscriptionPayment = null,
            Func<SubscriptionWebhookEvent, T> subscriptionCompleted = null,
            Func<SubscriptionWebhookEvent, T> subscriptionFailure = null,
            Func<SubscriptionWebhookEvent, T> subscriptionCanceled = null,
            Func<SubscriptionWebhookEvent, T> subscriptionSuspended = null,
            Func<T> unknown = null) =>
                Match(subscriptionCreated, subscriptionPayment, subscriptionCompleted, subscriptionFailure, subscriptionCanceled, subscriptionSuspended, unknown);

        [JsonConverter(typeof(UnionTypeCaseConverter<SubscriptionCreatedCase, SubscriptionWebhookEvent>))]
        private sealed class SubscriptionCreatedCase : SubscriptionParsingResult, ICaseValue<SubscriptionCreatedCase, SubscriptionWebhookEvent>
        {
            public SubscriptionWebhookEvent Value;

            public override T Match<T>(
                Func<SubscriptionWebhookEvent, T> subscriptionCreated,
                Func<SubscriptionWebhookEvent, T> subscriptionPayment,
                Func<SubscriptionWebhookEvent, T> subscriptionCompleted,
                Func<SubscriptionWebhookEvent, T> subscriptionFailure,
                Func<SubscriptionWebhookEvent, T> subscriptionCanceled,
                Func<SubscriptionWebhookEvent, T> subscriptionSuspended,
                Func<T> unknown) =>
                   subscriptionCreated != null ? subscriptionCreated(Value) : default;

            public SubscriptionCreatedCase Set(SubscriptionWebhookEvent value)
            {
                Value = value;
                return this;
            }

            public SubscriptionWebhookEvent Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<SubscriptionPaymentCase, SubscriptionWebhookEvent>))]
        private sealed class SubscriptionPaymentCase : SubscriptionParsingResult, ICaseValue<SubscriptionPaymentCase, SubscriptionWebhookEvent>
        {
            public SubscriptionWebhookEvent Value;

            public override T Match<T>(
                Func<SubscriptionWebhookEvent, T> subscriptionCreated,
                Func<SubscriptionWebhookEvent, T> subscriptionPayment,
                Func<SubscriptionWebhookEvent, T> subscriptionCompleted,
                Func<SubscriptionWebhookEvent, T> subscriptionFailure,
                Func<SubscriptionWebhookEvent, T> subscriptionCanceled,
                Func<SubscriptionWebhookEvent, T> subscriptionSuspended,
                Func<T> unknown) =>
                   subscriptionPayment != null ? subscriptionPayment(Value) : default;

            public SubscriptionPaymentCase Set(SubscriptionWebhookEvent value)
            {
                Value = value;
                return this;
            }

            public SubscriptionWebhookEvent Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<SubscriptionCompletedCase, SubscriptionWebhookEvent>))]
        private sealed class SubscriptionCompletedCase : SubscriptionParsingResult, ICaseValue<SubscriptionCompletedCase, SubscriptionWebhookEvent>
        {
            public SubscriptionWebhookEvent Value;

            public override T Match<T>(
                Func<SubscriptionWebhookEvent, T> subscriptionCreated,
                Func<SubscriptionWebhookEvent, T> subscriptionPayment,
                Func<SubscriptionWebhookEvent, T> subscriptionCompleted,
                Func<SubscriptionWebhookEvent, T> subscriptionFailure,
                Func<SubscriptionWebhookEvent, T> subscriptionCanceled,
                Func<SubscriptionWebhookEvent, T> subscriptionSuspended,
                Func<T> unknown) =>
                   subscriptionCompleted != null ? subscriptionCompleted(Value) : default;

            public SubscriptionCompletedCase Set(SubscriptionWebhookEvent value)
            {
                Value = value;
                return this;
            }

            public SubscriptionWebhookEvent Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<SubscriptionFailureCase, SubscriptionWebhookEvent>))]
        private sealed class SubscriptionFailureCase : SubscriptionParsingResult, ICaseValue<SubscriptionFailureCase, SubscriptionWebhookEvent>
        {
            public SubscriptionWebhookEvent Value;

            public override T Match<T>(
                Func<SubscriptionWebhookEvent, T> subscriptionCreated,
                Func<SubscriptionWebhookEvent, T> subscriptionPayment,
                Func<SubscriptionWebhookEvent, T> subscriptionCompleted,
                Func<SubscriptionWebhookEvent, T> subscriptionFailure,
                Func<SubscriptionWebhookEvent, T> subscriptionCanceled,
                Func<SubscriptionWebhookEvent, T> subscriptionSuspended,
                Func<T> unknown) =>
                   subscriptionFailure != null ? subscriptionFailure(Value) : default;

            public SubscriptionFailureCase Set(SubscriptionWebhookEvent value)
            {
                Value = value;
                return this;
            }

            public SubscriptionWebhookEvent Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<SubscriptionCanceledCase, SubscriptionWebhookEvent>))]
        private sealed class SubscriptionCanceledCase : SubscriptionParsingResult, ICaseValue<SubscriptionCanceledCase, SubscriptionWebhookEvent>
        {
            public SubscriptionWebhookEvent Value;

            public override T Match<T>(
                Func<SubscriptionWebhookEvent, T> subscriptionCreated,
                Func<SubscriptionWebhookEvent, T> subscriptionPayment,
                Func<SubscriptionWebhookEvent, T> subscriptionCompleted,
                Func<SubscriptionWebhookEvent, T> subscriptionFailure,
                Func<SubscriptionWebhookEvent, T> subscriptionCanceled,
                Func<SubscriptionWebhookEvent, T> subscriptionSuspended,
                Func<T> unknown) =>
                   subscriptionCanceled != null ? subscriptionCanceled(Value) : default;

            public SubscriptionCanceledCase Set(SubscriptionWebhookEvent value)
            {
                Value = value;
                return this;
            }

            public SubscriptionWebhookEvent Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<SubscriptionSuspendedCase, SubscriptionWebhookEvent>))]
        private sealed class SubscriptionSuspendedCase : SubscriptionParsingResult, ICaseValue<SubscriptionSuspendedCase, SubscriptionWebhookEvent>
        {
            public SubscriptionWebhookEvent Value;

            public override T Match<T>(
                Func<SubscriptionWebhookEvent, T> subscriptionCreated,
                Func<SubscriptionWebhookEvent, T> subscriptionPayment,
                Func<SubscriptionWebhookEvent, T> subscriptionCompleted,
                Func<SubscriptionWebhookEvent, T> subscriptionFailure,
                Func<SubscriptionWebhookEvent, T> subscriptionCanceled,
                Func<SubscriptionWebhookEvent, T> subscriptionSuspended,
                Func<T> unknown) =>
                   subscriptionSuspended != null ? subscriptionSuspended(Value) : default;

            public SubscriptionSuspendedCase Set(SubscriptionWebhookEvent value)
            {
                Value = value;
                return this;
            }

            public SubscriptionWebhookEvent Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }
        }

        /// <summary>
        /// Represents an unknown or unrecognized webhook event parsing result.
        /// Used when the event type does not match any known cases.
        /// </summary>
        internal sealed class Unknown : SubscriptionParsingResult
        {
            public override T Match<T>(
                Func<SubscriptionWebhookEvent, T> subscriptionCreated,
                Func<SubscriptionWebhookEvent, T> subscriptionPayment,
                Func<SubscriptionWebhookEvent, T> subscriptionCompleted,
                Func<SubscriptionWebhookEvent, T> subscriptionFailure,
                Func<SubscriptionWebhookEvent, T> subscriptionCanceled,
                Func<SubscriptionWebhookEvent, T> subscriptionSuspended,
                Func<T> unknown) =>
                   unknown != null ? unknown() : default;
        }
    }
}
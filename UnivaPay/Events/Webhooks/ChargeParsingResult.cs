// <copyright file="ChargeParsingResult.cs" company="APIMatic">
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
    /// This is an event class for ChargeParsingResult.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<ChargeParsingResult>),
        new[] {
            typeof(ChargeUpdatedCase),
            typeof(ChargeFinishedCase)
        },
        new[] {
            "charge_updated",
            "charge_finished"
        },
        "event",
        true
    )]
    public abstract class ChargeParsingResult
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
            Func<ChargeWebhookEvent, T> chargeUpdated,
            Func<ChargeWebhookEvent, T> chargeFinished,
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
            Func<ChargeWebhookEvent, T> chargeUpdated = null,
            Func<ChargeWebhookEvent, T> chargeFinished = null,
            Func<T> unknown = null) =>
                Match(chargeUpdated, chargeFinished, unknown);

        [JsonConverter(typeof(UnionTypeCaseConverter<ChargeUpdatedCase, ChargeWebhookEvent>))]
        private sealed class ChargeUpdatedCase : ChargeParsingResult, ICaseValue<ChargeUpdatedCase, ChargeWebhookEvent>
        {
            public ChargeWebhookEvent Value;

            public override T Match<T>(
                Func<ChargeWebhookEvent, T> chargeUpdated,
                Func<ChargeWebhookEvent, T> chargeFinished,
                Func<T> unknown) =>
                   chargeUpdated != null ? chargeUpdated(Value) : default;

            public ChargeUpdatedCase Set(ChargeWebhookEvent value)
            {
                Value = value;
                return this;
            }

            public ChargeWebhookEvent Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<ChargeFinishedCase, ChargeWebhookEvent>))]
        private sealed class ChargeFinishedCase : ChargeParsingResult, ICaseValue<ChargeFinishedCase, ChargeWebhookEvent>
        {
            public ChargeWebhookEvent Value;

            public override T Match<T>(
                Func<ChargeWebhookEvent, T> chargeUpdated,
                Func<ChargeWebhookEvent, T> chargeFinished,
                Func<T> unknown) =>
                   chargeFinished != null ? chargeFinished(Value) : default;

            public ChargeFinishedCase Set(ChargeWebhookEvent value)
            {
                Value = value;
                return this;
            }

            public ChargeWebhookEvent Get()
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
        internal sealed class Unknown : ChargeParsingResult
        {
            public override T Match<T>(
                Func<ChargeWebhookEvent, T> chargeUpdated,
                Func<ChargeWebhookEvent, T> chargeFinished,
                Func<T> unknown) =>
                   unknown != null ? unknown() : default;
        }
    }
}
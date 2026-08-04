// <copyright file="RefundParsingResult.cs" company="APIMatic">
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
    /// This is an event class for RefundParsingResult.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<RefundParsingResult>),
        new[] {
            typeof(RefundFinishedCase)
        },
        new[] {
            "refund_finished"
        },
        "event",
        true
    )]
    public abstract class RefundParsingResult
    {

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<RefundWebhookCallback, T> refundFinished, Func<T> unknown);

        /// <summary>
        /// Method to match from the provided one-of cases. The parameters represent
        /// optional callback functions for one-of type cases. You may provide only
        /// the callbacks you are interested in; others can be left as <c>null</c>. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function, or the default value if no callback is provided for the matched case.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public T MatchSome<T>(Func<RefundWebhookCallback, T> refundFinished = null, Func<T> unknown = null) =>
                Match(refundFinished, unknown);

        [JsonConverter(typeof(UnionTypeCaseConverter<RefundFinishedCase, RefundWebhookCallback>))]
        private sealed class RefundFinishedCase : RefundParsingResult, ICaseValue<RefundFinishedCase, RefundWebhookCallback>
        {
            public RefundWebhookCallback Value;

            public override T Match<T>(Func<RefundWebhookCallback, T> refundFinished, Func<T> unknown) =>
                   refundFinished != null ? refundFinished(Value) : default;

            public RefundFinishedCase Set(RefundWebhookCallback value)
            {
                Value = value;
                return this;
            }

            public RefundWebhookCallback Get()
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
        internal sealed class Unknown : RefundParsingResult
        {
            public override T Match<T>(Func<RefundWebhookCallback, T> refundFinished, Func<T> unknown) =>
                   unknown != null ? unknown() : default;
        }
    }
}
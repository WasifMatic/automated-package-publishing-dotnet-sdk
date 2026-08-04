// <copyright file="TokenParsingResult.cs" company="APIMatic">
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
    /// This is an event class for TokenParsingResult.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<TokenParsingResult>),
        new[] {
            typeof(TokenCreatedCase),
            typeof(TokenUpdatedCase),
            typeof(TokenThreeDsUpdatedCase),
            typeof(TokenCvvAuthUpdatedCase),
            typeof(TokenCvvAuthCheckUpdatedCase),
            typeof(TokenReplacedCase),
            typeof(RecurringTokenDeletedCase)
        },
        new[] {
            "token_created",
            "token_updated",
            "token_three_d_s_updated",
            "token_cvv_auth_updated",
            "token_cvv_auth_check_updated",
            "token_replaced",
            "recurring_token_deleted"
        },
        "event",
        true
    )]
    public abstract class TokenParsingResult
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
            Func<TokenWebhookEvent, T> tokenCreated,
            Func<TokenWebhookEvent, T> tokenUpdated,
            Func<TokenWebhookEvent, T> tokenThreeDsUpdated,
            Func<TokenWebhookEvent, T> tokenCvvAuthUpdated,
            Func<TokenWebhookEvent, T> tokenCvvAuthCheckUpdated,
            Func<TokenWebhookEvent, T> tokenReplaced,
            Func<TokenWebhookEvent, T> recurringTokenDeleted,
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
            Func<TokenWebhookEvent, T> tokenCreated = null,
            Func<TokenWebhookEvent, T> tokenUpdated = null,
            Func<TokenWebhookEvent, T> tokenThreeDsUpdated = null,
            Func<TokenWebhookEvent, T> tokenCvvAuthUpdated = null,
            Func<TokenWebhookEvent, T> tokenCvvAuthCheckUpdated = null,
            Func<TokenWebhookEvent, T> tokenReplaced = null,
            Func<TokenWebhookEvent, T> recurringTokenDeleted = null,
            Func<T> unknown = null) =>
                Match(tokenCreated, tokenUpdated, tokenThreeDsUpdated, tokenCvvAuthUpdated, tokenCvvAuthCheckUpdated, tokenReplaced, recurringTokenDeleted, unknown);

        [JsonConverter(typeof(UnionTypeCaseConverter<TokenCreatedCase, TokenWebhookEvent>))]
        private sealed class TokenCreatedCase : TokenParsingResult, ICaseValue<TokenCreatedCase, TokenWebhookEvent>
        {
            public TokenWebhookEvent Value;

            public override T Match<T>(
                Func<TokenWebhookEvent, T> tokenCreated,
                Func<TokenWebhookEvent, T> tokenUpdated,
                Func<TokenWebhookEvent, T> tokenThreeDsUpdated,
                Func<TokenWebhookEvent, T> tokenCvvAuthUpdated,
                Func<TokenWebhookEvent, T> tokenCvvAuthCheckUpdated,
                Func<TokenWebhookEvent, T> tokenReplaced,
                Func<TokenWebhookEvent, T> recurringTokenDeleted,
                Func<T> unknown) =>
                   tokenCreated != null ? tokenCreated(Value) : default;

            public TokenCreatedCase Set(TokenWebhookEvent value)
            {
                Value = value;
                return this;
            }

            public TokenWebhookEvent Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<TokenUpdatedCase, TokenWebhookEvent>))]
        private sealed class TokenUpdatedCase : TokenParsingResult, ICaseValue<TokenUpdatedCase, TokenWebhookEvent>
        {
            public TokenWebhookEvent Value;

            public override T Match<T>(
                Func<TokenWebhookEvent, T> tokenCreated,
                Func<TokenWebhookEvent, T> tokenUpdated,
                Func<TokenWebhookEvent, T> tokenThreeDsUpdated,
                Func<TokenWebhookEvent, T> tokenCvvAuthUpdated,
                Func<TokenWebhookEvent, T> tokenCvvAuthCheckUpdated,
                Func<TokenWebhookEvent, T> tokenReplaced,
                Func<TokenWebhookEvent, T> recurringTokenDeleted,
                Func<T> unknown) =>
                   tokenUpdated != null ? tokenUpdated(Value) : default;

            public TokenUpdatedCase Set(TokenWebhookEvent value)
            {
                Value = value;
                return this;
            }

            public TokenWebhookEvent Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<TokenThreeDsUpdatedCase, TokenWebhookEvent>))]
        private sealed class TokenThreeDsUpdatedCase : TokenParsingResult, ICaseValue<TokenThreeDsUpdatedCase, TokenWebhookEvent>
        {
            public TokenWebhookEvent Value;

            public override T Match<T>(
                Func<TokenWebhookEvent, T> tokenCreated,
                Func<TokenWebhookEvent, T> tokenUpdated,
                Func<TokenWebhookEvent, T> tokenThreeDsUpdated,
                Func<TokenWebhookEvent, T> tokenCvvAuthUpdated,
                Func<TokenWebhookEvent, T> tokenCvvAuthCheckUpdated,
                Func<TokenWebhookEvent, T> tokenReplaced,
                Func<TokenWebhookEvent, T> recurringTokenDeleted,
                Func<T> unknown) =>
                   tokenThreeDsUpdated != null ? tokenThreeDsUpdated(Value) : default;

            public TokenThreeDsUpdatedCase Set(TokenWebhookEvent value)
            {
                Value = value;
                return this;
            }

            public TokenWebhookEvent Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<TokenCvvAuthUpdatedCase, TokenWebhookEvent>))]
        private sealed class TokenCvvAuthUpdatedCase : TokenParsingResult, ICaseValue<TokenCvvAuthUpdatedCase, TokenWebhookEvent>
        {
            public TokenWebhookEvent Value;

            public override T Match<T>(
                Func<TokenWebhookEvent, T> tokenCreated,
                Func<TokenWebhookEvent, T> tokenUpdated,
                Func<TokenWebhookEvent, T> tokenThreeDsUpdated,
                Func<TokenWebhookEvent, T> tokenCvvAuthUpdated,
                Func<TokenWebhookEvent, T> tokenCvvAuthCheckUpdated,
                Func<TokenWebhookEvent, T> tokenReplaced,
                Func<TokenWebhookEvent, T> recurringTokenDeleted,
                Func<T> unknown) =>
                   tokenCvvAuthUpdated != null ? tokenCvvAuthUpdated(Value) : default;

            public TokenCvvAuthUpdatedCase Set(TokenWebhookEvent value)
            {
                Value = value;
                return this;
            }

            public TokenWebhookEvent Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<TokenCvvAuthCheckUpdatedCase, TokenWebhookEvent>))]
        private sealed class TokenCvvAuthCheckUpdatedCase : TokenParsingResult, ICaseValue<TokenCvvAuthCheckUpdatedCase, TokenWebhookEvent>
        {
            public TokenWebhookEvent Value;

            public override T Match<T>(
                Func<TokenWebhookEvent, T> tokenCreated,
                Func<TokenWebhookEvent, T> tokenUpdated,
                Func<TokenWebhookEvent, T> tokenThreeDsUpdated,
                Func<TokenWebhookEvent, T> tokenCvvAuthUpdated,
                Func<TokenWebhookEvent, T> tokenCvvAuthCheckUpdated,
                Func<TokenWebhookEvent, T> tokenReplaced,
                Func<TokenWebhookEvent, T> recurringTokenDeleted,
                Func<T> unknown) =>
                   tokenCvvAuthCheckUpdated != null ? tokenCvvAuthCheckUpdated(Value) : default;

            public TokenCvvAuthCheckUpdatedCase Set(TokenWebhookEvent value)
            {
                Value = value;
                return this;
            }

            public TokenWebhookEvent Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<TokenReplacedCase, TokenWebhookEvent>))]
        private sealed class TokenReplacedCase : TokenParsingResult, ICaseValue<TokenReplacedCase, TokenWebhookEvent>
        {
            public TokenWebhookEvent Value;

            public override T Match<T>(
                Func<TokenWebhookEvent, T> tokenCreated,
                Func<TokenWebhookEvent, T> tokenUpdated,
                Func<TokenWebhookEvent, T> tokenThreeDsUpdated,
                Func<TokenWebhookEvent, T> tokenCvvAuthUpdated,
                Func<TokenWebhookEvent, T> tokenCvvAuthCheckUpdated,
                Func<TokenWebhookEvent, T> tokenReplaced,
                Func<TokenWebhookEvent, T> recurringTokenDeleted,
                Func<T> unknown) =>
                   tokenReplaced != null ? tokenReplaced(Value) : default;

            public TokenReplacedCase Set(TokenWebhookEvent value)
            {
                Value = value;
                return this;
            }

            public TokenWebhookEvent Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<RecurringTokenDeletedCase, TokenWebhookEvent>))]
        private sealed class RecurringTokenDeletedCase : TokenParsingResult, ICaseValue<RecurringTokenDeletedCase, TokenWebhookEvent>
        {
            public TokenWebhookEvent Value;

            public override T Match<T>(
                Func<TokenWebhookEvent, T> tokenCreated,
                Func<TokenWebhookEvent, T> tokenUpdated,
                Func<TokenWebhookEvent, T> tokenThreeDsUpdated,
                Func<TokenWebhookEvent, T> tokenCvvAuthUpdated,
                Func<TokenWebhookEvent, T> tokenCvvAuthCheckUpdated,
                Func<TokenWebhookEvent, T> tokenReplaced,
                Func<TokenWebhookEvent, T> recurringTokenDeleted,
                Func<T> unknown) =>
                   recurringTokenDeleted != null ? recurringTokenDeleted(Value) : default;

            public RecurringTokenDeletedCase Set(TokenWebhookEvent value)
            {
                Value = value;
                return this;
            }

            public TokenWebhookEvent Get()
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
        internal sealed class Unknown : TokenParsingResult
        {
            public override T Match<T>(
                Func<TokenWebhookEvent, T> tokenCreated,
                Func<TokenWebhookEvent, T> tokenUpdated,
                Func<TokenWebhookEvent, T> tokenThreeDsUpdated,
                Func<TokenWebhookEvent, T> tokenCvvAuthUpdated,
                Func<TokenWebhookEvent, T> tokenCvvAuthCheckUpdated,
                Func<TokenWebhookEvent, T> tokenReplaced,
                Func<TokenWebhookEvent, T> recurringTokenDeleted,
                Func<T> unknown) =>
                   unknown != null ? unknown() : default;
        }
    }
}
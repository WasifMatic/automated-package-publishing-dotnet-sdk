// <copyright file="TransactionTokenData.cs" company="APIMatic">
// UnivaPay
//
// This file was automatically generated for Univapay by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System;

namespace UnivaPay.Models.Containers
{
    /// <summary>
    /// This is a container class for any-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<TransactionTokenData>),
        new[] {
            typeof(TokenResponseCardDataCase),
            typeof(TokenResponseKonbiniDataCase),
            typeof(TokenResponseOnlineDataCase),
            typeof(TokenResponseBankTransferDataCase)
        },
        false
    )]
    public abstract class TransactionTokenData
    {
        /// <summary>
        /// This is TokenResponseCardData case.
        /// </summary>
        /// <returns>
        /// The TransactionTokenData instance, wrapping the provided TokenResponseCardData value.
        /// </returns>
        public static TransactionTokenData FromTokenResponseCardData(TokenResponseCardData tokenResponseCardData)
        {
            return new TokenResponseCardDataCase().Set(tokenResponseCardData);
        }

        /// <summary>
        /// This is TokenResponseKonbiniData case.
        /// </summary>
        /// <returns>
        /// The TransactionTokenData instance, wrapping the provided TokenResponseKonbiniData value.
        /// </returns>
        public static TransactionTokenData FromTokenResponseKonbiniData(TokenResponseKonbiniData tokenResponseKonbiniData)
        {
            return new TokenResponseKonbiniDataCase().Set(tokenResponseKonbiniData);
        }

        /// <summary>
        /// This is TokenResponseOnlineData case.
        /// </summary>
        /// <returns>
        /// The TransactionTokenData instance, wrapping the provided TokenResponseOnlineData value.
        /// </returns>
        public static TransactionTokenData FromTokenResponseOnlineData(TokenResponseOnlineData tokenResponseOnlineData)
        {
            return new TokenResponseOnlineDataCase().Set(tokenResponseOnlineData);
        }

        /// <summary>
        /// This is TokenResponseBankTransferData case.
        /// </summary>
        /// <returns>
        /// The TransactionTokenData instance, wrapping the provided TokenResponseBankTransferData value.
        /// </returns>
        public static TransactionTokenData FromTokenResponseBankTransferData(TokenResponseBankTransferData tokenResponseBankTransferData)
        {
            return new TokenResponseBankTransferDataCase().Set(tokenResponseBankTransferData);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(
            Func<TokenResponseCardData, T> tokenResponseCardData,
            Func<TokenResponseKonbiniData, T> tokenResponseKonbiniData,
            Func<TokenResponseOnlineData, T> tokenResponseOnlineData,
            Func<TokenResponseBankTransferData, T> tokenResponseBankTransferData);

        /// <summary>
        /// Method to match from the provided any-of cases. The parameters represent
        /// optional callback functions for any-of type cases. You may provide only
        /// the callbacks you are interested in; others can be left as <c>null</c>. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function, or the default value if no callback is provided for the matched case.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public T MatchSome<T>(
            Func<TokenResponseCardData, T> tokenResponseCardData = null,
            Func<TokenResponseKonbiniData, T> tokenResponseKonbiniData = null,
            Func<TokenResponseOnlineData, T> tokenResponseOnlineData = null,
            Func<TokenResponseBankTransferData, T> tokenResponseBankTransferData = null) =>
                Match(tokenResponseCardData, tokenResponseKonbiniData, tokenResponseOnlineData, tokenResponseBankTransferData);

        [JsonConverter(typeof(UnionTypeCaseConverter<TokenResponseCardDataCase, TokenResponseCardData>))]
        private sealed class TokenResponseCardDataCase : TransactionTokenData, ICaseValue<TokenResponseCardDataCase, TokenResponseCardData>
        {
            public TokenResponseCardData Value;

            public override T Match<T>(
                Func<TokenResponseCardData, T> tokenResponseCardData,
                Func<TokenResponseKonbiniData, T> tokenResponseKonbiniData,
                Func<TokenResponseOnlineData, T> tokenResponseOnlineData,
                Func<TokenResponseBankTransferData, T> tokenResponseBankTransferData) =>
                   tokenResponseCardData != null ? tokenResponseCardData(Value) : default;

            public TokenResponseCardDataCase Set(TokenResponseCardData value)
            {
                Value = value;
                return this;
            }

            public TokenResponseCardData Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<TokenResponseKonbiniDataCase, TokenResponseKonbiniData>))]
        private sealed class TokenResponseKonbiniDataCase : TransactionTokenData, ICaseValue<TokenResponseKonbiniDataCase, TokenResponseKonbiniData>
        {
            public TokenResponseKonbiniData Value;

            public override T Match<T>(
                Func<TokenResponseCardData, T> tokenResponseCardData,
                Func<TokenResponseKonbiniData, T> tokenResponseKonbiniData,
                Func<TokenResponseOnlineData, T> tokenResponseOnlineData,
                Func<TokenResponseBankTransferData, T> tokenResponseBankTransferData) =>
                   tokenResponseKonbiniData != null ? tokenResponseKonbiniData(Value) : default;

            public TokenResponseKonbiniDataCase Set(TokenResponseKonbiniData value)
            {
                Value = value;
                return this;
            }

            public TokenResponseKonbiniData Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<TokenResponseOnlineDataCase, TokenResponseOnlineData>))]
        private sealed class TokenResponseOnlineDataCase : TransactionTokenData, ICaseValue<TokenResponseOnlineDataCase, TokenResponseOnlineData>
        {
            public TokenResponseOnlineData Value;

            public override T Match<T>(
                Func<TokenResponseCardData, T> tokenResponseCardData,
                Func<TokenResponseKonbiniData, T> tokenResponseKonbiniData,
                Func<TokenResponseOnlineData, T> tokenResponseOnlineData,
                Func<TokenResponseBankTransferData, T> tokenResponseBankTransferData) =>
                   tokenResponseOnlineData != null ? tokenResponseOnlineData(Value) : default;

            public TokenResponseOnlineDataCase Set(TokenResponseOnlineData value)
            {
                Value = value;
                return this;
            }

            public TokenResponseOnlineData Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<TokenResponseBankTransferDataCase, TokenResponseBankTransferData>))]
        private sealed class TokenResponseBankTransferDataCase : TransactionTokenData, ICaseValue<TokenResponseBankTransferDataCase, TokenResponseBankTransferData>
        {
            public TokenResponseBankTransferData Value;

            public override T Match<T>(
                Func<TokenResponseCardData, T> tokenResponseCardData,
                Func<TokenResponseKonbiniData, T> tokenResponseKonbiniData,
                Func<TokenResponseOnlineData, T> tokenResponseOnlineData,
                Func<TokenResponseBankTransferData, T> tokenResponseBankTransferData) =>
                   tokenResponseBankTransferData != null ? tokenResponseBankTransferData(Value) : default;

            public TokenResponseBankTransferDataCase Set(TokenResponseBankTransferData value)
            {
                Value = value;
                return this;
            }

            public TokenResponseBankTransferData Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }
        }
    }
}
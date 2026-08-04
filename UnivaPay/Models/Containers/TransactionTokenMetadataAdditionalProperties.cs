// <copyright file="TransactionTokenMetadataAdditionalProperties.cs" company="APIMatic">
// UnivaPay
//
// This file was automatically generated for Univapay by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace UnivaPay.Models.Containers
{
    /// <summary>
    /// This is a container class for any-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<TransactionTokenMetadataAdditionalProperties>),
        new[] {
            typeof(MStringCase),
            typeof(PrecisionCase),
            typeof(BooleanCase)
        },
        false
    )]
    public abstract class TransactionTokenMetadataAdditionalProperties
    {
        /// <summary>
        /// This is String case.
        /// </summary>
        /// <returns>
        /// The TransactionTokenMetadataAdditionalProperties instance, wrapping the provided string value.
        /// </returns>
        public static TransactionTokenMetadataAdditionalProperties FromString(string mString)
        {
            return new MStringCase().Set(mString);
        }

        /// <summary>
        /// This is Precision case.
        /// </summary>
        /// <returns>
        /// The TransactionTokenMetadataAdditionalProperties instance, wrapping the provided double value.
        /// </returns>
        public static TransactionTokenMetadataAdditionalProperties FromPrecision(double precision)
        {
            return new PrecisionCase().Set(precision);
        }

        /// <summary>
        /// This is Boolean case.
        /// </summary>
        /// <returns>
        /// The TransactionTokenMetadataAdditionalProperties instance, wrapping the provided bool value.
        /// </returns>
        public static TransactionTokenMetadataAdditionalProperties FromBoolean(bool boolean)
        {
            return new BooleanCase().Set(boolean);
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
            Func<string, T> mString,
            Func<double, T> precision,
            Func<bool, T> boolean);

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
            Func<string, T> mString = null,
            Func<double, T> precision = null,
            Func<bool, T> boolean = null) =>
                Match(mString, precision, boolean);

        [JsonConverter(typeof(UnionTypeCaseConverter<MStringCase, string>), JTokenType.String, JTokenType.Null)]
        private sealed class MStringCase : TransactionTokenMetadataAdditionalProperties, ICaseValue<MStringCase, string>
        {
            public string Value;

            public override T Match<T>(
                Func<string, T> mString,
                Func<double, T> precision,
                Func<bool, T> boolean) =>
                   mString != null ? mString(Value) : default;

            public MStringCase Set(string value)
            {
                Value = value;
                return this;
            }

            public string Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<PrecisionCase, double>), JTokenType.Float)]
        private sealed class PrecisionCase : TransactionTokenMetadataAdditionalProperties, ICaseValue<PrecisionCase, double>
        {
            public double Value;

            public override T Match<T>(
                Func<string, T> mString,
                Func<double, T> precision,
                Func<bool, T> boolean) =>
                   precision != null ? precision(Value) : default;

            public PrecisionCase Set(double value)
            {
                Value = value;
                return this;
            }

            public double Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<BooleanCase, bool>), JTokenType.Boolean)]
        private sealed class BooleanCase : TransactionTokenMetadataAdditionalProperties, ICaseValue<BooleanCase, bool>
        {
            public bool Value;

            public override T Match<T>(
                Func<string, T> mString,
                Func<double, T> precision,
                Func<bool, T> boolean) =>
                   boolean != null ? boolean(Value) : default;

            public BooleanCase Set(bool value)
            {
                Value = value;
                return this;
            }

            public bool Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value.ToString();
            }
        }
    }
}
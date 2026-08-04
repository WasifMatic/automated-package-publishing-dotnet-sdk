// <copyright file="BaseApi.cs" company="APIMatic">
// UnivaPay
//
// This file was automatically generated for Univapay by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core;
using APIMatic.Core.Http.Configuration;
using APIMatic.Core.Response;
using System;
using UnivaPay.Exceptions;
using UnivaPay.Http.Client;
using UnivaPay.Http.Request;
using UnivaPay.Http.Response;
using UnivaPay.Utilities;

namespace UnivaPay.Apis
{
    /// <summary>
    /// The base class for all controller classes.
    /// </summary>
    public class BaseApi
    {
        private readonly GlobalConfiguration globalConfiguration;

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseApi"/> class.
        /// </summary>
        internal BaseApi(GlobalConfiguration config) => globalConfiguration = config;

        protected static ErrorCase<HttpRequest, HttpResponse, HttpContext, ApiException> CreateErrorCase(string reason, Func<string, HttpContext, ApiException> error, bool isErrorTemplate = false)
            => new ErrorCase<HttpRequest, HttpResponse, HttpContext, ApiException>(reason, error, isErrorTemplate);

        protected ApiCall<HttpRequest, HttpResponse, HttpContext, ApiException, ApiResponse<T>, T> CreateApiCall<T>(ArraySerialization arraySerialization = ArraySerialization.UnIndexed)
            => new ApiCall<HttpRequest, HttpResponse, HttpContext, ApiException, ApiResponse<T>, T>(
                globalConfiguration,
                CompatibilityFactory,
                serialization: arraySerialization,
                returnTypeCreator: (response, result) => new ApiResponse<T>(response.StatusCode, response.Headers, result)
            );

        private static readonly CompatibilityFactory CompatibilityFactory = new CompatibilityFactory();
    }
}
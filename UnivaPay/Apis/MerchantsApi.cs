// <copyright file="MerchantsApi.cs" company="APIMatic">
// UnivaPay
//
// This file was automatically generated for Univapay by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core;
using APIMatic.Core.Utilities;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using UnivaPay.Exceptions;
using UnivaPay.Http.Response;

namespace UnivaPay.Apis
{
    /// <summary>
    /// MerchantsApi.
    /// </summary>
    public class MerchantsApi : BaseApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantsApi"/> class.
        /// </summary>
        internal MerchantsApi(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Returns merchant identity and the effective configuration resolved from bearer credentials. Treat this as the canonical introspection endpoint for merchant integrations.
        /// </summary>
        /// <returns>Returns the ApiResponse of Models.Merchant response from the API call.</returns>
        public ApiResponse<Models.Merchant> GetCurrentMerchant()
            => CoreHelper.RunTask(GetCurrentMerchantAsync());

        /// <summary>
        /// Returns merchant identity and the effective configuration resolved from bearer credentials. Treat this as the canonical introspection endpoint for merchant integrations.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.Merchant response from the API call.</returns>
        public async Task<ApiResponse<Models.Merchant>> GetCurrentMerchantAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Merchant>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/me")
                  .WithAuth("JWT_TOKEN"))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("401", CreateErrorCase("HTTP 401 Unauthorized: {$response.body#/code}", (errorReason, context) => new ApiErrorException(errorReason, context), true))
                  .ErrorCase("403", CreateErrorCase("HTTP 403 Forbidden: {$response.body#/code}", (errorReason, context) => new ApiErrorException(errorReason, context), true))
                  .ErrorCase("429", CreateErrorCase("HTTP 429 Rate Limited: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("400", CreateErrorCase("HTTP 400 Bad Request: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("404", CreateErrorCase("HTTP 404 Not Found: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("409", CreateErrorCase("HTTP 409 Conflict: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("500", CreateErrorCase("HTTP 500 Server Error: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("503", CreateErrorCase("HTTP 503 Unavailable: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("504", CreateErrorCase("HTTP 504 Timeout: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("0", CreateErrorCase("HTTP {$statusCode}: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}
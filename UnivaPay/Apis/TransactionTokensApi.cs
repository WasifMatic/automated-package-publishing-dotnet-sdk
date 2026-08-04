// <copyright file="TransactionTokensApi.cs" company="APIMatic">
// UnivaPay
//
// This file was automatically generated for Univapay by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core;
using APIMatic.Core.Types;
using APIMatic.Core.Utilities;
using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using UnivaPay.Exceptions;
using UnivaPay.Http.Response;

namespace UnivaPay.Apis
{
    /// <summary>
    /// TransactionTokensApi.
    /// </summary>
    public class TransactionTokensApi : BaseApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionTokensApi"/> class.
        /// </summary>
        internal TransactionTokensApi(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Exchange raw payment data for a secure token. **PCI DSS Compliance Required** if sending raw card numbers.
        /// </summary>
        /// <param name="body">Required parameter: Request payload for creating a transaction token..</param>
        /// <param name="idempotencyKey">Optional parameter: An optional idempotency key to prevent double charges and duplicate operations. We recommend a randomly generated UUID (v4)..</param>
        /// <returns>Returns the ApiResponse of Models.TransactionToken response from the API call.</returns>
        public ApiResponse<Models.TransactionToken> CreateTransactionToken(
                Models.TransactionTokenCreateRequest body,
                string idempotencyKey = null)
            => CoreHelper.RunTask(CreateTransactionTokenAsync(body, idempotencyKey));

        /// <summary>
        /// Exchange raw payment data for a secure token. **PCI DSS Compliance Required** if sending raw card numbers.
        /// </summary>
        /// <param name="body">Required parameter: Request payload for creating a transaction token..</param>
        /// <param name="idempotencyKey">Optional parameter: An optional idempotency key to prevent double charges and duplicate operations. We recommend a randomly generated UUID (v4)..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.TransactionToken response from the API call.</returns>
        public async Task<ApiResponse<Models.TransactionToken>> CreateTransactionTokenAsync(
                Models.TransactionTokenCreateRequest body,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.TransactionToken>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/tokens")
                  .WithAuth("JWT_TOKEN")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body).Required())
                      .Header(header => header.Setup("Content-Type", "application/json"))
                      .Header(header => header.Setup("Idempotency-Key", idempotencyKey))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("HTTP 400 Bad Request: {$response.body#/code}", (errorReason, context) => new ApiErrorException(errorReason, context), true))
                  .ErrorCase("401", CreateErrorCase("HTTP 401 Unauthorized: {$response.body#/code}", (errorReason, context) => new ApiErrorException(errorReason, context), true))
                  .ErrorCase("403", CreateErrorCase("HTTP 403 Forbidden: {$response.body#/code}", (errorReason, context) => new ApiErrorException(errorReason, context), true))
                  .ErrorCase("429", CreateErrorCase("HTTP 429 Rate Limited: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("404", CreateErrorCase("HTTP 404 Not Found: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("409", CreateErrorCase("HTTP 409 Conflict: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("500", CreateErrorCase("HTTP 500 Server Error: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("503", CreateErrorCase("HTTP 503 Unavailable: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("504", CreateErrorCase("HTTP 504 Timeout: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("0", CreateErrorCase("HTTP {$statusCode}: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Lists all transaction tokens across all stores.
        /// </summary>
        /// <param name="limit">Optional parameter: Maximum number of resources to return in one page..</param>
        /// <param name="cursor">Optional parameter: Cursor pointing to the resource after which pagination should continue..</param>
        /// <param name="cursorDirection">Optional parameter: Pagination direction relative to the supplied cursor..</param>
        /// <returns>Returns the ApiResponse of Models.TransactionTokenList response from the API call.</returns>
        public ApiResponse<Models.TransactionTokenList> ListAllTransactionTokens(
                int? limit = 10,
                Guid? cursor = null,
                Models.CursorDirectionQuery? cursorDirection = Models.CursorDirectionQuery.Desc)
            => CoreHelper.RunTask(ListAllTransactionTokensAsync(limit, cursor, cursorDirection));

        /// <summary>
        /// Lists all transaction tokens across all stores.
        /// </summary>
        /// <param name="limit">Optional parameter: Maximum number of resources to return in one page..</param>
        /// <param name="cursor">Optional parameter: Cursor pointing to the resource after which pagination should continue..</param>
        /// <param name="cursorDirection">Optional parameter: Pagination direction relative to the supplied cursor..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.TransactionTokenList response from the API call.</returns>
        public async Task<ApiResponse<Models.TransactionTokenList>> ListAllTransactionTokensAsync(
                int? limit = 10,
                Guid? cursor = null,
                Models.CursorDirectionQuery? cursorDirection = Models.CursorDirectionQuery.Desc,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.TransactionTokenList>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/tokens")
                  .WithAuth("JWT_TOKEN")
                  .Parameters(parameters => parameters
                      .Query(query => query.Setup("limit", limit ?? 10))
                      .Query(query => query.Setup("cursor", cursor))
                      .Query(query => query.Setup("cursor_direction", (cursorDirection.HasValue) ? CoreHelper.JsonSerialize(cursorDirection.Value).Trim('\"') : "desc"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("HTTP 400 Bad Request: {$response.body#/code}", (errorReason, context) => new ApiErrorException(errorReason, context), true))
                  .ErrorCase("401", CreateErrorCase("HTTP 401 Unauthorized: {$response.body#/code}", (errorReason, context) => new ApiErrorException(errorReason, context), true))
                  .ErrorCase("403", CreateErrorCase("HTTP 403 Forbidden: {$response.body#/code}", (errorReason, context) => new ApiErrorException(errorReason, context), true))
                  .ErrorCase("429", CreateErrorCase("HTTP 429 Rate Limited: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("404", CreateErrorCase("HTTP 404 Not Found: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("409", CreateErrorCase("HTTP 409 Conflict: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("500", CreateErrorCase("HTTP 500 Server Error: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("503", CreateErrorCase("HTTP 503 Unavailable: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("504", CreateErrorCase("HTTP 504 Timeout: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("0", CreateErrorCase("HTTP {$statusCode}: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Lists all transaction tokens for a specific store.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="limit">Optional parameter: Maximum number of resources to return in one page..</param>
        /// <param name="cursor">Optional parameter: Cursor pointing to the resource after which pagination should continue..</param>
        /// <param name="cursorDirection">Optional parameter: Pagination direction relative to the supplied cursor..</param>
        /// <returns>Returns the ApiResponse of Models.TransactionTokenList response from the API call.</returns>
        public ApiResponse<Models.TransactionTokenList> ListStoreTransactionTokens(
                Guid storeId,
                int? limit = 10,
                Guid? cursor = null,
                Models.CursorDirectionQuery? cursorDirection = Models.CursorDirectionQuery.Desc)
            => CoreHelper.RunTask(ListStoreTransactionTokensAsync(storeId, limit, cursor, cursorDirection));

        /// <summary>
        /// Lists all transaction tokens for a specific store.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="limit">Optional parameter: Maximum number of resources to return in one page..</param>
        /// <param name="cursor">Optional parameter: Cursor pointing to the resource after which pagination should continue..</param>
        /// <param name="cursorDirection">Optional parameter: Pagination direction relative to the supplied cursor..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.TransactionTokenList response from the API call.</returns>
        public async Task<ApiResponse<Models.TransactionTokenList>> ListStoreTransactionTokensAsync(
                Guid storeId,
                int? limit = 10,
                Guid? cursor = null,
                Models.CursorDirectionQuery? cursorDirection = Models.CursorDirectionQuery.Desc,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.TransactionTokenList>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/stores/{storeId}/tokens")
                  .WithAuth("JWT_TOKEN")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("storeId", storeId))
                      .Query(query => query.Setup("limit", limit ?? 10))
                      .Query(query => query.Setup("cursor", cursor))
                      .Query(query => query.Setup("cursor_direction", (cursorDirection.HasValue) ? CoreHelper.JsonSerialize(cursorDirection.Value).Trim('\"') : "desc"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("HTTP 400 Bad Request: {$response.body#/code}", (errorReason, context) => new ApiErrorException(errorReason, context), true))
                  .ErrorCase("401", CreateErrorCase("HTTP 401 Unauthorized: {$response.body#/code}", (errorReason, context) => new ApiErrorException(errorReason, context), true))
                  .ErrorCase("403", CreateErrorCase("HTTP 403 Forbidden: {$response.body#/code}", (errorReason, context) => new ApiErrorException(errorReason, context), true))
                  .ErrorCase("429", CreateErrorCase("HTTP 429 Rate Limited: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("404", CreateErrorCase("HTTP 404 Not Found: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("409", CreateErrorCase("HTTP 409 Conflict: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("500", CreateErrorCase("HTTP 500 Server Error: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("503", CreateErrorCase("HTTP 503 Unavailable: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("504", CreateErrorCase("HTTP 504 Timeout: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("0", CreateErrorCase("HTTP {$statusCode}: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Retrieves the details of an existing transaction token.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="id">Required parameter: The unique identifier of the resource..</param>
        /// <returns>Returns the ApiResponse of Models.TransactionToken response from the API call.</returns>
        public ApiResponse<Models.TransactionToken> GetTransactionToken(
                Guid storeId,
                Guid id)
            => CoreHelper.RunTask(GetTransactionTokenAsync(storeId, id));

        /// <summary>
        /// Retrieves the details of an existing transaction token.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="id">Required parameter: The unique identifier of the resource..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.TransactionToken response from the API call.</returns>
        public async Task<ApiResponse<Models.TransactionToken>> GetTransactionTokenAsync(
                Guid storeId,
                Guid id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.TransactionToken>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/stores/{storeId}/tokens/{id}")
                  .WithAuth("JWT_TOKEN")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("storeId", storeId))
                      .Template(template => template.Setup("id", id))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("HTTP 400 Bad Request: {$response.body#/code}", (errorReason, context) => new ApiErrorException(errorReason, context), true))
                  .ErrorCase("401", CreateErrorCase("HTTP 401 Unauthorized: {$response.body#/code}", (errorReason, context) => new ApiErrorException(errorReason, context), true))
                  .ErrorCase("403", CreateErrorCase("HTTP 403 Forbidden: {$response.body#/code}", (errorReason, context) => new ApiErrorException(errorReason, context), true))
                  .ErrorCase("404", CreateErrorCase("HTTP 404 Not Found: {$response.body#/code}", (errorReason, context) => new ApiErrorException(errorReason, context), true))
                  .ErrorCase("429", CreateErrorCase("HTTP 429 Rate Limited: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("409", CreateErrorCase("HTTP 409 Conflict: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("500", CreateErrorCase("HTTP 500 Server Error: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("503", CreateErrorCase("HTTP 503 Unavailable: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("504", CreateErrorCase("HTTP 504 Timeout: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("0", CreateErrorCase("HTTP {$statusCode}: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// ⚠️ **LEGACY WARNING: Discouraged Operation**.
        /// While it is technically possible to update a transaction token, this practice is highly discouraged and is maintained solely for legacy reasons. .
        /// **Updating raw card details requires your server environment to be fully PCI DSS compliant.**.
        /// **Recommended Approach:** Instead of updating an existing token, it is best practice to create an entirely new transaction token using Univapay's frontend integrations (**Link Form**, **Widget**, or **Inline Form**). This allows Univapay to securely handle the customer's payment data without it ever touching your servers.
        /// --- **Legacy Usage:** Updates CVV, Address, Email, or Card Details.  *Note: If updating only the CVV to resolve a `RECURRING_USAGE_REQUIRES_CVV` error, the application token secret is not required.*.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="id">Required parameter: The unique identifier of the resource..</param>
        /// <param name="idempotencyKey">Optional parameter: An optional idempotency key to prevent double charges and duplicate operations. We recommend a randomly generated UUID (v4)..</param>
        /// <param name="body">Optional parameter: Request payload for updating a transaction token..</param>
        /// <returns>Returns the ApiResponse of Models.TransactionToken response from the API call.</returns>
        public ApiResponse<Models.TransactionToken> UpdateTransactionToken(
                Guid storeId,
                Guid id,
                string idempotencyKey = null,
                Models.TransactionTokenUpdateRequest body = null)
            => CoreHelper.RunTask(UpdateTransactionTokenAsync(storeId, id, idempotencyKey, body));

        /// <summary>
        /// ⚠️ **LEGACY WARNING: Discouraged Operation**.
        /// While it is technically possible to update a transaction token, this practice is highly discouraged and is maintained solely for legacy reasons. .
        /// **Updating raw card details requires your server environment to be fully PCI DSS compliant.**.
        /// **Recommended Approach:** Instead of updating an existing token, it is best practice to create an entirely new transaction token using Univapay's frontend integrations (**Link Form**, **Widget**, or **Inline Form**). This allows Univapay to securely handle the customer's payment data without it ever touching your servers.
        /// --- **Legacy Usage:** Updates CVV, Address, Email, or Card Details.  *Note: If updating only the CVV to resolve a `RECURRING_USAGE_REQUIRES_CVV` error, the application token secret is not required.*.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="id">Required parameter: The unique identifier of the resource..</param>
        /// <param name="idempotencyKey">Optional parameter: An optional idempotency key to prevent double charges and duplicate operations. We recommend a randomly generated UUID (v4)..</param>
        /// <param name="body">Optional parameter: Request payload for updating a transaction token..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.TransactionToken response from the API call.</returns>
        public async Task<ApiResponse<Models.TransactionToken>> UpdateTransactionTokenAsync(
                Guid storeId,
                Guid id,
                string idempotencyKey = null,
                Models.TransactionTokenUpdateRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.TransactionToken>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/stores/{storeId}/tokens/{id}")
                  .WithAuth("JWT_TOKEN")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("storeId", storeId))
                      .Template(template => template.Setup("id", id))
                      .Header(header => header.Setup("Content-Type", "application/json"))
                      .Header(header => header.Setup("Idempotency-Key", idempotencyKey))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("HTTP 400 Bad Request: {$response.body#/code}", (errorReason, context) => new ApiErrorException(errorReason, context), true))
                  .ErrorCase("401", CreateErrorCase("HTTP 401 Unauthorized: {$response.body#/code}", (errorReason, context) => new ApiErrorException(errorReason, context), true))
                  .ErrorCase("403", CreateErrorCase("HTTP 403 Forbidden: {$response.body#/code}", (errorReason, context) => new ApiErrorException(errorReason, context), true))
                  .ErrorCase("404", CreateErrorCase("HTTP 404 Not Found: {$response.body#/code}", (errorReason, context) => new ApiErrorException(errorReason, context), true))
                  .ErrorCase("429", CreateErrorCase("HTTP 429 Rate Limited: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("409", CreateErrorCase("HTTP 409 Conflict: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("500", CreateErrorCase("HTTP 500 Server Error: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("503", CreateErrorCase("HTTP 503 Unavailable: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("504", CreateErrorCase("HTTP 504 Timeout: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("0", CreateErrorCase("HTTP {$statusCode}: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Deletes a specific transaction token. .
        /// ⚠️ **WARNING: Breaks Linked Subscriptions**.
        /// Please note that deleting a transaction token will immediately prevent any linked recurring charges or subscriptions from being processed. Proceed with caution.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="id">Required parameter: The unique identifier of the resource..</param>
        public void DeleteTransactionToken(
                Guid storeId,
                Guid id)
            => CoreHelper.RunVoidTask(DeleteTransactionTokenAsync(storeId, id));

        /// <summary>
        /// Deletes a specific transaction token. .
        /// ⚠️ **WARNING: Breaks Linked Subscriptions**.
        /// Please note that deleting a transaction token will immediately prevent any linked recurring charges or subscriptions from being processed. Proceed with caution.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="id">Required parameter: The unique identifier of the resource..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task DeleteTransactionTokenAsync(
                Guid storeId,
                Guid id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Delete, "/stores/{storeId}/tokens/{id}")
                  .WithAuth("JWT_TOKEN")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("storeId", storeId))
                      .Template(template => template.Setup("id", id))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("HTTP 400 Bad Request: {$response.body#/code}", (errorReason, context) => new ApiErrorException(errorReason, context), true))
                  .ErrorCase("401", CreateErrorCase("HTTP 401 Unauthorized: {$response.body#/code}", (errorReason, context) => new ApiErrorException(errorReason, context), true))
                  .ErrorCase("403", CreateErrorCase("HTTP 403 Forbidden: {$response.body#/code}", (errorReason, context) => new ApiErrorException(errorReason, context), true))
                  .ErrorCase("404", CreateErrorCase("HTTP 404 Not Found: {$response.body#/code}", (errorReason, context) => new ApiErrorException(errorReason, context), true))
                  .ErrorCase("429", CreateErrorCase("HTTP 429 Rate Limited: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("409", CreateErrorCase("HTTP 409 Conflict: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("500", CreateErrorCase("HTTP 500 Server Error: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("503", CreateErrorCase("HTTP 503 Unavailable: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("504", CreateErrorCase("HTTP 504 Timeout: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("0", CreateErrorCase("HTTP {$statusCode}: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Retrieves the information required to execute 3-D Secure authentication when creating a recurring transaction token.
        /// **⚠️ Important Notes:** 1. **PCI DSS Compliance:** This endpoint is only available to PCI DSS compliant merchants who are authorized to send raw card data directly via the API to create tokens. 2. **Target Tokens:** This only applies to tokens where `type` is `recurring`. For `one_time` or `subscription` tokens, 3-D Secure is requested during charge creation, not token creation. 3. **Execution Flow:**.
        ///    - After creating the token, poll the token object until `data.three_ds.status` becomes `awaiting`.
        ///    - Once `awaiting`, use this endpoint to fetch the issuer token details.
        ///    - Format the returned `payload` according to the `content_type` (e.g., URL-encoded) and execute an `http_post` request from the consumer's browser to the `issuer_token` URL.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="id">Required parameter: The unique identifier of the resource..</param>
        /// <returns>Returns the ApiResponse of Models.ThreeDsIssuerToken response from the API call.</returns>
        public ApiResponse<Models.ThreeDsIssuerToken> GetTokenThreeDsIssuerToken(
                Guid storeId,
                Guid id)
            => CoreHelper.RunTask(GetTokenThreeDsIssuerTokenAsync(storeId, id));

        /// <summary>
        /// Retrieves the information required to execute 3-D Secure authentication when creating a recurring transaction token.
        /// **⚠️ Important Notes:** 1. **PCI DSS Compliance:** This endpoint is only available to PCI DSS compliant merchants who are authorized to send raw card data directly via the API to create tokens. 2. **Target Tokens:** This only applies to tokens where `type` is `recurring`. For `one_time` or `subscription` tokens, 3-D Secure is requested during charge creation, not token creation. 3. **Execution Flow:**.
        ///    - After creating the token, poll the token object until `data.three_ds.status` becomes `awaiting`.
        ///    - Once `awaiting`, use this endpoint to fetch the issuer token details.
        ///    - Format the returned `payload` according to the `content_type` (e.g., URL-encoded) and execute an `http_post` request from the consumer's browser to the `issuer_token` URL.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="id">Required parameter: The unique identifier of the resource..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.ThreeDsIssuerToken response from the API call.</returns>
        public async Task<ApiResponse<Models.ThreeDsIssuerToken>> GetTokenThreeDsIssuerTokenAsync(
                Guid storeId,
                Guid id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ThreeDsIssuerToken>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/stores/{storeId}/tokens/{id}/three_ds/issuer_token")
                  .WithAuth("JWT_TOKEN")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("storeId", storeId))
                      .Template(template => template.Setup("id", id))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("HTTP 400 Bad Request: {$response.body#/code}", (errorReason, context) => new ApiErrorException(errorReason, context), true))
                  .ErrorCase("401", CreateErrorCase("HTTP 401 Unauthorized: {$response.body#/code}", (errorReason, context) => new ApiErrorException(errorReason, context), true))
                  .ErrorCase("403", CreateErrorCase("HTTP 403 Forbidden: {$response.body#/code}", (errorReason, context) => new ApiErrorException(errorReason, context), true))
                  .ErrorCase("404", CreateErrorCase("HTTP 404 Not Found: {$response.body#/code}", (errorReason, context) => new ApiErrorException(errorReason, context), true))
                  .ErrorCase("429", CreateErrorCase("HTTP 429 Rate Limited: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("409", CreateErrorCase("HTTP 409 Conflict: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("500", CreateErrorCase("HTTP 500 Server Error: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("503", CreateErrorCase("HTTP 503 Unavailable: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("504", CreateErrorCase("HTTP 504 Timeout: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("0", CreateErrorCase("HTTP {$statusCode}: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}
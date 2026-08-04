// <copyright file="CancelsApi.cs" company="APIMatic">
// UnivaPay
//
// This file was automatically generated for Univapay by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core;
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
    /// CancelsApi.
    /// </summary>
    public class CancelsApi : BaseApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CancelsApi"/> class.
        /// </summary>
        internal CancelsApi(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Returns a paginated list of cancels for the specified charge.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="chargeId">Required parameter: The unique identifier of the charge..</param>
        /// <param name="limit">Optional parameter: Maximum number of resources to return in one page..</param>
        /// <param name="cursor">Optional parameter: Cursor pointing to the resource after which pagination should continue..</param>
        /// <param name="cursorDirection">Optional parameter: Pagination direction relative to the supplied cursor..</param>
        /// <returns>Returns the ApiResponse of Models.CancelList response from the API call.</returns>
        public ApiResponse<Models.CancelList> ListCancels(
                Guid storeId,
                Guid chargeId,
                int? limit = 10,
                Guid? cursor = null,
                Models.CursorDirectionQuery? cursorDirection = Models.CursorDirectionQuery.Desc)
            => CoreHelper.RunTask(ListCancelsAsync(storeId, chargeId, limit, cursor, cursorDirection));

        /// <summary>
        /// Returns a paginated list of cancels for the specified charge.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="chargeId">Required parameter: The unique identifier of the charge..</param>
        /// <param name="limit">Optional parameter: Maximum number of resources to return in one page..</param>
        /// <param name="cursor">Optional parameter: Cursor pointing to the resource after which pagination should continue..</param>
        /// <param name="cursorDirection">Optional parameter: Pagination direction relative to the supplied cursor..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.CancelList response from the API call.</returns>
        public async Task<ApiResponse<Models.CancelList>> ListCancelsAsync(
                Guid storeId,
                Guid chargeId,
                int? limit = 10,
                Guid? cursor = null,
                Models.CursorDirectionQuery? cursorDirection = Models.CursorDirectionQuery.Desc,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CancelList>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/stores/{storeId}/charges/{chargeId}/cancels")
                  .WithAuth("JWT_TOKEN")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("storeId", storeId))
                      .Template(template => template.Setup("chargeId", chargeId))
                      .Query(query => query.Setup("limit", limit ?? 10))
                      .Query(query => query.Setup("cursor", cursor))
                      .Query(query => query.Setup("cursor_direction", (cursorDirection.HasValue) ? CoreHelper.JsonSerialize(cursorDirection.Value).Trim('\"') : "desc"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("401", CreateErrorCase("HTTP 401 Unauthorized: {$response.body#/code}", (errorReason, context) => new ApiErrorException(errorReason, context), true))
                  .ErrorCase("404", CreateErrorCase("HTTP 404 Not Found: {$response.body#/code}", (errorReason, context) => new ApiErrorException(errorReason, context), true))
                  .ErrorCase("400", CreateErrorCase("HTTP 400 Bad Request: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("403", CreateErrorCase("HTTP 403 Forbidden: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("409", CreateErrorCase("HTTP 409 Conflict: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("429", CreateErrorCase("HTTP 429 Rate Limited: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("500", CreateErrorCase("HTTP 500 Server Error: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("503", CreateErrorCase("HTTP 503 Unavailable: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("504", CreateErrorCase("HTTP 504 Timeout: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("0", CreateErrorCase("HTTP {$statusCode}: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Creates a new cancellation request for a charge. The charge must be in a cancellable state. Bank transfer and konbini charges that have already been paid cannot be cancelled.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="chargeId">Required parameter: The unique identifier of the charge..</param>
        /// <param name="idempotencyKey">Optional parameter: An optional idempotency key to prevent double charges and duplicate operations. We recommend a randomly generated UUID (v4)..</param>
        /// <param name="body">Optional parameter: Optional metadata payload for creating a cancel..</param>
        /// <returns>Returns the ApiResponse of Models.Cancel response from the API call.</returns>
        public ApiResponse<Models.Cancel> CreateCancel(
                Guid storeId,
                Guid chargeId,
                string idempotencyKey = null,
                Models.CancelCreateRequest body = null)
            => CoreHelper.RunTask(CreateCancelAsync(storeId, chargeId, idempotencyKey, body));

        /// <summary>
        /// Creates a new cancellation request for a charge. The charge must be in a cancellable state. Bank transfer and konbini charges that have already been paid cannot be cancelled.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="chargeId">Required parameter: The unique identifier of the charge..</param>
        /// <param name="idempotencyKey">Optional parameter: An optional idempotency key to prevent double charges and duplicate operations. We recommend a randomly generated UUID (v4)..</param>
        /// <param name="body">Optional parameter: Optional metadata payload for creating a cancel..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.Cancel response from the API call.</returns>
        public async Task<ApiResponse<Models.Cancel>> CreateCancelAsync(
                Guid storeId,
                Guid chargeId,
                string idempotencyKey = null,
                Models.CancelCreateRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Cancel>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/stores/{storeId}/charges/{chargeId}/cancels")
                  .WithAuth("JWT_TOKEN")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("storeId", storeId))
                      .Template(template => template.Setup("chargeId", chargeId))
                      .Header(header => header.Setup("Content-Type", "application/json"))
                      .Header(header => header.Setup("Idempotency-Key", idempotencyKey))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("HTTP 400 Bad Request: {$response.body#/code}", (errorReason, context) => new ApiErrorException(errorReason, context), true))
                  .ErrorCase("401", CreateErrorCase("HTTP 401 Unauthorized: {$response.body#/code}", (errorReason, context) => new ApiErrorException(errorReason, context), true))
                  .ErrorCase("404", CreateErrorCase("HTTP 404 Not Found: {$response.body#/code}", (errorReason, context) => new ApiErrorException(errorReason, context), true))
                  .ErrorCase("403", CreateErrorCase("HTTP 403 Forbidden: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("409", CreateErrorCase("HTTP 409 Conflict: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("429", CreateErrorCase("HTTP 429 Rate Limited: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("500", CreateErrorCase("HTTP 500 Server Error: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("503", CreateErrorCase("HTTP 503 Unavailable: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("504", CreateErrorCase("HTTP 504 Timeout: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("0", CreateErrorCase("HTTP {$statusCode}: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Retrieves a specific cancel by ID. Supports long-polling by appending `?polling=true` to wait for a status change (up to the server timeout). Requires a secret-bearing token.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="chargeId">Required parameter: The unique identifier of the charge..</param>
        /// <param name="id">Required parameter: The unique identifier of the resource..</param>
        /// <param name="polling">Optional parameter: If `true`, the server holds the connection open until the cancel status changes or the polling timeout is reached..</param>
        /// <returns>Returns the ApiResponse of Models.Cancel response from the API call.</returns>
        public ApiResponse<Models.Cancel> GetCancel(
                Guid storeId,
                Guid chargeId,
                Guid id,
                bool? polling = false)
            => CoreHelper.RunTask(GetCancelAsync(storeId, chargeId, id, polling));

        /// <summary>
        /// Retrieves a specific cancel by ID. Supports long-polling by appending `?polling=true` to wait for a status change (up to the server timeout). Requires a secret-bearing token.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="chargeId">Required parameter: The unique identifier of the charge..</param>
        /// <param name="id">Required parameter: The unique identifier of the resource..</param>
        /// <param name="polling">Optional parameter: If `true`, the server holds the connection open until the cancel status changes or the polling timeout is reached..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.Cancel response from the API call.</returns>
        public async Task<ApiResponse<Models.Cancel>> GetCancelAsync(
                Guid storeId,
                Guid chargeId,
                Guid id,
                bool? polling = false,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Cancel>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/stores/{storeId}/charges/{chargeId}/cancels/{id}")
                  .WithAuth("JWT_TOKEN")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("storeId", storeId))
                      .Template(template => template.Setup("chargeId", chargeId))
                      .Template(template => template.Setup("id", id))
                      .Query(query => query.Setup("polling", polling ?? false))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("401", CreateErrorCase("HTTP 401 Unauthorized: {$response.body#/code}", (errorReason, context) => new ApiErrorException(errorReason, context), true))
                  .ErrorCase("404", CreateErrorCase("HTTP 404 Not Found: {$response.body#/code}", (errorReason, context) => new ApiErrorException(errorReason, context), true))
                  .ErrorCase("400", CreateErrorCase("HTTP 400 Bad Request: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("403", CreateErrorCase("HTTP 403 Forbidden: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("409", CreateErrorCase("HTTP 409 Conflict: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("429", CreateErrorCase("HTTP 429 Rate Limited: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("500", CreateErrorCase("HTTP 500 Server Error: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("503", CreateErrorCase("HTTP 503 Unavailable: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("504", CreateErrorCase("HTTP 504 Timeout: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("0", CreateErrorCase("HTTP {$statusCode}: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Updates metadata on an existing cancel. Requires a secret-bearing token.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="chargeId">Required parameter: The unique identifier of the charge..</param>
        /// <param name="id">Required parameter: The unique identifier of the resource..</param>
        /// <param name="body">Required parameter: Request payload for updating cancel metadata..</param>
        /// <param name="idempotencyKey">Optional parameter: An optional idempotency key to prevent double charges and duplicate operations. We recommend a randomly generated UUID (v4)..</param>
        /// <returns>Returns the ApiResponse of Models.Cancel response from the API call.</returns>
        public ApiResponse<Models.Cancel> UpdateCancel(
                Guid storeId,
                Guid chargeId,
                Guid id,
                Models.CancelUpdateRequest body,
                string idempotencyKey = null)
            => CoreHelper.RunTask(UpdateCancelAsync(storeId, chargeId, id, body, idempotencyKey));

        /// <summary>
        /// Updates metadata on an existing cancel. Requires a secret-bearing token.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="chargeId">Required parameter: The unique identifier of the charge..</param>
        /// <param name="id">Required parameter: The unique identifier of the resource..</param>
        /// <param name="body">Required parameter: Request payload for updating cancel metadata..</param>
        /// <param name="idempotencyKey">Optional parameter: An optional idempotency key to prevent double charges and duplicate operations. We recommend a randomly generated UUID (v4)..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.Cancel response from the API call.</returns>
        public async Task<ApiResponse<Models.Cancel>> UpdateCancelAsync(
                Guid storeId,
                Guid chargeId,
                Guid id,
                Models.CancelUpdateRequest body,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Cancel>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/stores/{storeId}/charges/{chargeId}/cancels/{id}")
                  .WithAuth("JWT_TOKEN")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body).Required())
                      .Template(template => template.Setup("storeId", storeId))
                      .Template(template => template.Setup("chargeId", chargeId))
                      .Template(template => template.Setup("id", id))
                      .Header(header => header.Setup("Content-Type", "application/json"))
                      .Header(header => header.Setup("Idempotency-Key", idempotencyKey))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("HTTP 400 Bad Request: {$response.body#/code}", (errorReason, context) => new ApiErrorException(errorReason, context), true))
                  .ErrorCase("401", CreateErrorCase("HTTP 401 Unauthorized: {$response.body#/code}", (errorReason, context) => new ApiErrorException(errorReason, context), true))
                  .ErrorCase("403", CreateErrorCase("HTTP 403 Forbidden: {$response.body#/code}", (errorReason, context) => new ApiErrorException(errorReason, context), true))
                  .ErrorCase("404", CreateErrorCase("HTTP 404 Not Found: {$response.body#/code}", (errorReason, context) => new ApiErrorException(errorReason, context), true))
                  .ErrorCase("409", CreateErrorCase("HTTP 409 Conflict: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("429", CreateErrorCase("HTTP 429 Rate Limited: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("500", CreateErrorCase("HTTP 500 Server Error: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("503", CreateErrorCase("HTTP 503 Unavailable: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("504", CreateErrorCase("HTTP 504 Timeout: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("0", CreateErrorCase("HTTP {$statusCode}: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}
// <copyright file="RefundsApi.cs" company="APIMatic">
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
    /// RefundsApi.
    /// </summary>
    public class RefundsApi : BaseApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RefundsApi"/> class.
        /// </summary>
        internal RefundsApi(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Retrieves a list of all refunds for a specific charge.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="chargeId">Required parameter: The unique identifier of the charge..</param>
        /// <param name="limit">Optional parameter: Maximum number of resources to return in one page..</param>
        /// <param name="cursor">Optional parameter: Cursor pointing to the resource after which pagination should continue..</param>
        /// <param name="cursorDirection">Optional parameter: Pagination direction relative to the supplied cursor..</param>
        /// <param name="metadata">Optional parameter: Filter refunds by metadata content..</param>
        /// <returns>Returns the ApiResponse of Models.RefundList response from the API call.</returns>
        public ApiResponse<Models.RefundList> ListRefunds(
                Guid storeId,
                Guid chargeId,
                int? limit = 10,
                Guid? cursor = null,
                Models.CursorDirectionQuery? cursorDirection = Models.CursorDirectionQuery.Desc,
                string metadata = null)
            => CoreHelper.RunTask(ListRefundsAsync(storeId, chargeId, limit, cursor, cursorDirection, metadata));

        /// <summary>
        /// Retrieves a list of all refunds for a specific charge.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="chargeId">Required parameter: The unique identifier of the charge..</param>
        /// <param name="limit">Optional parameter: Maximum number of resources to return in one page..</param>
        /// <param name="cursor">Optional parameter: Cursor pointing to the resource after which pagination should continue..</param>
        /// <param name="cursorDirection">Optional parameter: Pagination direction relative to the supplied cursor..</param>
        /// <param name="metadata">Optional parameter: Filter refunds by metadata content..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.RefundList response from the API call.</returns>
        public async Task<ApiResponse<Models.RefundList>> ListRefundsAsync(
                Guid storeId,
                Guid chargeId,
                int? limit = 10,
                Guid? cursor = null,
                Models.CursorDirectionQuery? cursorDirection = Models.CursorDirectionQuery.Desc,
                string metadata = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.RefundList>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/stores/{storeId}/charges/{chargeId}/refunds")
                  .WithAuth("JWT_TOKEN")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("storeId", storeId))
                      .Template(template => template.Setup("chargeId", chargeId))
                      .Query(query => query.Setup("limit", limit ?? 10))
                      .Query(query => query.Setup("cursor", cursor))
                      .Query(query => query.Setup("cursor_direction", (cursorDirection.HasValue) ? CoreHelper.JsonSerialize(cursorDirection.Value).Trim('\"') : "desc"))
                      .Query(query => query.Setup("metadata", metadata))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("401", CreateErrorCase("HTTP 401 Unauthorized: {$response.body#/code}", (errorReason, context) => new ApiErrorException(errorReason, context), true))
                  .ErrorCase("403", CreateErrorCase("HTTP 403 Forbidden: {$response.body#/code}", (errorReason, context) => new ApiErrorException(errorReason, context), true))
                  .ErrorCase("404", CreateErrorCase("HTTP 404 Not Found: {$response.body#/code}", (errorReason, context) => new ApiErrorException(errorReason, context), true))
                  .ErrorCase("400", CreateErrorCase("HTTP 400 Bad Request: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("409", CreateErrorCase("HTTP 409 Conflict: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("429", CreateErrorCase("HTTP 429 Rate Limited: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("500", CreateErrorCase("HTTP 500 Server Error: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("503", CreateErrorCase("HTTP 503 Unavailable: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("504", CreateErrorCase("HTTP 504 Timeout: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("0", CreateErrorCase("HTTP {$statusCode}: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Creates a refund for a successful charge. The charge must have status `successful`. Konbini and bank transfer charges cannot be refunded. The refund is processed asynchronously — the initial status will be `pending`.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="chargeId">Required parameter: The unique identifier of the charge..</param>
        /// <param name="body">Required parameter: Request payload for creating a refund..</param>
        /// <param name="idempotencyKey">Optional parameter: An optional idempotency key to prevent double charges and duplicate operations. We recommend a randomly generated UUID (v4)..</param>
        /// <returns>Returns the ApiResponse of Models.Refund response from the API call.</returns>
        public ApiResponse<Models.Refund> CreateRefund(
                Guid storeId,
                Guid chargeId,
                Models.RefundCreateRequest body,
                string idempotencyKey = null)
            => CoreHelper.RunTask(CreateRefundAsync(storeId, chargeId, body, idempotencyKey));

        /// <summary>
        /// Creates a refund for a successful charge. The charge must have status `successful`. Konbini and bank transfer charges cannot be refunded. The refund is processed asynchronously — the initial status will be `pending`.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="chargeId">Required parameter: The unique identifier of the charge..</param>
        /// <param name="body">Required parameter: Request payload for creating a refund..</param>
        /// <param name="idempotencyKey">Optional parameter: An optional idempotency key to prevent double charges and duplicate operations. We recommend a randomly generated UUID (v4)..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.Refund response from the API call.</returns>
        public async Task<ApiResponse<Models.Refund>> CreateRefundAsync(
                Guid storeId,
                Guid chargeId,
                Models.RefundCreateRequest body,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Refund>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/stores/{storeId}/charges/{chargeId}/refunds")
                  .WithAuth("JWT_TOKEN")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body).Required())
                      .Template(template => template.Setup("storeId", storeId))
                      .Template(template => template.Setup("chargeId", chargeId))
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
        /// Retrieves the details of a specific refund. Supports long polling — set `polling=true` to wait until the refund status changes from `pending` to a terminal state (`successful`, `failed`, or `error`).
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="chargeId">Required parameter: The unique identifier of the charge..</param>
        /// <param name="id">Required parameter: The unique identifier of the resource..</param>
        /// <param name="polling">Optional parameter: If `true`, the server holds the connection open until the refund status transitions from `pending` to a terminal state, or until the polling timeout is reached..</param>
        /// <returns>Returns the ApiResponse of Models.Refund response from the API call.</returns>
        public ApiResponse<Models.Refund> GetRefund(
                Guid storeId,
                Guid chargeId,
                Guid id,
                bool? polling = null)
            => CoreHelper.RunTask(GetRefundAsync(storeId, chargeId, id, polling));

        /// <summary>
        /// Retrieves the details of a specific refund. Supports long polling — set `polling=true` to wait until the refund status changes from `pending` to a terminal state (`successful`, `failed`, or `error`).
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="chargeId">Required parameter: The unique identifier of the charge..</param>
        /// <param name="id">Required parameter: The unique identifier of the resource..</param>
        /// <param name="polling">Optional parameter: If `true`, the server holds the connection open until the refund status transitions from `pending` to a terminal state, or until the polling timeout is reached..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.Refund response from the API call.</returns>
        public async Task<ApiResponse<Models.Refund>> GetRefundAsync(
                Guid storeId,
                Guid chargeId,
                Guid id,
                bool? polling = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Refund>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/stores/{storeId}/charges/{chargeId}/refunds/{id}")
                  .WithAuth("JWT_TOKEN")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("storeId", storeId))
                      .Template(template => template.Setup("chargeId", chargeId))
                      .Template(template => template.Setup("id", id))
                      .Query(query => query.Setup("polling", polling))))
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
        /// Updates metadata, message, or reason on an existing refund.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="chargeId">Required parameter: The unique identifier of the charge..</param>
        /// <param name="id">Required parameter: The unique identifier of the resource..</param>
        /// <param name="body">Required parameter: Request payload for updating refund metadata or reason..</param>
        /// <param name="idempotencyKey">Optional parameter: An optional idempotency key to prevent double charges and duplicate operations. We recommend a randomly generated UUID (v4)..</param>
        /// <returns>Returns the ApiResponse of Models.Refund response from the API call.</returns>
        public ApiResponse<Models.Refund> UpdateRefund(
                Guid storeId,
                Guid chargeId,
                Guid id,
                Models.RefundUpdateRequest body,
                string idempotencyKey = null)
            => CoreHelper.RunTask(UpdateRefundAsync(storeId, chargeId, id, body, idempotencyKey));

        /// <summary>
        /// Updates metadata, message, or reason on an existing refund.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="chargeId">Required parameter: The unique identifier of the charge..</param>
        /// <param name="id">Required parameter: The unique identifier of the resource..</param>
        /// <param name="body">Required parameter: Request payload for updating refund metadata or reason..</param>
        /// <param name="idempotencyKey">Optional parameter: An optional idempotency key to prevent double charges and duplicate operations. We recommend a randomly generated UUID (v4)..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.Refund response from the API call.</returns>
        public async Task<ApiResponse<Models.Refund>> UpdateRefundAsync(
                Guid storeId,
                Guid chargeId,
                Guid id,
                Models.RefundUpdateRequest body,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Refund>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/stores/{storeId}/charges/{chargeId}/refunds/{id}")
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
// <copyright file="WebhooksApi.cs" company="APIMatic">
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
    /// WebhooksApi.
    /// </summary>
    public class WebhooksApi : BaseApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksApi"/> class.
        /// </summary>
        internal WebhooksApi(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Returns a paginated list of webhooks for the specified store. Requires a secret-bearing token.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="limit">Optional parameter: Maximum number of resources to return in one page..</param>
        /// <param name="cursor">Optional parameter: Cursor pointing to the resource after which pagination should continue..</param>
        /// <param name="cursorDirection">Optional parameter: Pagination direction relative to the supplied cursor..</param>
        /// <param name="active">Optional parameter: Filter by active status..</param>
        /// <returns>Returns the ApiResponse of Models.WebhookList response from the API call.</returns>
        public ApiResponse<Models.WebhookList> ListWebhooks(
                Guid storeId,
                int? limit = 10,
                Guid? cursor = null,
                Models.CursorDirectionQuery? cursorDirection = Models.CursorDirectionQuery.Desc,
                bool? active = null)
            => CoreHelper.RunTask(ListWebhooksAsync(storeId, limit, cursor, cursorDirection, active));

        /// <summary>
        /// Returns a paginated list of webhooks for the specified store. Requires a secret-bearing token.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="limit">Optional parameter: Maximum number of resources to return in one page..</param>
        /// <param name="cursor">Optional parameter: Cursor pointing to the resource after which pagination should continue..</param>
        /// <param name="cursorDirection">Optional parameter: Pagination direction relative to the supplied cursor..</param>
        /// <param name="active">Optional parameter: Filter by active status..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.WebhookList response from the API call.</returns>
        public async Task<ApiResponse<Models.WebhookList>> ListWebhooksAsync(
                Guid storeId,
                int? limit = 10,
                Guid? cursor = null,
                Models.CursorDirectionQuery? cursorDirection = Models.CursorDirectionQuery.Desc,
                bool? active = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.WebhookList>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/stores/{storeId}/webhooks")
                  .WithAuth("JWT_TOKEN")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("storeId", storeId))
                      .Query(query => query.Setup("limit", limit ?? 10))
                      .Query(query => query.Setup("cursor", cursor))
                      .Query(query => query.Setup("cursor_direction", (cursorDirection.HasValue) ? CoreHelper.JsonSerialize(cursorDirection.Value).Trim('\"') : "desc"))
                      .Query(query => query.Setup("active", active))))
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
        /// Creates a new webhook subscription for the specified store. Requires a secret-bearing token. Duplicate URLs within the same scope are not allowed. There is a maximum limit on the number of webhooks per store.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="body">Required parameter: Request payload for creating a store webhook subscription..</param>
        /// <param name="idempotencyKey">Optional parameter: An optional idempotency key to prevent double charges and duplicate operations. We recommend a randomly generated UUID (v4)..</param>
        /// <returns>Returns the ApiResponse of Models.Webhook response from the API call.</returns>
        public ApiResponse<Models.Webhook> CreateWebhook(
                Guid storeId,
                Models.WebhookCreateRequest body,
                string idempotencyKey = null)
            => CoreHelper.RunTask(CreateWebhookAsync(storeId, body, idempotencyKey));

        /// <summary>
        /// Creates a new webhook subscription for the specified store. Requires a secret-bearing token. Duplicate URLs within the same scope are not allowed. There is a maximum limit on the number of webhooks per store.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="body">Required parameter: Request payload for creating a store webhook subscription..</param>
        /// <param name="idempotencyKey">Optional parameter: An optional idempotency key to prevent double charges and duplicate operations. We recommend a randomly generated UUID (v4)..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.Webhook response from the API call.</returns>
        public async Task<ApiResponse<Models.Webhook>> CreateWebhookAsync(
                Guid storeId,
                Models.WebhookCreateRequest body,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Webhook>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/stores/{storeId}/webhooks")
                  .WithAuth("JWT_TOKEN")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body).Required())
                      .Template(template => template.Setup("storeId", storeId))
                      .Header(header => header.Setup("Content-Type", "application/json"))
                      .Header(header => header.Setup("Idempotency-Key", idempotencyKey))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("HTTP 400 Bad Request: {$response.body#/code}", (errorReason, context) => new ApiErrorException(errorReason, context), true))
                  .ErrorCase("401", CreateErrorCase("HTTP 401 Unauthorized: {$response.body#/code}", (errorReason, context) => new ApiErrorException(errorReason, context), true))
                  .ErrorCase("403", CreateErrorCase("HTTP 403 Forbidden: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("404", CreateErrorCase("HTTP 404 Not Found: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("409", CreateErrorCase("HTTP 409 Conflict: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("429", CreateErrorCase("HTTP 429 Rate Limited: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("500", CreateErrorCase("HTTP 500 Server Error: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("503", CreateErrorCase("HTTP 503 Unavailable: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("504", CreateErrorCase("HTTP 504 Timeout: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("0", CreateErrorCase("HTTP {$statusCode}: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Retrieves a specific webhook by ID.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="id">Required parameter: The unique identifier of the resource..</param>
        /// <returns>Returns the ApiResponse of Models.Webhook response from the API call.</returns>
        public ApiResponse<Models.Webhook> GetWebhook(
                Guid storeId,
                Guid id)
            => CoreHelper.RunTask(GetWebhookAsync(storeId, id));

        /// <summary>
        /// Retrieves a specific webhook by ID.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="id">Required parameter: The unique identifier of the resource..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.Webhook response from the API call.</returns>
        public async Task<ApiResponse<Models.Webhook>> GetWebhookAsync(
                Guid storeId,
                Guid id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Webhook>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/stores/{storeId}/webhooks/{id}")
                  .WithAuth("JWT_TOKEN")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("storeId", storeId))
                      .Template(template => template.Setup("id", id))))
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
        /// Updates an existing webhook. All fields are optional; omitted fields are left unchanged. Duplicate URLs within the same scope are not allowed.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="id">Required parameter: The unique identifier of the resource..</param>
        /// <param name="body">Required parameter: Request payload for updating a store webhook subscription..</param>
        /// <param name="idempotencyKey">Optional parameter: An optional idempotency key to prevent double charges and duplicate operations. We recommend a randomly generated UUID (v4)..</param>
        /// <returns>Returns the ApiResponse of Models.Webhook response from the API call.</returns>
        public ApiResponse<Models.Webhook> UpdateWebhook(
                Guid storeId,
                Guid id,
                Models.WebhookUpdateRequest body,
                string idempotencyKey = null)
            => CoreHelper.RunTask(UpdateWebhookAsync(storeId, id, body, idempotencyKey));

        /// <summary>
        /// Updates an existing webhook. All fields are optional; omitted fields are left unchanged. Duplicate URLs within the same scope are not allowed.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="id">Required parameter: The unique identifier of the resource..</param>
        /// <param name="body">Required parameter: Request payload for updating a store webhook subscription..</param>
        /// <param name="idempotencyKey">Optional parameter: An optional idempotency key to prevent double charges and duplicate operations. We recommend a randomly generated UUID (v4)..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.Webhook response from the API call.</returns>
        public async Task<ApiResponse<Models.Webhook>> UpdateWebhookAsync(
                Guid storeId,
                Guid id,
                Models.WebhookUpdateRequest body,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Webhook>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/stores/{storeId}/webhooks/{id}")
                  .WithAuth("JWT_TOKEN")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body).Required())
                      .Template(template => template.Setup("storeId", storeId))
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

        /// <summary>
        /// Deactivates and deletes a webhook subscription.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="id">Required parameter: The unique identifier of the resource..</param>
        public void DeleteWebhook(
                Guid storeId,
                Guid id)
            => CoreHelper.RunVoidTask(DeleteWebhookAsync(storeId, id));

        /// <summary>
        /// Deactivates and deletes a webhook subscription.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="id">Required parameter: The unique identifier of the resource..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task DeleteWebhookAsync(
                Guid storeId,
                Guid id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Delete, "/stores/{storeId}/webhooks/{id}")
                  .WithAuth("JWT_TOKEN")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("storeId", storeId))
                      .Template(template => template.Setup("id", id))))
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
        /// Returns a paginated list of webhook delivery events for the specified webhook. Each event captures the result of a single webhook delivery attempt.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="id">Required parameter: The unique identifier of the resource..</param>
        /// <param name="limit">Optional parameter: Maximum number of resources to return in one page..</param>
        /// <param name="cursor">Optional parameter: Cursor pointing to the resource after which pagination should continue..</param>
        /// <param name="cursorDirection">Optional parameter: Pagination direction relative to the supplied cursor..</param>
        /// <returns>Returns the ApiResponse of Models.WebhookEventList response from the API call.</returns>
        public ApiResponse<Models.WebhookEventList> ListWebhookEvents(
                Guid storeId,
                Guid id,
                int? limit = 10,
                Guid? cursor = null,
                Models.CursorDirectionQuery? cursorDirection = Models.CursorDirectionQuery.Desc)
            => CoreHelper.RunTask(ListWebhookEventsAsync(storeId, id, limit, cursor, cursorDirection));

        /// <summary>
        /// Returns a paginated list of webhook delivery events for the specified webhook. Each event captures the result of a single webhook delivery attempt.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="id">Required parameter: The unique identifier of the resource..</param>
        /// <param name="limit">Optional parameter: Maximum number of resources to return in one page..</param>
        /// <param name="cursor">Optional parameter: Cursor pointing to the resource after which pagination should continue..</param>
        /// <param name="cursorDirection">Optional parameter: Pagination direction relative to the supplied cursor..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.WebhookEventList response from the API call.</returns>
        public async Task<ApiResponse<Models.WebhookEventList>> ListWebhookEventsAsync(
                Guid storeId,
                Guid id,
                int? limit = 10,
                Guid? cursor = null,
                Models.CursorDirectionQuery? cursorDirection = Models.CursorDirectionQuery.Desc,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.WebhookEventList>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/stores/{storeId}/webhooks/{id}/events")
                  .WithAuth("JWT_TOKEN")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("storeId", storeId))
                      .Template(template => template.Setup("id", id))
                      .Query(query => query.Setup("limit", limit ?? 10))
                      .Query(query => query.Setup("cursor", cursor))
                      .Query(query => query.Setup("cursor_direction", (cursorDirection.HasValue) ? CoreHelper.JsonSerialize(cursorDirection.Value).Trim('\"') : "desc"))))
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
        /// Re-sends the webhook payload for a previously delivered (or failed) event. Returns 202 Accepted immediately; delivery is asynchronous.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="id">Required parameter: The unique identifier of the resource..</param>
        /// <param name="eventId">Required parameter: The unique identifier of the webhook event..</param>
        /// <param name="idempotencyKey">Optional parameter: An optional idempotency key to prevent double charges and duplicate operations. We recommend a randomly generated UUID (v4)..</param>
        /// <returns>Returns the ApiResponse of object response from the API call.</returns>
        public ApiResponse<object> RedeliverWebhookEvent(
                Guid storeId,
                Guid id,
                Guid eventId,
                string idempotencyKey = null)
            => CoreHelper.RunTask(RedeliverWebhookEventAsync(storeId, id, eventId, idempotencyKey));

        /// <summary>
        /// Re-sends the webhook payload for a previously delivered (or failed) event. Returns 202 Accepted immediately; delivery is asynchronous.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="id">Required parameter: The unique identifier of the resource..</param>
        /// <param name="eventId">Required parameter: The unique identifier of the webhook event..</param>
        /// <param name="idempotencyKey">Optional parameter: An optional idempotency key to prevent double charges and duplicate operations. We recommend a randomly generated UUID (v4)..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of object response from the API call.</returns>
        public async Task<ApiResponse<object>> RedeliverWebhookEventAsync(
                Guid storeId,
                Guid id,
                Guid eventId,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<object>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/stores/{storeId}/webhooks/{id}/events/{eventId}/redeliver")
                  .WithAuth("JWT_TOKEN")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("storeId", storeId))
                      .Template(template => template.Setup("id", id))
                      .Template(template => template.Setup("eventId", eventId))
                      .Header(header => header.Setup("Idempotency-Key", idempotencyKey))))
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
                  .ErrorCase("0", CreateErrorCase("HTTP {$statusCode}: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .Deserializer(response => response))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}
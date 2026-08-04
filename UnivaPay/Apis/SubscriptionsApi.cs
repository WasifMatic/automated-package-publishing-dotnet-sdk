// <copyright file="SubscriptionsApi.cs" company="APIMatic">
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
    /// SubscriptionsApi.
    /// </summary>
    public class SubscriptionsApi : BaseApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionsApi"/> class.
        /// </summary>
        internal SubscriptionsApi(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Creates a new subscription.
        /// </summary>
        /// <param name="idempotencyKey">Optional parameter: An optional idempotency key to prevent double charges and duplicate operations. We recommend a randomly generated UUID (v4)..</param>
        /// <param name="body">Optional parameter: Create Subscription request.</param>
        /// <returns>Returns the ApiResponse of Models.Subscription response from the API call.</returns>
        public ApiResponse<Models.Subscription> CreateSubscription(
                string idempotencyKey = null,
                Models.SubscriptionCreateRequest body = null)
            => CoreHelper.RunTask(CreateSubscriptionAsync(idempotencyKey, body));

        /// <summary>
        /// Creates a new subscription.
        /// </summary>
        /// <param name="idempotencyKey">Optional parameter: An optional idempotency key to prevent double charges and duplicate operations. We recommend a randomly generated UUID (v4)..</param>
        /// <param name="body">Optional parameter: Create Subscription request.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.Subscription response from the API call.</returns>
        public async Task<ApiResponse<Models.Subscription>> CreateSubscriptionAsync(
                string idempotencyKey = null,
                Models.SubscriptionCreateRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Subscription>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/subscriptions")
                  .WithAuth("JWT_TOKEN")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Header(header => header.Setup("Content-Type", "application/json"))
                      .Header(header => header.Setup("Idempotency-Key", idempotencyKey))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("HTTP 400 Bad Request: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("401", CreateErrorCase("HTTP 401 Unauthorized: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
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
        /// Lists all subscriptions across all stores.
        /// </summary>
        /// <param name="limit">Optional parameter: Maximum number of resources to return in one page..</param>
        /// <param name="cursor">Optional parameter: Cursor pointing to the resource after which pagination should continue..</param>
        /// <param name="cursorDirection">Optional parameter: Pagination direction relative to the supplied cursor..</param>
        /// <returns>Returns the ApiResponse of Models.SubscriptionList response from the API call.</returns>
        public ApiResponse<Models.SubscriptionList> ListAllSubscriptions(
                int? limit = 10,
                Guid? cursor = null,
                Models.CursorDirectionQuery? cursorDirection = Models.CursorDirectionQuery.Desc)
            => CoreHelper.RunTask(ListAllSubscriptionsAsync(limit, cursor, cursorDirection));

        /// <summary>
        /// Lists all subscriptions across all stores.
        /// </summary>
        /// <param name="limit">Optional parameter: Maximum number of resources to return in one page..</param>
        /// <param name="cursor">Optional parameter: Cursor pointing to the resource after which pagination should continue..</param>
        /// <param name="cursorDirection">Optional parameter: Pagination direction relative to the supplied cursor..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.SubscriptionList response from the API call.</returns>
        public async Task<ApiResponse<Models.SubscriptionList>> ListAllSubscriptionsAsync(
                int? limit = 10,
                Guid? cursor = null,
                Models.CursorDirectionQuery? cursorDirection = Models.CursorDirectionQuery.Desc,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SubscriptionList>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/subscriptions")
                  .WithAuth("JWT_TOKEN")
                  .Parameters(parameters => parameters
                      .Query(query => query.Setup("limit", limit ?? 10))
                      .Query(query => query.Setup("cursor", cursor))
                      .Query(query => query.Setup("cursor_direction", (cursorDirection.HasValue) ? CoreHelper.JsonSerialize(cursorDirection.Value).Trim('\"') : "desc"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("HTTP 400 Bad Request: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("401", CreateErrorCase("HTTP 401 Unauthorized: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
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
        /// Lists all subscriptions for a specific store.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="search">Optional parameter: Search by metadata values..</param>
        /// <param name="status">Optional parameter: Filter subscriptions by current status..</param>
        /// <param name="mode">Optional parameter: Filter subscriptions by processing mode..</param>
        /// <param name="limit">Optional parameter: Maximum number of resources to return in one page..</param>
        /// <param name="cursor">Optional parameter: Cursor pointing to the resource after which pagination should continue..</param>
        /// <param name="cursorDirection">Optional parameter: Pagination direction relative to the supplied cursor..</param>
        /// <returns>Returns the ApiResponse of Models.SubscriptionList response from the API call.</returns>
        public ApiResponse<Models.SubscriptionList> ListStoreSubscriptions(
                Guid storeId,
                string search = null,
                Models.SubscriptionStatus? status = null,
                Models.ChargeMode? mode = null,
                int? limit = 10,
                Guid? cursor = null,
                Models.CursorDirectionQuery? cursorDirection = Models.CursorDirectionQuery.Desc)
            => CoreHelper.RunTask(ListStoreSubscriptionsAsync(storeId, search, status, mode, limit, cursor, cursorDirection));

        /// <summary>
        /// Lists all subscriptions for a specific store.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="search">Optional parameter: Search by metadata values..</param>
        /// <param name="status">Optional parameter: Filter subscriptions by current status..</param>
        /// <param name="mode">Optional parameter: Filter subscriptions by processing mode..</param>
        /// <param name="limit">Optional parameter: Maximum number of resources to return in one page..</param>
        /// <param name="cursor">Optional parameter: Cursor pointing to the resource after which pagination should continue..</param>
        /// <param name="cursorDirection">Optional parameter: Pagination direction relative to the supplied cursor..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.SubscriptionList response from the API call.</returns>
        public async Task<ApiResponse<Models.SubscriptionList>> ListStoreSubscriptionsAsync(
                Guid storeId,
                string search = null,
                Models.SubscriptionStatus? status = null,
                Models.ChargeMode? mode = null,
                int? limit = 10,
                Guid? cursor = null,
                Models.CursorDirectionQuery? cursorDirection = Models.CursorDirectionQuery.Desc,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SubscriptionList>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/stores/{storeId}/subscriptions")
                  .WithAuth("JWT_TOKEN")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("storeId", storeId))
                      .Query(query => query.Setup("search", search))
                      .Query(query => query.Setup("status", (status.HasValue) ? CoreHelper.JsonSerialize(status.Value).Trim('\"') : null))
                      .Query(query => query.Setup("mode", (mode.HasValue) ? CoreHelper.JsonSerialize(mode.Value).Trim('\"') : null))
                      .Query(query => query.Setup("limit", limit ?? 10))
                      .Query(query => query.Setup("cursor", cursor))
                      .Query(query => query.Setup("cursor_direction", (cursorDirection.HasValue) ? CoreHelper.JsonSerialize(cursorDirection.Value).Trim('\"') : "desc"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("HTTP 400 Bad Request: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("401", CreateErrorCase("HTTP 401 Unauthorized: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
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
        /// Retrieves the details of an existing subscription.  Supports internal polling to wait for status changes.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="id">Required parameter: The Subscription ID..</param>
        /// <param name="polling">Optional parameter: If set to true, instructs the API to internally poll the subscription  status until it changes from 'unverified' (the initial status) to  another status..</param>
        /// <returns>Returns the ApiResponse of Models.Subscription response from the API call.</returns>
        public ApiResponse<Models.Subscription> GetSubscription(
                Guid storeId,
                Guid id,
                bool? polling = null)
            => CoreHelper.RunTask(GetSubscriptionAsync(storeId, id, polling));

        /// <summary>
        /// Retrieves the details of an existing subscription.  Supports internal polling to wait for status changes.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="id">Required parameter: The Subscription ID..</param>
        /// <param name="polling">Optional parameter: If set to true, instructs the API to internally poll the subscription  status until it changes from 'unverified' (the initial status) to  another status..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.Subscription response from the API call.</returns>
        public async Task<ApiResponse<Models.Subscription>> GetSubscriptionAsync(
                Guid storeId,
                Guid id,
                bool? polling = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Subscription>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/stores/{storeId}/subscriptions/{id}")
                  .WithAuth("JWT_TOKEN")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("storeId", storeId))
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
        /// Updates the configuration, payment method, or schedule of a specific subscription.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="id">Required parameter: The unique identifier of the resource..</param>
        /// <param name="idempotencyKey">Optional parameter: An optional idempotency key to prevent double charges and duplicate operations. We recommend a randomly generated UUID (v4)..</param>
        /// <param name="body">Optional parameter: Properties to update on the subscription..</param>
        /// <returns>Returns the ApiResponse of Models.Subscription response from the API call.</returns>
        public ApiResponse<Models.Subscription> UpdateSubscription(
                Guid storeId,
                Guid id,
                string idempotencyKey = null,
                Models.SubscriptionUpdateRequest body = null)
            => CoreHelper.RunTask(UpdateSubscriptionAsync(storeId, id, idempotencyKey, body));

        /// <summary>
        /// Updates the configuration, payment method, or schedule of a specific subscription.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="id">Required parameter: The unique identifier of the resource..</param>
        /// <param name="idempotencyKey">Optional parameter: An optional idempotency key to prevent double charges and duplicate operations. We recommend a randomly generated UUID (v4)..</param>
        /// <param name="body">Optional parameter: Properties to update on the subscription..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.Subscription response from the API call.</returns>
        public async Task<ApiResponse<Models.Subscription>> UpdateSubscriptionAsync(
                Guid storeId,
                Guid id,
                string idempotencyKey = null,
                Models.SubscriptionUpdateRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Subscription>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/stores/{storeId}/subscriptions/{id}")
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
        /// Cancels an existing subscription. The subscription status will be  permanently changed to `canceled` and it cannot be resumed.  Please proceed with caution.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="id">Required parameter: The unique identifier of the resource..</param>
        public void CancelSubscription(
                Guid storeId,
                Guid id)
            => CoreHelper.RunVoidTask(CancelSubscriptionAsync(storeId, id));

        /// <summary>
        /// Cancels an existing subscription. The subscription status will be  permanently changed to `canceled` and it cannot be resumed.  Please proceed with caution.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="id">Required parameter: The unique identifier of the resource..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task CancelSubscriptionAsync(
                Guid storeId,
                Guid id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Delete, "/stores/{storeId}/subscriptions/{id}")
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
        /// Retrieves a list of all historical and scheduled payments for a  specific subscription.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="subscriptionId">Required parameter: The unique identifier of the subscription..</param>
        /// <param name="limit">Optional parameter: Maximum number of resources to return in one page..</param>
        /// <param name="cursor">Optional parameter: Cursor pointing to the resource after which pagination should continue..</param>
        /// <param name="cursorDirection">Optional parameter: Pagination direction relative to the supplied cursor..</param>
        /// <returns>Returns the ApiResponse of Models.SubscriptionPaymentList response from the API call.</returns>
        public ApiResponse<Models.SubscriptionPaymentList> ListSubscriptionPayments(
                Guid storeId,
                Guid subscriptionId,
                int? limit = 10,
                Guid? cursor = null,
                Models.CursorDirectionQuery? cursorDirection = Models.CursorDirectionQuery.Desc)
            => CoreHelper.RunTask(ListSubscriptionPaymentsAsync(storeId, subscriptionId, limit, cursor, cursorDirection));

        /// <summary>
        /// Retrieves a list of all historical and scheduled payments for a  specific subscription.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="subscriptionId">Required parameter: The unique identifier of the subscription..</param>
        /// <param name="limit">Optional parameter: Maximum number of resources to return in one page..</param>
        /// <param name="cursor">Optional parameter: Cursor pointing to the resource after which pagination should continue..</param>
        /// <param name="cursorDirection">Optional parameter: Pagination direction relative to the supplied cursor..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.SubscriptionPaymentList response from the API call.</returns>
        public async Task<ApiResponse<Models.SubscriptionPaymentList>> ListSubscriptionPaymentsAsync(
                Guid storeId,
                Guid subscriptionId,
                int? limit = 10,
                Guid? cursor = null,
                Models.CursorDirectionQuery? cursorDirection = Models.CursorDirectionQuery.Desc,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SubscriptionPaymentList>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/stores/{storeId}/subscriptions/{subscriptionId}/payments")
                  .WithAuth("JWT_TOKEN")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("storeId", storeId))
                      .Template(template => template.Setup("subscriptionId", subscriptionId))
                      .Query(query => query.Setup("limit", limit ?? 10))
                      .Query(query => query.Setup("cursor", cursor))
                      .Query(query => query.Setup("cursor_direction", (cursorDirection.HasValue) ? CoreHelper.JsonSerialize(cursorDirection.Value).Trim('\"') : "desc"))))
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
        /// Retrieves the details of an individual payment associated with a specific subscription.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="subscriptionId">Required parameter: The unique identifier of the subscription..</param>
        /// <param name="paymentId">Required parameter: The unique identifier of the scheduled payment of a subscription.</param>
        /// <returns>Returns the ApiResponse of Models.SubscriptionPayment response from the API call.</returns>
        public ApiResponse<Models.SubscriptionPayment> GetSubscriptionPayment(
                Guid storeId,
                Guid subscriptionId,
                Guid paymentId)
            => CoreHelper.RunTask(GetSubscriptionPaymentAsync(storeId, subscriptionId, paymentId));

        /// <summary>
        /// Retrieves the details of an individual payment associated with a specific subscription.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="subscriptionId">Required parameter: The unique identifier of the subscription..</param>
        /// <param name="paymentId">Required parameter: The unique identifier of the scheduled payment of a subscription.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.SubscriptionPayment response from the API call.</returns>
        public async Task<ApiResponse<Models.SubscriptionPayment>> GetSubscriptionPaymentAsync(
                Guid storeId,
                Guid subscriptionId,
                Guid paymentId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SubscriptionPayment>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/stores/{storeId}/subscriptions/{subscriptionId}/payments/{paymentId}")
                  .WithAuth("JWT_TOKEN")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("storeId", storeId))
                      .Template(template => template.Setup("subscriptionId", subscriptionId))
                      .Template(template => template.Setup("paymentId", paymentId))))
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
        /// Updates properties of a specific scheduled payment for a subscription. Can be used to change the due date when permitted, mark the payment as paid, schedule a termination status, or set a retry interval.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="subscriptionId">Required parameter: The unique identifier of the subscription..</param>
        /// <param name="paymentId">Required parameter: The unique identifier of the scheduled payment of a subscription.</param>
        /// <param name="body">Required parameter: Request payload for updating a scheduled subscription payment..</param>
        /// <param name="idempotencyKey">Optional parameter: An optional idempotency key to prevent double charges and duplicate operations. We recommend a randomly generated UUID (v4)..</param>
        /// <returns>Returns the ApiResponse of Models.SubscriptionPayment response from the API call.</returns>
        public ApiResponse<Models.SubscriptionPayment> UpdateSubscriptionPayment(
                Guid storeId,
                Guid subscriptionId,
                Guid paymentId,
                Models.SubscriptionPatchPaymentRequest body,
                string idempotencyKey = null)
            => CoreHelper.RunTask(UpdateSubscriptionPaymentAsync(storeId, subscriptionId, paymentId, body, idempotencyKey));

        /// <summary>
        /// Updates properties of a specific scheduled payment for a subscription. Can be used to change the due date when permitted, mark the payment as paid, schedule a termination status, or set a retry interval.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="subscriptionId">Required parameter: The unique identifier of the subscription..</param>
        /// <param name="paymentId">Required parameter: The unique identifier of the scheduled payment of a subscription.</param>
        /// <param name="body">Required parameter: Request payload for updating a scheduled subscription payment..</param>
        /// <param name="idempotencyKey">Optional parameter: An optional idempotency key to prevent double charges and duplicate operations. We recommend a randomly generated UUID (v4)..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.SubscriptionPayment response from the API call.</returns>
        public async Task<ApiResponse<Models.SubscriptionPayment>> UpdateSubscriptionPaymentAsync(
                Guid storeId,
                Guid subscriptionId,
                Guid paymentId,
                Models.SubscriptionPatchPaymentRequest body,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SubscriptionPayment>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/stores/{storeId}/subscriptions/{subscriptionId}/payments/{paymentId}")
                  .WithAuth("JWT_TOKEN")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body).Required())
                      .Template(template => template.Setup("storeId", storeId))
                      .Template(template => template.Setup("subscriptionId", subscriptionId))
                      .Template(template => template.Setup("paymentId", paymentId))
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
        /// Retrieves the most recent charge created for a specific subscription. Returns 404 if no charges have been attempted yet.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="subscriptionId">Required parameter: The unique identifier of the subscription..</param>
        /// <returns>Returns the ApiResponse of Models.Charge response from the API call.</returns>
        public ApiResponse<Models.Charge> GetSubscriptionLatestCharge(
                Guid storeId,
                Guid subscriptionId)
            => CoreHelper.RunTask(GetSubscriptionLatestChargeAsync(storeId, subscriptionId));

        /// <summary>
        /// Retrieves the most recent charge created for a specific subscription. Returns 404 if no charges have been attempted yet.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="subscriptionId">Required parameter: The unique identifier of the subscription..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.Charge response from the API call.</returns>
        public async Task<ApiResponse<Models.Charge>> GetSubscriptionLatestChargeAsync(
                Guid storeId,
                Guid subscriptionId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Charge>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/stores/{storeId}/subscriptions/{subscriptionId}/charges/latest")
                  .WithAuth("JWT_TOKEN")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("storeId", storeId))
                      .Template(template => template.Setup("subscriptionId", subscriptionId))))
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
        /// Retrieves a paginated list of charges linked to a subscription. Backend search uses the same charge search surface as normal charge listing and adds a subscription filter for the requested subscription.
        /// </summary>
        /// <param name="merchantId">Required parameter: The unique identifier of the merchant..</param>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="subscriptionId">Required parameter: The unique identifier of the subscription..</param>
        /// <param name="limit">Optional parameter: Maximum number of resources to return in one page..</param>
        /// <param name="cursor">Optional parameter: Cursor pointing to the resource after which pagination should continue..</param>
        /// <param name="cursorDirection">Optional parameter: Pagination direction relative to the supplied cursor..</param>
        /// <returns>Returns the ApiResponse of Models.ChargeList response from the API call.</returns>
        public ApiResponse<Models.ChargeList> ListSubscriptionCharges(
                Guid merchantId,
                Guid storeId,
                Guid subscriptionId,
                int? limit = 10,
                Guid? cursor = null,
                Models.CursorDirectionQuery? cursorDirection = Models.CursorDirectionQuery.Desc)
            => CoreHelper.RunTask(ListSubscriptionChargesAsync(merchantId, storeId, subscriptionId, limit, cursor, cursorDirection));

        /// <summary>
        /// Retrieves a paginated list of charges linked to a subscription. Backend search uses the same charge search surface as normal charge listing and adds a subscription filter for the requested subscription.
        /// </summary>
        /// <param name="merchantId">Required parameter: The unique identifier of the merchant..</param>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="subscriptionId">Required parameter: The unique identifier of the subscription..</param>
        /// <param name="limit">Optional parameter: Maximum number of resources to return in one page..</param>
        /// <param name="cursor">Optional parameter: Cursor pointing to the resource after which pagination should continue..</param>
        /// <param name="cursorDirection">Optional parameter: Pagination direction relative to the supplied cursor..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.ChargeList response from the API call.</returns>
        public async Task<ApiResponse<Models.ChargeList>> ListSubscriptionChargesAsync(
                Guid merchantId,
                Guid storeId,
                Guid subscriptionId,
                int? limit = 10,
                Guid? cursor = null,
                Models.CursorDirectionQuery? cursorDirection = Models.CursorDirectionQuery.Desc,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ChargeList>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/merchants/{merchantId}/stores/{storeId}/subscriptions/{subscriptionId}/charges")
                  .WithAuth("JWT_TOKEN")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("merchantId", merchantId))
                      .Template(template => template.Setup("storeId", storeId))
                      .Template(template => template.Setup("subscriptionId", subscriptionId))
                      .Query(query => query.Setup("limit", limit ?? 10))
                      .Query(query => query.Setup("cursor", cursor))
                      .Query(query => query.Setup("cursor_direction", (cursorDirection.HasValue) ? CoreHelper.JsonSerialize(cursorDirection.Value).Trim('\"') : "desc"))))
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
        /// Retrieves a paginated list of all charge attempts made for a specific scheduled payment of a subscription. Useful for inspecting retry history.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="subscriptionId">Required parameter: The unique identifier of the subscription..</param>
        /// <param name="paymentId">Required parameter: The unique identifier of the scheduled payment of a subscription.</param>
        /// <param name="limit">Optional parameter: Maximum number of resources to return in one page..</param>
        /// <param name="cursor">Optional parameter: Cursor pointing to the resource after which pagination should continue..</param>
        /// <param name="cursorDirection">Optional parameter: Pagination direction relative to the supplied cursor..</param>
        /// <returns>Returns the ApiResponse of Models.ChargeList response from the API call.</returns>
        public ApiResponse<Models.ChargeList> ListChargesForSubscriptionPayment(
                Guid storeId,
                Guid subscriptionId,
                Guid paymentId,
                int? limit = 10,
                Guid? cursor = null,
                Models.CursorDirectionQuery? cursorDirection = Models.CursorDirectionQuery.Desc)
            => CoreHelper.RunTask(ListChargesForSubscriptionPaymentAsync(storeId, subscriptionId, paymentId, limit, cursor, cursorDirection));

        /// <summary>
        /// Retrieves a paginated list of all charge attempts made for a specific scheduled payment of a subscription. Useful for inspecting retry history.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="subscriptionId">Required parameter: The unique identifier of the subscription..</param>
        /// <param name="paymentId">Required parameter: The unique identifier of the scheduled payment of a subscription.</param>
        /// <param name="limit">Optional parameter: Maximum number of resources to return in one page..</param>
        /// <param name="cursor">Optional parameter: Cursor pointing to the resource after which pagination should continue..</param>
        /// <param name="cursorDirection">Optional parameter: Pagination direction relative to the supplied cursor..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.ChargeList response from the API call.</returns>
        public async Task<ApiResponse<Models.ChargeList>> ListChargesForSubscriptionPaymentAsync(
                Guid storeId,
                Guid subscriptionId,
                Guid paymentId,
                int? limit = 10,
                Guid? cursor = null,
                Models.CursorDirectionQuery? cursorDirection = Models.CursorDirectionQuery.Desc,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ChargeList>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/stores/{storeId}/subscriptions/{subscriptionId}/payments/{paymentId}/charges")
                  .WithAuth("JWT_TOKEN")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("storeId", storeId))
                      .Template(template => template.Setup("subscriptionId", subscriptionId))
                      .Template(template => template.Setup("paymentId", paymentId))
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
        /// Suspends a subscription that is currently `current` or `unpaid`. The `termination_mode` controls when the suspension takes effect: `immediate` (default) suspends right away, `on_next_payment` waits until the next scheduled payment date before suspending.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="subscriptionId">Required parameter: The unique identifier of the subscription..</param>
        /// <param name="idempotencyKey">Optional parameter: An optional idempotency key to prevent double charges and duplicate operations. We recommend a randomly generated UUID (v4)..</param>
        /// <param name="body">Optional parameter: Request payload for suspending a subscription..</param>
        /// <returns>Returns the ApiResponse of Models.Subscription response from the API call.</returns>
        public ApiResponse<Models.Subscription> SuspendSubscription(
                Guid storeId,
                Guid subscriptionId,
                string idempotencyKey = null,
                Models.SubscriptionSuspendRequest body = null)
            => CoreHelper.RunTask(SuspendSubscriptionAsync(storeId, subscriptionId, idempotencyKey, body));

        /// <summary>
        /// Suspends a subscription that is currently `current` or `unpaid`. The `termination_mode` controls when the suspension takes effect: `immediate` (default) suspends right away, `on_next_payment` waits until the next scheduled payment date before suspending.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="subscriptionId">Required parameter: The unique identifier of the subscription..</param>
        /// <param name="idempotencyKey">Optional parameter: An optional idempotency key to prevent double charges and duplicate operations. We recommend a randomly generated UUID (v4)..</param>
        /// <param name="body">Optional parameter: Request payload for suspending a subscription..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.Subscription response from the API call.</returns>
        public async Task<ApiResponse<Models.Subscription>> SuspendSubscriptionAsync(
                Guid storeId,
                Guid subscriptionId,
                string idempotencyKey = null,
                Models.SubscriptionSuspendRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Subscription>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/stores/{storeId}/subscriptions/{subscriptionId}/suspend")
                  .WithAuth("JWT_TOKEN")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("storeId", storeId))
                      .Template(template => template.Setup("subscriptionId", subscriptionId))
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
        /// Resumes a subscription that is currently `suspended`, setting its status back to `unpaid` and rescheduling the next payment. No request body is required.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="subscriptionId">Required parameter: The unique identifier of the subscription..</param>
        /// <param name="idempotencyKey">Optional parameter: An optional idempotency key to prevent double charges and duplicate operations. We recommend a randomly generated UUID (v4)..</param>
        /// <returns>Returns the ApiResponse of Models.Subscription response from the API call.</returns>
        public ApiResponse<Models.Subscription> UnsuspendSubscription(
                Guid storeId,
                Guid subscriptionId,
                string idempotencyKey = null)
            => CoreHelper.RunTask(UnsuspendSubscriptionAsync(storeId, subscriptionId, idempotencyKey));

        /// <summary>
        /// Resumes a subscription that is currently `suspended`, setting its status back to `unpaid` and rescheduling the next payment. No request body is required.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="subscriptionId">Required parameter: The unique identifier of the subscription..</param>
        /// <param name="idempotencyKey">Optional parameter: An optional idempotency key to prevent double charges and duplicate operations. We recommend a randomly generated UUID (v4)..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.Subscription response from the API call.</returns>
        public async Task<ApiResponse<Models.Subscription>> UnsuspendSubscriptionAsync(
                Guid storeId,
                Guid subscriptionId,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Subscription>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/stores/{storeId}/subscriptions/{subscriptionId}/unsuspend")
                  .WithAuth("JWT_TOKEN")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("storeId", storeId))
                      .Template(template => template.Setup("subscriptionId", subscriptionId))
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
        /// Replaces the payment method (transaction token) used for a subscription. Useful when a card expires or a customer wants to switch payment methods. The new token must belong to the same store, be active, and match the subscription's processing mode (live/test). One-time tokens are not accepted; use a recurring or subscription token.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="subscriptionId">Required parameter: The unique identifier of the subscription..</param>
        /// <param name="body">Required parameter: Request payload for replacing a subscription payment token..</param>
        /// <param name="idempotencyKey">Optional parameter: An optional idempotency key to prevent double charges and duplicate operations. We recommend a randomly generated UUID (v4)..</param>
        /// <returns>Returns the ApiResponse of Models.Subscription response from the API call.</returns>
        public ApiResponse<Models.Subscription> UpdateSubscriptionToken(
                Guid storeId,
                Guid subscriptionId,
                Models.SubscriptionPatchTokenRequest body,
                string idempotencyKey = null)
            => CoreHelper.RunTask(UpdateSubscriptionTokenAsync(storeId, subscriptionId, body, idempotencyKey));

        /// <summary>
        /// Replaces the payment method (transaction token) used for a subscription. Useful when a card expires or a customer wants to switch payment methods. The new token must belong to the same store, be active, and match the subscription's processing mode (live/test). One-time tokens are not accepted; use a recurring or subscription token.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="subscriptionId">Required parameter: The unique identifier of the subscription..</param>
        /// <param name="body">Required parameter: Request payload for replacing a subscription payment token..</param>
        /// <param name="idempotencyKey">Optional parameter: An optional idempotency key to prevent double charges and duplicate operations. We recommend a randomly generated UUID (v4)..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.Subscription response from the API call.</returns>
        public async Task<ApiResponse<Models.Subscription>> UpdateSubscriptionTokenAsync(
                Guid storeId,
                Guid subscriptionId,
                Models.SubscriptionPatchTokenRequest body,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Subscription>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/stores/{storeId}/subscriptions/{subscriptionId}/token")
                  .WithAuth("JWT_TOKEN")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body).Required())
                      .Template(template => template.Setup("storeId", storeId))
                      .Template(template => template.Setup("subscriptionId", subscriptionId))
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
    }
}
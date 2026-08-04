// <copyright file="ChargesApi.cs" company="APIMatic">
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
    /// ChargesApi.
    /// </summary>
    public class ChargesApi : BaseApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChargesApi"/> class.
        /// </summary>
        internal ChargesApi(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Creates a charge on a payment instrument (e.g. transaction token).
        /// </summary>
        /// <param name="idempotencyKey">Optional parameter: An optional idempotency key to prevent double charges and duplicate operations. We recommend a randomly generated UUID (v4)..</param>
        /// <param name="body">Optional parameter: Request payload for creating a charge..</param>
        /// <returns>Returns the ApiResponse of Models.Charge response from the API call.</returns>
        public ApiResponse<Models.Charge> CreateCharge(
                string idempotencyKey = null,
                Models.ChargeCreateRequest body = null)
            => CoreHelper.RunTask(CreateChargeAsync(idempotencyKey, body));

        /// <summary>
        /// Creates a charge on a payment instrument (e.g. transaction token).
        /// </summary>
        /// <param name="idempotencyKey">Optional parameter: An optional idempotency key to prevent double charges and duplicate operations. We recommend a randomly generated UUID (v4)..</param>
        /// <param name="body">Optional parameter: Request payload for creating a charge..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.Charge response from the API call.</returns>
        public async Task<ApiResponse<Models.Charge>> CreateChargeAsync(
                string idempotencyKey = null,
                Models.ChargeCreateRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Charge>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/charges")
                  .WithAuth("JWT_TOKEN")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
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
        /// Lists all charges across all stores for the authenticated user.
        /// </summary>
        /// <param name="limit">Optional parameter: Maximum number of resources to return in one page..</param>
        /// <param name="cursor">Optional parameter: Cursor pointing to the resource after which pagination should continue..</param>
        /// <param name="cursorDirection">Optional parameter: Pagination direction relative to the supplied cursor..</param>
        /// <param name="lastFour">Optional parameter: Filter by the last 4 digits of the card.  **Note:** If specified, `name`, `exp_month`, and `exp_year` must also be included..</param>
        /// <param name="name">Optional parameter: Filter by cardholder name.  **Note:** If specified, `last_four`, `exp_month`, and `exp_year` must also be included..</param>
        /// <param name="expMonth">Optional parameter: Filter by expiration month.  **Note:** If specified, `last_four`, `name`, and `exp_year` must also be included..</param>
        /// <param name="expYear">Optional parameter: Filter by expiration year.  **Note:** If specified, `last_four`, `name`, and `exp_month` must also be included..</param>
        /// <param name="from">Optional parameter: Show charges created on or after this date (ISO-8601)..</param>
        /// <param name="to">Optional parameter: Show charges created before this date (ISO-8601)..</param>
        /// <param name="email">Optional parameter: Filter by email address..</param>
        /// <param name="phone">Optional parameter: Filter by phone number..</param>
        /// <param name="amountFrom">Optional parameter: Show charges with an amount greater than or equal to this value..</param>
        /// <param name="amountTo">Optional parameter: Show charges with an amount strictly less than this value..</param>
        /// <param name="currency">Optional parameter: Filter by currency (ISO-4217)..</param>
        /// <param name="mode">Optional parameter: Filter by environment mode..</param>
        /// <param name="metadata">Optional parameter: Filter by metadata..</param>
        /// <param name="transactionTokenId">Optional parameter: Filter by transaction token ID..</param>
        /// <returns>Returns the ApiResponse of Models.ChargeList response from the API call.</returns>
        public ApiResponse<Models.ChargeList> ListAllCharges(
                int? limit = 10,
                Guid? cursor = null,
                Models.CursorDirectionQuery? cursorDirection = Models.CursorDirectionQuery.Desc,
                string lastFour = null,
                string name = null,
                int? expMonth = null,
                int? expYear = null,
                string from = null,
                string to = null,
                string email = null,
                string phone = null,
                int? amountFrom = null,
                int? amountTo = null,
                string currency = null,
                Models.ModeQuery? mode = null,
                string metadata = null,
                Guid? transactionTokenId = null)
            => CoreHelper.RunTask(ListAllChargesAsync(limit, cursor, cursorDirection, lastFour, name, expMonth, expYear, from, to, email, phone, amountFrom, amountTo, currency, mode, metadata, transactionTokenId));

        /// <summary>
        /// Lists all charges across all stores for the authenticated user.
        /// </summary>
        /// <param name="limit">Optional parameter: Maximum number of resources to return in one page..</param>
        /// <param name="cursor">Optional parameter: Cursor pointing to the resource after which pagination should continue..</param>
        /// <param name="cursorDirection">Optional parameter: Pagination direction relative to the supplied cursor..</param>
        /// <param name="lastFour">Optional parameter: Filter by the last 4 digits of the card.  **Note:** If specified, `name`, `exp_month`, and `exp_year` must also be included..</param>
        /// <param name="name">Optional parameter: Filter by cardholder name.  **Note:** If specified, `last_four`, `exp_month`, and `exp_year` must also be included..</param>
        /// <param name="expMonth">Optional parameter: Filter by expiration month.  **Note:** If specified, `last_four`, `name`, and `exp_year` must also be included..</param>
        /// <param name="expYear">Optional parameter: Filter by expiration year.  **Note:** If specified, `last_four`, `name`, and `exp_month` must also be included..</param>
        /// <param name="from">Optional parameter: Show charges created on or after this date (ISO-8601)..</param>
        /// <param name="to">Optional parameter: Show charges created before this date (ISO-8601)..</param>
        /// <param name="email">Optional parameter: Filter by email address..</param>
        /// <param name="phone">Optional parameter: Filter by phone number..</param>
        /// <param name="amountFrom">Optional parameter: Show charges with an amount greater than or equal to this value..</param>
        /// <param name="amountTo">Optional parameter: Show charges with an amount strictly less than this value..</param>
        /// <param name="currency">Optional parameter: Filter by currency (ISO-4217)..</param>
        /// <param name="mode">Optional parameter: Filter by environment mode..</param>
        /// <param name="metadata">Optional parameter: Filter by metadata..</param>
        /// <param name="transactionTokenId">Optional parameter: Filter by transaction token ID..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.ChargeList response from the API call.</returns>
        public async Task<ApiResponse<Models.ChargeList>> ListAllChargesAsync(
                int? limit = 10,
                Guid? cursor = null,
                Models.CursorDirectionQuery? cursorDirection = Models.CursorDirectionQuery.Desc,
                string lastFour = null,
                string name = null,
                int? expMonth = null,
                int? expYear = null,
                string from = null,
                string to = null,
                string email = null,
                string phone = null,
                int? amountFrom = null,
                int? amountTo = null,
                string currency = null,
                Models.ModeQuery? mode = null,
                string metadata = null,
                Guid? transactionTokenId = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ChargeList>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/charges")
                  .WithAuth("JWT_TOKEN")
                  .Parameters(parameters => parameters
                      .Query(query => query.Setup("limit", limit ?? 10))
                      .Query(query => query.Setup("cursor", cursor))
                      .Query(query => query.Setup("cursor_direction", (cursorDirection.HasValue) ? CoreHelper.JsonSerialize(cursorDirection.Value).Trim('\"') : "desc"))
                      .Query(query => query.Setup("last_four", lastFour))
                      .Query(query => query.Setup("name", name))
                      .Query(query => query.Setup("exp_month", expMonth))
                      .Query(query => query.Setup("exp_year", expYear))
                      .Query(query => query.Setup("from", from))
                      .Query(query => query.Setup("to", to))
                      .Query(query => query.Setup("email", email))
                      .Query(query => query.Setup("phone", phone))
                      .Query(query => query.Setup("amount_from", amountFrom))
                      .Query(query => query.Setup("amount_to", amountTo))
                      .Query(query => query.Setup("currency", currency))
                      .Query(query => query.Setup("mode", (mode.HasValue) ? CoreHelper.JsonSerialize(mode.Value).Trim('\"') : null))
                      .Query(query => query.Setup("metadata", metadata))
                      .Query(query => query.Setup("transaction_token_id", transactionTokenId))))
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
        /// Lists all charges for a specific store.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="limit">Optional parameter: Maximum number of resources to return in one page..</param>
        /// <param name="cursor">Optional parameter: Cursor pointing to the resource after which pagination should continue..</param>
        /// <param name="cursorDirection">Optional parameter: Pagination direction relative to the supplied cursor..</param>
        /// <param name="lastFour">Optional parameter: Filter by the last 4 digits of the card.  **Note:** If specified, `name`, `exp_month`, and `exp_year` must also be included..</param>
        /// <param name="name">Optional parameter: Filter by cardholder name.  **Note:** If specified, `last_four`, `exp_month`, and `exp_year` must also be included..</param>
        /// <param name="expMonth">Optional parameter: Filter by expiration month.  **Note:** If specified, `last_four`, `name`, and `exp_year` must also be included..</param>
        /// <param name="expYear">Optional parameter: Filter by expiration year.  **Note:** If specified, `last_four`, `name`, and `exp_month` must also be included..</param>
        /// <param name="from">Optional parameter: Show charges created on or after this date (ISO-8601)..</param>
        /// <param name="to">Optional parameter: Show charges created before this date (ISO-8601)..</param>
        /// <param name="email">Optional parameter: Filter by email address..</param>
        /// <param name="phone">Optional parameter: Filter by phone number..</param>
        /// <param name="amountFrom">Optional parameter: Show charges with an amount greater than or equal to this value..</param>
        /// <param name="amountTo">Optional parameter: Show charges with an amount strictly less than this value..</param>
        /// <param name="currency">Optional parameter: Filter by currency (ISO-4217)..</param>
        /// <param name="mode">Optional parameter: Filter by environment mode..</param>
        /// <param name="metadata">Optional parameter: Filter by metadata..</param>
        /// <param name="transactionTokenId">Optional parameter: Filter by transaction token ID..</param>
        /// <returns>Returns the ApiResponse of Models.ChargeList response from the API call.</returns>
        public ApiResponse<Models.ChargeList> ListStoreCharges(
                Guid storeId,
                int? limit = 10,
                Guid? cursor = null,
                Models.CursorDirectionQuery? cursorDirection = Models.CursorDirectionQuery.Desc,
                string lastFour = null,
                string name = null,
                int? expMonth = null,
                int? expYear = null,
                string from = null,
                string to = null,
                string email = null,
                string phone = null,
                int? amountFrom = null,
                int? amountTo = null,
                string currency = null,
                Models.ModeQuery? mode = null,
                string metadata = null,
                Guid? transactionTokenId = null)
            => CoreHelper.RunTask(ListStoreChargesAsync(storeId, limit, cursor, cursorDirection, lastFour, name, expMonth, expYear, from, to, email, phone, amountFrom, amountTo, currency, mode, metadata, transactionTokenId));

        /// <summary>
        /// Lists all charges for a specific store.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="limit">Optional parameter: Maximum number of resources to return in one page..</param>
        /// <param name="cursor">Optional parameter: Cursor pointing to the resource after which pagination should continue..</param>
        /// <param name="cursorDirection">Optional parameter: Pagination direction relative to the supplied cursor..</param>
        /// <param name="lastFour">Optional parameter: Filter by the last 4 digits of the card.  **Note:** If specified, `name`, `exp_month`, and `exp_year` must also be included..</param>
        /// <param name="name">Optional parameter: Filter by cardholder name.  **Note:** If specified, `last_four`, `exp_month`, and `exp_year` must also be included..</param>
        /// <param name="expMonth">Optional parameter: Filter by expiration month.  **Note:** If specified, `last_four`, `name`, and `exp_year` must also be included..</param>
        /// <param name="expYear">Optional parameter: Filter by expiration year.  **Note:** If specified, `last_four`, `name`, and `exp_month` must also be included..</param>
        /// <param name="from">Optional parameter: Show charges created on or after this date (ISO-8601)..</param>
        /// <param name="to">Optional parameter: Show charges created before this date (ISO-8601)..</param>
        /// <param name="email">Optional parameter: Filter by email address..</param>
        /// <param name="phone">Optional parameter: Filter by phone number..</param>
        /// <param name="amountFrom">Optional parameter: Show charges with an amount greater than or equal to this value..</param>
        /// <param name="amountTo">Optional parameter: Show charges with an amount strictly less than this value..</param>
        /// <param name="currency">Optional parameter: Filter by currency (ISO-4217)..</param>
        /// <param name="mode">Optional parameter: Filter by environment mode..</param>
        /// <param name="metadata">Optional parameter: Filter by metadata..</param>
        /// <param name="transactionTokenId">Optional parameter: Filter by transaction token ID..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.ChargeList response from the API call.</returns>
        public async Task<ApiResponse<Models.ChargeList>> ListStoreChargesAsync(
                Guid storeId,
                int? limit = 10,
                Guid? cursor = null,
                Models.CursorDirectionQuery? cursorDirection = Models.CursorDirectionQuery.Desc,
                string lastFour = null,
                string name = null,
                int? expMonth = null,
                int? expYear = null,
                string from = null,
                string to = null,
                string email = null,
                string phone = null,
                int? amountFrom = null,
                int? amountTo = null,
                string currency = null,
                Models.ModeQuery? mode = null,
                string metadata = null,
                Guid? transactionTokenId = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ChargeList>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/stores/{storeId}/charges")
                  .WithAuth("JWT_TOKEN")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("storeId", storeId))
                      .Query(query => query.Setup("limit", limit ?? 10))
                      .Query(query => query.Setup("cursor", cursor))
                      .Query(query => query.Setup("cursor_direction", (cursorDirection.HasValue) ? CoreHelper.JsonSerialize(cursorDirection.Value).Trim('\"') : "desc"))
                      .Query(query => query.Setup("last_four", lastFour))
                      .Query(query => query.Setup("name", name))
                      .Query(query => query.Setup("exp_month", expMonth))
                      .Query(query => query.Setup("exp_year", expYear))
                      .Query(query => query.Setup("from", from))
                      .Query(query => query.Setup("to", to))
                      .Query(query => query.Setup("email", email))
                      .Query(query => query.Setup("phone", phone))
                      .Query(query => query.Setup("amount_from", amountFrom))
                      .Query(query => query.Setup("amount_to", amountTo))
                      .Query(query => query.Setup("currency", currency))
                      .Query(query => query.Setup("mode", (mode.HasValue) ? CoreHelper.JsonSerialize(mode.Value).Trim('\"') : null))
                      .Query(query => query.Setup("metadata", metadata))
                      .Query(query => query.Setup("transaction_token_id", transactionTokenId))))
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
        /// Retrieves the details of an existing charge.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="id">Required parameter: The unique identifier of the resource..</param>
        /// <param name="polling">Optional parameter: If set to true, instructs the API to internally poll the charge status  until it changes from 'pending' (the initial status) to another status..</param>
        /// <returns>Returns the ApiResponse of Models.Charge response from the API call.</returns>
        public ApiResponse<Models.Charge> GetCharge(
                Guid storeId,
                Guid id,
                bool? polling = null)
            => CoreHelper.RunTask(GetChargeAsync(storeId, id, polling));

        /// <summary>
        /// Retrieves the details of an existing charge.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="id">Required parameter: The unique identifier of the resource..</param>
        /// <param name="polling">Optional parameter: If set to true, instructs the API to internally poll the charge status  until it changes from 'pending' (the initial status) to another status..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.Charge response from the API call.</returns>
        public async Task<ApiResponse<Models.Charge>> GetChargeAsync(
                Guid storeId,
                Guid id,
                bool? polling = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Charge>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/stores/{storeId}/charges/{id}")
                  .WithAuth("JWT_TOKEN")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("storeId", storeId))
                      .Template(template => template.Setup("id", id))
                      .Query(query => query.Setup("polling", polling))))
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
        /// Use this request to add or modify arbitrary metadata on an existing charge.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="id">Required parameter: The unique identifier of the resource..</param>
        /// <param name="idempotencyKey">Optional parameter: An optional idempotency key to prevent double charges and duplicate operations. We recommend a randomly generated UUID (v4)..</param>
        /// <param name="body">Optional parameter: Request payload for updating charge metadata..</param>
        /// <returns>Returns the ApiResponse of Models.Charge response from the API call.</returns>
        public ApiResponse<Models.Charge> UpdateCharge(
                Guid storeId,
                Guid id,
                string idempotencyKey = null,
                Models.ChargeUpdateRequest body = null)
            => CoreHelper.RunTask(UpdateChargeAsync(storeId, id, idempotencyKey, body));

        /// <summary>
        /// Use this request to add or modify arbitrary metadata on an existing charge.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="id">Required parameter: The unique identifier of the resource..</param>
        /// <param name="idempotencyKey">Optional parameter: An optional idempotency key to prevent double charges and duplicate operations. We recommend a randomly generated UUID (v4)..</param>
        /// <param name="body">Optional parameter: Request payload for updating charge metadata..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.Charge response from the API call.</returns>
        public async Task<ApiResponse<Models.Charge>> UpdateChargeAsync(
                Guid storeId,
                Guid id,
                string idempotencyKey = null,
                Models.ChargeUpdateRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Charge>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/stores/{storeId}/charges/{id}")
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
        /// Captures a previously authorized charge (where `capture` was set to false during creation).  The capture amount must be less than or equal to the authorized amount, and the currency must match.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="id">Required parameter: The unique identifier of the resource..</param>
        /// <param name="body">Required parameter: Request payload for capturing an authorized charge..</param>
        /// <param name="idempotencyKey">Optional parameter: An optional idempotency key to prevent double charges and duplicate operations. We recommend a randomly generated UUID (v4)..</param>
        /// <returns>Returns the ApiResponse of object response from the API call.</returns>
        public ApiResponse<object> CaptureCharge(
                Guid storeId,
                Guid id,
                Models.ChargeCaptureRequest body,
                string idempotencyKey = null)
            => CoreHelper.RunTask(CaptureChargeAsync(storeId, id, body, idempotencyKey));

        /// <summary>
        /// Captures a previously authorized charge (where `capture` was set to false during creation).  The capture amount must be less than or equal to the authorized amount, and the currency must match.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="id">Required parameter: The unique identifier of the resource..</param>
        /// <param name="body">Required parameter: Request payload for capturing an authorized charge..</param>
        /// <param name="idempotencyKey">Optional parameter: An optional idempotency key to prevent double charges and duplicate operations. We recommend a randomly generated UUID (v4)..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of object response from the API call.</returns>
        public async Task<ApiResponse<object>> CaptureChargeAsync(
                Guid storeId,
                Guid id,
                Models.ChargeCaptureRequest body,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<object>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/stores/{storeId}/charges/{id}/capture")
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
                  .ErrorCase("429", CreateErrorCase("HTTP 429 Rate Limited: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("409", CreateErrorCase("HTTP 409 Conflict: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("500", CreateErrorCase("HTTP 500 Server Error: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("503", CreateErrorCase("HTTP 503 Unavailable: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("504", CreateErrorCase("HTTP 504 Timeout: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("0", CreateErrorCase("HTTP {$statusCode}: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .Deserializer(response => response))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Retrieves the necessary payment execution URL (for online payments) or bank account details (for bank transfers).
        /// **⚠️ Prerequisite:** The charge `status` must be `awaiting` before requesting the issuer token.  If requested while the charge is in any other status, an error will be returned.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="id">Required parameter: The unique identifier of the resource..</param>
        /// <returns>Returns the ApiResponse of Models.IssuerToken response from the API call.</returns>
        public ApiResponse<Models.IssuerToken> GetChargeIssuerToken(
                Guid storeId,
                Guid id)
            => CoreHelper.RunTask(GetChargeIssuerTokenAsync(storeId, id));

        /// <summary>
        /// Retrieves the necessary payment execution URL (for online payments) or bank account details (for bank transfers).
        /// **⚠️ Prerequisite:** The charge `status` must be `awaiting` before requesting the issuer token.  If requested while the charge is in any other status, an error will be returned.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="id">Required parameter: The unique identifier of the resource..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.IssuerToken response from the API call.</returns>
        public async Task<ApiResponse<Models.IssuerToken>> GetChargeIssuerTokenAsync(
                Guid storeId,
                Guid id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.IssuerToken>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/stores/{storeId}/charges/{id}/issuer_token")
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
        /// Retrieves the 3-D Secure issuer token details required to authenticate a card charge.
        /// **⚠️ Prerequisites:** 1. The charge must be created with `three_ds.mode` set to `normal` or `force`. 2. You must poll the charge until its `status` becomes `awaiting` before making this request.
        /// **Execution Flow:** Once retrieved, the client (browser) must execute an `http_post` request to the `issuer_token` URL.  The `payload` object must be formatted according to the `content_type` (e.g., URL-encoded) and sent in the body. You can execute this via a redirect or inside an iframe. If using an iframe, continue polling the charge status  in the background until it reaches `successful`, `failed`, or `error`.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="id">Required parameter: The unique identifier of the resource..</param>
        /// <returns>Returns the ApiResponse of Models.ThreeDsIssuerToken response from the API call.</returns>
        public ApiResponse<Models.ThreeDsIssuerToken> GetChargeThreeDsIssuerToken(
                Guid storeId,
                Guid id)
            => CoreHelper.RunTask(GetChargeThreeDsIssuerTokenAsync(storeId, id));

        /// <summary>
        /// Retrieves the 3-D Secure issuer token details required to authenticate a card charge.
        /// **⚠️ Prerequisites:** 1. The charge must be created with `three_ds.mode` set to `normal` or `force`. 2. You must poll the charge until its `status` becomes `awaiting` before making this request.
        /// **Execution Flow:** Once retrieved, the client (browser) must execute an `http_post` request to the `issuer_token` URL.  The `payload` object must be formatted according to the `content_type` (e.g., URL-encoded) and sent in the body. You can execute this via a redirect or inside an iframe. If using an iframe, continue polling the charge status  in the background until it reaches `successful`, `failed`, or `error`.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="id">Required parameter: The unique identifier of the resource..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.ThreeDsIssuerToken response from the API call.</returns>
        public async Task<ApiResponse<Models.ThreeDsIssuerToken>> GetChargeThreeDsIssuerTokenAsync(
                Guid storeId,
                Guid id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ThreeDsIssuerToken>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/stores/{storeId}/charges/{id}/three_ds/issuer_token")
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
        /// Retrieves bank transfer ledger entries associated with a charge. This is an optional reconciliation endpoint — not part of the required create-charge-and-poll flow.
        /// **⚠️ Requires a merchant-level application token**, unlike the rest of the bank transfer flow. A store application token (`Bearer {secret}.{jwt}` scoped to a `store_id`) is not sufficient here, even though the path is store-scoped.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="id">Required parameter: The unique identifier of the resource..</param>
        /// <returns>Returns the ApiResponse of Models.BankTransferLedgerList response from the API call.</returns>
        public ApiResponse<Models.BankTransferLedgerList> ListBankTransferLedgers(
                Guid storeId,
                Guid id)
            => CoreHelper.RunTask(ListBankTransferLedgersAsync(storeId, id));

        /// <summary>
        /// Retrieves bank transfer ledger entries associated with a charge. This is an optional reconciliation endpoint — not part of the required create-charge-and-poll flow.
        /// **⚠️ Requires a merchant-level application token**, unlike the rest of the bank transfer flow. A store application token (`Bearer {secret}.{jwt}` scoped to a `store_id`) is not sufficient here, even though the path is store-scoped.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="id">Required parameter: The unique identifier of the resource..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.BankTransferLedgerList response from the API call.</returns>
        public async Task<ApiResponse<Models.BankTransferLedgerList>> ListBankTransferLedgersAsync(
                Guid storeId,
                Guid id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.BankTransferLedgerList>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/stores/{storeId}/charges/{id}/bank_transfer_ledgers")
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
        /// Creates a customs declaration for a successful charge. Backend only accepts this request for WeChat Online and WeChat MPM charges. If a declaration already exists and is no longer pending, the backend updates its identity fields and restarts processing instead of creating a new record.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="chargeId">Required parameter: The unique identifier of the charge..</param>
        /// <param name="body">Required parameter: Request payload for creating a customs declaration..</param>
        /// <param name="idempotencyKey">Optional parameter: An optional idempotency key to prevent double charges and duplicate operations. We recommend a randomly generated UUID (v4)..</param>
        /// <returns>Returns the ApiResponse of Models.CustomsDeclarationWebhookData response from the API call.</returns>
        public ApiResponse<Models.CustomsDeclarationWebhookData> CreateCustomsDeclaration(
                Guid storeId,
                Guid chargeId,
                Models.CustomsDeclarationCreateRequest body,
                string idempotencyKey = null)
            => CoreHelper.RunTask(CreateCustomsDeclarationAsync(storeId, chargeId, body, idempotencyKey));

        /// <summary>
        /// Creates a customs declaration for a successful charge. Backend only accepts this request for WeChat Online and WeChat MPM charges. If a declaration already exists and is no longer pending, the backend updates its identity fields and restarts processing instead of creating a new record.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="chargeId">Required parameter: The unique identifier of the charge..</param>
        /// <param name="body">Required parameter: Request payload for creating a customs declaration..</param>
        /// <param name="idempotencyKey">Optional parameter: An optional idempotency key to prevent double charges and duplicate operations. We recommend a randomly generated UUID (v4)..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.CustomsDeclarationWebhookData response from the API call.</returns>
        public async Task<ApiResponse<Models.CustomsDeclarationWebhookData>> CreateCustomsDeclarationAsync(
                Guid storeId,
                Guid chargeId,
                Models.CustomsDeclarationCreateRequest body,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CustomsDeclarationWebhookData>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/stores/{storeId}/charges/{chargeId}/customs")
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
        /// Retrieves a customs declaration for a charge. Supports long polling when `polling=true`, returning once the declaration leaves its current state or the polling timeout is reached.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="chargeId">Required parameter: The unique identifier of the charge..</param>
        /// <param name="id">Required parameter: The unique identifier of the customs declaration..</param>
        /// <param name="polling">Optional parameter: Hold the request open while waiting for a status change..</param>
        /// <returns>Returns the ApiResponse of Models.CustomsDeclarationWebhookData response from the API call.</returns>
        public ApiResponse<Models.CustomsDeclarationWebhookData> GetCustomsDeclaration(
                Guid storeId,
                Guid chargeId,
                Guid id,
                bool? polling = false)
            => CoreHelper.RunTask(GetCustomsDeclarationAsync(storeId, chargeId, id, polling));

        /// <summary>
        /// Retrieves a customs declaration for a charge. Supports long polling when `polling=true`, returning once the declaration leaves its current state or the polling timeout is reached.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="chargeId">Required parameter: The unique identifier of the charge..</param>
        /// <param name="id">Required parameter: The unique identifier of the customs declaration..</param>
        /// <param name="polling">Optional parameter: Hold the request open while waiting for a status change..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.CustomsDeclarationWebhookData response from the API call.</returns>
        public async Task<ApiResponse<Models.CustomsDeclarationWebhookData>> GetCustomsDeclarationAsync(
                Guid storeId,
                Guid chargeId,
                Guid id,
                bool? polling = false,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CustomsDeclarationWebhookData>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/stores/{storeId}/charges/{chargeId}/customs/{id}")
                  .WithAuth("JWT_TOKEN")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("storeId", storeId))
                      .Template(template => template.Setup("chargeId", chargeId))
                      .Template(template => template.Setup("id", id))
                      .Query(query => query.Setup("polling", polling ?? false))))
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
        /// Updates a customs declaration and requeues processing. Backend patching preserves the original `customs`, `certificate_id`, and `certificate_name` values and only accepts a new `merchant_customs_no`. Pending declarations cannot be patched.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="chargeId">Required parameter: The unique identifier of the charge..</param>
        /// <param name="id">Required parameter: The unique identifier of the customs declaration..</param>
        /// <param name="body">Required parameter: Request payload for patching a customs declaration..</param>
        /// <param name="idempotencyKey">Optional parameter: An optional idempotency key to prevent double charges and duplicate operations. We recommend a randomly generated UUID (v4)..</param>
        /// <returns>Returns the ApiResponse of Models.CustomsDeclarationWebhookData response from the API call.</returns>
        public ApiResponse<Models.CustomsDeclarationWebhookData> PatchCustomsDeclaration(
                Guid storeId,
                Guid chargeId,
                Guid id,
                Models.CustomsDeclarationPatchRequest body,
                string idempotencyKey = null)
            => CoreHelper.RunTask(PatchCustomsDeclarationAsync(storeId, chargeId, id, body, idempotencyKey));

        /// <summary>
        /// Updates a customs declaration and requeues processing. Backend patching preserves the original `customs`, `certificate_id`, and `certificate_name` values and only accepts a new `merchant_customs_no`. Pending declarations cannot be patched.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="chargeId">Required parameter: The unique identifier of the charge..</param>
        /// <param name="id">Required parameter: The unique identifier of the customs declaration..</param>
        /// <param name="body">Required parameter: Request payload for patching a customs declaration..</param>
        /// <param name="idempotencyKey">Optional parameter: An optional idempotency key to prevent double charges and duplicate operations. We recommend a randomly generated UUID (v4)..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.CustomsDeclarationWebhookData response from the API call.</returns>
        public async Task<ApiResponse<Models.CustomsDeclarationWebhookData>> PatchCustomsDeclarationAsync(
                Guid storeId,
                Guid chargeId,
                Guid id,
                Models.CustomsDeclarationPatchRequest body,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CustomsDeclarationWebhookData>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/stores/{storeId}/charges/{chargeId}/customs/{id}")
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
                  .ErrorCase("429", CreateErrorCase("HTTP 429 Rate Limited: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("409", CreateErrorCase("HTTP 409 Conflict: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("500", CreateErrorCase("HTTP 500 Server Error: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("503", CreateErrorCase("HTTP 503 Unavailable: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("504", CreateErrorCase("HTTP 504 Timeout: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("0", CreateErrorCase("HTTP {$statusCode}: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}
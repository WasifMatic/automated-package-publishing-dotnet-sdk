// <copyright file="TransactionTokensApiTest.cs" company="APIMatic">
// UnivapayClientSdk.Tests
//
// This file was automatically generated for Univapay by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;
using APIMatic.Core.Utilities;
using NUnit.Framework;
using Newtonsoft.Json.Converters;
using UnivaPay;
using UnivaPay.Apis;
using UnivaPay.Exceptions;
using UnivaPay.Http.Client;
using UnivaPay.Http.Response;
using UnivaPay.Models.Containers;
using UnivaPay.Utilities;

namespace UnivaPay
{
    /// <summary>
    /// TransactionTokensApiTest.
    /// </summary>
    [TestFixture]
    public class TransactionTokensApiTest : ApiTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private TransactionTokensApi controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.TransactionTokensApi;
        }

        /// <summary>
        /// Exchange raw payment data for a secure token. **PCI DSS Compliance Required** if sending raw card numbers..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestCreateTransactionToken()
        {
            // Parameters for the API call
            Models.TransactionTokenCreateRequest body = ApiHelper.JsonDeserialize<Models.TransactionTokenCreateRequest>("{\"payment_type\":\"card\",\"type\":\"recurring\",\"email\":\"test@univapay.com\",\"metadata\":{\"univapay-phone-number\":\"+81 08012341234\"},\"data\":{\"cardholder\":\"TEST TEST\",\"card_number\":\"4242424242424242\",\"exp_month\":\"09\",\"exp_year\":\"26\",\"cvv\":\"123\",\"phone_number\":{\"country_code\":\"81\",\"local_number\":\"08012341234\"},\"three_ds\":{\"redirect_endpoint\":\"https://univapay.com/redirect/index.html\"},\"cvv_authorize\":{\"enabled\":false,\"currency\":\"JPY\"}}}");
            string idempotencyKey = "f64be872-353d-4c3c-84cb-3dc617fe89f7";

            // Perform API call
            ApiResponse<Models.TransactionToken> result = null;
            try
            {
                result = await this.controller.CreateTransactionTokenAsync(body, idempotencyKey);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(201, HttpCallBack.Response.StatusCode, "Status should be 201");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/json");

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsProperSubsetOf(
                    "{\"id\":\"11f11e85-e9e9-b198-b990-c3a715943241\",\"store_id\":\"11f0e274-1e3b-4752-9513-33d3e07ede13\",\"email\":\"test@test.com\",\"payment_type\":\"card\",\"active\":true,\"mode\":\"live\",\"type\":\"recurring\",\"usage_limit\":null,\"confirmed\":null,\"metadata\":{\"univapay-link-id\":\"11f11e85-1b45-dace-bf3d-cbcae52f65fc\",\"univapay-name\":\"test\",\"univapay-phone-number\":\"+81 08012341234\"},\"created_on\":\"2026-03-13T02:39:52.908468Z\",\"updated_on\":\"2026-03-13T02:39:52.908468Z\",\"last_used_on\":null,\"data\":{\"card\":{\"cardholder\":\"TEST TEST\",\"exp_month\":9,\"exp_year\":2026,\"card_bin\":\"424242\",\"last_four\":\"424242\",\"brand\":\"visa\",\"card_type\":\"credit\",\"country\":\"JP\",\"category\":\"standard\",\"issuer\":\"issuer\",\"sub_brand\":\"none\"},\"billing\":{\"line1\":null,\"line2\":null,\"state\":null,\"city\":null,\"country\":null,\"zip\":null,\"phone_number\":{\"country_code\":81,\"local_number\":\"08012341234\"}},\"cvv_authorize\":{\"enabled\":false,\"status\":null,\"charge_id\":null,\"credentials_id\":null,\"currency\":null},\"cvv_authorize_check\":{\"status\":null,\"charge_id\":null,\"date\":null},\"three_ds\":{\"enabled\":true,\"status\":\"pending\",\"redirect_endpoint\":\"https://univapay.com/redirect/index.html\",\"error\":null,\"exempted\":false}}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Lists all transaction tokens across all stores..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestListAllTransactionTokens()
        {
            // Parameters for the API call
            int? limit = 10;
            Guid? cursor = Guid.Parse("3541d4fa-596d-428e-8a36-f274e1b3d505");
            Models.CursorDirectionQuery cursorDirection = ApiHelper.JsonDeserialize<Models.CursorDirectionQuery>("\"desc\"");

            // Perform API call
            ApiResponse<Models.TransactionTokenList> result = null;
            try
            {
                result = await this.controller.ListAllTransactionTokensAsync(limit, cursor, cursorDirection);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/json");

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsProperSubsetOf(
                    "{\"items\":[{\"id\":\"2fe23e45-f95d-4c95-9963-739070096443\",\"store_id\":\"79e9504e-96d8-46ed-8d22-2e8b36238605\",\"merchant_name\":\"Test Merchant\",\"store_name\":\"Tokyo Store\",\"email\":\"taro@example.com\",\"payment_type\":\"card\",\"active\":true,\"mode\":\"live\",\"type\":\"recurring\",\"created_on\":\"2026-04-09T07:35:50Z\",\"updated_on\":\"2026-04-09T07:35:50Z\",\"user_data\":{\"cardholder_name\":\"TARO YAMADA\",\"email\":\"taro@example.com\"}},{\"id\":\"3af34f56-a06e-4d06-aa74-84a181107554\",\"store_id\":\"8bfa615f-a7e9-47fe-9e33-3f9c47349716\",\"merchant_name\":\"Test Merchant\",\"store_name\":\"Osaka Store\",\"email\":\"hanako@example.com\",\"payment_type\":\"card\",\"active\":true,\"mode\":\"live\",\"type\":\"one_time\",\"created_on\":\"2026-04-10T10:20:11Z\",\"updated_on\":\"2026-04-10T10:20:11Z\",\"user_data\":{\"cardholder_name\":\"HANAKO SUZUKI\",\"email\":\"hanako@example.com\"}},{\"id\":\"4bf45e67-b17f-4e17-bb85-95b292218665\",\"store_id\":\"79e9504e-96d8-46ed-8d22-2e8b36238605\",\"merchant_name\":\"Test Merchant\",\"store_name\":\"Tokyo Store\",\"email\":\"jiro@example.com\",\"payment_type\":\"card\",\"active\":false,\"mode\":\"live\",\"type\":\"subscription\",\"created_on\":\"2026-04-11T18:05:42Z\",\"updated_on\":\"2026-04-12T08:31:09Z\",\"user_data\":{\"cardholder_name\":\"JIRO TANAKA\",\"email\":\"jiro@example.com\"}}],\"has_more\":false,\"total_hits\":3}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Lists all transaction tokens for a specific store..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestListStoreTransactionTokens()
        {
            // Parameters for the API call
            Guid storeId = Guid.Parse("0cab399b-5621-425b-993b-f8507eba1e78");
            int? limit = 10;
            Guid? cursor = Guid.Parse("3541d4fa-596d-428e-8a36-f274e1b3d505");
            Models.CursorDirectionQuery cursorDirection = ApiHelper.JsonDeserialize<Models.CursorDirectionQuery>("\"desc\"");

            // Perform API call
            ApiResponse<Models.TransactionTokenList> result = null;
            try
            {
                result = await this.controller.ListStoreTransactionTokensAsync(storeId, limit, cursor, cursorDirection);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/json");

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsProperSubsetOf(
                    "{\"items\":[{\"id\":\"2fe23e45-f95d-4c95-9963-739070096443\",\"store_id\":\"79e9504e-96d8-46ed-8d22-2e8b36238605\",\"merchant_name\":\"Test Merchant\",\"store_name\":\"Tokyo Store\",\"email\":\"taro@example.com\",\"payment_type\":\"card\",\"active\":true,\"mode\":\"live\",\"type\":\"recurring\",\"created_on\":\"2026-04-09T07:35:50Z\",\"updated_on\":\"2026-04-09T07:35:50Z\",\"user_data\":{\"cardholder_name\":\"TARO YAMADA\",\"email\":\"taro@example.com\"}},{\"id\":\"5cf56e78-c28a-4f28-cc96-06c303329776\",\"store_id\":\"79e9504e-96d8-46ed-8d22-2e8b36238605\",\"merchant_name\":\"Test Merchant\",\"store_name\":\"Tokyo Store\",\"email\":\"saburo@example.com\",\"payment_type\":\"card\",\"active\":true,\"mode\":\"live\",\"type\":\"one_time\",\"created_on\":\"2026-04-10T12:14:00Z\",\"updated_on\":\"2026-04-10T12:14:00Z\",\"user_data\":{\"cardholder_name\":\"SABURO KATO\",\"email\":\"saburo@example.com\"}},{\"id\":\"6df67e89-d39a-4039-dd07-17d414430887\",\"store_id\":\"79e9504e-96d8-46ed-8d22-2e8b36238605\",\"merchant_name\":\"Test Merchant\",\"store_name\":\"Tokyo Store\",\"email\":\"shiro@example.com\",\"payment_type\":\"card\",\"active\":true,\"mode\":\"live\",\"type\":\"subscription\",\"created_on\":\"2026-04-11T16:48:23Z\",\"updated_on\":\"2026-04-11T16:48:23Z\",\"user_data\":{\"cardholder_name\":\"SHIRO ITO\",\"email\":\"shiro@example.com\"}}],\"has_more\":false,\"total_hits\":3}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Retrieves the details of an existing transaction token..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetTransactionToken()
        {
            // Parameters for the API call
            Guid storeId = Guid.Parse("0cab399b-5621-425b-993b-f8507eba1e78");
            Guid id = Guid.Parse("c4e87129-cad4-47fb-8ded-b4c0a4ae0dd4");

            // Perform API call
            ApiResponse<Models.TransactionToken> result = null;
            try
            {
                result = await this.controller.GetTransactionTokenAsync(storeId, id);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/json");

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsProperSubsetOf(
                    "{\"id\":\"11f11e85-e9e9-b198-b990-c3a715943241\",\"store_id\":\"11f0e274-1e3b-4752-9513-33d3e07ede13\",\"email\":\"test@test.com\",\"payment_type\":\"card\",\"active\":true,\"mode\":\"live\",\"type\":\"recurring\",\"usage_limit\":null,\"confirmed\":null,\"metadata\":{\"univapay-link-id\":\"11f11e85-1b45-dace-bf3d-cbcae52f65fc\",\"univapay-name\":\"test\",\"univapay-phone-number\":\"+81 08012341234\"},\"created_on\":\"2026-03-13T02:39:52.908468Z\",\"updated_on\":\"2026-03-13T02:39:52.908468Z\",\"last_used_on\":null,\"data\":{\"card\":{\"cardholder\":\"TEST TEST\",\"exp_month\":9,\"exp_year\":2026,\"card_bin\":\"424242\",\"last_four\":\"424242\",\"brand\":\"visa\",\"card_type\":\"credit\",\"country\":\"JP\",\"category\":\"standard\",\"issuer\":\"issuer\",\"sub_brand\":\"none\"},\"billing\":{\"line1\":null,\"line2\":null,\"state\":null,\"city\":null,\"country\":null,\"zip\":null,\"phone_number\":{\"country_code\":81,\"local_number\":\"08012341234\"}},\"cvv_authorize\":{\"enabled\":false,\"status\":null,\"charge_id\":null,\"credentials_id\":null,\"currency\":null},\"cvv_authorize_check\":{\"status\":null,\"charge_id\":null,\"date\":null},\"three_ds\":{\"enabled\":true,\"status\":\"pending\",\"redirect_endpoint\":\"https://univapay.com/redirect/index.html\",\"error\":null,\"exempted\":false}}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// ⚠️ **LEGACY WARNING: Discouraged Operation**
        ///While it is technically possible to update a transaction token, this practice is highly discouraged and is maintained solely for legacy reasons. 
        ///**Updating raw card details requires your server environment to be fully PCI DSS compliant.**
        ///**Recommended Approach:** Instead of updating an existing token, it is best practice to create an entirely new transaction token using Univapay's frontend integrations (**Link Form**, **Widget**, or **Inline Form**). This allows Univapay to securely handle the customer's payment data without it ever touching your servers.
        ///--- **Legacy Usage:** Updates CVV, Address, Email, or Card Details.  *Note: If updating only the CVV to resolve a `RECURRING_USAGE_REQUIRES_CVV` error, the application token secret is not required.*.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestUpdateTransactionToken()
        {
            // Parameters for the API call
            Guid storeId = Guid.Parse("0cab399b-5621-425b-993b-f8507eba1e78");
            Guid id = Guid.Parse("c4e87129-cad4-47fb-8ded-b4c0a4ae0dd4");
            string idempotencyKey = "f64be872-353d-4c3c-84cb-3dc617fe89f7";
            Models.TransactionTokenUpdateRequest body = ApiHelper.JsonDeserialize<Models.TransactionTokenUpdateRequest>("{\"email\":\"test.update@test.com\",\"data\":{\"cardholder\":\"TARO YAMADA\",\"card_number\":\"4000020000000000\",\"exp_month\":12,\"exp_year\":2099,\"cvv\":\"123\",\"line1\":\"11111\",\"line2\":\"222\",\"state\":\"Tokyo\",\"city\":\"テスト区一丁目\",\"country\":\"JP\",\"zip\":\"1234567\",\"phone_number\":{\"country_code\":\"81\",\"local_number\":\"08000000000\"}}}");

            // Perform API call
            ApiResponse<Models.TransactionToken> result = null;
            try
            {
                result = await this.controller.UpdateTransactionTokenAsync(storeId, id, idempotencyKey, body);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/json");

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsProperSubsetOf(
                    "{\"id\":\"11f11e85-e9e9-b198-b990-c3a715943241\",\"store_id\":\"11f0e274-1e3b-4752-9513-33d3e07ede13\",\"email\":\"test@test.com\",\"payment_type\":\"card\",\"active\":true,\"mode\":\"live\",\"type\":\"recurring\",\"usage_limit\":null,\"confirmed\":null,\"metadata\":{\"univapay-link-id\":\"11f11e85-1b45-dace-bf3d-cbcae52f65fc\",\"univapay-name\":\"test\",\"univapay-phone-number\":\"+81 08012341234\"},\"created_on\":\"2026-03-13T02:39:52.908468Z\",\"updated_on\":\"2026-03-13T02:39:52.908468Z\",\"last_used_on\":null,\"data\":{\"card\":{\"cardholder\":\"TEST TEST\",\"exp_month\":9,\"exp_year\":2026,\"card_bin\":\"424242\",\"last_four\":\"424242\",\"brand\":\"visa\",\"card_type\":\"credit\",\"country\":\"JP\",\"category\":\"standard\",\"issuer\":\"issuer\",\"sub_brand\":\"none\"},\"billing\":{\"line1\":null,\"line2\":null,\"state\":null,\"city\":null,\"country\":null,\"zip\":null,\"phone_number\":{\"country_code\":81,\"local_number\":\"08012341234\"}},\"cvv_authorize\":{\"enabled\":false,\"status\":null,\"charge_id\":null,\"credentials_id\":null,\"currency\":null},\"cvv_authorize_check\":{\"status\":null,\"charge_id\":null,\"date\":null},\"three_ds\":{\"enabled\":true,\"status\":\"pending\",\"redirect_endpoint\":\"https://univapay.com/redirect/index.html\",\"error\":null,\"exempted\":false}}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Deletes a specific transaction token. 
        ///⚠️ **WARNING: Breaks Linked Subscriptions**
        ///Please note that deleting a transaction token will immediately prevent any linked recurring charges or subscriptions from being processed. Proceed with caution..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestDeleteTransactionToken()
        {
            // Parameters for the API call
            Guid storeId = Guid.Parse("0cab399b-5621-425b-993b-f8507eba1e78");
            Guid id = Guid.Parse("c4e87129-cad4-47fb-8ded-b4c0a4ae0dd4");

            // Perform API call
            try
            {
                await this.controller.DeleteTransactionTokenAsync(storeId, id);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(204, HttpCallBack.Response.StatusCode, "Status should be 204");
        }

        /// <summary>
        /// Retrieves the information required to execute 3-D Secure authentication when creating a recurring transaction token.
        ///**⚠️ Important Notes:** 1. **PCI DSS Compliance:** This endpoint is only available to PCI DSS compliant merchants who are authorized to send raw card data directly via the API to create tokens. 2. **Target Tokens:** This only applies to tokens where `type` is `recurring`. For `one_time` or `subscription` tokens, 3-D Secure is requested during charge creation, not token creation. 3. **Execution Flow:**
        ///   - After creating the token, poll the token object until `data.three_ds.status` becomes `awaiting`.
        ///   - Once `awaiting`, use this endpoint to fetch the issuer token details.
        ///   - Format the returned `payload` according to the `content_type` (e.g., URL-encoded) and execute an `http_post` request from the consumer's browser to the `issuer_token` URL..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetTokenThreeDsIssuerToken()
        {
            // Parameters for the API call
            Guid storeId = Guid.Parse("0cab399b-5621-425b-993b-f8507eba1e78");
            Guid id = Guid.Parse("c4e87129-cad4-47fb-8ded-b4c0a4ae0dd4");

            // Perform API call
            ApiResponse<Models.ThreeDsIssuerToken> result = null;
            try
            {
                result = await this.controller.GetTokenThreeDsIssuerTokenAsync(storeId, id);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/json");

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsProperSubsetOf(
                    "{\"issuer_token\":\"http://test.com/action\",\"call_method\":\"http_post\",\"payload\":{\"request_data\":\"example_value\"},\"payment_type\":\"card\",\"content_type\":\"application/x-www-form-urlencoded; charset=UTF-8\"}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }
    }
}
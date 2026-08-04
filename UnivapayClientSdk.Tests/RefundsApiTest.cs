// <copyright file="RefundsApiTest.cs" company="APIMatic">
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
    /// RefundsApiTest.
    /// </summary>
    [TestFixture]
    public class RefundsApiTest : ApiTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private RefundsApi controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.RefundsApi;
        }

        /// <summary>
        /// Retrieves a list of all refunds for a specific charge..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestListRefunds()
        {
            // Parameters for the API call
            Guid storeId = Guid.Parse("0cab399b-5621-425b-993b-f8507eba1e78");
            Guid chargeId = Guid.Parse("6efb4e5c-690a-40f3-a4f1-0e19c5f84e98");
            int? limit = 10;
            Guid? cursor = Guid.Parse("3541d4fa-596d-428e-8a36-f274e1b3d505");
            Models.CursorDirectionQuery cursorDirection = ApiHelper.JsonDeserialize<Models.CursorDirectionQuery>("\"desc\"");
            string metadata = "order_id: 12345";

            // Perform API call
            ApiResponse<Models.RefundList> result = null;
            try
            {
                result = await this.controller.ListRefundsAsync(storeId, chargeId, limit, cursor, cursorDirection, metadata);
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
                    "{\"items\":[{\"id\":\"b4d9fea9-c9b3-4e76-a25d-b61f7e4821b6\",\"store_id\":\"76cf4a64-02bc-4cb3-9a28-74622e5928a1\",\"charge_id\":\"6efb4e5c-690a-40f3-a4f1-0e19c5f84e98\",\"status\":\"successful\",\"amount\":1000,\"currency\":\"JPY\",\"amount_formatted\":1000,\"reason\":\"customer_request\",\"message\":\"Customer returned item\",\"error\":{},\"metadata\":{},\"mode\":\"live\",\"created_on\":\"2026-04-09T07:35:50.000000Z\",\"updated_on\":\"2026-04-09T07:36:00.000000Z\"},{\"id\":\"c5e0afb0-dac4-5f87-b36e-c72f8f5932c7\",\"store_id\":\"76cf4a64-02bc-4cb3-9a28-74622e5928a1\",\"charge_id\":\"7fac5f6d-7a1b-51e4-b5f2-1f2ad6f95fa9\",\"status\":\"pending\",\"amount\":2500,\"currency\":\"JPY\",\"amount_formatted\":2500,\"reason\":\"duplicate\",\"message\":\"Duplicate charge\",\"error\":{},\"metadata\":{\"order_id\":\"ORD-1002\"},\"mode\":\"live\",\"created_on\":\"2026-04-10T10:00:00.000000Z\",\"updated_on\":\"2026-04-10T10:00:05.000000Z\"},{\"id\":\"d6f1bac1-ebd5-6098-c47f-d83a906043d8\",\"store_id\":\"76cf4a64-02bc-4cb3-9a28-74622e5928a1\",\"charge_id\":\"80bd6a7e-8b2c-62f5-c6a3-2a3be7a06aba\",\"status\":\"successful\",\"amount\":500,\"currency\":\"JPY\",\"amount_formatted\":500,\"reason\":\"fraud\",\"message\":\"Fraudulent transaction reversed\",\"error\":{},\"metadata\":{},\"mode\":\"live\",\"created_on\":\"2026-04-11T14:22:08.000000Z\",\"updated_on\":\"2026-04-11T14:22:20.000000Z\"}],\"has_more\":false,\"total_hits\":3}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Creates a refund for a successful charge. The charge must have status `successful`. Konbini and bank transfer charges cannot be refunded. The refund is processed asynchronously — the initial status will be `pending`..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestCreateRefund()
        {
            // Parameters for the API call
            Guid storeId = Guid.Parse("0cab399b-5621-425b-993b-f8507eba1e78");
            Guid chargeId = Guid.Parse("6efb4e5c-690a-40f3-a4f1-0e19c5f84e98");
            Models.RefundCreateRequest body = ApiHelper.JsonDeserialize<Models.RefundCreateRequest>("{\"amount\":1000,\"currency\":\"JPY\",\"reason\":\"customer_request\"}");
            string idempotencyKey = "f64be872-353d-4c3c-84cb-3dc617fe89f7";

            // Perform API call
            ApiResponse<Models.Refund> result = null;
            try
            {
                result = await this.controller.CreateRefundAsync(storeId, chargeId, body, idempotencyKey);
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
                    "{\"id\":\"b4d9fea9-c9b3-4e76-a25d-b61f7e4821b6\",\"store_id\":\"76cf4a64-02bc-4cb3-9a28-74622e5928a1\",\"charge_id\":\"6efb4e5c-690a-40f3-a4f1-0e19c5f84e98\",\"status\":\"pending\",\"amount\":1000,\"currency\":\"JPY\",\"amount_formatted\":1000,\"reason\":\"customer_request\",\"message\":\"Customer returned item\",\"error\":null,\"metadata\":{},\"mode\":\"live\",\"created_on\":\"2026-04-09T07:35:50.000000Z\",\"updated_on\":\"2026-04-09T07:35:50.000000Z\"}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Retrieves the details of a specific refund. Supports long polling — set `polling=true` to wait until the refund status changes from `pending` to a terminal state (`successful`, `failed`, or `error`)..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetRefund()
        {
            // Parameters for the API call
            Guid storeId = Guid.Parse("0cab399b-5621-425b-993b-f8507eba1e78");
            Guid chargeId = Guid.Parse("6efb4e5c-690a-40f3-a4f1-0e19c5f84e98");
            Guid id = Guid.Parse("c4e87129-cad4-47fb-8ded-b4c0a4ae0dd4");
            bool? polling = true;

            // Perform API call
            ApiResponse<Models.Refund> result = null;
            try
            {
                result = await this.controller.GetRefundAsync(storeId, chargeId, id, polling);
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
                    "{\"id\":\"b4d9fea9-c9b3-4e76-a25d-b61f7e4821b6\",\"store_id\":\"76cf4a64-02bc-4cb3-9a28-74622e5928a1\",\"charge_id\":\"6efb4e5c-690a-40f3-a4f1-0e19c5f84e98\",\"status\":\"successful\",\"amount\":1000,\"currency\":\"JPY\",\"amount_formatted\":1000,\"reason\":\"customer_request\",\"message\":\"Customer returned item\",\"error\":null,\"metadata\":{},\"mode\":\"live\",\"created_on\":\"2026-04-09T07:35:50.000000Z\",\"updated_on\":\"2026-04-09T07:36:00.000000Z\"}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Updates metadata, message, or reason on an existing refund..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestUpdateRefund()
        {
            // Parameters for the API call
            Guid storeId = Guid.Parse("0cab399b-5621-425b-993b-f8507eba1e78");
            Guid chargeId = Guid.Parse("6efb4e5c-690a-40f3-a4f1-0e19c5f84e98");
            Guid id = Guid.Parse("c4e87129-cad4-47fb-8ded-b4c0a4ae0dd4");
            Models.RefundUpdateRequest body = ApiHelper.JsonDeserialize<Models.RefundUpdateRequest>("{\"message\":\"Updated reason note\",\"metadata\":{\"order_id\":\"12345\"}}");
            string idempotencyKey = "f64be872-353d-4c3c-84cb-3dc617fe89f7";

            // Perform API call
            ApiResponse<Models.Refund> result = null;
            try
            {
                result = await this.controller.UpdateRefundAsync(storeId, chargeId, id, body, idempotencyKey);
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
                    "{\"id\":\"b4d9fea9-c9b3-4e76-a25d-b61f7e4821b6\",\"store_id\":\"76cf4a64-02bc-4cb3-9a28-74622e5928a1\",\"charge_id\":\"6efb4e5c-690a-40f3-a4f1-0e19c5f84e98\",\"status\":\"successful\",\"amount\":1000,\"currency\":\"JPY\",\"amount_formatted\":1000,\"reason\":\"customer_request\",\"message\":\"Updated reason note\",\"error\":null,\"metadata\":{\"order_id\":\"12345\"},\"mode\":\"live\",\"created_on\":\"2026-04-09T07:35:50.000000Z\",\"updated_on\":\"2026-04-09T08:00:00.000000Z\"}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }
    }
}
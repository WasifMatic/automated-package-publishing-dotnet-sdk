// <copyright file="CancelsApiTest.cs" company="APIMatic">
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
    /// CancelsApiTest.
    /// </summary>
    [TestFixture]
    public class CancelsApiTest : ApiTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private CancelsApi controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.CancelsApi;
        }

        /// <summary>
        /// Returns a paginated list of cancels for the specified charge..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestListCancels()
        {
            // Parameters for the API call
            Guid storeId = Guid.Parse("0cab399b-5621-425b-993b-f8507eba1e78");
            Guid chargeId = Guid.Parse("6efb4e5c-690a-40f3-a4f1-0e19c5f84e98");
            int? limit = 10;
            Guid? cursor = Guid.Parse("3541d4fa-596d-428e-8a36-f274e1b3d505");
            Models.CursorDirectionQuery cursorDirection = ApiHelper.JsonDeserialize<Models.CursorDirectionQuery>("\"desc\"");

            // Perform API call
            ApiResponse<Models.CancelList> result = null;
            try
            {
                result = await this.controller.ListCancelsAsync(storeId, chargeId, limit, cursor, cursorDirection);
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
                    "{\"items\":[{\"id\":\"a1b2c3d4-e5f6-7890-abcd-ef1234567890\",\"charge_id\":\"6efb4e5c-690a-40f3-a4f1-0e19c5f84e98\",\"store_id\":\"76cf4a64-02bc-4cb3-9a28-74622e5928a1\",\"status\":\"successful\",\"error\":{},\"metadata\":{\"order_id\":\"ORD-987\"},\"mode\":\"live\",\"created_on\":\"2026-04-09T07:35:50.000000Z\",\"updated_on\":\"2026-04-09T07:36:00.000000Z\"},{\"id\":\"b2c3d4e5-f6a7-8901-bcde-f23456789012\",\"charge_id\":\"7fac5f6d-7a1b-51e4-b5f2-1f2ad6f95fa9\",\"store_id\":\"76cf4a64-02bc-4cb3-9a28-74622e5928a1\",\"status\":\"successful\",\"error\":{},\"metadata\":{\"order_id\":\"ORD-988\"},\"mode\":\"live\",\"created_on\":\"2026-04-10T10:00:00.000000Z\",\"updated_on\":\"2026-04-10T10:00:12.000000Z\"},{\"id\":\"c3d4e5f6-a7b8-9012-cdef-345678901234\",\"charge_id\":\"80bd6a7e-8b2c-62f5-c6a3-2a3be7a06aba\",\"store_id\":\"76cf4a64-02bc-4cb3-9a28-74622e5928a1\",\"status\":\"pending\",\"error\":{},\"metadata\":{},\"mode\":\"live\",\"created_on\":\"2026-04-11T14:22:08.000000Z\",\"updated_on\":\"2026-04-11T14:22:08.000000Z\"}],\"has_more\":false}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Creates a new cancellation request for a charge. The charge must be in a cancellable state. Bank transfer and konbini charges that have already been paid cannot be cancelled.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestCreateCancel()
        {
            // Parameters for the API call
            Guid storeId = Guid.Parse("0cab399b-5621-425b-993b-f8507eba1e78");
            Guid chargeId = Guid.Parse("6efb4e5c-690a-40f3-a4f1-0e19c5f84e98");
            string idempotencyKey = "f64be872-353d-4c3c-84cb-3dc617fe89f7";
            Models.CancelCreateRequest body = ApiHelper.JsonDeserialize<Models.CancelCreateRequest>("{\"metadata\":{\"order_id\":\"ORD-987\"}}");

            // Perform API call
            ApiResponse<Models.Cancel> result = null;
            try
            {
                result = await this.controller.CreateCancelAsync(storeId, chargeId, idempotencyKey, body);
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
                    "{\"id\":\"a1b2c3d4-e5f6-7890-abcd-ef1234567890\",\"charge_id\":\"6efb4e5c-690a-40f3-a4f1-0e19c5f84e98\",\"store_id\":\"76cf4a64-02bc-4cb3-9a28-74622e5928a1\",\"status\":\"pending\",\"error\":null,\"metadata\":{},\"mode\":\"live\",\"created_on\":\"2026-04-09T07:35:50.000000Z\",\"updated_on\":\"2026-04-09T07:35:50.000000Z\"}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Retrieves a specific cancel by ID. Supports long-polling by appending `?polling=true` to wait for a status change (up to the server timeout). Requires a secret-bearing token..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetCancel()
        {
            // Parameters for the API call
            Guid storeId = Guid.Parse("0cab399b-5621-425b-993b-f8507eba1e78");
            Guid chargeId = Guid.Parse("6efb4e5c-690a-40f3-a4f1-0e19c5f84e98");
            Guid id = Guid.Parse("c4e87129-cad4-47fb-8ded-b4c0a4ae0dd4");
            bool? polling = false;

            // Perform API call
            ApiResponse<Models.Cancel> result = null;
            try
            {
                result = await this.controller.GetCancelAsync(storeId, chargeId, id, polling);
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
                    "{\"id\":\"a1b2c3d4-e5f6-7890-abcd-ef1234567890\",\"charge_id\":\"6efb4e5c-690a-40f3-a4f1-0e19c5f84e98\",\"store_id\":\"76cf4a64-02bc-4cb3-9a28-74622e5928a1\",\"status\":\"successful\",\"error\":null,\"metadata\":{},\"mode\":\"live\",\"created_on\":\"2026-04-09T07:35:50.000000Z\",\"updated_on\":\"2026-04-09T07:36:00.000000Z\"}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Updates metadata on an existing cancel. Requires a secret-bearing token..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestUpdateCancel()
        {
            // Parameters for the API call
            Guid storeId = Guid.Parse("0cab399b-5621-425b-993b-f8507eba1e78");
            Guid chargeId = Guid.Parse("6efb4e5c-690a-40f3-a4f1-0e19c5f84e98");
            Guid id = Guid.Parse("c4e87129-cad4-47fb-8ded-b4c0a4ae0dd4");
            Models.CancelUpdateRequest body = ApiHelper.JsonDeserialize<Models.CancelUpdateRequest>("{\"metadata\":{\"order_id\":\"12345\"}}");
            string idempotencyKey = "f64be872-353d-4c3c-84cb-3dc617fe89f7";

            // Perform API call
            ApiResponse<Models.Cancel> result = null;
            try
            {
                result = await this.controller.UpdateCancelAsync(storeId, chargeId, id, body, idempotencyKey);
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
                    "{\"id\":\"a1b2c3d4-e5f6-7890-abcd-ef1234567890\",\"charge_id\":\"6efb4e5c-690a-40f3-a4f1-0e19c5f84e98\",\"store_id\":\"76cf4a64-02bc-4cb3-9a28-74622e5928a1\",\"status\":\"successful\",\"error\":null,\"metadata\":{\"order_id\":\"12345\"},\"mode\":\"live\",\"created_on\":\"2026-04-09T07:35:50.000000Z\",\"updated_on\":\"2026-04-09T08:00:00.000000Z\"}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }
    }
}
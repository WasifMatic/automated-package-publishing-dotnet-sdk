// <copyright file="WebhooksApiTest.cs" company="APIMatic">
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
    /// WebhooksApiTest.
    /// </summary>
    [TestFixture]
    public class WebhooksApiTest : ApiTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private WebhooksApi controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.WebhooksApi;
        }

        /// <summary>
        /// Returns a paginated list of webhooks for the specified store. Requires a secret-bearing token..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestListWebhooks()
        {
            // Parameters for the API call
            Guid storeId = Guid.Parse("0cab399b-5621-425b-993b-f8507eba1e78");
            int? limit = 10;
            Guid? cursor = Guid.Parse("3541d4fa-596d-428e-8a36-f274e1b3d505");
            Models.CursorDirectionQuery cursorDirection = ApiHelper.JsonDeserialize<Models.CursorDirectionQuery>("\"desc\"");
            bool? active = true;

            // Perform API call
            ApiResponse<Models.WebhookList> result = null;
            try
            {
                result = await this.controller.ListWebhooksAsync(storeId, limit, cursor, cursorDirection, active);
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
                    "{\"items\":[{\"id\":\"d3e4f5a6-b7c8-9012-def0-123456789abc\",\"store_id\":\"76cf4a64-02bc-4cb3-9a28-74622e5928a1\",\"merchant_id\":\"01234567-89ab-cdef-0123-456789abcdef\",\"triggers\":[\"charge_finished\",\"refund_finished\"],\"url\":\"https://example.com/webhooks/payments\",\"auth_token\":\"my-secret-token\",\"active\":true,\"is_integration\":false,\"created_on\":\"2026-04-01T00:00:00.000000Z\",\"updated_on\":\"2026-04-02T00:00:00.000000Z\"},{\"id\":\"e4f5a6b7-c8d9-0123-ef01-23456789abcd\",\"store_id\":\"76cf4a64-02bc-4cb3-9a28-74622e5928a1\",\"merchant_id\":\"01234567-89ab-cdef-0123-456789abcdef\",\"triggers\":[\"subscription_payment\",\"subscription_failure\"],\"url\":\"https://example.com/webhooks/subscriptions\",\"auth_token\":null,\"active\":true,\"is_integration\":false,\"created_on\":\"2026-04-03T08:30:00.000000Z\",\"updated_on\":\"2026-04-03T08:30:00.000000Z\"},{\"id\":\"f5a6b7c8-d9e0-1234-f012-3456789abcde\",\"store_id\":\"76cf4a64-02bc-4cb3-9a28-74622e5928a1\",\"merchant_id\":\"01234567-89ab-cdef-0123-456789abcdef\",\"triggers\":[\"cancel_finished\"],\"url\":\"https://example.com/webhooks/cancels\",\"auth_token\":\"legacy-token\",\"active\":false,\"is_integration\":false,\"created_on\":\"2026-03-20T12:00:00.000000Z\",\"updated_on\":\"2026-04-05T09:15:00.000000Z\"}],\"has_more\":false}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Creates a new webhook subscription for the specified store. Requires a secret-bearing token. Duplicate URLs within the same scope are not allowed. There is a maximum limit on the number of webhooks per store..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestCreateWebhook()
        {
            // Parameters for the API call
            Guid storeId = Guid.Parse("0cab399b-5621-425b-993b-f8507eba1e78");
            Models.WebhookCreateRequest body = ApiHelper.JsonDeserialize<Models.WebhookCreateRequest>("{\"triggers\":[\"charge_finished\"],\"url\":\"https://example.com/webhooks/payments\",\"auth_token\":\"my-secret-token\"}");
            string idempotencyKey = "f64be872-353d-4c3c-84cb-3dc617fe89f7";

            // Perform API call
            ApiResponse<Models.Webhook> result = null;
            try
            {
                result = await this.controller.CreateWebhookAsync(storeId, body, idempotencyKey);
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
                    "{\"id\":\"d3e4f5a6-b7c8-9012-def0-123456789abc\",\"store_id\":\"76cf4a64-02bc-4cb3-9a28-74622e5928a1\",\"merchant_id\":\"01234567-89ab-cdef-0123-456789abcdef\",\"triggers\":[\"charge_finished\",\"refund_finished\"],\"url\":\"https://example.com/webhooks/payments\",\"auth_token\":\"my-secret-token\",\"active\":true,\"is_integration\":false,\"created_on\":\"2026-04-01T00:00:00.000000Z\",\"updated_on\":\"2026-04-01T00:00:00.000000Z\"}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Retrieves a specific webhook by ID..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetWebhook()
        {
            // Parameters for the API call
            Guid storeId = Guid.Parse("0cab399b-5621-425b-993b-f8507eba1e78");
            Guid id = Guid.Parse("c4e87129-cad4-47fb-8ded-b4c0a4ae0dd4");

            // Perform API call
            ApiResponse<Models.Webhook> result = null;
            try
            {
                result = await this.controller.GetWebhookAsync(storeId, id);
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
                    "{\"id\":\"d3e4f5a6-b7c8-9012-def0-123456789abc\",\"store_id\":\"76cf4a64-02bc-4cb3-9a28-74622e5928a1\",\"merchant_id\":\"01234567-89ab-cdef-0123-456789abcdef\",\"triggers\":[\"charge_finished\"],\"url\":\"https://example.com/webhooks/payments\",\"active\":true}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Updates an existing webhook. All fields are optional; omitted fields are left unchanged. Duplicate URLs within the same scope are not allowed..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestUpdateWebhook()
        {
            // Parameters for the API call
            Guid storeId = Guid.Parse("0cab399b-5621-425b-993b-f8507eba1e78");
            Guid id = Guid.Parse("c4e87129-cad4-47fb-8ded-b4c0a4ae0dd4");
            Models.WebhookUpdateRequest body = ApiHelper.JsonDeserialize<Models.WebhookUpdateRequest>("{\"active\":false}");
            string idempotencyKey = "f64be872-353d-4c3c-84cb-3dc617fe89f7";

            // Perform API call
            ApiResponse<Models.Webhook> result = null;
            try
            {
                result = await this.controller.UpdateWebhookAsync(storeId, id, body, idempotencyKey);
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
                    "{\"id\":\"d3e4f5a6-b7c8-9012-def0-123456789abc\",\"store_id\":\"76cf4a64-02bc-4cb3-9a28-74622e5928a1\",\"merchant_id\":\"01234567-89ab-cdef-0123-456789abcdef\",\"triggers\":[\"charge_finished\"],\"url\":\"https://example.com/webhooks/v2\",\"active\":false}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Deactivates and deletes a webhook subscription..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestDeleteWebhook()
        {
            // Parameters for the API call
            Guid storeId = Guid.Parse("0cab399b-5621-425b-993b-f8507eba1e78");
            Guid id = Guid.Parse("c4e87129-cad4-47fb-8ded-b4c0a4ae0dd4");

            // Perform API call
            try
            {
                await this.controller.DeleteWebhookAsync(storeId, id);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(204, HttpCallBack.Response.StatusCode, "Status should be 204");
        }

        /// <summary>
        /// Returns a paginated list of webhook delivery events for the specified webhook. Each event captures the result of a single webhook delivery attempt..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestListWebhookEvents()
        {
            // Parameters for the API call
            Guid storeId = Guid.Parse("0cab399b-5621-425b-993b-f8507eba1e78");
            Guid id = Guid.Parse("c4e87129-cad4-47fb-8ded-b4c0a4ae0dd4");
            int? limit = 10;
            Guid? cursor = Guid.Parse("3541d4fa-596d-428e-8a36-f274e1b3d505");
            Models.CursorDirectionQuery cursorDirection = ApiHelper.JsonDeserialize<Models.CursorDirectionQuery>("\"desc\"");

            // Perform API call
            ApiResponse<Models.WebhookEventList> result = null;
            try
            {
                result = await this.controller.ListWebhookEventsAsync(storeId, id, limit, cursor, cursorDirection);
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
                    "{\"items\":[{\"id\":\"e1f2a3b4-c5d6-7890-efab-123456789cde\",\"webhook_id\":\"d3e4f5a6-b7c8-9012-def0-123456789abc\",\"event\":\"charge_finished\",\"successful\":true,\"fired_on\":\"2026-04-09T07:36:00.000000Z\",\"error_message\":null,\"created_on\":\"2026-04-09T07:35:50.000000Z\"},{\"id\":\"f2a3b4c5-d6e7-8901-fabc-23456789cdef\",\"webhook_id\":\"d3e4f5a6-b7c8-9012-def0-123456789abc\",\"event\":\"refund_finished\",\"successful\":true,\"fired_on\":\"2026-04-10T11:00:05.000000Z\",\"error_message\":null,\"created_on\":\"2026-04-10T11:00:00.000000Z\"},{\"id\":\"a3b4c5d6-e7f8-9012-abcd-3456789cdef0\",\"webhook_id\":\"d3e4f5a6-b7c8-9012-def0-123456789abc\",\"event\":\"cancel_finished\",\"successful\":false,\"fired_on\":\"2026-04-11T15:30:10.000000Z\",\"error_message\":\"Connection timed out after 10s\",\"created_on\":\"2026-04-11T15:30:00.000000Z\"}],\"has_more\":false}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Re-sends the webhook payload for a previously delivered (or failed) event. Returns 202 Accepted immediately; delivery is asynchronous..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestRedeliverWebhookEvent()
        {
            // Parameters for the API call
            Guid storeId = Guid.Parse("0cab399b-5621-425b-993b-f8507eba1e78");
            Guid id = Guid.Parse("c4e87129-cad4-47fb-8ded-b4c0a4ae0dd4");
            Guid eventId = Guid.Parse("e1f2a3b4-c5d6-7890-efab-123456789cde");
            string idempotencyKey = "f64be872-353d-4c3c-84cb-3dc617fe89f7";

            // Perform API call
            ApiResponse<object> result = null;
            try
            {
                result = await this.controller.RedeliverWebhookEventAsync(storeId, id, eventId, idempotencyKey);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(202, HttpCallBack.Response.StatusCode, "Status should be 202");

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
                    "{}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }
    }
}
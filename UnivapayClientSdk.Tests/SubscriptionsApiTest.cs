// <copyright file="SubscriptionsApiTest.cs" company="APIMatic">
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
    /// SubscriptionsApiTest.
    /// </summary>
    [TestFixture]
    public class SubscriptionsApiTest : ApiTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private SubscriptionsApi controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.SubscriptionsApi;
        }

        /// <summary>
        /// Creates a new subscription..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestCreateSubscription()
        {
            // Parameters for the API call
            string idempotencyKey = "f64be872-353d-4c3c-84cb-3dc617fe89f7";
            Models.SubscriptionCreateRequest body = ApiHelper.JsonDeserialize<Models.SubscriptionCreateRequest>("{\"transaction_token_id\":\"11ef32a7-3a71-8662-803f-1bc27702eeec\",\"amount\":1000,\"currency\":\"JPY\",\"period\":\"monthly\"}");

            // Perform API call
            ApiResponse<Models.Subscription> result = null;
            try
            {
                result = await this.controller.CreateSubscriptionAsync(idempotencyKey, body);
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
                    "{\"id\":\"11ef335e-9aa5-c54a-8313-7f9847da313a\",\"store_id\":\"11edf541-c42d-653c-8c3d-dfe0a55f95c0\",\"transaction_token_id\":\"11ef32a7-3a71-8662-803f-1bc27702eeec\",\"amount\":1250,\"currency\":\"USD\",\"amount_formatted\":12.5,\"initial_amount\":1000,\"initial_amount_formatted\":10.0,\"subsequent_cycles_start\":null,\"only_direct_currency\":false,\"first_charge_authorization_only\":false,\"status\":\"current\",\"metadata\":{\"order_id\":\"ORD-987\"},\"mode\":\"live\",\"created_on\":\"2024-06-26T01:51:28.627023Z\",\"period\":\"monthly\",\"next_payment\":{\"id\":\"11ef3360-1f9a-c54a-8313-7f9847da313b\",\"due_date\":\"2024-07-26\",\"zone_id\":\"Asia/Tokyo\",\"amount\":1250,\"currency\":\"USD\",\"amount_formatted\":12.5,\"is_paid\":false}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Lists all subscriptions across all stores..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestListAllSubscriptions()
        {
            // Parameters for the API call
            int? limit = 10;
            Guid? cursor = Guid.Parse("3541d4fa-596d-428e-8a36-f274e1b3d505");
            Models.CursorDirectionQuery cursorDirection = ApiHelper.JsonDeserialize<Models.CursorDirectionQuery>("\"desc\"");

            // Perform API call
            ApiResponse<Models.SubscriptionList> result = null;
            try
            {
                result = await this.controller.ListAllSubscriptionsAsync(limit, cursor, cursorDirection);
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
                    "{\"items\":[{\"id\":\"11ef3410-aaaa-4bcd-8e1f-1a2b3c4d5e60\",\"store_id\":\"11edf541-c42d-653c-8c3d-dfe0a55f95c0\",\"transaction_token_id\":\"11ef3413-dddd-4ef0-b142-4d5e6f809193\",\"amount\":1250,\"currency\":\"USD\",\"amount_formatted\":12.5,\"status\":\"current\",\"merchant_name\":\"管理画面ガイド\",\"store_name\":\"管理画面ガイド_TEST店舗\",\"payment_type\":\"card\",\"next_payment_date\":\"2024-07-26\",\"user_data\":{\"type\":\"charge\",\"cardholder_name\":\"taro yamada\",\"email\":\"taro@test.com\",\"brand\":\"visa\"}},{\"id\":\"11ef3411-bbbb-4cde-9f20-2b3c4d5e6f71\",\"store_id\":\"22af6520-d53e-764d-9d4e-ef01b66fa6d1\",\"transaction_token_id\":\"11ef3414-eeee-4f01-c253-5e6f80919204\",\"amount\":3000,\"currency\":\"JPY\",\"amount_formatted\":3000,\"status\":\"current\",\"merchant_name\":\"管理画面ガイド\",\"store_name\":\"管理画面ガイド_Online店舗\",\"payment_type\":\"card\",\"next_payment_date\":\"2024-08-10\",\"user_data\":{\"type\":\"charge\",\"cardholder_name\":\"hanako suzuki\",\"email\":\"hanako@test.com\",\"brand\":\"mastercard\"}},{\"id\":\"11ef3412-cccc-4def-a031-3c4d5e6f8082\",\"store_id\":\"33af7631-e64f-875e-ae5f-f012c77fb7e2\",\"transaction_token_id\":\"11ef3415-ffff-4012-d364-6f8091920315\",\"amount\":9800,\"currency\":\"JPY\",\"amount_formatted\":9800,\"status\":\"suspended\",\"merchant_name\":\"管理画面ガイド\",\"store_name\":\"管理画面ガイド_Osaka店舗\",\"payment_type\":\"card\",\"next_payment_date\":\"2024-09-15\",\"user_data\":{\"type\":\"charge\",\"cardholder_name\":\"jiro tanaka\",\"email\":\"jiro@test.com\",\"brand\":\"jcb\"}}],\"has_more\":false,\"total_hits\":3}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Lists all subscriptions for a specific store..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestListStoreSubscriptions()
        {
            // Parameters for the API call
            Guid storeId = Guid.Parse("0cab399b-5621-425b-993b-f8507eba1e78");
            string search = "order_id:12345";
            Models.SubscriptionStatus status = ApiHelper.JsonDeserialize<Models.SubscriptionStatus>("\"current\"");
            Models.ChargeMode mode = ApiHelper.JsonDeserialize<Models.ChargeMode>("\"live\"");
            int? limit = 10;
            Guid? cursor = Guid.Parse("3541d4fa-596d-428e-8a36-f274e1b3d505");
            Models.CursorDirectionQuery cursorDirection = ApiHelper.JsonDeserialize<Models.CursorDirectionQuery>("\"desc\"");

            // Perform API call
            ApiResponse<Models.SubscriptionList> result = null;
            try
            {
                result = await this.controller.ListStoreSubscriptionsAsync(storeId, search, status, mode, limit, cursor, cursorDirection);
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
                    "{\"items\":[{\"id\":\"11ef335e-9aa5-c54a-8313-7f9847da313a\",\"store_id\":\"11edf541-c42d-653c-8c3d-dfe0a55f95c0\",\"transaction_token_id\":\"11ef32a7-3a71-8662-803f-1bc27702eeec\",\"amount\":1250,\"currency\":\"USD\",\"amount_formatted\":12.5,\"status\":\"current\",\"merchant_name\":\"管理画面ガイド\",\"store_name\":\"管理画面ガイド_TEST店舗\",\"payment_type\":\"card\",\"next_payment_date\":\"2024-07-26\",\"user_data\":{\"type\":\"charge\",\"cardholder_name\":\"taro yamada\",\"email\":\"test@test.com\",\"brand\":\"visa\"}},{\"id\":\"11ef3401-1a2b-4c3d-8e4f-5a6b7c8d9e0f\",\"store_id\":\"11edf541-c42d-653c-8c3d-dfe0a55f95c0\",\"transaction_token_id\":\"11ef3402-2b3c-4d5e-9f60-6b7c8d9e0f11\",\"amount\":5000,\"currency\":\"JPY\",\"amount_formatted\":5000,\"status\":\"current\",\"merchant_name\":\"管理画面ガイド\",\"store_name\":\"管理画面ガイド_TEST店舗\",\"payment_type\":\"card\",\"next_payment_date\":\"2024-08-01\",\"user_data\":{\"type\":\"charge\",\"cardholder_name\":\"hanako suzuki\",\"email\":\"hanako@test.com\",\"brand\":\"mastercard\"}},{\"id\":\"11ef3403-3c4d-5e6f-a071-7c8d9e0f1122\",\"store_id\":\"11edf541-c42d-653c-8c3d-dfe0a55f95c0\",\"transaction_token_id\":\"11ef3404-4d5e-6f70-b182-8d9e0f112233\",\"amount\":9800,\"currency\":\"JPY\",\"amount_formatted\":9800,\"status\":\"suspended\",\"merchant_name\":\"管理画面ガイド\",\"store_name\":\"管理画面ガイド_TEST店舗\",\"payment_type\":\"card\",\"next_payment_date\":\"2024-09-15\",\"user_data\":{\"type\":\"charge\",\"cardholder_name\":\"jiro tanaka\",\"email\":\"jiro@test.com\",\"brand\":\"jcb\"}}],\"has_more\":false,\"total_hits\":3}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Retrieves the details of an existing subscription.  Supports internal polling to wait for status changes..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetSubscription()
        {
            // Parameters for the API call
            Guid storeId = Guid.Parse("0cab399b-5621-425b-993b-f8507eba1e78");
            Guid id = Guid.Parse("11ef335e-9aa5-c54a-8313-7f9847da313a");
            bool? polling = true;

            // Perform API call
            ApiResponse<Models.Subscription> result = null;
            try
            {
                result = await this.controller.GetSubscriptionAsync(storeId, id, polling);
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
                    "{\"id\":\"11ef335e-9aa5-c54a-8313-7f9847da313a\",\"store_id\":\"11edf541-c42d-653c-8c3d-dfe0a55f95c0\",\"transaction_token_id\":\"11ef32a7-3a71-8662-803f-1bc27702eeec\",\"amount\":1250,\"currency\":\"USD\",\"amount_formatted\":12.5,\"initial_amount\":null,\"initial_amount_formatted\":null,\"subsequent_cycles_start\":null,\"schedule_settings\":{\"start_on\":\"2024-07-01\",\"zone_id\":\"Asia/Tokyo\",\"preserve_end_of_month\":false,\"retry_interval\":\"P7D\",\"termination_mode\":\"immediate\"},\"only_direct_currency\":false,\"first_charge_capture_after\":null,\"first_charge_authorization_only\":false,\"status\":\"current\",\"metadata\":{\"order_id\":\"12345\"},\"mode\":\"test\",\"created_on\":\"2024-06-26T01:51:28.627023Z\",\"period\":\"monthly\",\"next_payment\":{\"id\":\"11ef335e-9ae2-8322-8e79-e7ba4b56234e\",\"due_date\":\"2024-07-26\",\"zone_id\":\"Asia/Tokyo\",\"amount\":1250,\"currency\":\"USD\",\"amount_formatted\":12.5,\"is_paid\":false,\"is_last_payment\":false,\"created_on\":\"2024-06-26T01:51:29.025129Z\",\"updated_on\":\"2024-06-26T01:51:29.025129Z\",\"retry_date\":null}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Updates the configuration, payment method, or schedule of a specific subscription..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestUpdateSubscription()
        {
            // Parameters for the API call
            Guid storeId = Guid.Parse("0cab399b-5621-425b-993b-f8507eba1e78");
            Guid id = Guid.Parse("c4e87129-cad4-47fb-8ded-b4c0a4ae0dd4");
            string idempotencyKey = "f64be872-353d-4c3c-84cb-3dc617fe89f7";
            Models.SubscriptionUpdateRequest body = ApiHelper.JsonDeserialize<Models.SubscriptionUpdateRequest>("{\"metadata\":{\"order_id\":\"12345\"},\"schedule_settings\":{\"termination_mode\":\"on_next_payment\"}}");

            // Perform API call
            ApiResponse<Models.Subscription> result = null;
            try
            {
                result = await this.controller.UpdateSubscriptionAsync(storeId, id, idempotencyKey, body);
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
                    "{\"id\":\"11ef335e-9aa5-c54a-8313-7f9847da313a\",\"store_id\":\"11edf541-c42d-653c-8c3d-dfe0a55f95c0\",\"transaction_token_id\":\"11ef3362-3700-c54a-9baa-6f7e6527c9d9\",\"amount\":1250,\"currency\":\"USD\",\"amount_formatted\":12.5,\"initial_amount\":null,\"initial_amount_formatted\":null,\"subsequent_cycles_start\":null,\"schedule_settings\":{\"start_on\":\"2024-07-01\",\"zone_id\":\"Asia/Tokyo\",\"preserve_end_of_month\":false,\"retry_interval\":\"P7D\",\"termination_mode\":\"on_next_payment\"},\"only_direct_currency\":false,\"first_charge_capture_after\":null,\"first_charge_authorization_only\":false,\"status\":\"current\",\"metadata\":{\"order_id\":\"12345\"},\"mode\":\"test\",\"created_on\":\"2024-06-26T01:51:28.627023Z\",\"period\":\"monthly\",\"next_payment\":{\"id\":\"11ef335e-9ae2-8322-8e79-e7ba4b56234e\",\"due_date\":\"2030-01-01\",\"zone_id\":\"Asia/Tokyo\",\"amount\":1250,\"currency\":\"USD\",\"amount_formatted\":12.5,\"is_paid\":false,\"is_last_payment\":false,\"created_on\":\"2024-06-26T01:51:29.025129Z\",\"updated_on\":\"2024-06-26T01:51:29.025129Z\",\"retry_date\":null}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Cancels an existing subscription. The subscription status will be  permanently changed to `canceled` and it cannot be resumed.  Please proceed with caution..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestCancelSubscription()
        {
            // Parameters for the API call
            Guid storeId = Guid.Parse("0cab399b-5621-425b-993b-f8507eba1e78");
            Guid id = Guid.Parse("c4e87129-cad4-47fb-8ded-b4c0a4ae0dd4");

            // Perform API call
            try
            {
                await this.controller.CancelSubscriptionAsync(storeId, id);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(204, HttpCallBack.Response.StatusCode, "Status should be 204");
        }

        /// <summary>
        /// Retrieves a list of all historical and scheduled payments for a  specific subscription..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestListSubscriptionPayments()
        {
            // Parameters for the API call
            Guid storeId = Guid.Parse("0cab399b-5621-425b-993b-f8507eba1e78");
            Guid subscriptionId = Guid.Parse("25d0fb2c-18ef-11e7-9dd3-db8fb7b820e7");
            int? limit = 10;
            Guid? cursor = Guid.Parse("3541d4fa-596d-428e-8a36-f274e1b3d505");
            Models.CursorDirectionQuery cursorDirection = ApiHelper.JsonDeserialize<Models.CursorDirectionQuery>("\"desc\"");

            // Perform API call
            ApiResponse<Models.SubscriptionPaymentList> result = null;
            try
            {
                result = await this.controller.ListSubscriptionPaymentsAsync(storeId, subscriptionId, limit, cursor, cursorDirection);
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
                    "{\"items\":[{\"id\":\"11e89a0a-8cee-d660-b984-3fcaaed46e7c\",\"due_date\":\"2018-08-21\",\"zone_id\":\"Asia/Tokyo\",\"amount\":10000,\"currency\":\"JPY\",\"amount_formatted\":10000,\"is_paid\":false,\"is_last_payment\":false,\"created_on\":\"2018-08-07T06:24:33.961256Z\",\"updated_on\":\"2018-08-07T06:24:33.961256Z\"},{\"id\":\"11e89a0a-8cc5-2662-9460-2b14b1a601ba\",\"due_date\":\"2018-08-07\",\"zone_id\":\"Asia/Tokyo\",\"amount\":1000,\"currency\":\"JPY\",\"amount_formatted\":1000,\"is_paid\":true,\"is_last_payment\":false,\"created_on\":\"2018-08-07T06:24:33.646223Z\",\"updated_on\":\"2018-08-07T06:24:33.887760Z\"}],\"has_more\":false}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Retrieves the details of an individual payment associated with a specific subscription..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetSubscriptionPayment()
        {
            // Parameters for the API call
            Guid storeId = Guid.Parse("0cab399b-5621-425b-993b-f8507eba1e78");
            Guid subscriptionId = Guid.Parse("25d0fb2c-18ef-11e7-9dd3-db8fb7b820e7");
            Guid paymentId = Guid.Parse("11e89a0a-8cee-d660-b984-3fcaaed46e7c");

            // Perform API call
            ApiResponse<Models.SubscriptionPayment> result = null;
            try
            {
                result = await this.controller.GetSubscriptionPaymentAsync(storeId, subscriptionId, paymentId);
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
                    "{\"id\":\"11e89a0a-8cee-d660-b984-3fcaaed46e7c\",\"due_date\":\"2018-08-21\",\"zone_id\":\"Asia/Tokyo\",\"amount\":10000,\"currency\":\"JPY\",\"amount_formatted\":10000,\"is_paid\":false,\"is_last_payment\":false,\"created_on\":\"2018-08-07T06:24:33.961256Z\"}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Updates properties of a specific scheduled payment for a subscription. Can be used to change the due date when permitted, mark the payment as paid, schedule a termination status, or set a retry interval..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestUpdateSubscriptionPayment()
        {
            // Parameters for the API call
            Guid storeId = Guid.Parse("0cab399b-5621-425b-993b-f8507eba1e78");
            Guid subscriptionId = Guid.Parse("25d0fb2c-18ef-11e7-9dd3-db8fb7b820e7");
            Guid paymentId = Guid.Parse("11e89a0a-8cee-d660-b984-3fcaaed46e7c");
            Models.SubscriptionPatchPaymentRequest body = ApiHelper.JsonDeserialize<Models.SubscriptionPatchPaymentRequest>("{\"due_date\":\"2026-09-01\",\"is_paid\":false}");
            string idempotencyKey = "f64be872-353d-4c3c-84cb-3dc617fe89f7";

            // Perform API call
            ApiResponse<Models.SubscriptionPayment> result = null;
            try
            {
                result = await this.controller.UpdateSubscriptionPaymentAsync(storeId, subscriptionId, paymentId, body, idempotencyKey);
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
                    "{\"id\":\"11e89a0a-8cee-d660-b984-3fcaaed46e7c\",\"due_date\":\"2026-09-01\",\"zone_id\":\"Asia/Tokyo\",\"amount\":10000,\"currency\":\"JPY\",\"amount_formatted\":10000,\"is_paid\":false,\"is_last_payment\":false,\"created_on\":\"2018-08-07T06:24:33.961256Z\",\"updated_on\":\"2026-04-22T06:00:00.000000Z\"}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Retrieves the most recent charge created for a specific subscription. Returns 404 if no charges have been attempted yet..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetSubscriptionLatestCharge()
        {
            // Parameters for the API call
            Guid storeId = Guid.Parse("0cab399b-5621-425b-993b-f8507eba1e78");
            Guid subscriptionId = Guid.Parse("25d0fb2c-18ef-11e7-9dd3-db8fb7b820e7");

            // Perform API call
            ApiResponse<Models.Charge> result = null;
            try
            {
                result = await this.controller.GetSubscriptionLatestChargeAsync(storeId, subscriptionId);
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
                    "{\"id\":\"6efb4e5c-690a-40f3-a4f1-0e19c5f84e98\",\"store_id\":\"11edf541-c42d-653c-8c3d-dfe0a55f95c0\",\"transaction_token_id\":\"11ef32a7-3a71-8662-803f-1bc27702eeec\",\"transaction_token_type\":\"recurring\",\"subscription_id\":\"11ef335e-9aa5-c54a-8313-7f9847da313a\",\"requested_amount\":1250,\"requested_currency\":\"USD\",\"requested_amount_formatted\":12.5,\"charged_amount\":1250,\"charged_currency\":\"USD\",\"charged_amount_formatted\":12.5,\"only_direct_currency\":false,\"status\":\"successful\",\"error\":null,\"mode\":\"test\",\"created_on\":\"2024-06-26T01:51:30.000000Z\"}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Retrieves a paginated list of charges linked to a subscription. Backend search uses the same charge search surface as normal charge listing and adds a subscription filter for the requested subscription..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestListSubscriptionCharges()
        {
            // Parameters for the API call
            Guid merchantId = Guid.Parse("01234567-89ab-cdef-0123-456789abcdef");
            Guid storeId = Guid.Parse("0cab399b-5621-425b-993b-f8507eba1e78");
            Guid subscriptionId = Guid.Parse("25d0fb2c-18ef-11e7-9dd3-db8fb7b820e7");
            int? limit = 10;
            Guid? cursor = Guid.Parse("3541d4fa-596d-428e-8a36-f274e1b3d505");
            Models.CursorDirectionQuery cursorDirection = ApiHelper.JsonDeserialize<Models.CursorDirectionQuery>("\"desc\"");

            // Perform API call
            ApiResponse<Models.ChargeList> result = null;
            try
            {
                result = await this.controller.ListSubscriptionChargesAsync(merchantId, storeId, subscriptionId, limit, cursor, cursorDirection);
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
                    "{\"items\":[{\"id\":\"6efb4e5c-690a-40f3-a4f1-0e19c5f84e98\",\"store_id\":\"11edf541-c42d-653c-8c3d-dfe0a55f95c0\",\"transaction_token_id\":\"11ef32a7-3a71-8662-803f-1bc27702eeec\",\"transaction_token_type\":\"recurring\",\"subscription_id\":\"11ef335e-9aa5-c54a-8313-7f9847da313a\",\"requested_amount\":1250,\"requested_currency\":\"USD\",\"requested_amount_formatted\":12.5,\"charged_amount\":1250,\"charged_currency\":\"USD\",\"charged_amount_formatted\":12.5,\"only_direct_currency\":false,\"status\":\"successful\",\"error\":{},\"mode\":\"test\",\"created_on\":\"2024-06-26T01:51:30.000000Z\"}],\"has_more\":false,\"total_hits\":1}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Retrieves a paginated list of all charge attempts made for a specific scheduled payment of a subscription. Useful for inspecting retry history..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestListChargesForSubscriptionPayment()
        {
            // Parameters for the API call
            Guid storeId = Guid.Parse("0cab399b-5621-425b-993b-f8507eba1e78");
            Guid subscriptionId = Guid.Parse("25d0fb2c-18ef-11e7-9dd3-db8fb7b820e7");
            Guid paymentId = Guid.Parse("11e89a0a-8cee-d660-b984-3fcaaed46e7c");
            int? limit = 10;
            Guid? cursor = Guid.Parse("3541d4fa-596d-428e-8a36-f274e1b3d505");
            Models.CursorDirectionQuery cursorDirection = ApiHelper.JsonDeserialize<Models.CursorDirectionQuery>("\"desc\"");

            // Perform API call
            ApiResponse<Models.ChargeList> result = null;
            try
            {
                result = await this.controller.ListChargesForSubscriptionPaymentAsync(storeId, subscriptionId, paymentId, limit, cursor, cursorDirection);
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
                    "{\"items\":[{\"id\":\"6efb4e5c-690a-40f3-a4f1-0e19c5f84e98\",\"store_id\":\"11edf541-c42d-653c-8c3d-dfe0a55f95c0\",\"transaction_token_id\":\"11ef32a7-3a71-8662-803f-1bc27702eeec\",\"transaction_token_type\":\"recurring\",\"subscription_id\":\"11ef335e-9aa5-c54a-8313-7f9847da313a\",\"requested_amount\":1250,\"requested_currency\":\"USD\",\"requested_amount_formatted\":12.5,\"charged_amount\":1250,\"charged_currency\":\"USD\",\"charged_amount_formatted\":12.5,\"only_direct_currency\":false,\"status\":\"successful\",\"error\":{},\"mode\":\"test\",\"created_on\":\"2024-06-26T01:51:30.000000Z\"}],\"has_more\":false,\"total_hits\":1}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Suspends a subscription that is currently `current` or `unpaid`. The `termination_mode` controls when the suspension takes effect: `immediate` (default) suspends right away, `on_next_payment` waits until the next scheduled payment date before suspending..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestSuspendSubscription()
        {
            // Parameters for the API call
            Guid storeId = Guid.Parse("0cab399b-5621-425b-993b-f8507eba1e78");
            Guid subscriptionId = Guid.Parse("11ef335e-9aa5-c54a-8313-7f9847da313a");
            string idempotencyKey = "f64be872-353d-4c3c-84cb-3dc617fe89f7";
            Models.SubscriptionSuspendRequest body = ApiHelper.JsonDeserialize<Models.SubscriptionSuspendRequest>("{\"schedule_settings\":{\"termination_mode\":\"on_next_payment\"}}");

            // Perform API call
            ApiResponse<Models.Subscription> result = null;
            try
            {
                result = await this.controller.SuspendSubscriptionAsync(storeId, subscriptionId, idempotencyKey, body);
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
                    "{\"id\":\"11ef335e-9aa5-c54a-8313-7f9847da313a\",\"store_id\":\"11edf541-c42d-653c-8c3d-dfe0a55f95c0\",\"transaction_token_id\":\"11ef32a7-3a71-8662-803f-1bc27702eeec\",\"amount\":1250,\"currency\":\"USD\",\"amount_formatted\":12.5,\"status\":\"suspended\",\"mode\":\"test\",\"created_on\":\"2024-06-26T01:51:28.627023Z\",\"period\":\"monthly\"}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Resumes a subscription that is currently `suspended`, setting its status back to `unpaid` and rescheduling the next payment. No request body is required..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestUnsuspendSubscription()
        {
            // Parameters for the API call
            Guid storeId = Guid.Parse("0cab399b-5621-425b-993b-f8507eba1e78");
            Guid subscriptionId = Guid.Parse("11ef335e-9aa5-c54a-8313-7f9847da313a");
            string idempotencyKey = "f64be872-353d-4c3c-84cb-3dc617fe89f7";

            // Perform API call
            ApiResponse<Models.Subscription> result = null;
            try
            {
                result = await this.controller.UnsuspendSubscriptionAsync(storeId, subscriptionId, idempotencyKey);
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
                    "{\"id\":\"11ef335e-9aa5-c54a-8313-7f9847da313a\",\"store_id\":\"11edf541-c42d-653c-8c3d-dfe0a55f95c0\",\"transaction_token_id\":\"11ef32a7-3a71-8662-803f-1bc27702eeec\",\"amount\":1250,\"currency\":\"USD\",\"amount_formatted\":12.5,\"status\":\"unpaid\",\"mode\":\"test\",\"created_on\":\"2024-06-26T01:51:28.627023Z\",\"period\":\"monthly\"}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Replaces the payment method (transaction token) used for a subscription. Useful when a card expires or a customer wants to switch payment methods. The new token must belong to the same store, be active, and match the subscription's processing mode (live/test). One-time tokens are not accepted; use a recurring or subscription token..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestUpdateSubscriptionToken()
        {
            // Parameters for the API call
            Guid storeId = Guid.Parse("0cab399b-5621-425b-993b-f8507eba1e78");
            Guid subscriptionId = Guid.Parse("11ef335e-9aa5-c54a-8313-7f9847da313a");
            Models.SubscriptionPatchTokenRequest body = ApiHelper.JsonDeserialize<Models.SubscriptionPatchTokenRequest>("{\"transaction_token_id\":\"11ef3362-3700-c54a-9baa-6f7e6527c9d9\"}");
            string idempotencyKey = "f64be872-353d-4c3c-84cb-3dc617fe89f7";

            // Perform API call
            ApiResponse<Models.Subscription> result = null;
            try
            {
                result = await this.controller.UpdateSubscriptionTokenAsync(storeId, subscriptionId, body, idempotencyKey);
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
                    "{\"id\":\"11ef335e-9aa5-c54a-8313-7f9847da313a\",\"store_id\":\"11edf541-c42d-653c-8c3d-dfe0a55f95c0\",\"transaction_token_id\":\"11ef3362-3700-c54a-9baa-6f7e6527c9d9\",\"amount\":1250,\"currency\":\"USD\",\"amount_formatted\":12.5,\"status\":\"current\",\"mode\":\"test\",\"created_on\":\"2024-06-26T01:51:28.627023Z\",\"period\":\"monthly\"}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }
    }
}
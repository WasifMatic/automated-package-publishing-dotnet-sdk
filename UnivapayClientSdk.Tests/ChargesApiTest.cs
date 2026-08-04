// <copyright file="ChargesApiTest.cs" company="APIMatic">
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
    /// ChargesApiTest.
    /// </summary>
    [TestFixture]
    public class ChargesApiTest : ApiTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private ChargesApi controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.ChargesApi;
        }

        /// <summary>
        /// Creates a charge on a payment instrument (e.g. transaction token)..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestCreateCharge()
        {
            // Parameters for the API call
            string idempotencyKey = "f64be872-353d-4c3c-84cb-3dc617fe89f7";
            Models.ChargeCreateRequest body = ApiHelper.JsonDeserialize<Models.ChargeCreateRequest>("{\"transaction_token_id\":\"11ef32a7-3a71-8662-803f-1bc27702eeec\",\"amount\":1000,\"currency\":\"JPY\",\"metadata\":{\"order_id\":\"12345\"},\"redirect\":{\"endpoint\":\"https://test.url/\"}}");

            // Perform API call
            ApiResponse<Models.Charge> result = null;
            try
            {
                result = await this.controller.CreateChargeAsync(idempotencyKey, body);
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
                    "{\"id\":\"11ef32c2-4010-a312-aaff-4b63e4d5f92d\",\"store_id\":\"11edf541-c42d-653c-8c3d-dfe0a55f95c0\",\"transaction_token_id\":\"11ef32a7-3a71-8662-803f-1bc27702eeec\",\"transaction_token_type\":\"recurring\",\"subscription_id\":null,\"merchant_transaction_id\":null,\"requested_amount\":1000,\"requested_currency\":\"JPY\",\"requested_amount_formatted\":1000,\"charged_amount\":null,\"charged_currency\":null,\"charged_amount_formatted\":null,\"fee_amount\":null,\"fee_currency\":null,\"fee_amount_formatted\":null,\"only_direct_currency\":false,\"capture_at\":null,\"descriptor\":null,\"descriptor_phone_number\":null,\"status\":\"pending\",\"error\":null,\"metadata\":{\"order_id\":\"12345\"},\"mode\":\"test\",\"created_on\":\"2024-06-25T07:12:15.16452Z\",\"redirect\":{\"endpoint\":\"https://test.url/\",\"redirect_id\":\"11ef32c2-40cf-f772-8325-1798abb1110d\"}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Lists all charges across all stores for the authenticated user..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestListAllCharges()
        {
            // Parameters for the API call
            int? limit = 10;
            Guid? cursor = Guid.Parse("3541d4fa-596d-428e-8a36-f274e1b3d505");
            Models.CursorDirectionQuery cursorDirection = ApiHelper.JsonDeserialize<Models.CursorDirectionQuery>("\"desc\"");
            string lastFour = "4242";
            string name = "TARO YAMADA";
            int? expMonth = 12;
            int? expYear = 2026;
            string from = "2026-04-01T00:00:00Z";
            string to = "2026-04-30T23:59:59.999000Z";
            string email = "user@example.com";
            string phone = "+8108012341234";
            int? amountFrom = 1000;
            int? amountTo = 5000;
            string currency = "JPY";
            Models.ModeQuery mode = ApiHelper.JsonDeserialize<Models.ModeQuery>("\"live\"");
            string metadata = "order_id: 12345";
            Guid? transactionTokenId = Guid.Parse("f33b673e-564c-4645-ae17-ca03846a86b7");

            // Perform API call
            ApiResponse<Models.ChargeList> result = null;
            try
            {
                result = await this.controller.ListAllChargesAsync(limit, cursor, cursorDirection, lastFour, name, expMonth, expYear, from, to, email, phone, amountFrom, amountTo, currency, mode, metadata, transactionTokenId);
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
                    "{\"items\":[{\"id\":\"11ef3500-1a2b-4c3d-8e4f-a1b2c3d4e5f0\",\"store_id\":\"11edf541-c42d-653c-8c3d-dfe0a55f95c0\",\"transaction_token_id\":\"11ef3501-2b3c-4d5e-9f60-b2c3d4e5f011\",\"transaction_token_type\":\"one_time\",\"subscription_id\":null,\"merchant_transaction_id\":null,\"requested_amount\":1000,\"requested_currency\":\"JPY\",\"requested_amount_formatted\":1000,\"charged_amount\":1000,\"charged_currency\":\"JPY\",\"charged_amount_formatted\":1000,\"fee_amount\":null,\"fee_currency\":null,\"fee_amount_formatted\":null,\"only_direct_currency\":false,\"capture_at\":null,\"descriptor\":null,\"descriptor_phone_number\":null,\"status\":\"successful\",\"error\":{},\"metadata\":{\"order_id\":\"ORD-2001\"},\"mode\":\"live\",\"created_on\":\"2026-04-09T07:35:50.000000Z\",\"redirect\":{},\"merchant_name\":\"管理画面ガイド\",\"store_name\":\"管理画面ガイド_TEST店舗\"},{\"id\":\"11ef3502-3c4d-5e6f-a071-c3d4e5f01122\",\"store_id\":\"22af6520-d53e-764d-9d4e-ef01b66fa6d1\",\"transaction_token_id\":\"11ef3503-4d5e-6f70-b182-d4e5f0112233\",\"transaction_token_type\":\"recurring\",\"subscription_id\":null,\"merchant_transaction_id\":null,\"requested_amount\":1250,\"requested_currency\":\"USD\",\"requested_amount_formatted\":12.5,\"charged_amount\":1250,\"charged_currency\":\"USD\",\"charged_amount_formatted\":12.5,\"fee_amount\":null,\"fee_currency\":null,\"fee_amount_formatted\":null,\"only_direct_currency\":false,\"capture_at\":null,\"descriptor\":null,\"descriptor_phone_number\":null,\"status\":\"successful\",\"error\":{},\"metadata\":{\"order_id\":\"ORD-2002\"},\"mode\":\"live\",\"created_on\":\"2026-04-10T10:20:11.000000Z\",\"redirect\":{},\"merchant_name\":\"管理画面ガイド\",\"store_name\":\"管理画面ガイド_Online店舗\"},{\"id\":\"11ef3504-5e6f-7081-c293-e5f001223344\",\"store_id\":\"33af7631-e64f-875e-ae5f-f012c77fb7e2\",\"transaction_token_id\":\"11ef3505-6f70-8192-d3a4-f00112233455\",\"transaction_token_type\":\"one_time\",\"subscription_id\":null,\"merchant_transaction_id\":null,\"requested_amount\":5000,\"requested_currency\":\"JPY\",\"requested_amount_formatted\":5000,\"charged_amount\":5000,\"charged_currency\":\"JPY\",\"charged_amount_formatted\":5000,\"fee_amount\":null,\"fee_currency\":null,\"fee_amount_formatted\":null,\"only_direct_currency\":false,\"capture_at\":null,\"descriptor\":null,\"descriptor_phone_number\":null,\"status\":\"successful\",\"error\":{},\"metadata\":{\"order_id\":\"ORD-2003\"},\"mode\":\"live\",\"created_on\":\"2026-04-11T14:22:08.000000Z\",\"redirect\":{},\"merchant_name\":\"管理画面ガイド\",\"store_name\":\"管理画面ガイド_Osaka店舗\"}],\"has_more\":false,\"total_hits\":3}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Lists all charges for a specific store..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestListStoreCharges()
        {
            // Parameters for the API call
            Guid storeId = Guid.Parse("0cab399b-5621-425b-993b-f8507eba1e78");
            int? limit = 10;
            Guid? cursor = Guid.Parse("3541d4fa-596d-428e-8a36-f274e1b3d505");
            Models.CursorDirectionQuery cursorDirection = ApiHelper.JsonDeserialize<Models.CursorDirectionQuery>("\"desc\"");
            string lastFour = "4242";
            string name = "TARO YAMADA";
            int? expMonth = 12;
            int? expYear = 2026;
            string from = "2026-04-01T00:00:00Z";
            string to = "2026-04-30T23:59:59.999000Z";
            string email = "user@example.com";
            string phone = "+8108012341234";
            int? amountFrom = 1000;
            int? amountTo = 5000;
            string currency = "JPY";
            Models.ModeQuery mode = ApiHelper.JsonDeserialize<Models.ModeQuery>("\"live\"");
            string metadata = "order_id: 12345";
            Guid? transactionTokenId = Guid.Parse("f33b673e-564c-4645-ae17-ca03846a86b7");

            // Perform API call
            ApiResponse<Models.ChargeList> result = null;
            try
            {
                result = await this.controller.ListStoreChargesAsync(storeId, limit, cursor, cursorDirection, lastFour, name, expMonth, expYear, from, to, email, phone, amountFrom, amountTo, currency, mode, metadata, transactionTokenId);
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
                    "{\"items\":[{\"id\":\"11ef32c4-9ea8-169c-a6c8-bfc29867a226\",\"store_id\":\"11edf541-c42d-653c-8c3d-dfe0a55f95c0\",\"transaction_token_id\":\"11ef32c4-9e89-0cac-bd63-17b9a26af61b\",\"transaction_token_type\":\"one_time\",\"subscription_id\":null,\"merchant_transaction_id\":null,\"requested_amount\":1000,\"requested_currency\":\"JPY\",\"requested_amount_formatted\":1000,\"charged_amount\":1000,\"charged_currency\":\"JPY\",\"charged_amount_formatted\":1000,\"fee_amount\":null,\"fee_currency\":null,\"fee_amount_formatted\":null,\"only_direct_currency\":false,\"capture_at\":null,\"descriptor\":null,\"descriptor_phone_number\":null,\"status\":\"successful\",\"error\":{},\"metadata\":{\"univapay-name\":\"taro yamada\",\"univapay-phone-number\":\"8029854583\"},\"mode\":\"test\",\"created_on\":\"2024-06-25T07:29:12.854865Z\",\"redirect\":{},\"merchant_name\":\"管理画面ガイド\",\"store_name\":\"管理画面ガイド_TEST店舗\"},{\"id\":\"11ef32c3-3cfe-3bc0-abed-0bb96f792078\",\"store_id\":\"11edf541-c42d-653c-8c3d-dfe0a55f95c0\",\"transaction_token_id\":\"11ef32c3-3cdd-df92-9dce-c346b9fdf088\",\"transaction_token_type\":\"one_time\",\"subscription_id\":null,\"merchant_transaction_id\":null,\"requested_amount\":1000,\"requested_currency\":\"JPY\",\"requested_amount_formatted\":1000,\"charged_amount\":1000,\"charged_currency\":\"JPY\",\"charged_amount_formatted\":1000,\"fee_amount\":null,\"fee_currency\":null,\"fee_amount_formatted\":null,\"only_direct_currency\":false,\"capture_at\":null,\"descriptor\":null,\"descriptor_phone_number\":null,\"status\":\"successful\",\"error\":{},\"metadata\":{\"order_id\":\"12345\"},\"mode\":\"test\",\"created_on\":\"2024-06-25T07:19:19.507637Z\",\"redirect\":{},\"merchant_name\":\"管理画面ガイド\",\"store_name\":\"管理画面ガイド_TEST店舗\"}],\"has_more\":false,\"total_hits\":2}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Retrieves the details of an existing charge..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetCharge()
        {
            // Parameters for the API call
            Guid storeId = Guid.Parse("0cab399b-5621-425b-993b-f8507eba1e78");
            Guid id = Guid.Parse("c4e87129-cad4-47fb-8ded-b4c0a4ae0dd4");
            bool? polling = true;

            // Perform API call
            ApiResponse<Models.Charge> result = null;
            try
            {
                result = await this.controller.GetChargeAsync(storeId, id, polling);
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
                    "{\"id\":\"11ef32c2-4010-a312-aaff-4b63e4d5f92d\",\"store_id\":\"11edf541-c42d-653c-8c3d-dfe0a55f95c0\",\"transaction_token_id\":\"11ef32a7-3a71-8662-803f-1bc27702eeec\",\"transaction_token_type\":\"recurring\",\"subscription_id\":null,\"merchant_transaction_id\":null,\"requested_amount\":1000,\"requested_currency\":\"JPY\",\"requested_amount_formatted\":1000,\"charged_amount\":1000,\"charged_currency\":\"JPY\",\"charged_amount_formatted\":1000,\"fee_amount\":null,\"fee_currency\":null,\"fee_amount_formatted\":null,\"only_direct_currency\":false,\"capture_at\":null,\"descriptor\":null,\"descriptor_phone_number\":null,\"status\":\"successful\",\"error\":null,\"metadata\":{\"order_id\":\"12345\"},\"mode\":\"test\",\"created_on\":\"2024-06-25T07:12:15.16452Z\",\"redirect\":{\"endpoint\":\"https://test.url/\",\"redirect_id\":\"11ef32c2-40cf-f772-8325-1798abb1110d\"}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Use this request to add or modify arbitrary metadata on an existing charge..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestUpdateCharge()
        {
            // Parameters for the API call
            Guid storeId = Guid.Parse("0cab399b-5621-425b-993b-f8507eba1e78");
            Guid id = Guid.Parse("c4e87129-cad4-47fb-8ded-b4c0a4ae0dd4");
            string idempotencyKey = "f64be872-353d-4c3c-84cb-3dc617fe89f7";
            Models.ChargeUpdateRequest body = ApiHelper.JsonDeserialize<Models.ChargeUpdateRequest>("{\"metadata\":{\"order_id\":\"1234\"}}");

            // Perform API call
            ApiResponse<Models.Charge> result = null;
            try
            {
                result = await this.controller.UpdateChargeAsync(storeId, id, idempotencyKey, body);
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
                    "{\"id\":\"11ef32c2-4010-a312-aaff-4b63e4d5f92d\",\"store_id\":\"11edf541-c42d-653c-8c3d-dfe0a55f95c0\",\"transaction_token_id\":\"11ef32a7-3a71-8662-803f-1bc27702eeec\",\"transaction_token_type\":\"recurring\",\"subscription_id\":null,\"merchant_transaction_id\":null,\"requested_amount\":1000,\"requested_currency\":\"JPY\",\"requested_amount_formatted\":1000,\"charged_amount\":1000,\"charged_currency\":\"JPY\",\"charged_amount_formatted\":1000,\"fee_amount\":null,\"fee_currency\":null,\"fee_amount_formatted\":null,\"only_direct_currency\":false,\"capture_at\":null,\"descriptor\":null,\"descriptor_phone_number\":null,\"status\":\"successful\",\"error\":null,\"metadata\":{\"order_id\":\"1234\"},\"mode\":\"test\",\"created_on\":\"2024-06-25T07:12:15.16452Z\",\"redirect\":{\"endpoint\":\"https://test.url/\",\"redirect_id\":\"11ef32c2-40cf-f772-8325-1798abb1110d\"}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Captures a previously authorized charge (where `capture` was set to false during creation).  The capture amount must be less than or equal to the authorized amount, and the currency must match..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestCaptureCharge()
        {
            // Parameters for the API call
            Guid storeId = Guid.Parse("0cab399b-5621-425b-993b-f8507eba1e78");
            Guid id = Guid.Parse("c4e87129-cad4-47fb-8ded-b4c0a4ae0dd4");
            Models.ChargeCaptureRequest body = ApiHelper.JsonDeserialize<Models.ChargeCaptureRequest>("{\"amount\":1000,\"currency\":\"JPY\"}");
            string idempotencyKey = "f64be872-353d-4c3c-84cb-3dc617fe89f7";

            // Perform API call
            ApiResponse<object> result = null;
            try
            {
                result = await this.controller.CaptureChargeAsync(storeId, id, body, idempotencyKey);
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
                    "{}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Retrieves the necessary payment execution URL (for online payments) or bank account details (for bank transfers).
        ///**⚠️ Prerequisite:** The charge `status` must be `awaiting` before requesting the issuer token.  If requested while the charge is in any other status, an error will be returned..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetChargeIssuerToken()
        {
            // Parameters for the API call
            Guid storeId = Guid.Parse("0cab399b-5621-425b-993b-f8507eba1e78");
            Guid id = Guid.Parse("c4e87129-cad4-47fb-8ded-b4c0a4ae0dd4");

            // Perform API call
            ApiResponse<Models.IssuerToken> result = null;
            try
            {
                result = await this.controller.GetChargeIssuerTokenAsync(storeId, id);
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
                    "{\"issuer_token\":\"http://test.com/action\",\"call_method\":\"http_post\",\"payload\":{\"request_data\":\"example_value\"},\"payment_type\":\"online\"}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Retrieves the 3-D Secure issuer token details required to authenticate a card charge.
        ///**⚠️ Prerequisites:** 1. The charge must be created with `three_ds.mode` set to `normal` or `force`. 2. You must poll the charge until its `status` becomes `awaiting` before making this request.
        ///**Execution Flow:** Once retrieved, the client (browser) must execute an `http_post` request to the `issuer_token` URL.  The `payload` object must be formatted according to the `content_type` (e.g., URL-encoded) and sent in the body. You can execute this via a redirect or inside an iframe. If using an iframe, continue polling the charge status  in the background until it reaches `successful`, `failed`, or `error`..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetChargeThreeDsIssuerToken()
        {
            // Parameters for the API call
            Guid storeId = Guid.Parse("0cab399b-5621-425b-993b-f8507eba1e78");
            Guid id = Guid.Parse("c4e87129-cad4-47fb-8ded-b4c0a4ae0dd4");

            // Perform API call
            ApiResponse<Models.ThreeDsIssuerToken> result = null;
            try
            {
                result = await this.controller.GetChargeThreeDsIssuerTokenAsync(storeId, id);
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

        /// <summary>
        /// Retrieves bank transfer ledger entries associated with a charge. This is an optional reconciliation endpoint — not part of the required create-charge-and-poll flow.
        ///**⚠️ Requires a merchant-level application token**, unlike the rest of the bank transfer flow. A store application token (`Bearer {secret}.{jwt}` scoped to a `store_id`) is not sufficient here, even though the path is store-scoped..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestListBankTransferLedgers()
        {
            // Parameters for the API call
            Guid storeId = Guid.Parse("0cab399b-5621-425b-993b-f8507eba1e78");
            Guid id = Guid.Parse("c4e87129-cad4-47fb-8ded-b4c0a4ae0dd4");

            // Perform API call
            ApiResponse<Models.BankTransferLedgerList> result = null;
            try
            {
                result = await this.controller.ListBankTransferLedgersAsync(storeId, id);
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
                    "{\"items\":[{\"bank_ledger_type\":\"payment\",\"amount\":1000,\"balance\":0,\"virtual_bank_account_holder_name\":\"test holder name\",\"virtual_bank_account_number\":\"1234567\",\"virtual_account_id\":\"test account id\",\"transaction_date\":\"2024-06-25\",\"transaction_timestamp\":\"2024-06-25T07:29:16.367347Z\",\"mode\":\"test\",\"created_on\":\"2024-06-25T07:29:16.373181Z\"},{\"bank_ledger_type\":\"deposit\",\"amount\":1000,\"balance\":1000,\"virtual_bank_account_holder_name\":\"test holder name\",\"virtual_bank_account_number\":\"1234567\",\"virtual_account_id\":\"test account id\",\"transaction_date\":\"2024-06-25\",\"transaction_timestamp\":\"2024-06-25T07:29:16.36731Z\",\"mode\":\"test\",\"created_on\":\"2024-06-25T07:29:16.368093Z\"}],\"has_more\":false,\"total_hits\":2}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Creates a customs declaration for a successful charge. Backend only accepts this request for WeChat Online and WeChat MPM charges. If a declaration already exists and is no longer pending, the backend updates its identity fields and restarts processing instead of creating a new record..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestCreateCustomsDeclaration()
        {
            // Parameters for the API call
            Guid storeId = Guid.Parse("0cab399b-5621-425b-993b-f8507eba1e78");
            Guid chargeId = Guid.Parse("6efb4e5c-690a-40f3-a4f1-0e19c5f84e98");
            Models.CustomsDeclarationCreateRequest body = ApiHelper.JsonDeserialize<Models.CustomsDeclarationCreateRequest>("{\"customs\":\"TOKYO\",\"merchant_customs_no\":\"1234567890\",\"certificate_id\":\"AB1234567\",\"certificate_name\":\"TARO YAMADA\"}");
            string idempotencyKey = "f64be872-353d-4c3c-84cb-3dc617fe89f7";

            // Perform API call
            ApiResponse<Models.CustomsDeclarationWebhookData> result = null;
            try
            {
                result = await this.controller.CreateCustomsDeclarationAsync(storeId, chargeId, body, idempotencyKey);
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
                    "{\"id\":\"11ef0000-0000-4000-8000-000000000040\",\"charge_id\":\"11ef0000-0000-4000-8000-000000000001\",\"merchant_id\":\"11ef0000-0000-4000-8000-000000000020\",\"store_id\":\"11ef0000-0000-4000-8000-000000000022\",\"mode\":\"test\",\"gateway\":\"wechat_online\",\"declaration\":{\"customs\":\"TOKYO\",\"merchant_customs_no\":\"1234567890\",\"certificate_id\":\"AB1234567\",\"certificate_name\":\"TARO YAMADA\"},\"declaration_result\":{},\"status\":\"pending\",\"error\":null,\"created_on\":\"2026-04-09T07:35:50.000000Z\"}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Creates a customs declaration for a successful charge. Backend only accepts this request for WeChat Online and WeChat MPM charges. If a declaration already exists and is no longer pending, the backend updates its identity fields and restarts processing instead of creating a new record..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestCreateCustomsDeclaration1()
        {
            // Parameters for the API call
            Guid storeId = Guid.Parse("0cab399b-5621-425b-993b-f8507eba1e78");
            Guid chargeId = Guid.Parse("6efb4e5c-690a-40f3-a4f1-0e19c5f84e98");
            Models.CustomsDeclarationCreateRequest body = ApiHelper.JsonDeserialize<Models.CustomsDeclarationCreateRequest>("{\"customs\":\"TOKYO\",\"merchant_customs_no\":\"1234567890\",\"certificate_id\":\"AB1234567\",\"certificate_name\":\"TARO YAMADA\"}");
            string idempotencyKey = "f64be872-353d-4c3c-84cb-3dc617fe89f7";

            // One-off client whose HttpClient sends "Prefer: code=201" so the Prism
            // mock returns the 201 response on this dual-status endpoint (mirrors the
            // TypeScript harness fix for createCustomsDeclaration1).
            var preferHttpClient = new System.Net.Http.HttpClient();
            preferHttpClient.DefaultRequestHeaders.Add("Prefer", "code=201");
            var preferCallBack = new HttpCallback();
            UnivapayClientSdkClient preferredClient = this.Client.ToBuilder()
                .HttpCallback(preferCallBack)
                .HttpClientConfig(config => config.HttpClientInstance(preferHttpClient))
                .Build();
            ChargesApi preferredController = preferredClient.ChargesApi;

            // Perform API call
            ApiResponse<Models.CustomsDeclarationWebhookData> result = null;
            try
            {
                result = await preferredController.CreateCustomsDeclarationAsync(storeId, chargeId, body, idempotencyKey);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(201, preferCallBack.Response.StatusCode, "Status should be 201");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/json");

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    preferCallBack.Response.Headers),
                    "Headers should match");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsProperSubsetOf(
                    "{\"id\":\"11ef0000-0000-4000-8000-000000000040\",\"charge_id\":\"11ef0000-0000-4000-8000-000000000001\",\"merchant_id\":\"11ef0000-0000-4000-8000-000000000020\",\"store_id\":\"11ef0000-0000-4000-8000-000000000022\",\"mode\":\"test\",\"gateway\":\"wechat_online\",\"declaration\":{\"customs\":\"TOKYO\",\"merchant_customs_no\":\"1234567890\",\"certificate_id\":\"AB1234567\",\"certificate_name\":\"TARO YAMADA\"},\"declaration_result\":{},\"status\":\"pending\",\"error\":null,\"created_on\":\"2026-04-09T07:35:50.000000Z\"}",
                    TestHelper.ConvertStreamToString(preferCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Retrieves a customs declaration for a charge. Supports long polling when `polling=true`, returning once the declaration leaves its current state or the polling timeout is reached..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetCustomsDeclaration()
        {
            // Parameters for the API call
            Guid storeId = Guid.Parse("0cab399b-5621-425b-993b-f8507eba1e78");
            Guid chargeId = Guid.Parse("6efb4e5c-690a-40f3-a4f1-0e19c5f84e98");
            Guid id = Guid.Parse("11ef0000-0000-4000-8000-000000000040");
            bool? polling = false;

            // Perform API call
            ApiResponse<Models.CustomsDeclarationWebhookData> result = null;
            try
            {
                result = await this.controller.GetCustomsDeclarationAsync(storeId, chargeId, id, polling);
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
                    "{\"id\":\"11ef0000-0000-4000-8000-000000000040\",\"charge_id\":\"11ef0000-0000-4000-8000-000000000001\",\"merchant_id\":\"11ef0000-0000-4000-8000-000000000020\",\"store_id\":\"11ef0000-0000-4000-8000-000000000022\",\"mode\":\"test\",\"gateway\":\"wechat_online\",\"declaration\":{\"customs\":\"TOKYO\",\"merchant_customs_no\":\"1234567890\",\"certificate_id\":\"AB1234567\",\"certificate_name\":\"TARO YAMADA\"},\"declaration_result\":{\"approving_authority\":\"TOKYO\",\"trade_id\":\"wx_trade_12345\",\"transaction_id\":\"wx_txn_12345\",\"charge_transaction_id\":\"wx_charge_12345\"},\"status\":\"successful\",\"error\":null,\"created_on\":\"2026-04-09T07:35:50.000000Z\"}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Updates a customs declaration and requeues processing. Backend patching preserves the original `customs`, `certificate_id`, and `certificate_name` values and only accepts a new `merchant_customs_no`. Pending declarations cannot be patched..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestPatchCustomsDeclaration()
        {
            // Parameters for the API call
            Guid storeId = Guid.Parse("0cab399b-5621-425b-993b-f8507eba1e78");
            Guid chargeId = Guid.Parse("6efb4e5c-690a-40f3-a4f1-0e19c5f84e98");
            Guid id = Guid.Parse("11ef0000-0000-4000-8000-000000000040");
            Models.CustomsDeclarationPatchRequest body = ApiHelper.JsonDeserialize<Models.CustomsDeclarationPatchRequest>("{\"merchant_customs_no\":\"1234567891\"}");
            string idempotencyKey = "f64be872-353d-4c3c-84cb-3dc617fe89f7";

            // Perform API call
            ApiResponse<Models.CustomsDeclarationWebhookData> result = null;
            try
            {
                result = await this.controller.PatchCustomsDeclarationAsync(storeId, chargeId, id, body, idempotencyKey);
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
                    "{\"id\":\"11ef0000-0000-4000-8000-000000000040\",\"charge_id\":\"11ef0000-0000-4000-8000-000000000001\",\"merchant_id\":\"11ef0000-0000-4000-8000-000000000020\",\"store_id\":\"11ef0000-0000-4000-8000-000000000022\",\"mode\":\"test\",\"gateway\":\"wechat_online\",\"declaration\":{\"customs\":\"TOKYO\",\"merchant_customs_no\":\"1234567891\",\"certificate_id\":\"AB1234567\",\"certificate_name\":\"TARO YAMADA\"},\"declaration_result\":{},\"status\":\"pending\",\"error\":null,\"created_on\":\"2026-04-09T07:35:50.000000Z\"}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }
    }
}
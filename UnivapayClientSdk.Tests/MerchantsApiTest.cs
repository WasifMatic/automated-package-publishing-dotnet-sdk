// <copyright file="MerchantsApiTest.cs" company="APIMatic">
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
    /// MerchantsApiTest.
    /// </summary>
    [TestFixture]
    public class MerchantsApiTest : ApiTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private MerchantsApi controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.MerchantsApi;
        }

        /// <summary>
        /// Returns merchant identity and the effective configuration resolved from bearer credentials. Treat this as the canonical introspection endpoint for merchant integrations..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetCurrentMerchant()
        {
            // Perform API call
            ApiResponse<Models.Merchant> result = null;
            try
            {
                result = await this.controller.GetCurrentMerchantAsync();
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
                    "{\"id\":\"11ef0000-0000-4000-8000-000000000020\",\"verification_data_id\":\"11ef0000-0000-4000-8000-000000000021\",\"name\":\"Example Merchant\",\"email\":\"owner@example.com\",\"notification_email\":\"alerts@example.com\",\"finance_notification_email\":\"finance@example.com\",\"verified\":true,\"configuration\":{\"percent_fee\":3.6,\"country\":\"JP\",\"language\":\"ja\",\"minimum_charge_amounts\":[{\"amount\":100,\"currency\":\"JPY\"}],\"maximum_charge_amounts\":[{\"amount\":100000,\"currency\":\"JPY\"}],\"user_transactions_configuration\":{\"enabled\":true,\"notify_customer\":true,\"notify_on_webhook_failure\":true},\"card_configuration\":{\"enabled\":true,\"debit_enabled\":true,\"prepaid_enabled\":false,\"three_ds_required\":true},\"online_configuration\":{\"enabled\":true},\"bank_transfer_configuration\":{\"enabled\":true,\"match_amount\":true,\"expiration\":\"P7D\"}},\"created_on\":\"2026-04-09T07:35:50.000000Z\"}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }
    }
}
// <copyright file="BankTransferHandlerTests.cs" company="APIMatic">
// UnivapayClientSdk.Tests
//
// This file was automatically generated for Univapay by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using NUnit.Framework;
using System;
using System.Text;
using System.Threading.Tasks;
using UnivaPay.Events.Webhooks;
using UnivaPay.Utilities;

namespace UnivaPay
{
    [TestFixture]
    public class BankTransferHandlerTests
    {
        [Test]
        public async Task OnBankTransferStatusUpdated_BankTransferHandler_ReturnsBankTransferStatusUpdatedEvent()
        {
            // Arrange
            const string body = 
                "{\"id\":\"11ef0000-0000-4000-8000-000000000001\",\"event\":\"bank_transfer_status_updated\",\"data\":{\"id\":\"11ef0000-0000-4000-8000-000000000002\",\"charge_id\":\"11ef0000-0000-4000-8000-000000000001\",\"payment_status\":\"exact\",\"latest_deposit_date\":\"2026-04-09T07:35:50.000000Z\",\"created_on\":\"2026-04-09T07:35:50.000000Z\",\"latest_deposit_amount\":1000,\"balance\":0,\"currency\":\"JPY\",\"amount\":1000,\"amount_difference\":0,\"token_metadata\":{\"order_id\":\"12345\"},\"charge_metadata\":{\"order_id\":\"order_12345\"},\"exampleAdditionalProperty\":{\"key1\":\"val1\",\"key2\":\"val2\"}},\"created_on\":\"2026-04-09T07:35:50.000000Z\",\"exampleAdditionalProperty\":{\"key1\":\"val1\",\"key2\":\"val2\"}}";
            var payload = Encoding.UTF8.GetBytes(body);
            var httpRequestData = HttpRequestDataTestFactory.CreatePostRequestWithBody(payload);

            // Act
            var parsingResult = await BankTransferHandler.ParseEventAsync(httpRequestData);
            var result =  parsingResult.MatchSome(
                bankTransferStatusUpdated: bankTransferStatusUpdated => true
            );

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public async Task OnInvalidPayload_BankTransferHandler_ReturnsUnknown()
        {
            // Arrange
            var payload = Array.Empty<byte>();
            var httpRequestData = HttpRequestDataTestFactory.CreatePostRequestWithBody(payload);

            // Act
            var parsingResult = await BankTransferHandler.ParseEventAsync(httpRequestData);
            var result =  parsingResult.MatchSome(
                unknown: () => true
            );

            // Assert
            Assert.IsTrue(result);
        }
    }
}
// <copyright file="RefundHandlerTests.cs" company="APIMatic">
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
    public class RefundHandlerTests
    {
        [Test]
        public async Task OnRefundFinished_RefundHandler_ReturnsRefundFinishedEvent()
        {
            // Arrange
            const string body = 
                "{\"id\":\"11ef0000-0000-4000-8000-000000000001\",\"event\":\"refund_finished\",\"data\":{\"id\":\"b4d9fea9-c9b3-4e76-a25d-b61f7e4821b6\",\"store_id\":\"76cf4a64-02bc-4cb3-9a28-74622e5928a1\",\"charge_id\":\"6efb4e5c-690a-40f3-a4f1-0e19c5f84e98\",\"status\":\"successful\",\"amount\":1000,\"currency\":\"JPY\",\"amount_formatted\":1000,\"reason\":\"customer_request\",\"message\":\"Customer returned item\",\"error\":null,\"metadata\":{\"order_id\":\"order_12345\"},\"mode\":\"live\",\"created_on\":\"2026-04-09T07:35:50.000000Z\",\"updated_on\":\"2026-04-09T07:36:00.000000Z\",\"exampleAdditionalProperty\":{\"key1\":\"val1\",\"key2\":\"val2\"}},\"created_on\":\"2026-04-09T07:35:50.000000Z\",\"exampleAdditionalProperty\":{\"key1\":\"val1\",\"key2\":\"val2\"}}";
            var payload = Encoding.UTF8.GetBytes(body);
            var httpRequestData = HttpRequestDataTestFactory.CreatePostRequestWithBody(payload);

            // Act
            var parsingResult = await RefundHandler.ParseEventAsync(httpRequestData);
            var result =  parsingResult.MatchSome(
                refundFinished: refundFinished => true
            );

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public async Task OnInvalidPayload_RefundHandler_ReturnsUnknown()
        {
            // Arrange
            var payload = Array.Empty<byte>();
            var httpRequestData = HttpRequestDataTestFactory.CreatePostRequestWithBody(payload);

            // Act
            var parsingResult = await RefundHandler.ParseEventAsync(httpRequestData);
            var result =  parsingResult.MatchSome(
                unknown: () => true
            );

            // Assert
            Assert.IsTrue(result);
        }
    }
}
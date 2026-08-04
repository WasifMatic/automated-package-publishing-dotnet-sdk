// <copyright file="CancelHandlerTests.cs" company="APIMatic">
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
    public class CancelHandlerTests
    {
        [Test]
        public async Task OnCancelFinished_CancelHandler_ReturnsCancelFinishedEvent()
        {
            // Arrange
            const string body = 
                "{\"id\":\"11ef0000-0000-4000-8000-000000000001\",\"event\":\"cancel_finished\",\"data\":{\"id\":\"a1b2c3d4-e5f6-7890-abcd-ef1234567890\",\"charge_id\":\"6efb4e5c-690a-40f3-a4f1-0e19c5f84e98\",\"store_id\":\"76cf4a64-02bc-4cb3-9a28-74622e5928a1\",\"status\":\"successful\",\"error\":null,\"metadata\":{\"order_id\":\"order_12345\"},\"mode\":\"live\",\"created_on\":\"2026-04-09T07:35:50.000000Z\",\"updated_on\":\"2026-04-09T07:36:00.000000Z\",\"exampleAdditionalProperty\":{\"key1\":\"val1\",\"key2\":\"val2\"}},\"created_on\":\"2026-04-09T07:35:50.000000Z\",\"exampleAdditionalProperty\":{\"key1\":\"val1\",\"key2\":\"val2\"}}";
            var payload = Encoding.UTF8.GetBytes(body);
            var httpRequestData = HttpRequestDataTestFactory.CreatePostRequestWithBody(payload);

            // Act
            var parsingResult = await CancelHandler.ParseEventAsync(httpRequestData);
            var result =  parsingResult.MatchSome(
                cancelFinished: cancelFinished => true
            );

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public async Task OnInvalidPayload_CancelHandler_ReturnsUnknown()
        {
            // Arrange
            var payload = Array.Empty<byte>();
            var httpRequestData = HttpRequestDataTestFactory.CreatePostRequestWithBody(payload);

            // Act
            var parsingResult = await CancelHandler.ParseEventAsync(httpRequestData);
            var result =  parsingResult.MatchSome(
                unknown: () => true
            );

            // Assert
            Assert.IsTrue(result);
        }
    }
}
// <copyright file="CustomsHandlerTests.cs" company="APIMatic">
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
    public class CustomsHandlerTests
    {
        [Test]
        public async Task OnCustomsDeclarationFinished_CustomsHandler_ReturnsCustomsDeclarationFinishedEvent()
        {
            // Arrange
            const string body = 
                "{\"id\":\"11ef0000-0000-4000-8000-000000000001\",\"event\":\"customs_declaration_finished\",\"data\":{\"id\":\"11ef0000-0000-4000-8000-000000000040\",\"charge_id\":\"11ef0000-0000-4000-8000-000000000001\",\"merchant_id\":\"11ef0000-0000-4000-8000-000000000020\",\"store_id\":\"11ef0000-0000-4000-8000-000000000022\",\"mode\":\"test\",\"gateway\":\"wechat_online\",\"declaration\":{\"customs\":\"TOKYO\",\"merchant_customs_no\":\"1234567890\",\"certificate_id\":\"AB1234567\",\"certificate_name\":\"TARO YAMADA\"},\"declaration_result\":{\"approving_authority\":\"TOKYO\",\"trade_id\":\"wx_trade_12345\",\"transaction_id\":\"wx_txn_12345\",\"charge_transaction_id\":\"wx_charge_12345\"},\"status\":\"successful\",\"created_on\":\"2026-04-09T07:35:50.000000Z\",\"platform_id\":\"00000550-0000-0000-0000-000000000000\",\"exampleAdditionalProperty\":{\"key1\":\"val1\",\"key2\":\"val2\"}},\"created_on\":\"2026-04-09T07:35:50.000000Z\",\"exampleAdditionalProperty\":{\"key1\":\"val1\",\"key2\":\"val2\"}}";
            var payload = Encoding.UTF8.GetBytes(body);
            var httpRequestData = HttpRequestDataTestFactory.CreatePostRequestWithBody(payload);

            // Act
            var parsingResult = await CustomsHandler.ParseEventAsync(httpRequestData);
            var result =  parsingResult.MatchSome(
                customsDeclarationFinished: customsDeclarationFinished => true
            );

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public async Task OnInvalidPayload_CustomsHandler_ReturnsUnknown()
        {
            // Arrange
            var payload = Array.Empty<byte>();
            var httpRequestData = HttpRequestDataTestFactory.CreatePostRequestWithBody(payload);

            // Act
            var parsingResult = await CustomsHandler.ParseEventAsync(httpRequestData);
            var result =  parsingResult.MatchSome(
                unknown: () => true
            );

            // Assert
            Assert.IsTrue(result);
        }
    }
}
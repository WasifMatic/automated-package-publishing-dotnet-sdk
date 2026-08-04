// <copyright file="SubscriptionHandlerTests.cs" company="APIMatic">
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
    public class SubscriptionHandlerTests
    {
        [Test]
        public async Task OnSubscriptionCreated_SubscriptionHandler_ReturnsSubscriptionCreatedEvent()
        {
            // Arrange
            const string body = 
                "{\"id\":\"11ef0000-0000-4000-8000-000000000001\",\"event\":\"subscription_created\",\"data\":{\"id\":\"11ef335e-9aa5-c54a-8313-7f9847da313a\",\"store_id\":\"11edf541-c42d-653c-8c3d-dfe0a55f95c0\",\"transaction_token_id\":\"11ef32a7-3a71-8662-803f-1bc27702eeec\",\"amount\":1250,\"currency\":\"USD\",\"amount_formatted\":12.5,\"schedule_settings\":{\"start_on\":\"2024-07-01\",\"zone_id\":\"Asia/Tokyo\",\"preserve_end_of_month\":false,\"retry_interval\":\"P7D\",\"termination_mode\":\"on_next_payment\"},\"only_direct_currency\":false,\"first_charge_authorization_only\":false,\"status\":\"current\",\"metadata\":{\"order_id\":\"12345\"},\"mode\":\"test\",\"created_on\":\"2024-06-26T01:51:28.627023Z\",\"period\":\"monthly\",\"exampleAdditionalProperty\":{\"key1\":\"val1\",\"key2\":\"val2\"}},\"created_on\":\"2026-04-09T07:35:50.000000Z\",\"exampleAdditionalProperty\":{\"key1\":\"val1\",\"key2\":\"val2\"}}";
            var payload = Encoding.UTF8.GetBytes(body);
            var httpRequestData = HttpRequestDataTestFactory.CreatePostRequestWithBody(payload);

            // Act
            var parsingResult = await SubscriptionHandler.ParseEventAsync(httpRequestData);
            var result =  parsingResult.MatchSome(
                subscriptionCreated: subscriptionCreated => true
            );

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public async Task OnSubscriptionPayment_SubscriptionHandler_ReturnsSubscriptionPaymentEvent()
        {
            // Arrange
            const string body = 
                "{\"id\":\"11ef0000-0000-4000-8000-000000000001\",\"event\":\"subscription_payment\",\"data\":{\"id\":\"11ef335e-9aa5-c54a-8313-7f9847da313a\",\"store_id\":\"11edf541-c42d-653c-8c3d-dfe0a55f95c0\",\"transaction_token_id\":\"11ef32a7-3a71-8662-803f-1bc27702eeec\",\"amount\":1250,\"currency\":\"USD\",\"amount_formatted\":12.5,\"schedule_settings\":{\"start_on\":\"2024-07-01\",\"zone_id\":\"Asia/Tokyo\",\"preserve_end_of_month\":false,\"retry_interval\":\"P7D\",\"termination_mode\":\"on_next_payment\"},\"only_direct_currency\":false,\"first_charge_authorization_only\":false,\"status\":\"current\",\"metadata\":{\"order_id\":\"12345\"},\"mode\":\"test\",\"created_on\":\"2024-06-26T01:51:28.627023Z\",\"period\":\"monthly\",\"exampleAdditionalProperty\":{\"key1\":\"val1\",\"key2\":\"val2\"}},\"created_on\":\"2026-04-09T07:35:50.000000Z\",\"exampleAdditionalProperty\":{\"key1\":\"val1\",\"key2\":\"val2\"}}";
            var payload = Encoding.UTF8.GetBytes(body);
            var httpRequestData = HttpRequestDataTestFactory.CreatePostRequestWithBody(payload);

            // Act
            var parsingResult = await SubscriptionHandler.ParseEventAsync(httpRequestData);
            var result =  parsingResult.MatchSome(
                subscriptionPayment: subscriptionPayment => true
            );

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public async Task OnSubscriptionCompleted_SubscriptionHandler_ReturnsSubscriptionCompletedEvent()
        {
            // Arrange
            const string body = 
                "{\"id\":\"11ef0000-0000-4000-8000-000000000001\",\"event\":\"subscription_completed\",\"data\":{\"id\":\"11ef335e-9aa5-c54a-8313-7f9847da313a\",\"store_id\":\"11edf541-c42d-653c-8c3d-dfe0a55f95c0\",\"transaction_token_id\":\"11ef32a7-3a71-8662-803f-1bc27702eeec\",\"amount\":1250,\"currency\":\"USD\",\"amount_formatted\":12.5,\"schedule_settings\":{\"start_on\":\"2024-07-01\",\"zone_id\":\"Asia/Tokyo\",\"preserve_end_of_month\":false,\"retry_interval\":\"P7D\",\"termination_mode\":\"on_next_payment\"},\"only_direct_currency\":false,\"first_charge_authorization_only\":false,\"status\":\"current\",\"metadata\":{\"order_id\":\"12345\"},\"mode\":\"test\",\"created_on\":\"2024-06-26T01:51:28.627023Z\",\"period\":\"monthly\",\"exampleAdditionalProperty\":{\"key1\":\"val1\",\"key2\":\"val2\"}},\"created_on\":\"2026-04-09T07:35:50.000000Z\",\"exampleAdditionalProperty\":{\"key1\":\"val1\",\"key2\":\"val2\"}}";
            var payload = Encoding.UTF8.GetBytes(body);
            var httpRequestData = HttpRequestDataTestFactory.CreatePostRequestWithBody(payload);

            // Act
            var parsingResult = await SubscriptionHandler.ParseEventAsync(httpRequestData);
            var result =  parsingResult.MatchSome(
                subscriptionCompleted: subscriptionCompleted => true
            );

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public async Task OnSubscriptionFailure_SubscriptionHandler_ReturnsSubscriptionFailureEvent()
        {
            // Arrange
            const string body = 
                "{\"id\":\"11ef0000-0000-4000-8000-000000000001\",\"event\":\"subscription_failure\",\"data\":{\"id\":\"11ef335e-9aa5-c54a-8313-7f9847da313a\",\"store_id\":\"11edf541-c42d-653c-8c3d-dfe0a55f95c0\",\"transaction_token_id\":\"11ef32a7-3a71-8662-803f-1bc27702eeec\",\"amount\":1250,\"currency\":\"USD\",\"amount_formatted\":12.5,\"schedule_settings\":{\"start_on\":\"2024-07-01\",\"zone_id\":\"Asia/Tokyo\",\"preserve_end_of_month\":false,\"retry_interval\":\"P7D\",\"termination_mode\":\"on_next_payment\"},\"only_direct_currency\":false,\"first_charge_authorization_only\":false,\"status\":\"current\",\"metadata\":{\"order_id\":\"12345\"},\"mode\":\"test\",\"created_on\":\"2024-06-26T01:51:28.627023Z\",\"period\":\"monthly\",\"exampleAdditionalProperty\":{\"key1\":\"val1\",\"key2\":\"val2\"}},\"created_on\":\"2026-04-09T07:35:50.000000Z\",\"exampleAdditionalProperty\":{\"key1\":\"val1\",\"key2\":\"val2\"}}";
            var payload = Encoding.UTF8.GetBytes(body);
            var httpRequestData = HttpRequestDataTestFactory.CreatePostRequestWithBody(payload);

            // Act
            var parsingResult = await SubscriptionHandler.ParseEventAsync(httpRequestData);
            var result =  parsingResult.MatchSome(
                subscriptionFailure: subscriptionFailure => true
            );

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public async Task OnSubscriptionCanceled_SubscriptionHandler_ReturnsSubscriptionCanceledEvent()
        {
            // Arrange
            const string body = 
                "{\"id\":\"11ef0000-0000-4000-8000-000000000001\",\"event\":\"subscription_canceled\",\"data\":{\"id\":\"11ef335e-9aa5-c54a-8313-7f9847da313a\",\"store_id\":\"11edf541-c42d-653c-8c3d-dfe0a55f95c0\",\"transaction_token_id\":\"11ef32a7-3a71-8662-803f-1bc27702eeec\",\"amount\":1250,\"currency\":\"USD\",\"amount_formatted\":12.5,\"schedule_settings\":{\"start_on\":\"2024-07-01\",\"zone_id\":\"Asia/Tokyo\",\"preserve_end_of_month\":false,\"retry_interval\":\"P7D\",\"termination_mode\":\"on_next_payment\"},\"only_direct_currency\":false,\"first_charge_authorization_only\":false,\"status\":\"current\",\"metadata\":{\"order_id\":\"12345\"},\"mode\":\"test\",\"created_on\":\"2024-06-26T01:51:28.627023Z\",\"period\":\"monthly\",\"exampleAdditionalProperty\":{\"key1\":\"val1\",\"key2\":\"val2\"}},\"created_on\":\"2026-04-09T07:35:50.000000Z\",\"exampleAdditionalProperty\":{\"key1\":\"val1\",\"key2\":\"val2\"}}";
            var payload = Encoding.UTF8.GetBytes(body);
            var httpRequestData = HttpRequestDataTestFactory.CreatePostRequestWithBody(payload);

            // Act
            var parsingResult = await SubscriptionHandler.ParseEventAsync(httpRequestData);
            var result =  parsingResult.MatchSome(
                subscriptionCanceled: subscriptionCanceled => true
            );

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public async Task OnSubscriptionSuspended_SubscriptionHandler_ReturnsSubscriptionSuspendedEvent()
        {
            // Arrange
            const string body = 
                "{\"id\":\"11ef0000-0000-4000-8000-000000000001\",\"event\":\"subscription_suspended\",\"data\":{\"id\":\"11ef335e-9aa5-c54a-8313-7f9847da313a\",\"store_id\":\"11edf541-c42d-653c-8c3d-dfe0a55f95c0\",\"transaction_token_id\":\"11ef32a7-3a71-8662-803f-1bc27702eeec\",\"amount\":1250,\"currency\":\"USD\",\"amount_formatted\":12.5,\"schedule_settings\":{\"start_on\":\"2024-07-01\",\"zone_id\":\"Asia/Tokyo\",\"preserve_end_of_month\":false,\"retry_interval\":\"P7D\",\"termination_mode\":\"on_next_payment\"},\"only_direct_currency\":false,\"first_charge_authorization_only\":false,\"status\":\"current\",\"metadata\":{\"order_id\":\"12345\"},\"mode\":\"test\",\"created_on\":\"2024-06-26T01:51:28.627023Z\",\"period\":\"monthly\",\"exampleAdditionalProperty\":{\"key1\":\"val1\",\"key2\":\"val2\"}},\"created_on\":\"2026-04-09T07:35:50.000000Z\",\"exampleAdditionalProperty\":{\"key1\":\"val1\",\"key2\":\"val2\"}}";
            var payload = Encoding.UTF8.GetBytes(body);
            var httpRequestData = HttpRequestDataTestFactory.CreatePostRequestWithBody(payload);

            // Act
            var parsingResult = await SubscriptionHandler.ParseEventAsync(httpRequestData);
            var result =  parsingResult.MatchSome(
                subscriptionSuspended: subscriptionSuspended => true
            );

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public async Task OnInvalidPayload_SubscriptionHandler_ReturnsUnknown()
        {
            // Arrange
            var payload = Array.Empty<byte>();
            var httpRequestData = HttpRequestDataTestFactory.CreatePostRequestWithBody(payload);

            // Act
            var parsingResult = await SubscriptionHandler.ParseEventAsync(httpRequestData);
            var result =  parsingResult.MatchSome(
                unknown: () => true
            );

            // Assert
            Assert.IsTrue(result);
        }
    }
}
// <copyright file="TokenHandlerTests.cs" company="APIMatic">
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
    public class TokenHandlerTests
    {
        [Test]
        public async Task OnTokenCreated_TokenHandler_ReturnsTokenCreatedEvent()
        {
            // Arrange
            const string body = 
                "{\"id\":\"11ef0000-0000-4000-8000-000000000001\",\"event\":\"token_created\",\"data\":{\"id\":\"6426bbd2-17bd-41bf-883b-1fe970db48ee\",\"store_id\":\"fc264608-9a9e-495e-844e-a08129a81af4\",\"email\":\"test@univapay.com\",\"payment_type\":\"card\",\"active\":true,\"mode\":\"live\",\"type\":\"recurring\",\"confirmed\":true,\"metadata\":{\"customer_id\":\"cust_12345\"},\"created_on\":\"2026-04-09T07:35:50.000000Z\",\"updated_on\":\"2026-04-09T07:35:50.000000Z\",\"exampleAdditionalProperty\":{\"key1\":\"val1\",\"key2\":\"val2\"}},\"created_on\":\"2026-04-09T07:35:50.000000Z\",\"exampleAdditionalProperty\":{\"key1\":\"val1\",\"key2\":\"val2\"}}";
            var payload = Encoding.UTF8.GetBytes(body);
            var httpRequestData = HttpRequestDataTestFactory.CreatePostRequestWithBody(payload);

            // Act
            var parsingResult = await TokenHandler.ParseEventAsync(httpRequestData);
            var result =  parsingResult.MatchSome(
                tokenCreated: tokenCreated => true
            );

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public async Task OnTokenUpdated_TokenHandler_ReturnsTokenUpdatedEvent()
        {
            // Arrange
            const string body = 
                "{\"id\":\"11ef0000-0000-4000-8000-000000000001\",\"event\":\"token_updated\",\"data\":{\"id\":\"6426bbd2-17bd-41bf-883b-1fe970db48ee\",\"store_id\":\"fc264608-9a9e-495e-844e-a08129a81af4\",\"email\":\"test@univapay.com\",\"payment_type\":\"card\",\"active\":true,\"mode\":\"live\",\"type\":\"recurring\",\"confirmed\":true,\"metadata\":{\"customer_id\":\"cust_12345\"},\"created_on\":\"2026-04-09T07:35:50.000000Z\",\"updated_on\":\"2026-04-09T07:35:50.000000Z\",\"exampleAdditionalProperty\":{\"key1\":\"val1\",\"key2\":\"val2\"}},\"created_on\":\"2026-04-09T07:35:50.000000Z\",\"exampleAdditionalProperty\":{\"key1\":\"val1\",\"key2\":\"val2\"}}";
            var payload = Encoding.UTF8.GetBytes(body);
            var httpRequestData = HttpRequestDataTestFactory.CreatePostRequestWithBody(payload);

            // Act
            var parsingResult = await TokenHandler.ParseEventAsync(httpRequestData);
            var result =  parsingResult.MatchSome(
                tokenUpdated: tokenUpdated => true
            );

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public async Task OnTokenThreeDsUpdated_TokenHandler_ReturnsTokenThreeDsUpdatedEvent()
        {
            // Arrange
            const string body = 
                "{\"id\":\"11ef0000-0000-4000-8000-000000000001\",\"event\":\"token_three_d_s_updated\",\"data\":{\"id\":\"6426bbd2-17bd-41bf-883b-1fe970db48ee\",\"store_id\":\"fc264608-9a9e-495e-844e-a08129a81af4\",\"email\":\"test@univapay.com\",\"payment_type\":\"card\",\"active\":true,\"mode\":\"live\",\"type\":\"recurring\",\"confirmed\":true,\"metadata\":{\"customer_id\":\"cust_12345\"},\"created_on\":\"2026-04-09T07:35:50.000000Z\",\"updated_on\":\"2026-04-09T07:35:50.000000Z\",\"exampleAdditionalProperty\":{\"key1\":\"val1\",\"key2\":\"val2\"}},\"created_on\":\"2026-04-09T07:35:50.000000Z\",\"exampleAdditionalProperty\":{\"key1\":\"val1\",\"key2\":\"val2\"}}";
            var payload = Encoding.UTF8.GetBytes(body);
            var httpRequestData = HttpRequestDataTestFactory.CreatePostRequestWithBody(payload);

            // Act
            var parsingResult = await TokenHandler.ParseEventAsync(httpRequestData);
            var result =  parsingResult.MatchSome(
                tokenThreeDsUpdated: tokenThreeDsUpdated => true
            );

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public async Task OnTokenCvvAuthUpdated_TokenHandler_ReturnsTokenCvvAuthUpdatedEvent()
        {
            // Arrange
            const string body = 
                "{\"id\":\"11ef0000-0000-4000-8000-000000000001\",\"event\":\"token_cvv_auth_updated\",\"data\":{\"id\":\"6426bbd2-17bd-41bf-883b-1fe970db48ee\",\"store_id\":\"fc264608-9a9e-495e-844e-a08129a81af4\",\"email\":\"test@univapay.com\",\"payment_type\":\"card\",\"active\":true,\"mode\":\"live\",\"type\":\"recurring\",\"confirmed\":true,\"metadata\":{\"customer_id\":\"cust_12345\"},\"created_on\":\"2026-04-09T07:35:50.000000Z\",\"updated_on\":\"2026-04-09T07:35:50.000000Z\",\"exampleAdditionalProperty\":{\"key1\":\"val1\",\"key2\":\"val2\"}},\"created_on\":\"2026-04-09T07:35:50.000000Z\",\"exampleAdditionalProperty\":{\"key1\":\"val1\",\"key2\":\"val2\"}}";
            var payload = Encoding.UTF8.GetBytes(body);
            var httpRequestData = HttpRequestDataTestFactory.CreatePostRequestWithBody(payload);

            // Act
            var parsingResult = await TokenHandler.ParseEventAsync(httpRequestData);
            var result =  parsingResult.MatchSome(
                tokenCvvAuthUpdated: tokenCvvAuthUpdated => true
            );

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public async Task OnTokenCvvAuthCheckUpdated_TokenHandler_ReturnsTokenCvvAuthCheckUpdatedEvent()
        {
            // Arrange
            const string body = 
                "{\"id\":\"11ef0000-0000-4000-8000-000000000001\",\"event\":\"token_cvv_auth_check_updated\",\"data\":{\"id\":\"6426bbd2-17bd-41bf-883b-1fe970db48ee\",\"store_id\":\"fc264608-9a9e-495e-844e-a08129a81af4\",\"email\":\"test@univapay.com\",\"payment_type\":\"card\",\"active\":true,\"mode\":\"live\",\"type\":\"recurring\",\"confirmed\":true,\"metadata\":{\"customer_id\":\"cust_12345\"},\"created_on\":\"2026-04-09T07:35:50.000000Z\",\"updated_on\":\"2026-04-09T07:35:50.000000Z\",\"exampleAdditionalProperty\":{\"key1\":\"val1\",\"key2\":\"val2\"}},\"created_on\":\"2026-04-09T07:35:50.000000Z\",\"exampleAdditionalProperty\":{\"key1\":\"val1\",\"key2\":\"val2\"}}";
            var payload = Encoding.UTF8.GetBytes(body);
            var httpRequestData = HttpRequestDataTestFactory.CreatePostRequestWithBody(payload);

            // Act
            var parsingResult = await TokenHandler.ParseEventAsync(httpRequestData);
            var result =  parsingResult.MatchSome(
                tokenCvvAuthCheckUpdated: tokenCvvAuthCheckUpdated => true
            );

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public async Task OnTokenReplaced_TokenHandler_ReturnsTokenReplacedEvent()
        {
            // Arrange
            const string body = 
                "{\"id\":\"11ef0000-0000-4000-8000-000000000001\",\"event\":\"token_replaced\",\"data\":{\"id\":\"6426bbd2-17bd-41bf-883b-1fe970db48ee\",\"store_id\":\"fc264608-9a9e-495e-844e-a08129a81af4\",\"email\":\"test@univapay.com\",\"payment_type\":\"card\",\"active\":true,\"mode\":\"live\",\"type\":\"recurring\",\"confirmed\":true,\"metadata\":{\"customer_id\":\"cust_12345\"},\"created_on\":\"2026-04-09T07:35:50.000000Z\",\"updated_on\":\"2026-04-09T07:35:50.000000Z\",\"exampleAdditionalProperty\":{\"key1\":\"val1\",\"key2\":\"val2\"}},\"created_on\":\"2026-04-09T07:35:50.000000Z\",\"exampleAdditionalProperty\":{\"key1\":\"val1\",\"key2\":\"val2\"}}";
            var payload = Encoding.UTF8.GetBytes(body);
            var httpRequestData = HttpRequestDataTestFactory.CreatePostRequestWithBody(payload);

            // Act
            var parsingResult = await TokenHandler.ParseEventAsync(httpRequestData);
            var result =  parsingResult.MatchSome(
                tokenReplaced: tokenReplaced => true
            );

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public async Task OnRecurringTokenDeleted_TokenHandler_ReturnsRecurringTokenDeletedEvent()
        {
            // Arrange
            const string body = 
                "{\"id\":\"11ef0000-0000-4000-8000-000000000001\",\"event\":\"recurring_token_deleted\",\"data\":{\"id\":\"6426bbd2-17bd-41bf-883b-1fe970db48ee\",\"store_id\":\"fc264608-9a9e-495e-844e-a08129a81af4\",\"email\":\"test@univapay.com\",\"payment_type\":\"card\",\"active\":true,\"mode\":\"live\",\"type\":\"recurring\",\"confirmed\":true,\"metadata\":{\"customer_id\":\"cust_12345\"},\"created_on\":\"2026-04-09T07:35:50.000000Z\",\"updated_on\":\"2026-04-09T07:35:50.000000Z\",\"exampleAdditionalProperty\":{\"key1\":\"val1\",\"key2\":\"val2\"}},\"created_on\":\"2026-04-09T07:35:50.000000Z\",\"exampleAdditionalProperty\":{\"key1\":\"val1\",\"key2\":\"val2\"}}";
            var payload = Encoding.UTF8.GetBytes(body);
            var httpRequestData = HttpRequestDataTestFactory.CreatePostRequestWithBody(payload);

            // Act
            var parsingResult = await TokenHandler.ParseEventAsync(httpRequestData);
            var result =  parsingResult.MatchSome(
                recurringTokenDeleted: recurringTokenDeleted => true
            );

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public async Task OnInvalidPayload_TokenHandler_ReturnsUnknown()
        {
            // Arrange
            var payload = Array.Empty<byte>();
            var httpRequestData = HttpRequestDataTestFactory.CreatePostRequestWithBody(payload);

            // Act
            var parsingResult = await TokenHandler.ParseEventAsync(httpRequestData);
            var result =  parsingResult.MatchSome(
                unknown: () => true
            );

            // Assert
            Assert.IsTrue(result);
        }
    }
}
// <copyright file="CustomsHandler.cs" company="APIMatic">
// UnivaPay
//
// This file was automatically generated for Univapay by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Threading;
using System.Threading.Tasks;
using UnivaPay.Http.Request;

namespace UnivaPay.Events.Webhooks
{
    /// <summary>
    /// CustomsHandler to handle event parsing.
    /// </summary>
    public static class CustomsHandler
    {
        /// <summary>
        /// Parses the incoming HTTP request data and deserializes it into an <see cref="CustomsParsingResult"/> object.
        /// Returns <see cref="CustomsParsingResult.Unknown"/> if the payload is empty or deserialization fails.
        /// </summary>
        /// <param name="request">The HTTP request data containing the event payload.</param>
        /// <param name="cancellationToken">Token to cancel the operation.</param>
        /// <returns>
        /// A task that represents the asynchronous operation. The task result contains the parsed <see cref="CustomsParsingResult"/> object,
        /// or <see cref="CustomsParsingResult.Unknown"/> if parsing fails.
        /// </returns>
        public static async Task<CustomsParsingResult> ParseEventAsync(HttpRequestData request, CancellationToken cancellationToken = default)
        {
            var payload = await request.ReadBodyAsStringAsync(cancellationToken).ConfigureAwait(false);
    
            if (string.IsNullOrEmpty(payload))
                return new CustomsParsingResult.Unknown();
    
            var settings = new JsonSerializerSettings
            {
                MissingMemberHandling = MissingMemberHandling.Ignore
            };
    
            var accountsEvent = JsonConvert.DeserializeObject<CustomsParsingResult>(payload, settings);
            return accountsEvent ?? new CustomsParsingResult.Unknown();
        }
    }
}
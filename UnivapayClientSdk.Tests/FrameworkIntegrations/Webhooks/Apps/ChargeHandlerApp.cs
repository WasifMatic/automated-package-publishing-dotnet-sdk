// <copyright file="ChargeHandlerApp.cs" company="APIMatic">
// UnivapayClientSdk.Tests
//
// This file was automatically generated for Univapay by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using UnivaPay.Events.Webhooks;
using UnivaPay.Http.Request;

namespace UnivaPay.FrameworkIntegrations.Webhooks.Apps
{
    [Route("webhooks")]
    [ApiController]
    public class ChargeApp : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> ReceiveEvent()
        {
            // Create the HttpRequestData from the incoming HttpRequest
            var eventRequest = HttpRequestData.FromAspNetCoreParams(
                Request.Method,
                Request.Scheme,
                Request.Host.ToString(),
                Request.Path.ToString(),
                Request.QueryString.ToString(),
                Request.Headers,
                Request.Body,
                Request.Query,
                Request.Cookies,
                Request.Protocol,
                Request.ContentType,
                Request.ContentLength
            );

            var chargeParsingResult = await ChargeHandler.ParseEventAsync(eventRequest);
            var result = chargeParsingResult.MatchSome(
                chargeUpdated: chargeUpdated => true
            );

            return Ok(result);
        }
    }
}    
// <copyright file="Extensions.cs" company="Univapay">
// Hand-authored SDK extensions kept OUTSIDE the generated files.
//
// APIMatic regenerates the Api classes on every build, so any customization
// injected into those files risks a merge conflict whenever the spec changes
// nearby. The generated Api classes are not declared `partial`, so these
// helpers are C# extension methods living in a file APIMatic never generates —
// regeneration can never conflict with them.
//
// The helpers mirror the equivalent methods in the other UnivaPay SDKs
// (pollCharge / poll_charge in TypeScript, Python, Java, PHP and Ruby):
// re-issue the resource GET with polling=true until the resource leaves its
// initial state, up to a bounded number of attempts.
//
// Note there is deliberately no delay between attempts. Each request carries
// polling=true, which makes the server hold it open for up to 3 seconds, so
// the loop is already self-throttling (roughly one request per 3s against an
// exact-URL burst of 10 that refills at 2/s). Adding a delay would diverge
// from the other SDKs; dropping polling=true would turn this into the
// high-frequency polling loop the API documentation warns against.
// </copyright>
using System;
using System.Threading;
using System.Threading.Tasks;
using UnivaPay.Http.Response;

namespace UnivaPay.Apis
{
    /// <summary>
    /// Polling helpers that re-issue a resource request with
    /// <c>polling=true</c> until the resource leaves its initial state.
    /// </summary>
    public static class PollingExtensions
    {
        /// <summary>
        /// Number of polling attempts used when the caller does not specify one.
        /// Matches the default in the other UnivaPay SDKs.
        /// </summary>
        public const int DefaultPollAttempts = 10;

        /// <summary>
        /// Polls a charge with <c>polling=true</c> until it leaves <c>pending</c>,
        /// or until <paramref name="maxAttempts"/> is exhausted.
        /// </summary>
        /// <remarks>
        /// A charge still <c>pending</c> when the attempts run out is returned
        /// as-is: that is a poll timeout, not a failure, and the caller should
        /// fall back to the webhook rather than treating the payment as failed.
        /// Errors from the underlying request propagate immediately; retrying
        /// transient gateway errors (502, 503, 504) is left to the caller.
        /// A <paramref name="maxAttempts"/> of zero or less skips the loop and
        /// fetches once.
        /// </remarks>
        public static async Task<ApiResponse<Models.Charge>> PollChargeAsync(
                this ChargesApi api,
                Guid storeId,
                Guid id,
                int maxAttempts = DefaultPollAttempts,
                CancellationToken cancellationToken = default)
        {
            if (api == null)
            {
                throw new ArgumentNullException(nameof(api));
            }

            // maxAttempts is honoured as given; zero or less means "fetch once".
            for (int attempt = 0; attempt < maxAttempts; attempt++)
            {
                var response = await api.GetChargeAsync(storeId, id, true, cancellationToken)
                    .ConfigureAwait(false);
                if (response.Data?.Status != null && IsTerminal(response.Data.Status.Value))
                {
                    return response;
                }
            }

            return await api.GetChargeAsync(storeId, id, true, cancellationToken)
                .ConfigureAwait(false);
        }

        /// <summary>
        /// Polls a refund with <c>polling=true</c> until it reaches a final
        /// state, or until <paramref name="maxAttempts"/> is exhausted.
        /// See <see cref="PollChargeAsync"/> for timeout and error semantics.
        /// </summary>
        public static async Task<ApiResponse<Models.Refund>> PollRefundAsync(
                this RefundsApi api,
                Guid storeId,
                Guid chargeId,
                Guid id,
                int maxAttempts = DefaultPollAttempts,
                CancellationToken cancellationToken = default)
        {
            if (api == null)
            {
                throw new ArgumentNullException(nameof(api));
            }

            // maxAttempts is honoured as given; zero or less means "fetch once".
            for (int attempt = 0; attempt < maxAttempts; attempt++)
            {
                var response = await api.GetRefundAsync(storeId, chargeId, id, true, cancellationToken)
                    .ConfigureAwait(false);
                if (response.Data?.Status != null && IsTerminal(response.Data.Status.Value))
                {
                    return response;
                }
            }

            return await api.GetRefundAsync(storeId, chargeId, id, true, cancellationToken)
                .ConfigureAwait(false);
        }

        /// <summary>
        /// Polls a cancel with <c>polling=true</c> until it reaches a final
        /// state, or until <paramref name="maxAttempts"/> is exhausted.
        /// See <see cref="PollChargeAsync"/> for timeout and error semantics.
        /// </summary>
        public static async Task<ApiResponse<Models.Cancel>> PollCancelAsync(
                this CancelsApi api,
                Guid storeId,
                Guid chargeId,
                Guid id,
                int maxAttempts = DefaultPollAttempts,
                CancellationToken cancellationToken = default)
        {
            if (api == null)
            {
                throw new ArgumentNullException(nameof(api));
            }

            // maxAttempts is honoured as given; zero or less means "fetch once".
            for (int attempt = 0; attempt < maxAttempts; attempt++)
            {
                var response = await api.GetCancelAsync(storeId, chargeId, id, true, cancellationToken)
                    .ConfigureAwait(false);
                if (response.Data?.Status != null && IsTerminal(response.Data.Status.Value))
                {
                    return response;
                }
            }

            return await api.GetCancelAsync(storeId, chargeId, id, true, cancellationToken)
                .ConfigureAwait(false);
        }

        /// <summary>
        /// Polls a subscription with <c>polling=true</c> until it leaves
        /// <c>unverified</c>, or until <paramref name="maxAttempts"/> is
        /// exhausted. See <see cref="PollChargeAsync"/> for timeout and error
        /// semantics.
        /// </summary>
        /// <remarks>
        /// Expressed as "any status other than unverified" rather than a list of
        /// final states, matching the other UnivaPay SDKs: a subscription's poll
        /// ends on the first transition, and new statuses must not silently
        /// change that.
        /// </remarks>
        public static async Task<ApiResponse<Models.Subscription>> PollSubscriptionAsync(
                this SubscriptionsApi api,
                Guid storeId,
                Guid id,
                int maxAttempts = DefaultPollAttempts,
                CancellationToken cancellationToken = default)
        {
            if (api == null)
            {
                throw new ArgumentNullException(nameof(api));
            }

            // maxAttempts is honoured as given; zero or less means "fetch once".
            for (int attempt = 0; attempt < maxAttempts; attempt++)
            {
                var response = await api.GetSubscriptionAsync(storeId, id, true, cancellationToken)
                    .ConfigureAwait(false);
                if (response.Data?.Status != null
                    && response.Data.Status.Value != Models.SubscriptionStatus.Unverified)
                {
                    return response;
                }
            }

            return await api.GetSubscriptionAsync(storeId, id, true, cancellationToken)
                .ConfigureAwait(false);
        }


        /// <summary>
        /// Reports whether a charge has left <c>pending</c>. Wider than the four
        /// final states on purpose: the internal poll ends as soon as any
        /// transition out of <c>pending</c> occurs.
        /// </summary>
        private static bool IsTerminal(Models.ChargeStatus status)
        {
            switch (status)
            {
                case Models.ChargeStatus.Successful:
                case Models.ChargeStatus.Failed:
                case Models.ChargeStatus.Error:
                case Models.ChargeStatus.Canceled:
                case Models.ChargeStatus.Authorized:
                case Models.ChargeStatus.Awaiting:
                    return true;
                default:
                    return false;
            }
        }

        /// <summary>Reports whether a refund has reached a final state.</summary>
        private static bool IsTerminal(Models.RefundStatus status)
        {
            switch (status)
            {
                case Models.RefundStatus.Successful:
                case Models.RefundStatus.Failed:
                case Models.RefundStatus.Error:
                    return true;
                default:
                    return false;
            }
        }

        /// <summary>Reports whether a cancel has reached a final state.</summary>
        private static bool IsTerminal(Models.CancelStatus status)
        {
            switch (status)
            {
                case Models.CancelStatus.Successful:
                case Models.CancelStatus.Failed:
                case Models.CancelStatus.Error:
                    return true;
                default:
                    return false;
            }
        }
    }
}

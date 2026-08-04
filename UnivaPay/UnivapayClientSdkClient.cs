// <copyright file="UnivapayClientSdkClient.cs" company="APIMatic">
// UnivaPay
//
// This file was automatically generated for Univapay by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core;
using APIMatic.Core.Authentication;
using APIMatic.Core.Utilities;
using APIMatic.Core.Utilities.Logger.Configuration;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using UnivaPay.Apis;
using UnivaPay.Authentication;
using UnivaPay.Http.Client;
using UnivaPay.Logging;

namespace UnivaPay
{
    /// <summary>
    /// The gateway for the SDK. This class acts as a factory for Api and holds the
    /// configuration of the SDK.
    /// </summary>
    public sealed class UnivapayClientSdkClient : IConfiguration
    {
        // A map of environments and their corresponding servers/baseurls
        private static readonly Dictionary<Environment, Dictionary<Enum, string>> EnvironmentsMap =
            new Dictionary<Environment, Dictionary<Enum, string>>
        {
            {
                Environment.Production, new Dictionary<Enum, string>
                {
                    { Server.Default, "{baseUrl}" },
                }
            },
        };

        private readonly GlobalConfiguration globalConfiguration;
        private SdkLoggingConfiguration sdkLoggingConfiguration;
        private const string userAgent = "DotNet-SDK/9.1.0 (OS: {os-info}, Engine: {engine}/{engine-version})";
        private readonly HttpCallback httpCallback;
        private readonly Lazy<ChargesApi> charges;
        private readonly Lazy<TransactionTokensApi> transactionTokens;
        private readonly Lazy<RefundsApi> refunds;
        private readonly Lazy<SubscriptionsApi> subscriptions;
        private readonly Lazy<CancelsApi> cancels;
        private readonly Lazy<MerchantsApi> merchants;
        private readonly Lazy<StoresApi> stores;
        private readonly Lazy<WebhooksApi> webhooks;

        private UnivapayClientSdkClient(
            Environment environment,
            string baseUrl,
            BearerAuthModel bearerAuthModel,
            HttpCallback httpCallback,
            IHttpClientConfiguration httpClientConfiguration,
            SdkLoggingConfiguration sdkLoggingConfiguration)
        {
            this.Environment = environment;
            this.BaseUrl = baseUrl;
            this.httpCallback = httpCallback;
            this.HttpClientConfiguration = httpClientConfiguration;
            this.sdkLoggingConfiguration = sdkLoggingConfiguration;
            BearerAuthModel = bearerAuthModel;
            var bearerAuthManager = new BearerAuthManager(bearerAuthModel);
            globalConfiguration = new GlobalConfiguration.Builder()
                .AuthManagers(new Dictionary<string, AuthManager> {
                    {"JWT_TOKEN", bearerAuthManager},
                })
                .ApiCallback(httpCallback)
                .HttpConfiguration(httpClientConfiguration)
                .ServerUrls(EnvironmentsMap[environment], Server.Default)
                .LoggingConfig(sdkLoggingConfiguration)
                .Parameters(globalParameter => globalParameter
                    .Template(templateParameter => templateParameter.Setup("baseUrl", this.BaseUrl))
                )
                .UserAgent(userAgent)
                .Build();
            BearerAuthCredentials = bearerAuthManager;

            this.charges = new Lazy<ChargesApi>(
                () => new ChargesApi(globalConfiguration));
            this.transactionTokens = new Lazy<TransactionTokensApi>(
                () => new TransactionTokensApi(globalConfiguration));
            this.refunds = new Lazy<RefundsApi>(
                () => new RefundsApi(globalConfiguration));
            this.subscriptions = new Lazy<SubscriptionsApi>(
                () => new SubscriptionsApi(globalConfiguration));
            this.cancels = new Lazy<CancelsApi>(
                () => new CancelsApi(globalConfiguration));
            this.merchants = new Lazy<MerchantsApi>(
                () => new MerchantsApi(globalConfiguration));
            this.stores = new Lazy<StoresApi>(
                () => new StoresApi(globalConfiguration));
            this.webhooks = new Lazy<WebhooksApi>(
                () => new WebhooksApi(globalConfiguration));
        }

        /// <summary>
        /// Gets ChargesApi.
        /// </summary>
        public ChargesApi ChargesApi => this.charges.Value;

        /// <summary>
        /// Gets TransactionTokensApi.
        /// </summary>
        public TransactionTokensApi TransactionTokensApi => this.transactionTokens.Value;

        /// <summary>
        /// Gets RefundsApi.
        /// </summary>
        public RefundsApi RefundsApi => this.refunds.Value;

        /// <summary>
        /// Gets SubscriptionsApi.
        /// </summary>
        public SubscriptionsApi SubscriptionsApi => this.subscriptions.Value;

        /// <summary>
        /// Gets CancelsApi.
        /// </summary>
        public CancelsApi CancelsApi => this.cancels.Value;

        /// <summary>
        /// Gets MerchantsApi.
        /// </summary>
        public MerchantsApi MerchantsApi => this.merchants.Value;

        /// <summary>
        /// Gets StoresApi.
        /// </summary>
        public StoresApi StoresApi => this.stores.Value;

        /// <summary>
        /// Gets WebhooksApi.
        /// </summary>
        public WebhooksApi WebhooksApi => this.webhooks.Value;

        /// <summary>
        /// Gets the configuration of the Http Client associated with this client.
        /// </summary>
        public IHttpClientConfiguration HttpClientConfiguration { get; }

        /// <summary>
        /// Gets Environment.
        /// Current API environment.
        /// </summary>
        public Environment Environment { get; }

        /// <summary>
        /// Gets BaseUrl.
        /// Base URL for the API.
        /// </summary>
        public string BaseUrl { get; }

        /// <summary>
        /// Gets http callback.
        /// </summary>
        public HttpCallback HttpCallback => this.httpCallback;

        /// <summary>
        /// Gets the credentials to use with BearerAuth.
        /// </summary>
        public IBearerAuthCredentials BearerAuthCredentials { get; private set; }

        /// <summary>
        /// Gets the credentials model to use with BearerAuth.
        /// </summary>
        public BearerAuthModel BearerAuthModel { get; private set; }

        /// <summary>
        /// Gets the secret key to use, together with the JWT token, for API requests.
        /// </summary>
        public string SecretKey => this.BearerAuthCredentials.SecretKey;

        /// <summary>
        /// Gets the JWT token to use, together with the secret key, for API requests.
        /// </summary>
        public string JwtToken => this.BearerAuthCredentials.JwtToken;

        /// <summary>
        /// Gets the URL for a particular alias in the current environment and appends
        /// it with template parameters.
        /// </summary>
        /// <param name="alias">Default value:DEFAULT.</param>
        /// <returns>Returns the baseurl.</returns>
        public string GetBaseUri(Server alias = Server.Default)
        {
            return globalConfiguration.ServerUrl(alias);
        }

        /// <summary>
        /// Creates an object of the UnivapayClientSdkClient using the values provided for the builder.
        /// </summary>
        /// <returns>Builder.</returns>
        public Builder ToBuilder()
        {
            Builder builder = new Builder()
                .Environment(this.Environment)
                .BaseUrl(this.BaseUrl)
                .HttpCallback(httpCallback)
                .LoggingConfig(sdkLoggingConfiguration)
                .HttpClientConfig(config => config.Build());

            if (BearerAuthModel != null)
            {
                builder.BearerAuthCredentials(BearerAuthModel.ToBuilder().Build());
            }

            return builder;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return
                $"Environment = {this.Environment}, " +
                $"BaseUrl = {this.BaseUrl}, " +
                $"HttpClientConfiguration = {this.HttpClientConfiguration}, ";
        }

        /// <summary>
        /// Creates the client using builder.
        /// </summary>
        /// <returns> UnivapayClientSdkClient.</returns>
        internal static UnivapayClientSdkClient CreateFromEnvironment()
        {
            var builder = new Builder();

            string environment = System.Environment.GetEnvironmentVariable("UNIVA_PAY_ENVIRONMENT");
            string baseUrl = System.Environment.GetEnvironmentVariable("BASE_URL");
            string secretKey = System.Environment.GetEnvironmentVariable("SECRET_KEY");
            string jwtToken = System.Environment.GetEnvironmentVariable("JWT_TOKEN");

            if (environment != null)
            {
                builder.Environment(CoreHelper.JsonDeserialize<Environment>($"\"{environment}\""));
            }

            if (baseUrl != null)
            {
                builder.BaseUrl(baseUrl);
            }

            if (secretKey != null && jwtToken != null)
            {
                builder.BearerAuthCredentials(new BearerAuthModel
                .Builder(secretKey, jwtToken)
                .Build());
            }

            return builder.Build();
        }

        /// <summary>
        /// Creates the client from configuration.
        /// </summary>
        /// <returns> UnivapayClientSdkClient.</returns>
        public static UnivapayClientSdkClient FromConfiguration(IConfigurationSection configuration) =>
            Builder.FromConfiguration(configuration).Build();

        /// <summary>
        /// Builder class.
        /// </summary>
        public class Builder
        {
            private Environment _environment = UnivaPay.Environment.Production;
            private string _baseUrl = "https://api.univapay.com";
            private BearerAuthModel _bearerAuthModel = new BearerAuthModel();
            private HttpClientConfiguration.Builder _httpClientConfig = new HttpClientConfiguration.Builder();
            private HttpCallback _httpCallback;
            private SdkLoggingConfiguration _sdkLoggingConfiguration;

            /// <summary>
            /// Sets credentials for BearerAuth.
            /// </summary>
            /// <param name="bearerAuthModel">BearerAuthModel.</param>
            /// <returns>Builder.</returns>
            public Builder BearerAuthCredentials(BearerAuthModel bearerAuthModel)
            {
                _bearerAuthModel = bearerAuthModel ??
                    throw new ArgumentNullException(nameof(bearerAuthModel));
                return this;
            }

            /// <summary>
            /// Sets Environment.
            /// </summary>
            /// <param name="environment"> Environment. </param>
            /// <returns> Builder. </returns>
            public Builder Environment(Environment environment)
            {
                _environment = environment;
                return this;
            }

            /// <summary>
            /// Sets BaseUrl.
            /// </summary>
            /// <param name="baseUrl"> BaseUrl. </param>
            /// <returns> Builder. </returns>
            public Builder BaseUrl(string baseUrl)
            {
                _baseUrl = baseUrl ?? throw new ArgumentNullException(nameof(baseUrl));
                return this;
            }

            /// <summary>
            /// Sets HttpClientConfig.
            /// </summary>
            /// <param name="action"> Action. </param>
            /// <returns>Builder.</returns>
            public Builder HttpClientConfig(Action<HttpClientConfiguration.Builder> action)
            {
                if (action is null)
                {
                    throw new ArgumentNullException(nameof(action));
                }

                action(_httpClientConfig);
                return this;
            }

            private Builder HttpClientConfig(HttpClientConfiguration.Builder httpClientConfigurationBuilder)
            {
                if (httpClientConfigurationBuilder != null)
                {
                    _httpClientConfig = httpClientConfigurationBuilder;
                }

                return this;
            }

            /// <summary>
            /// Sets the default logging configuration, using the Console logger.
            /// </summary>
            /// <returns>Builder.</returns>
            public Builder LoggingConfig()
            {
                _sdkLoggingConfiguration = SdkLoggingConfiguration.Console();
                return this;
            }

            /// <summary>
            /// Sets the logging configuration using the provided <paramref name="action"/>.
            /// </summary>
            /// <param name="action">The action to perform on the logging configuration builder.</param>
            /// <returns>Builder.</returns>
            /// <exception cref="ArgumentNullException">Thrown when <paramref name="action"/> is null.</exception>
            public Builder LoggingConfig(Action<LogBuilder> action)
            {
                if (action is null) throw new ArgumentNullException(nameof(action));
                var logBuilder =
                    LogBuilder.CreateFromConfig(_sdkLoggingConfiguration ?? SdkLoggingConfiguration.Console());
                action(logBuilder);
                _sdkLoggingConfiguration = logBuilder.Build();
                return this;
            }

            internal Builder LoggingConfig(SdkLoggingConfiguration configuration)
            {
                _sdkLoggingConfiguration = configuration;
                return this;
            }

            /// <summary>
            /// Sets the HttpCallback for the Builder.
            /// </summary>
            /// <param name="httpCallback"> http callback. </param>
            /// <returns>Builder.</returns>
            public Builder HttpCallback(HttpCallback httpCallback)
            {
                _httpCallback = httpCallback;
                return this;
            }

            /// <summary>
            /// Creates an object of the UnivapayClientSdkClient using the values provided for the builder.
            /// </summary>
            /// <returns>UnivapayClientSdkClient.</returns>
            public UnivapayClientSdkClient Build()
            {
                if (_bearerAuthModel.SecretKey == null || _bearerAuthModel.JwtToken == null)
                {
                    _bearerAuthModel = null;
                }
                return new UnivapayClientSdkClient(
                    _environment,
                    _baseUrl,
                    _bearerAuthModel,
                    _httpCallback,
                    _httpClientConfig.Build(),
                    _sdkLoggingConfiguration);
            }

            /// <summary>
            /// Creates the client builder from configuration.
            /// </summary>
            /// <returns> Builder.</returns>
            public static Builder FromConfiguration(IConfigurationSection config)
            {
                var builder = new Builder();
                var options = config.Get<UnivapayClientSdkClientOptions>();
                if (options == null) return builder;
                if (options.Environment != null)
                    builder.Environment(options.Environment.Value);
                if (options.BaseUrl != null)
                    builder.BaseUrl(options.BaseUrl);
                if (options.BearerAuthCredentials != null)
                    builder.BearerAuthCredentials(BearerAuthModel.FromOptions(options.BearerAuthCredentials));
                if (options.HttpClientConfig != null)
                    builder.HttpClientConfig(Http.Client.HttpClientConfiguration.FromOptions(options.HttpClientConfig));
                if (options.LoggingConfig != null)
                    builder.LoggingConfig(LogBuilder.FromOptions(options.LoggingConfig));
                return builder;
            }
        }

        public class UnivapayClientSdkClientOptions
        {
            public Environment? Environment { get; set; }
            public string BaseUrl { get; set; }
            public BearerAuthModelOptions BearerAuthCredentials { get; set; }
            public HttpClientConfigurationOptions HttpClientConfig { get; set; }
            public LoggingConfigOptions LoggingConfig { get; set; }
        }
    }
}
